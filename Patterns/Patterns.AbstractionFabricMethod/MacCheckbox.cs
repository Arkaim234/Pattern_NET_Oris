using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractionFabricMethod
{
    public class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Отрисовка чекбокса в стиле Mac");
        public void Toggle() => Console.WriteLine("Переключение Mac-чекбокса");
    }
}
