using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodcon
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();

            Boundedbuffer buf = new Boundedbuffer(4);

            Producer prod = new Producer(buf, 100);
            Consumer con = new Consumer();

            Parallel.Invoke(prod.run, con.Run);
            s1.Stop();
            Console.WriteLine("tid" + s1.Elapsed);
            Console.ReadKey();


            


        }
    }
}
