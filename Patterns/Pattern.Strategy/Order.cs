using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Strategy
{
    internal class Order
    {
        private decimal _amount;
        private IPaymentStrategy _paymentstrategy;

        public Order(decimal amount) 
        {
            _amount = amount;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentstrategy)
        {
            _paymentstrategy = paymentstrategy;
        }

        public void IsSetPaymentStrategy(IPaymentStrategy _paymentstrategy)
        {
            if (_paymentstrategy == null)
                Console.WriteLine("Способ оплаты не выбран");
            _paymentstrategy.Pay(_amount);
        }
    }
}
