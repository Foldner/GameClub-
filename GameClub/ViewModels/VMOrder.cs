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
    class VMOrder : VMBase
    {
        private readonly INavigation navigation;
        private readonly IdbCrud dbOperations;

        private OrderModel selectedOrder;
        public OrderModel SelectedOrder
        {
            get { return selectedOrder; }
            set
            {
                selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }
        public Page CurrentPage => navigation.CurrentPage;
        public Visibility CurrentVisibility => navigation.CurrentVisibility;

        private ObservableCollection<OrderModel> order;
        public ObservableCollection<OrderModel> Order
        {
            get { return order; }
            set
            {
                order = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<CustomerModel> customer;
        public ObservableCollection<CustomerModel> Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                OnPropertyChanged();
            }
        }

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

        private ObservableCollection<OrderTypeModel> orderType;
        public ObservableCollection<OrderTypeModel> OrderType
        {
            get { return orderType; }
            set
            {
                orderType = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ProductModel> product;
        public ObservableCollection<ProductModel> Product
        {
            get { return product; }
            set
            {
                product = value;
                OnPropertyChanged();
            }
        }

        private string search;
        public string Search
        {
            get { return search; }
            set
            {
                if (orderR)
                {
                    Order.Remove(selectedOrder);
                    CreateOrderChanged();
                }
                search = value;
                OnPropertyChanged("Search");
            }
        }

        void CreateOrderChanged()
        {
            if (orderR)
            {
                orderR = false;
                TextCreate = "Новый";
                KindCreate = "Add";
            }
            else
            {
                orderR = true;
                TextCreate = "Сохранить";
                KindCreate = "ContentSaveAll";
            }
        }


        bool orderR;

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

        private RelayCommand editOrder;
        public RelayCommand EditOrder
        {
            get
            {
                return editOrder ?? (editOrder = new RelayCommand(obj =>
                {
                    dbOperations.UpdateOrder(SelectedOrder);
                },
                    (obj) => (selectedOrder != null && (!orderR))));
            }
        }

        private RelayCommand createOrder;
        public RelayCommand CreateOrder
        {
            get
            {
                return createOrder ?? (createOrder = new RelayCommand(obj =>
                {
                    if (!orderR)
                    {
                        SelectedOrder = new OrderModel();
                        Order.Add(selectedOrder);
                    }
                    else
                    {
                        dbOperations.CreateOrder(selectedOrder);
                        Order = new ObservableCollection<OrderModel>(dbOperations.GetAllOrders());
                        SelectedOrder = null;
                    }
                    CreateOrderChanged();

                }));
            }
        }

        private RelayCommand deleteOrder;
        public RelayCommand DeleteOrder
        {
            get
            {
                return deleteOrder ?? (deleteOrder = new RelayCommand(obj =>
                {
                    MessageBoxResult result = System.Windows.MessageBox.Show("Удалить?", "Подтверждение удаления", System.Windows.MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        dbOperations.DeleteOrder(selectedOrder.Id);
                        Order = new ObservableCollection<OrderModel>(dbOperations.GetAllOrders());
                        SelectedOrder = null;
                    }
                },
                    (obj) => (selectedOrder != null && (!orderR) && selectedOrder.Id != 1 && selectedOrder.Id != 2 && selectedOrder.Id != 1002)));
            }
        }


        private RelayCommand refresh;
        public RelayCommand Refresh
        {
            get
            {
                return refresh ?? (refresh = new RelayCommand(obj =>
                {
                    Order = new ObservableCollection<OrderModel>(dbOperations.GetAllOrders());
                    SelectedOrder = null;
                }));
            }
        }


        private RelayCommand searchOrder;
        public RelayCommand SearchOrder
        {
            get
            {
                return searchOrder ?? (searchOrder = new RelayCommand(obj =>
                {
                    List<string> keyWords = new List<string>();
                    string req = search;
                    if (req != null)
                    {
                        keyWords.AddRange(req.Split(' '));
                        ObservableCollection<OrderModel> cl = new ObservableCollection<OrderModel>();
                        List<OrderModel> clientlist = dbOperations.GetAllOrders();
                        Order = new ObservableCollection<OrderModel>(clientlist);
                        foreach (OrderModel c in order)
                        {
                            string stat = Convert.ToString(c.Id);
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
                        Order = cl;
                    }

                }));
            }
        }

        public VMOrder()
        {
            navigation = IoC.Get<INavigation>();
            navigation.CurrentPageChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
            navigation.VisibilityChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
            dbOperations = BLL.ServiceModules.IoC.Get<IdbCrud>();

            List<OrderModel> orderlist = dbOperations.GetAllOrders();
            List<DeviceModel> devicelist = dbOperations.GetAllDevices();
            List<CustomerModel> customerlist = dbOperations.GetAllCustomers();
            List<ProductModel> productlist = dbOperations.GetAllProducts();
            List<OrderTypeModel> ordertypelist = dbOperations.GetAllOrderTypes();

            Order = new ObservableCollection<OrderModel>(orderlist);
            Device = new ObservableCollection<DeviceModel>(devicelist);
            Customer = new ObservableCollection<CustomerModel>(customerlist);
            Product = new ObservableCollection<ProductModel>(productlist);
            OrderType = new ObservableCollection<OrderTypeModel>(ordertypelist);

            TextCreate = "Новый";
            KindCreate = "Add";
            orderR = false;
        }
    }
}
