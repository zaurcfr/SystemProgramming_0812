using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SystemProgramming_0812
{
    class Program
    {
        public volatile int a;
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.AsParallel().AsOrdered().ToList();
            
            Timer t = new Timer((c) =>
            {
                //var l = c as List<int>;
                Console.WriteLine("Hello");
            }, null, 1000, 500);
            Console.ReadLine();
            //t.Dispose();
            //Console.ReadLine();
        }
    }
}
