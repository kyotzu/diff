using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ListVsLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\kyotzu\\Desktop\\Text1.txt";
            List<string> lines = new List<string>(File.ReadAllLines(filePath));

            List<string> list = new List<string>();
            LinkedList<string> linkedList = new LinkedList<string>();

            Stopwatch listStopwatch = Stopwatch.StartNew();
            foreach (var line in lines)
            {
                list.Add(line);
            }
            listStopwatch.Stop();
            Console.WriteLine($"Время вставки в List<T>: {listStopwatch.ElapsedMilliseconds} ms");

            Stopwatch linkedListStopwatch = Stopwatch.StartNew();
            foreach (var line in lines)
            {
                linkedList.AddLast(line);
            }
            linkedListStopwatch.Stop();
            Console.WriteLine($"Время вставки в LinkedList<T>: {linkedListStopwatch.ElapsedMilliseconds} ms");
        }
    }
}
