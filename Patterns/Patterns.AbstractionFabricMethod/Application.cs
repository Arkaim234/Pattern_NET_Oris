using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractionFabricMethod
{
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void RenderUI()
        {
            _button.Render();
            _checkbox.Render();
        }

        public void HandleUserAction()
        {
            _button.OnClick();
            _checkbox.Toggle();
        }
    }
}
