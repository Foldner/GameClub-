using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using BLL.Models;

namespace BLL
{
    public class dbOperations : IdbCrud
    {
        IdbOperations db;

        public dbOperations(IdbOperations repos)
        {
            db = repos;
        }

        #region Customer
        public List<CustomerModel> GetAllCustomers()
        {
            return db.Customers.GetList().Select(i => new CustomerModel(i)).ToList();
        }

        public CustomerModel GetCustomer(int id)
        {
            CustomerModel cl = new CustomerModel(db.Customers.GetItem(id));
            return cl;
        }

        public void CreateCustomer(CustomerModel c)
        {
            db.Customers.Create(new Customer() { CustomerName = c.CustomerName,
                PhoneNumber = c.PhoneNumber,
                BirthDate = c.BirthDate,
                RegDate = c.RegDate,
                MoneySpent = c.MoneySpent,
                Login = c.Login });
            Save();
        }

        public void UpdateCustomer(CustomerModel c)
        {
            Customer cl = db.Customers.GetItem(c.Id);
            cl.CustomerName = c.CustomerName;
            cl.PhoneNumber = c.PhoneNumber;
            cl.BirthDate = c.BirthDate;
            cl.RegDate = c.RegDate;
            cl.MoneySpent = c.MoneySpent;
            cl.Login = c.Login;
            db.Customers.Update(cl);
            Save();
        }
        public void DeleteCustomer(int id)
        {
            Customer cl = db.Customers.GetItem(id);
            if (cl != null)
            {
                db.Customers.Delete(cl.Id);
                Save();
            }
        }
        #endregion

        #region Device
        public List<DeviceModel> GetAllDevices()
        {
            return db.Devices.GetList().Select(i => new DeviceModel(i)).ToList();
        }

        public DeviceModel GetDevice(int id)
        {
            DeviceModel cl = new DeviceModel(db.Devices.GetItem(id));
            return cl;
        }

        public void CreateDevice(DeviceModel c)
        {
            db.Devices.Create(new Device()
            {
                DeviceName = c.DeviceName,
                ReleaseTime = c.ReleaseTime,
                DeviceTypeId = c.DeviceTypeId,
                StatusTypeId = c.StatusTypeId,
            });
            Save();
        }

        public void UpdateDevice(DeviceModel c)
        {
            Device cl = db.Devices.GetItem(c.Id);
            cl.DeviceName = c.DeviceName;
            cl.ReleaseTime = c.ReleaseTime;
            cl.DeviceTypeId = c.DeviceTypeId;
            cl.StatusTypeId = c.StatusTypeId;
            db.Devices.Update(cl);
            Save();
        }
        public void DeleteDevice(int id)
        {
            Device cl = db.Devices.GetItem(id);
            if (cl != null)
            {
                db.Devices.Delete(cl.Id);
                Save();
            }
        }
        #endregion

        #region DeviceType
        public List<DeviceTypeModel> GetAllDeviceTypes()
        {
            return db.DeviceTypes.GetList().Select(i => new DeviceTypeModel(i)).ToList();
        }

        public DeviceTypeModel GetDeviceType(int id)
        {
            DeviceTypeModel cl = new DeviceTypeModel(db.DeviceTypes.GetItem(id));
            return cl;
        }

        public void CreateDeviceType(DeviceTypeModel c)
        {
            db.DeviceTypes.Create(new DeviceType()
            {
                TypeName = c.TypeName,
                PricePerHour = c.PricePerHour
            });
            Save();
        }

        public void UpdateDeviceType(DeviceTypeModel c)
        {
            DeviceType cl = db.DeviceTypes.GetItem(c.Id);
            cl.TypeName = c.TypeName;
            cl.PricePerHour = c.PricePerHour;
            db.DeviceTypes.Update(cl);
            Save();
        }
        public void DeleteDeviceType(int id)
        {
            DeviceType cl = db.DeviceTypes.GetItem(id);
            if (cl != null)
            {
                db.DeviceTypes.Delete(cl.Id);
                Save();
            }
        }
        #endregion

        #region Order
        public List<OrderModel> GetAllOrders()
        {
            return db.Orders.GetList().Select(i => new OrderModel(i)).ToList();
        }

        public OrderModel GetOrder(int id)
        {
            OrderModel cl = new OrderModel(db.Orders.GetItem(id));
            return cl;
        }

