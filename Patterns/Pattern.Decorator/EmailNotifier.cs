using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Decorator
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email отправлен: {message}");
        }
    }
}
