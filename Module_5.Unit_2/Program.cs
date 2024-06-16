namespace Module_5.Unit_2
{
    internal class Program
    {
        static string ShowColor()
        {
            Console.WriteLine("Наишите свой любимый цвет на английском с маленькой буквы");
            string color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;
                    }
                case "green":
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green!");
                        break;
                    }
                case "cyan":
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan!");
                        break;
                    }
                default:
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color is yellow!");
                        break;
                    }
            }
            return color;
        }
        static int[] SortArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            result = SortArray(result);
            return result;
        }
        static void Main(string[] args)
        {
            string[] favcolor = new string[3];
            for (int i = 0; i < favcolor.Length; i++)
            {
                favcolor[i] = ShowColor();
            }
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolor)
            {
                Console.WriteLine(color);
            }
            int[] array = GetArrayFromConsole();
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
