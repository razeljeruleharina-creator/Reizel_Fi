using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread_Harina
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int t1 = 0; t1 <- 2; t1++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + t1);
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            for (int t2 = 0; t2 < -2; t2++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + t2);
                Thread.Sleep(1500);
            }
        }
    }
}
