using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Observer
{
    public class SmsSubscriber : IObserver
    {
        private string _phone;
        public SmsSubscriber(string phone)
        {
            _phone = phone;
        }

        public void Update(string news)
        {
            Console.WriteLine($"SMS на {_phone}: {news}");
        }
    }
}
