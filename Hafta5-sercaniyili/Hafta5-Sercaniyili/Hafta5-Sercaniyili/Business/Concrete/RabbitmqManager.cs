﻿using Hafta5_Sercaniyili.Business.Abstract;
using Hafta5_Sercaniyili.Entities.Data;
using Hafta5_Sercanİyili.DTOs;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace Hafta5_Sercaniyili.Business.Concrete
{
    //Rabbitmq kuyruk ekleme metodu
    public class RabbitmqManager : IRabbitmqService
    {
        private readonly IRabbitmqConnection _connection;
        public RabbitmqManager(IRabbitmqConnection connection) => _connection = connection;

        public void Publish(AppUser user, string exchangeType, string exchangeName, string queueName, string routeKey)
        {

            using var connection=_connection.GetRabbitMqConnection();
            //var connectionFactory = new ConnectionFactory()
            //{
            //    HostName = "localhost",
            //    VirtualHost = "/",
            //    Port = 5672,
            //    UserName = "guest",
            //    Password = "guest"

            //};
            //using var connection=connectionFactory.CreateConnection();

            using var channel = connection.CreateModel();

            channel.ExchangeDeclare(exchangeName,exchangeType,false,false);

            channel.QueueDeclare(queueName, false,false,false);

            channel.QueueBind(queueName, exchangeName, routeKey);

            var message= Encoding.UTF8.GetBytes(JsonSerializer.Serialize(user));

            channel.BasicPublish(exchangeName, routeKey,null,message);
        }
    }
}
