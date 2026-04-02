using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Decorator
{
    public class LoggingNotifier : INotifier
    {
        private readonly INotifier _wrapped;
        public LoggingNotifier(INotifier wrapped)
        {
            _wrapped = wrapped;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Лог: отправка '{message}'");
            _wrapped.Send(message);
        }
    }
}
