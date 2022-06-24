using Hafta5_Sercaniyili.Business.Abstract;
using RabbitMQ.Client;

namespace Hafta5_Sercaniyili.Business.Concrete
{
    public class RabbitmqConnection : IRabbitmqConnection
    {
        public IConnection GetRabbitMqConnection()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost",
                VirtualHost = "/",
                Port = 5672,
                UserName = "guest",
                Password = "guest"

            }.CreateConnection();

            return connectionFactory;
        }
        }
    }
