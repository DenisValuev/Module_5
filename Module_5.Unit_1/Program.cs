namespace Module_5.Unit_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            Console.WriteLine("Введите пять любимых блюда");
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Блюдо {0}", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }

        }
    }
}
