using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Builder
{
    public class PizzaDirector
    {
        public Pizza MakeMargherita(IPizzaBuilder builder)
        {
            return builder
                .SetDough("Тонкое")
                .SetSauce("Томатный")
                .SetCheese("Моцарелла")
                .Build();
        }

        public Pizza MakePepperoni(IPizzaBuilder builder)
        {
            return builder
                .SetDough("Пышное")
                .SetSauce("Томатный")
                .SetCheese("Моцарелла")
                .SetPepperoni("Пепперони")
                .Build();
        }
    }
}
