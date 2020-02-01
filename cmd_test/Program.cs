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
            //Dictionary 字典（键值关联数组）
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("DengYu", 29);
            ages.Add("QiuBao", 28);
            ages["DengYong"] = 5;
            ages["DengMeng"] = 3;
            foreach (KeyValuePair<string, int> element in ages)
            {
                Console.WriteLine($"Name:{element.Key}  Age:{element.Value}");
            }

            //Stack 后入先出栈 
            /*Stack<int> numbers = new Stack<int>();
            foreach (int number in new int[] { 9, 3, 7, 2 })
            {
                numbers.Push(number);
                Console.WriteLine($"{number} has been pushed on the stack");
            }
            while (numbers.Count > 0)
            {
                Console.WriteLine($"{numbers.Pop()} has been popped off the stack");
            }*/

            //Queue 先进先出队列
            /*Queue<int> numbers = new Queue<int>();
            foreach (int number in new int[] { 9, 3, 7, 2 })
            {
                numbers.Enqueue(number);
                Console.WriteLine($"{number} has joined the queue");
            }
            while (numbers.Count > 0)
            {
                Console.WriteLine($"{numbers.Dequeue()} has left the queue");                           
            }*/


            //LinkedList 双向有序列表，为任何一端的插入和删除提供优化（即可作队列又可以当栈）
            /*LinkedList<int> numbers = new LinkedList<int>();
            foreach (int number in new int[] {10,8,6,4,2 })
            {
                numbers.AddFirst(number);
            }
            foreach (int number in numbers) //正向遍历
            {
                Console.WriteLine(number);
            }
            for (LinkedListNode<int> node = numbers.Last; node != null; node = node.Previous)
            {
                Console.WriteLine(node.Value);
            }*/

            //List 使用方法和数组差不多，但提供了搜索和排序算法
            /*List<int> numbers = new List<int>();
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
            */
        }
    }
}
