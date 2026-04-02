using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractionFabricMethod
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
}
