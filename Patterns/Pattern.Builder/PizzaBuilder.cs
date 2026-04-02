using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Builder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public IPizzaBuilder SetDough(string dough)
        {
            _pizza.Dough = dough;
            return this;
        }

        public IPizzaBuilder SetSauce(string sauce)
        {
            _pizza.Sauce = sauce;
            return this;
        }

        public IPizzaBuilder SetCheese(string cheese)
        {
            _pizza.Cheese = cheese;
            return this;
        }

        public IPizzaBuilder SetPepperoni(string pepperoni)
        {
            _pizza.Meat = pepperoni;
            return this;
        }

        public IPizzaBuilder SetMushrooms(string mushrooms)
        {
            _pizza.Mushrooms = mushrooms;
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}
