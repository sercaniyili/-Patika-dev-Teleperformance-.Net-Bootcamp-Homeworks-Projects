using Hafta5_Sercaniyili.Entities.Data;
using Hafta5_Sercanİyili.DTOs;

namespace Hafta5_Sercaniyili.Business.Abstract
{
    public interface IRabbitmqService
    {
        void Publish(AppUser user, string exchangeType, string exchangeName, string queueName,  string routeKey);
    }
}
