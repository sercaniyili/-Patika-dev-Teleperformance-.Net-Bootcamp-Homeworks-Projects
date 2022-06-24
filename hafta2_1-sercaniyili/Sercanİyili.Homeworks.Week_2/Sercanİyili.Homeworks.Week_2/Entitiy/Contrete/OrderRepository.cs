using InterfaceSegregetion.DI.Controllers.Entitiy.Abstract;

namespace InterfaceSegregetion.DI.Controllers.Entitiy.Contrete
{
    public class OrderRepository : IOrderRepository
    {
        public bool AddOrder(object orderDetails)
        {
            return true;
        }

        public object GetOrderDetails(string orderId)
        {
            var orderDetails = new object();
            return orderDetails;
           
        }

        public bool ModifyOrder(object orderDetails)
        {
            return true;
        }
    }
}
