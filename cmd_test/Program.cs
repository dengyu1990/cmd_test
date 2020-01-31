﻿using System;
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
            //Queue 先进先出队列
            Queue<int> numbers = new Queue<int>();
            foreach (int number in new int[] { 9, 3, 7, 2 })
            {
                numbers.Enqueue(number);
                Console.WriteLine($"{number} has joined the queue");
            }
            while (numbers.Count > 0)
            {
                Console.WriteLine($"{numbers.Dequeue()} has left the queue");                           
            }


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
