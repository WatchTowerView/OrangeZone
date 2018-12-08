using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threadology1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread  smthred = new Thread(AuxWork);
            smthred.Name = "Secondard Route Work";
            smthred.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main thread {0}", i+3);
            }
        }

        private static void AuxWork()
        {
            for (int j = 0; j < 400; j++)
            {
                Console.WriteLine("Aux Thread Work {0}", j + 2 * 5);
                Thread.Sleep(200);
            }
        }
    }
}
