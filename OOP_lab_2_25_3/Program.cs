using System;

namespace OOP_lab_2_25_3
{
    class Program
    {
        public static int IndexOfMinAbs(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (Math.Abs(array[index]) >= Math.Abs(array[i]))
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Multiplication(int[] array)
        {
            int firstIndex = 0;
            int secondIndex = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > 0)
                {
                    firstIndex = i;

                    break;
                }
            }

            for (int i = firstIndex + 1; i < array.Length; ++i)
            {
                if (array[i] > 0)
                {
                    secondIndex = i;

                    break;
                }
            }

            if (Math.Abs(firstIndex - secondIndex) > 1)
            {
                int d = 1;

                for (int i = firstIndex + 1; i < secondIndex; ++i)
                {
                    d *= array[i];
                }

                return d;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];

            var random = new Random();

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(-100, 100);
            }

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("Hомер мiнiмального за модулем елемента масиву: {0}", IndexOfMinAbs(array));
            Console.WriteLine("Добуток елементiв масиву, розташованих мiж першим й другим нульовими елементами: {0}", Multiplication(array));
        }
    }
}
