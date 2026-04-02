using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.FabricMethod
{
    public abstract class TransportFactory
    {
        public abstract ITransport CreateTransport();

        public ITransport OrderTransport()
        {
            var transport = CreateTransport();
            LogCreation(transport);
            return transport;
        }

        protected virtual void LogCreation(ITransport transport)
        {
            Console.WriteLine($"[LOG] Создан транспорт типа: {transport.GetType().Name}");
        }
    }

    public class CarFactory : TransportFactory
    {
        public override ITransport CreateTransport() => new Car();
    }

    public class BicycleFactory : TransportFactory
    {
        public override ITransport CreateTransport() => new Bicycle();
    }

    public class AirplaneFactory : TransportFactory
    {
        public override ITransport CreateTransport() => new Airplane();
    }
}
