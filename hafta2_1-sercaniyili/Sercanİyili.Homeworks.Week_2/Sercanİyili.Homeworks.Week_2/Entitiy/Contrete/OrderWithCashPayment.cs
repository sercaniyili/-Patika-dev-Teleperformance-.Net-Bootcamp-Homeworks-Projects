using InterfaceSegregetion.DI.Controllers.Entitiy.Abstract;

namespace InterfaceSegregetion.DI.Controllers.Entitiy.Contrete
{
    public class OrderWithCashPayment :  IPaymentOffline
    {
        public bool MakePaymentByCash(double amount)
        {
            return true;
        }
    }
}
