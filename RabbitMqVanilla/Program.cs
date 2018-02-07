using System;
using RabbitMQ.Client;

namespace RabbitMqVanilla
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            }.CreateConnection();

            var model = connection.CreateModel();

        }
    }
}