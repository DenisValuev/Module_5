namespace Module_5.Unit_4
{
    internal class Program
    {
        static void ChangeAge(ref int age)
        {
            age = 35;
        }
        //Заполнение массива
        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        //Сортировка массива
        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = new int[array.Length];
            sortedasc = new int[array.Length];
            Array.Copy(array, sorteddesc, array.Length);
            Array.Copy(array, sortedasc, array.Length);
            sorteddesc = SortArrayDesc(sorteddesc);
            sortedasc = SortArrayAsc(sortedasc);
        }
        //Сортировка массива по возрастанию
        static int[] SortArrayAsc(int[] array) 
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
        //Сортировка массива по убыванию
        static int[] SortArrayDesc(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            //int _age = 32;
            //ChangeAge(ref _age);
            //Console.WriteLine("Возраст вне метода {0}", _age);
            int _num = 5;
            var _array = GetArrayFromConsole(ref _num);
            int[] sorteddesc = new int[_num];
            int[] sortedasc = new int[_num];
            SortArray(_array, out sorteddesc, out sortedasc);
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("По убыванию");
            foreach (var item in sorteddesc)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("По возрастанию");
            foreach (var item in sortedasc)
            {
                Console.Write(item + " ");
            }
        }
    }
}
