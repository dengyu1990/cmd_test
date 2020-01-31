using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmd_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            foreach (int number in new int[12] { 10, 9, 8, 7, 7, 6, 5, 10, 4, 3, 2, 1 })
            {
                numbers.Add(number);
            }
            numbers.Insert(numbers.Count - 1, 99); //插入该位置，该位置元素往后移位
            numbers.Remove(7);
            numbers.RemoveAt(6);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
