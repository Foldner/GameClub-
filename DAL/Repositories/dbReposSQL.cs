using DAL.Interfaces;

namespace DAL.Repositories
{
    public class dbReposSQL : IdbOperations
    {
        private GCdb db;
        private CustomerRepository customerRepository;
        private DeviceRepository deviceRepository;
        private DeviceTypeRepository deviceTypeRepository;
        private OrderRepository orderRepository;
        private OrderTypeRepository orderTypeRepository;
        private ProductRepository productRepository;
        private StatusTypeRepository statusTypeRepository;
        private ReportRepository report;

        public dbReposSQL()
        {
            db = new GCdb();
        }

        public IRepository<Customer> Customers
        {
            get
            {
                if (customerRepository == null)
                    customerRepository = new CustomerRepository(db);
                return customerRepository;
            }
        }
        public IRepository<Device> Devices
        {
            get
            {
                if (deviceRepository == null)
                    deviceRepository = new DeviceRepository(db);
                return deviceRepository;
            }
        }
        public IRepository<DeviceType> DeviceTypes
        {
            get
            {
                if (deviceTypeRepository == null)
                    deviceTypeRepository = new DeviceTypeRepository(db);
                return deviceTypeRepository;
            }
        }
        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }
        public IRepository<OrderType> OrderTypes
        {
            get
            {
                if (orderTypeRepository == null)
                    orderTypeRepository = new OrderTypeRepository(db);
                return orderTypeRepository;
            }
        }
        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }
        public IRepository<StatusType> StatusTypes
        {
            get
            {
                if (statusTypeRepository == null)
                    statusTypeRepository = new StatusTypeRepository(db);
                return statusTypeRepository;
            }
        }

        public IReportsReprository Reports
        {
            get
            {
                if (report == null)
                    report = new ReportRepository(db);
                return report;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
