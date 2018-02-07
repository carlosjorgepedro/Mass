using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Sample.Messages;

namespace MassTransit.Receiver
{
    public class RegisterCustomerConsumer : IConsumer<IRegisterCustomer>
    {
        public Task Consume(ConsumeContext<IRegisterCustomer> context)
        {
            var newCustomer = context.Message;
            Console.WriteLine("A new customer has signed up, it's time to register it. Details: ");
            Console.WriteLine(newCustomer.Address);
            Console.WriteLine(newCustomer.Name);
            Console.WriteLine(newCustomer.Id);
            Console.WriteLine(newCustomer.ResgisteredUtc);
            return Task.FromResult(context.Message);

        }
    }
}