using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Decorator
{
    public class Decorator : INotifier
    {
        protected readonly INotifier _notifier;
        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }
        public void Send(string message)
        {
            _notifier.Send(message); 
        }
    }
}
