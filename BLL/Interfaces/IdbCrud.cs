using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IdbCrud
    {
        List<CustomerModel> GetAllCustomers();
        List<DeviceModel> GetAllDevices();
        List<DeviceTypeModel> GetAllDeviceTypes();
        List<OrderModel> GetAllOrders();
        List<OrderTypeModel> GetAllOrderTypes();
        List<ProductModel> GetAllProducts();
        List<StatusTypeModel> GetAllStatusTypes();
        CustomerModel GetCustomer(int id);
        DeviceModel GetDevice(int id);
        DeviceTypeModel GetDeviceType(int id);
        OrderModel GetOrder(int id);
        OrderTypeModel GetOrderType(int id);
        ProductModel GetProduct(int id);
        StatusTypeModel GetStatusType(int id);


        void CreateCustomer(CustomerModel o);
        void UpdateCustomer(CustomerModel o);
        void DeleteCustomer(int id);


        void CreateDevice(DeviceModel c);
        void UpdateDevice(DeviceModel c);
        void DeleteDevice(int id);


        void CreateDeviceType(DeviceTypeModel c);
        void UpdateDeviceType(DeviceTypeModel c);
        void DeleteDeviceType(int id);


        void CreateOrder(OrderModel t);
        void UpdateOrder(OrderModel t);
        void DeleteOrder(int id);


        void CreateOrderType(OrderTypeModel t);
        void UpdateOrderType(OrderTypeModel t);
        void DeleteOrderType(int id);


        void CreateProduct(ProductModel s);
        void UpdateProduct(ProductModel s);
        void DeleteProduct(int id);


        void CreateStatusType(StatusTypeModel s);
        void UpdateStatusType(StatusTypeModel s);
        void DeleteStatusType(int id);


        int Save();
    }
}