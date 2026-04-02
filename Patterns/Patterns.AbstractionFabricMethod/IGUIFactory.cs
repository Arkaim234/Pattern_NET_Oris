using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractionFabricMethod
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
