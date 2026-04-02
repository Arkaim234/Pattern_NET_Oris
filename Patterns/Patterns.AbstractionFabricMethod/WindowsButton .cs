namespace Patterns.AbstractionFabricMethod
{
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Отрисовка кнопки в стиле Windows");
        public void OnClick() => Console.WriteLine("Клик по Windows-кнопке");
    }
}
