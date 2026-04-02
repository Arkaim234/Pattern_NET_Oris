using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Adapter
{
    public class SocketToUsbAdapter : IUsbCharger
    {
        private readonly EuropeanSocket _socket;

        public SocketToUsbAdapter(EuropeanSocket socket)
        {
            _socket = socket;
        }

        public void ChargeWithUsb()
        {
            _socket.Provide220Volts();
            Console.WriteLine("Адаптер преобразует в 5V и подключается к USB.");
            Console.WriteLine("Телефон заряжается через USB.");
        }
    }
}
