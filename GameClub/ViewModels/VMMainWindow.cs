using GameClub.Navigation;
using System.Windows.Controls;
using System.Windows;
using GameClub.Views.Frames.Main;
//using GameClub.Views.Frames;

namespace GameClub.ViewModels
{
    class VMMainWindow : VMBase
    {
        private readonly INavigation navigation;

        public Page CurrentPage => navigation.CurrentPage;
        public Visibility CurrentVisibility => navigation.CurrentVisibility;


        OrdersMain ordersPage;
        DevicesMain devicesPage;
        //CustomersMain customersPage;
        //ProductsMain productsPage;


        private RelayCommand orderCommand;
        public RelayCommand OrderCommand
        {
            get
            {
                return orderCommand ?? (orderCommand = new RelayCommand(obj =>
                {
                    if (ordersPage == null)
                    {
                        ordersPage = new OrdersMain();
                    }
                    navigation.Navigate(ordersPage);
                    navigation.ChangeVisibility(Visibility.Hidden);
                }));
            }
        }

        private RelayCommand deviceCommand;
        public RelayCommand DeviceCommand
        {
            get
            {
                return deviceCommand ?? (deviceCommand = new RelayCommand(obj =>
                {

                    if (devicesPage == null)
                    {
                        devicesPage = new DevicesMain();
                    }
                    navigation.Navigate(devicesPage);
                    navigation.ChangeVisibility(Visibility.Hidden);
                }));
            }
        }


        //private RelayCommand customerCommand;
        //public RelayCommand CustomerCommand
        //{
        //    get
        //    {
        //        return customerCommand ?? (customerCommand = new RelayCommand(obj =>
        //        {
        //            if (customersPage == null)
        //            {
        //                customersPage = new CustomersMain();
        //            }
        //            navigation.Navigate(customersPage);
        //            navigation.ChangeVisibility(Visibility.Hidden);
        //        }));
        //    }
        //}

        //private RelayCommand productCommand;
        //public RelayCommand ProductCommand
        //{
        //    get
        //    {
        //        return productCommand ?? (productCommand = new RelayCommand(obj =>
        //        {
        //            if (productsPage == null)
        //            {
        //                productsPage = new ProductsMain();
        //            }
        //            navigation.Navigate(productsPage);
        //            navigation.ChangeVisibility(Visibility.Hidden);
        //        }));
        //    }
        //}


        public VMMainWindow()
        {
            navigation = IoC.Get<INavigation>();
            navigation.CurrentPageChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
            navigation.VisibilityChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
            navigation.Navigate(new OrdersMain());
            navigation.ChangeVisibility(Visibility.Hidden);
        }

    }
}
