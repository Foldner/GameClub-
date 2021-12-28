using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClub.Navigation;
using System.Windows.Controls;
using System.Windows;
using BLL.Models;
using BLL.Interfaces;
using BLL.ServiceModules;
using Ninject;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using GameClub.Views.Frames;
using GameClub.Views.Frames.Main;
using System.IO;

namespace GameClub.ViewModels
{
    class VMDevice : VMBase
    {
        private readonly INavigation navigation;
        private readonly IdbCrud dbOperations;

        private DeviceModel selectedDevice;
        public DeviceModel SelectedDevice
        {
            get { return selectedDevice; }
            set
            {
                selectedDevice = value;
                OnPropertyChanged("SelectedDevice");
            }
        }
        public Page CurrentPage => navigation.CurrentPage;
        public Visibility CurrentVisibility => navigation.CurrentVisibility;

        private ObservableCollection<DeviceModel> device;
        public ObservableCollection<DeviceModel> Device
        {
            get { return device; }
            set
            {
                device = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<StatusTypeModel> statusType;
        public ObservableCollection<StatusTypeModel> StatusType
        {
            get { return statusType; }
            set
            {
                statusType = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<DeviceTypeModel> deviceType;
        public ObservableCollection<DeviceTypeModel> DeviceType
        {
            get { return deviceType; }
            set
            {
                deviceType = value;
                OnPropertyChanged();
            }
        }


        private string search;
        public string Search
        {
            get { return search; }
            set
            {
                if (deviceR)
                {
                    Device.Remove(selectedDevice);
                    CreateDeviceChanged();
                }
                search = value;
                OnPropertyChanged("Search");
            }
        }

        void CreateDeviceChanged()
        {
            if (deviceR)
            {
                deviceR = false;
                TextCreate = "Новый";
                KindCreate = "Add";
            }
            else
            {
                deviceR = true;
                TextCreate = "Сохранить";
                KindCreate = "ContentSaveAll";
            }
        }


        bool deviceR;

        private string textCreate;
        public string TextCreate
        {
            get { return textCreate; }
            set
            {
                textCreate = value;
                OnPropertyChanged("TextCreate");
            }
        }

        private string kindCreate;
        public string KindCreate
        {
            get { return kindCreate; }
            set
            {
                kindCreate = value;
                OnPropertyChanged("KindCreate");
            }
        }

        private RelayCommand changeStatus;
        public RelayCommand ChangeStatus
        {
            get
            {
                return changeStatus ?? (changeStatus = new RelayCommand(obj =>
                {
                    if (selectedDevice.StatusTypeId != 1)
                        selectedDevice.StatusTypeId = 2;
                    else
                        selectedDevice.StatusTypeId = 1;

                    dbOperations.UpdateDevice(selectedDevice);
                },
                    (obj) => (selectedDevice != null)
                    ));
            }
        }

        private RelayCommand editDevice;
        public RelayCommand EditDevice
        {
            get
            {
                return editDevice ?? (editDevice = new RelayCommand(obj =>
                {
                    dbOperations.UpdateDevice(SelectedDevice);
                },
                    (obj) => (selectedDevice != null && (!deviceR))));
            }
        }

        private RelayCommand createDevice;
        public RelayCommand CreateDevice
        {
            get
            {
                return createDevice ?? (createDevice = new RelayCommand(obj =>
                {
                    if (!deviceR)
                    {
                        SelectedDevice = new DeviceModel();
                        Device.Add(selectedDevice);
                    }
                    else
                    {
                        dbOperations.CreateDevice(selectedDevice);
                        Device = new ObservableCollection<DeviceModel>(dbOperations.GetAllDevices());
                        SelectedDevice = null;
                    }
                    CreateDeviceChanged();

                }));
            }
        }

        private RelayCommand deleteDevice;
        public RelayCommand DeleteDevice
        {
            get
            {
                return deleteDevice ?? (deleteDevice = new RelayCommand(obj =>
                {
                    MessageBoxResult result = System.Windows.MessageBox.Show("Удалить?", "Подтверждение удаления", System.Windows.MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        dbOperations.DeleteDevice(selectedDevice.Id);
                        Device = new ObservableCollection<DeviceModel>(dbOperations.GetAllDevices());
                        SelectedDevice = null;
                    }
                },
                    (obj) => (selectedDevice != null && (!deviceR) && selectedDevice.Id != 1 && selectedDevice.Id != 2 && selectedDevice.Id != 1002)));
            }
        }


        private RelayCommand refresh;
        public RelayCommand Refresh
        {
            get
            {
                return refresh ?? (refresh = new RelayCommand(obj =>
                {
                    Device = new ObservableCollection<DeviceModel>(dbOperations.GetAllDevices());
                    SelectedDevice = null;
                }));
            }
        }


        private RelayCommand searchDevice;
        public RelayCommand SearchDevice
        {
            get
            {
                return searchDevice ?? (searchDevice = new RelayCommand(obj =>
                {
                    List<string> keyWords = new List<string>();
                    string req = search;
                    if (req != null)
                    {
                        keyWords.AddRange(req.Split(' '));
                        ObservableCollection<DeviceModel> cl = new ObservableCollection<DeviceModel>();
                        List<DeviceModel> clientlist = dbOperations.GetAllDevices();
                        Device = new ObservableCollection<DeviceModel>(clientlist);
                        foreach (DeviceModel c in device)
                        {
                            string stat = c.DeviceName;
                            bool st = true;
                            for (int i = 0; i < keyWords.Count; i++)
                                if (!stat.Contains(keyWords[i]))
                                {
                                    st = false;
                                    break;
                                }
                            if (st)
                                cl.Add(c);
                        }
                        Device = cl;
                    }

                }));
            }
        }

        public VMDevice()
        {
            navigation = IoC.Get<INavigation>();
            navigation.CurrentPageChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
            navigation.VisibilityChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
            dbOperations = BLL.ServiceModules.IoC.Get<IdbCrud>();

            List<DeviceModel> devicelist = dbOperations.GetAllDevices();
            device = new ObservableCollection<DeviceModel>(devicelist);

            List<StatusTypeModel> statustypelist = dbOperations.GetAllStatusTypes();
            statusType = new ObservableCollection<StatusTypeModel>(statustypelist);

            List<DeviceTypeModel> devicetypelist = dbOperations.GetAllDeviceTypes();
            deviceType = new ObservableCollection<DeviceTypeModel>(devicetypelist);

            TextCreate = "Новый";
            KindCreate = "Add";
            deviceR = false;
        }
    }
}
