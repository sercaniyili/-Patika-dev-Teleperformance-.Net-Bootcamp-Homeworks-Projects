using InterfaceSegregetion.DI.Controllers.Entitiy.Abstract;

namespace InterfaceSegregetion.DI.Controllers.Entitiy.Contrete
{
    public class Order
    {
        private readonly IOrderRepository _orderRepository;

        public Order(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
    
        public string OrderId { get; set; }
        public string CreateOrder(object orderObject)
        {
            return OrderId;
        }
        public bool AddOrder(object orderDetails)
        {
            return _orderRepository.AddOrder(orderDetails);
        }
        public bool ModifyOrder(object orderDetails)
        {
            return _orderRepository.ModifyOrder(orderDetails);
        }
        public object GetOrderDetails(string orderId)
        {
            return _orderRepository.GetOrderDetails(orderId);
        }

    }
}
