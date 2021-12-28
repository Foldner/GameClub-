namespace DAL.Interfaces
{
    public interface IdbOperations
    {
        IRepository<Customer> Customers { get; }
        IRepository<Device> Devices { get; }
        IRepository<DeviceType> DeviceTypes { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderType> OrderTypes { get; }
        IRepository<Product> Products { get; }
        IRepository<StatusType> StatusTypes { get; }
        int Save();
    }
}