using System;

namespace ExceptionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    array[i] = i;
                }
            }
            catch
            {
                Console.WriteLine("We have error");
            }
            finally
            {
                Console.WriteLine("Work with array done");
            }
            foreach (var el in array)
            {
                Console.WriteLine(el);
            }
        }
    }
}
