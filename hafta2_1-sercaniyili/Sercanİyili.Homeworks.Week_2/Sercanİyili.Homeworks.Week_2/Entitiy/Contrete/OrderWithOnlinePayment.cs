using InterfaceSegregetion.DI.Controllers.Entitiy.Abstract;

namespace InterfaceSegregetion.DI.Controllers.Entitiy.Contrete
{
    public class OrderWithOnlinePayment : IPaymentOnline
    {
        public bool MakePaymentByBank(double amount)
        {
            return true;
        }
    }
}
