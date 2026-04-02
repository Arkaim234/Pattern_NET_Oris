using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Builder
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder SetDough(string dough);
        IPizzaBuilder SetSauce(string sauce);
        IPizzaBuilder SetCheese(string cheese);
        IPizzaBuilder SetPepperoni(string meat);
        IPizzaBuilder SetMushrooms(string mushrooms);
        Pizza Build();
    }
}
