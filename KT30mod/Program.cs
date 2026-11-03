
using System;
using System.Collections.Generic;

namespace KT30mod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" List<int> ");

            List<int> numbers = new List<int> { 1, 2, 3 };

            Console.WriteLine("Исходный список: " +
                string.Join(", ", numbers));

            numbers.Swap(0, 2);

            Console.WriteLine("После Swap(0, 2): " +
                string.Join(", ", numbers));

            Console.WriteLine("IsEmpty(): " + numbers.IsEmpty());

            List<int> emptyNumbers = new List<int>();

            Console.WriteLine("Пустой список IsEmpty(): " +
                emptyNumbers.IsEmpty());
        }
}
    
    public static class ListExtensions
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static bool IsEmpty<T>(this List<T> list)
        {
            return list.Count == 0;
        }
    }}


