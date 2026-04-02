using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Observer
{
    public class EmailSubscriber : IObserver
    {
        private string _email;
        public EmailSubscriber(string email)
        {
            _email = email;
        }

        public void Update(string news)
        {
            Console.WriteLine($"Email на {_email}: Новая новость - {news}");
        }
    }
}
