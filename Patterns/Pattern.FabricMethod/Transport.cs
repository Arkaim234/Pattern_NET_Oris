using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.FabricMethod
{
    internal class Transport
    {
        //Объеденил транспорт чтобы не создовать каждый класс т.к. они слишком мелкие
    }

    public class Car : ITransport
    {
        public void Deliver() => Console.WriteLine("Доставка по дорогам на автомобиле.");
    }

    public class Bicycle : ITransport
    {
        public void Deliver() => Console.WriteLine("Доставка на велосипеде (экологично!).");
    }

    public class Airplane : ITransport
    {
        public void Deliver() => Console.WriteLine("Доставка по воздуху на самолёте.");
    }
}
