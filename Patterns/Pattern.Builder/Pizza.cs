namespace Pattern.Builder
{
    public class Pizza
    {
        public string Dough { get; set; } = "";
        public string Sauce { get; set; } = "";
        public string Cheese { get; set; } = "";
        public string Meat { get; set; } = "";
        public string Mushrooms { get; set; } = "";

        public void Show()
        {
            Console.WriteLine($"Тесто: {Dough}");
            Console.WriteLine($"Соус: {Sauce}");
            Console.WriteLine($"Сыр: {Cheese}");
            Console.WriteLine($"Мясная начинка: {Meat}");
            Console.WriteLine($"Грибы: {Mushrooms}");
        }
    }
}
