using Waiter.Interfaces;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RabbitMQ.Client.Events;

namespace Waiter.Implementation
{
    public class RabbitMQEventBus : IEventBus
    {
        String _hostname;
        int _portNumber;
        public string HostName { get => _hostname; set => _hostname = value; }

        public int PortNumber { get => _portNumber; set => _portNumber = value; }

        public void PublishEvent<T>(String queueName, T e)
        {
            if (String.IsNullOrEmpty(HostName))
                throw new Exception("Hostname needs provided");

            var factory = new ConnectionFactory() { HostName = _hostname, Port = _portNumber };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName,
                                     durable: true,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = JsonSerializer.Serialize(e);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: queueName,
                                     basicProperties: null,
                                     body: body);
            }
        }

        public T ConsumeEvent<T>(String queueName)
        {
            var factory = new ConnectionFactory() { HostName = "host.docker.internal" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName,
                                     durable: true,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);
                };
                var t = channel.BasicConsume(queue: queueName,
                                      autoAck: true,
                                      consumer: consumer);

                var o = JsonSerializer.Deserialize<T>(t);

                return o;
                //Console.WriteLine(" Press [enter] to exit.");
                //Console.ReadLine();
            }
        }
    }
}