using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплачено {amount} руб. через PayPal (user@example.com)");
        }
    }
}
