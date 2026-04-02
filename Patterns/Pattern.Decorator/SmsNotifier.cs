using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Decorator
{
    internal class SmsNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS отправлено: {message}");
        }
    }
}
