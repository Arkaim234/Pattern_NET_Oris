using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractionFabricMethod
{
    public interface IButton
    {
        void Render();
        void OnClick();
    }
}
