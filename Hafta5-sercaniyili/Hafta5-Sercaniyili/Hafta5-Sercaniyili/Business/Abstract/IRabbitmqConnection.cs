using RabbitMQ.Client;

namespace Hafta5_Sercaniyili.Business.Abstract
{
    public interface IRabbitmqConnection
    {
        IConnection GetRabbitMqConnection();
    }
}
