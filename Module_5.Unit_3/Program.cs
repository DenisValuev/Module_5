namespace Module_5.Unit_3
{
    internal class Program
    {
        static string EnterColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
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
        static void ShowColors(string username = "Jane", params string[] favcolors)
        {
            Console.WriteLine("{0}, Ваши любимые цвета:", username);
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
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
        static void ShowArray(int[] array, bool IsSort = false)
        {
            if (!IsSort)
                SortArray(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            //(string name, int age) anketa;
            //Console.WriteLine("Введите имя");
            //anketa.name = Console.ReadLine();
            //Console.WriteLine("Введите возраст");
            //anketa.age = int.Parse(Console.ReadLine());
            //string[] favcolor = new string[3];
            //for (int i = 0; i < favcolor.Length; i++)
            //{
            //    favcolor[i] = EnterColor(anketa.name, anketa.age);
            //}
            //ShowColors(anketa.name, favcolor[0], favcolor[2]);
            //ShowColors();
            //ShowColors(anketa.name, "red", "green");
            var _array = GetArrayFromConsole(10);
            //var sortedarray = SortArray(_array);
            ShowArray(_array);
            
        }
    }
}
