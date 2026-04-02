using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплачено {amount} руб. картой ****5678");
        }

    }
}
