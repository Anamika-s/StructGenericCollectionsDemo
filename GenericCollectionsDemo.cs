using System;
using System.Collections.Generic;


namespace StrutureenumDemos
{
    class GenericCollectionsDemo
    {
        static void Main()

        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach (int temp in list)
                Console.WriteLine(temp);

            Stack<string> stack = new Stack<string>();
            stack.Push("C");
            stack.Push("C++");
            foreach (string temp in stack)
                Console.WriteLine(temp);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            foreach (int temp in queue)
                Console.WriteLine(temp);
            Dictionary<int, int> records = new Dictionary<int, int>();
            records[1] = 90;
            records[2] = 98;

        }
    }

}