        public int CreateOrder(OrderModel c)
        {
            db.Orders.Create(new Order()
            {
                OrderDate = c.OrderDate,
                TotalCost = c.TotalCost,
                CustomerId = c.CustomerId,
                DeviceId = c.DeviceId,
                ProductId = c.ProductId,
                OrderTypeId = c.OrderTypeId
            });
            Save();
            int id = db.Orders.GetList().Where(i => i.TotalCost == c.TotalCost && i.CustomerId == c.CustomerId && i.DeviceId == c.DeviceId && i.OrderTypeId == c.OrderTypeId).First().Id;
            return id;          
        }

        public void UpdateOrder(OrderModel c)
        {
            Order cl = db.Orders.GetItem(c.Id);
            cl.OrderDate = c.OrderDate;
            cl.TotalCost = c.TotalCost;
            cl.CustomerId = c.CustomerId;
            cl.DeviceId = c.DeviceId;
            cl.ProductId = c.ProductId;
            cl.OrderTypeId = c.OrderTypeId;
            db.Orders.Update(cl);
            Save();
        }
        public void DeleteOrder(int id)
        {
            Order cl = db.Orders.GetItem(id);
            if (cl != null)
            {
                db.Orders.Delete(cl.Id);
                Save();
            }
        }
        #endregion

        #region OrderType
        public List<OrderTypeModel> GetAllOrderTypes()
        {
            return db.OrderTypes.GetList().Select(i => new OrderTypeModel(i)).ToList();
        }

        public OrderTypeModel GetOrderType(int id)
        {
            OrderTypeModel cl = new OrderTypeModel(db.OrderTypes.GetItem(id));
            return cl;
        }

        public void CreateOrderType(OrderTypeModel c)
        {
            db.OrderTypes.Create(new OrderType()
            {
                TypeName = c.TypeName
            });
            Save();
        }

        public void UpdateOrderType(OrderTypeModel c)
        {
            OrderType cl = db.OrderTypes.GetItem(c.Id);
            cl.TypeName = c.TypeName;
            db.OrderTypes.Update(cl);
            Save();
        }
        public void DeleteOrderType(int id)
        {
            OrderType cl = db.OrderTypes.GetItem(id);
            if (cl != null)
            {
                db.OrderTypes.Delete(cl.Id);
                Save();
            }
        }
        #endregion

        #region Product
        public List<ProductModel> GetAllProducts()
        {
            return db.Products.GetList().Select(i => new ProductModel(i)).ToList();
        }

        public ProductModel GetProduct(int id)
        {
            ProductModel cl = new ProductModel(db.Products.GetItem(id));
            return cl;
        }

        public void CreateProduct(ProductModel c)
        {
            db.Products.Create(new Product()
            {
                ProductName = c.ProductName,
                Cost = c.Cost
            });
            Save();
        }

        public void UpdateProduct(ProductModel c)
        {
            Product cl = db.Products.GetItem(c.Id);
            cl.ProductName = c.ProductName;
            cl.Cost = c.Cost;
            db.Products.Update(cl);
            Save();
        }
        public void DeleteProduct(int id)
        {
            Product cl = db.Products.GetItem(id);
            if (cl != null)
            {
                db.Products.Delete(cl.Id);
                Save();
            }
        }
        #endregion

        #region StatusType
        public List<StatusTypeModel> GetAllStatusTypes()
        {
            return db.StatusTypes.GetList().Select(i => new StatusTypeModel(i)).ToList();
        }

        public StatusTypeModel GetStatusType(int id)
        {
            StatusTypeModel cl = new StatusTypeModel(db.StatusTypes.GetItem(id));
            return cl;
        }

        public void CreateStatusType(StatusTypeModel c)
        {
            db.StatusTypes.Create(new StatusType()
            {
                StatusName = c.StatusName
            });
            Save();
        }

        public void UpdateStatusType(StatusTypeModel c)
        {
            StatusType cl = db.StatusTypes.GetItem(c.Id);
            cl.StatusName = c.StatusName;
            db.StatusTypes.Update(cl);
            Save();
        }
        public void DeleteStatusType(int id)
        {
            StatusType cl = db.StatusTypes.GetItem(id);
            if (cl != null)
            {
                db.StatusTypes.Delete(cl.Id);
                Save();
            }
        }
        #endregion

        public int Save()
        {
            int SaveCh = 0;
            try
            {
                SaveCh = db.Save();
            }
            catch (Exception e)
            {
                return 2;
            }
            if (SaveCh > 0) return 1;
            return 0;
        }
    }
}
