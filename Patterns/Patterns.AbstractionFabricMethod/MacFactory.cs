using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractionFabricMethod
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}
