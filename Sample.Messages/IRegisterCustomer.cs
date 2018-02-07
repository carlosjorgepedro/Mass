using System;

namespace Sample.Messages
{
    public interface IRegisterCustomer
    {
        Guid Id { get; }
        DateTime ResgisteredUtc { get; }
        int Type { get; }
        string Name { get; }
        bool Preferred { get; }
        decimal DefaultDiscount { get; }
        string Address { get; }
    }
}
