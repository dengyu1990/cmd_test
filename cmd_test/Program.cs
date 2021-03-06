﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace cmd_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //获得当前程序中所有正在运行的进程
            Process[] pros = Process.GetProcesses();
            foreach (var item in pros)
            {
                Console.WriteLine(item);
            }
            //通过进程打开一些程序()
            Process.Start("calc"); //计算器
            Process.Start("mspaint"); //Windows自带画图
            Process.Start("notepad"); //记事本
            Process.Start("iexplore", "http://www.icefish.cn"); //IE游览器
            //通过一个进程打开指定的文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Administrator\Desktop\qiubao.txt");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();


            //Directory类的使用（创建文件夹）
            /*Directory.CreateDirectory(@"A:\test");
            Console.WriteLine("创建文件夹test成功");
            //带上参数可以删除该文件夹下的子文件夹和文件，不带若内含文件则无法删除
            Directory.Delete(@"A:\test", true);
            Directory.Move(@"A:\test", @"A:\Temp"); //实际把test改名成Temp（注意：不能跨磁盘移动）
            //获得指定文件夹下所有文件的全路径（带参数可过滤特定文件类型）
            string[] paths = Directory.GetFiles(@"B:\Brainwash", "*.jpg");
            foreach (string path in paths)
            {
                Console.WriteLine(path);
            }
            //获得指定文件夹下所有文件夹的全路径（带参数可过滤特定文件类型）
            string[] paths = Directory.GetDirectories(@"B:");
            foreach (string path in paths)
            {
                Console.WriteLine(path);
            }
            //判断文件夹存在(不能判断文件)
            if (Directory.Exists(@"A:\Temp\a.txt"))
            {
                Console.WriteLine("该路径下的文件夹存在");
            }*/

            //MD5加解密
            /*MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes("Icefish Coporation");
            byte[] MD5buffer = md5.ComputeHash(buffer);
            //Console.WriteLine(Encoding.Default.GetString(MD5buffer));
            string strNew = "";
            for (int i = 0; i < MD5buffer.Length; i++)
            {
                strNew += MD5buffer[i].ToString("x2"); //转行成16进制
            }
            Console.WriteLine(strNew);*/

            //序列化与反序列化（仅示例代码）
            /*Person p = new Person();
            using(FileStream fsWrite = new FileStream(@"C:\Users\dy\1.txt"))
            {
                BinaryFormatter fsWrite = new BinaryFormatter();
                bf.Serialize(fsWrite,p);  //序列化
            }
            using(FileStream fsRead = new FileStream(@"C:\Users\dy\1.txt"))
            {
                BinaryFormatter fsRead = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);  //反序列化
            }*/

            //普通网络请求的示例
            /*WebRequest req = WebRequest.Create("http://www.azure.cn");
            WebResponse resp = req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.ASCII);
            Console.WriteLine(reader.ReadToEnd());*/

            //HashSet 哈希表
            /*HashSet<string> employees = new HashSet<string>(new string[] { "DengYu", "Qiubao" });
            HashSet<string> customers = new HashSet<string>(new string[] { "DengYong", "DengMeng" });

            employees.Add("DengMeng");
            customers.Add("QiuBao");

            customers.IntersectWith(employees); //即是客户又是员工的人
            foreach(string name in customers)
            {
                Console.WriteLine(name);
            }*/

            //Dictionary 字典（键值关联数组）
            /*Dictionary<string, int> ages = new Dictionary<string, int>();
            //SortedDictionary<string, int> ages = new SortedDictionary<string, int>(); 有序键字典
            ages.Add("DengYu", 29);
            ages.Add("QiuBao", 28);
            ages["DengYong"] = 5;
            ages["DengMeng"] = 3;
            foreach (KeyValuePair<string, int> element in ages)
            {
                Console.WriteLine($"Name:{element.Key}  Age:{element.Value}");
            }*/

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
