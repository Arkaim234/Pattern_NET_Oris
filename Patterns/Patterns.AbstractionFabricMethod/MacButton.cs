using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractionFabricMethod
{
    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Отрисовка кнопки в стиле Mac");
        public void OnClick() => Console.WriteLine("Клик по Mac-кнопке");
    }
}
