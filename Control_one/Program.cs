// Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых 
// меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать
//  на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами
namespace Seminar9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStart = new string[] { "hello", "bob", "world", "vasya", "baz", "32", "year" };
            Console.WriteLine("Начальный массив строк: " + string.Join(",", arrayStart) + "");
            int size = SizeMin(arrayStart);
            string[] arrayEnd = new string[size];
            FillArrayEND(arrayStart, arrayEnd);
            Console.WriteLine("Итоговый массив строк в котором 3 и менее символов: " + string.Join(",", arrayEnd) + "");
        }
        static int SizeMin(string[] array)
        {
            int size = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                size++;
            }
            return size;
        }
        static void FillArrayEND(string[] arrayStart, string[] arrayEnd)
        {
            int n = 0;
            for (int i = 0; i < arrayStart.Length; i++)
            {
                if (arrayStart[i].Length <= 3)
                {
                arrayEnd[n] = arrayStart[i];
                n++;
                }
            }
        }
    }
}