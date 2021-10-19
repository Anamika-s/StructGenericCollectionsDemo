using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StrutureenumDemos
{
    class CollectionsDemo
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.Add("Ajay");
            list.Add(90.8);
            foreach(var temp in list)
                Console.WriteLine(temp);
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push("Ajay");
            foreach (object temp in stack)
                Console.WriteLine(temp);

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue("Ajay");
            foreach (object temp in queue)
                Console.WriteLine(temp);

            Hashtable hs = new Hashtable();
            hs[2] = 90;
            hs["Ajay"] = "Delhi";



        }
    }
}
