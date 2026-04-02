using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractionFabricMethod
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Отрисовка чекбокса в стиле Windows");
        public void Toggle() => Console.WriteLine("Переключение Windows-чекбокса");
    }
}
