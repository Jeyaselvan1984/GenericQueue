using System;
using System.Collections.Generic;

namespace GenericQueue
{
  

    class GenQueue<T>
        {
        public Queue<T> values;

        public GenQueue()
        {
            values = new Queue<T>();
           T  doc = default (T);
            Console.WriteLine("Default value of Document is {0}", (doc != null) ? doc.ToString() : "null");
        }

        public void addToQueue(T val)
    {
            values.Enqueue(val);
    }
        public T getFromQueue()
        {
            return values.Dequeue();
        }
    }
    class Program
    {
        public struct str
        {
            public string firstname;
            public string lastname;
        };
        static void SwapValue<T>(ref T x, ref T y) where T : struct
        {
            Console.WriteLine("Generic method used.");
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
           
        str st1 = new str { firstname = "Jey", lastname = "Sel" };
        str st2 = new str { firstname = "Jayden", lastname = "Had" };

        Program.SwapValue<str>(ref st1, ref st2);

            Console.WriteLine("st1 values are {0}, {1}", st1.firstname, st1.lastname);
            
            Console.WriteLine("Hello World!");
            GenQueue<int> genericQueue = new GenQueue<int>();

            genericQueue.addToQueue(1);

                
             
                Console.WriteLine(genericQueue.getFromQueue());
            


        }
    }
}
