using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp2NewReso
{
    class Program
    {
        private static bool onetimeDone = false;
        private static readonly object lockobj = new object();

        static void Main(string[] args)
        {

            Thread secothd = new Thread(ThreadFunc);
            secothd.Start();
            ThreadFunc();
            Console.ReadLine();
        }



        public static void ThreadFunc()
        {
            lock (lockobj)
            {
                if (!onetimeDone)
                {
                    Console.WriteLine("Hello Mars");
                    onetimeDone = true;
                }
            }
        }
    }
}
