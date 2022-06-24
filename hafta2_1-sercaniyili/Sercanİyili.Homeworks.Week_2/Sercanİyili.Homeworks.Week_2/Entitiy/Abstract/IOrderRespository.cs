namespace InterfaceSegregetion.DI.Controllers.Entitiy.Abstract
{
    public interface IOrderRepository
    {
        bool AddOrder(object orderDetails);
        bool ModifyOrder(object orderDetails);
        object GetOrderDetails(string orderId);
    }
}
