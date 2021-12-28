using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using BLL.Models;
using BLL.Interfaces;
using BLL.ServiceModules;
using Ninject;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using GameClub.Views.Frames.Order;
using GameClub.Views.Frames.Main;

namespace GameClub.ViewModels
{
    public class VMOrderEdit : VMBase
    {
        private readonly IdbCrud dbOperations;

        public bool status;

        public string textst;

        public string Textst
        {
            get { return textst; }
            set
            {
                textst = value;
                OnPropertyChanged("textst");
            }
        }

        private OrderModel selectedOrder;
        public OrderModel SelectedOrder
        {
            get { return selectedOrder; }
            set
            {
                selectedOrder = value;

                List<OrderModel> orderlist = dbOperations.GetAllOrders();
                List<DeviceModel> devicelist = dbOperations.GetAllDevices();
                List<CustomerModel> customerlist = dbOperations.GetAllCustomers();
                List<ProductModel> productlist = dbOperations.GetAllProducts();
                List<OrderTypeModel> ordertypelist = dbOperations.GetAllOrderTypes();
                List<DeviceTypeModel> devicetypelist = dbOperations.GetAllDeviceTypes();

                Order = new ObservableCollection<OrderModel>(orderlist);
                Device = new ObservableCollection<DeviceModel>(devicelist);
                Customer = new ObservableCollection<CustomerModel>(customerlist);
                Product = new ObservableCollection<ProductModel>(productlist);
                OrderType = new ObservableCollection<OrderTypeModel>(ordertypelist);
                DeviceType = new ObservableCollection<DeviceTypeModel>(devicetypelist);

                OnPropertyChanged("SelectedOrder");
                Textst = " ";
            }
        }


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

        double SumCount()
        {
            //CustomerModel cl = dbOperations.GetCustomer(selectedOrder.CustomerId);
            //ProductModel pr = dbOperations.GetProduct((int)selectedOrder.ProductId);
            if (selectedOrder.ProductId != null)
            {
                ProductModel pr = dbOperations.GetProduct((int)selectedOrder.ProductId);

                return (pr.Cost);             
            }
            else
            {
                DeviceTypeModel cl = dbOperations.GetDeviceType((int)selectedOrder.DeviceId);
                return (300);
            }
            
        }

        private RelayCommand createUpdateCommand;
        public RelayCommand CreateUpdateCommand
        {
            get
            {
                return createUpdateCommand ?? (createUpdateCommand = new RelayCommand(obj =>
                {
                    if (status)
                    {
                        selectedOrder.OrderDate = DateTime.Now;
                        selectedOrder.TotalCost = SumCount();
                        

                        selectedOrder.UpdateDates();
                        selectedOrder.Id = dbOperations.CreateOrder(selectedOrder);
                        status = false;
                        Textst = "Заказ создан";
                    }
                    else
                    {
                        selectedOrder.TotalCost = SumCount();
                        selectedOrder.UpdateDates();
                        dbOperations.UpdateOrder(selectedOrder);
                        Textst = "Заказ обновлён";
                    }
                },
                    (obj) => ((selectedOrder != null) && (selectedOrder.TotalCost != null) && (selectedOrder.DeviceId != null)  )));
            }
        }



        public VMOrderEdit()
        {
            status = true;
            dbOperations = BLL.ServiceModules.IoC.Get<IdbCrud>();


            List<OrderModel> orderlist = dbOperations.GetAllOrders();
            List<DeviceModel> devicelist = dbOperations.GetAllDevices();
            List<CustomerModel> customerlist = dbOperations.GetAllCustomers();
            List<ProductModel> productlist = dbOperations.GetAllProducts();
            List<OrderTypeModel> ordertypelist = dbOperations.GetAllOrderTypes();
            List<DeviceTypeModel> devicetypelist = dbOperations.GetAllDeviceTypes();

            Order = new ObservableCollection<OrderModel>(orderlist);
            Device = new ObservableCollection<DeviceModel>(devicelist);
            Customer = new ObservableCollection<CustomerModel>(customerlist);
            Product = new ObservableCollection<ProductModel>(productlist);
            OrderType = new ObservableCollection<OrderTypeModel>(ordertypelist);
            DeviceType = new ObservableCollection<DeviceTypeModel>(devicetypelist);


        }

    }
}
