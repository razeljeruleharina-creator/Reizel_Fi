using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTrackThread_Harina
{
    public partial class frmTrackThread : Form {
        public frmTrackThread() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void label1_Click(object sender, EventArgs e) { 
        }



        private void button1_Click(object sender, EventArgs e) {
            ThreadStart delObjThread1 = new ThreadStart(Thread1);
            Thread threadA = new Thread(delObjThread1);
            threadA.Name = "Thread A";

            ThreadStart delObjThread2 = new ThreadStart(Thread2);
            Thread threadB = new Thread(delObjThread2);
            threadB.Name = "Thread B";

            ThreadStart delObjThread3 = new ThreadStart(Thread1);
            Thread threadC = new Thread(delObjThread3);
            threadC.Name = "Thread C";

            ThreadStart delObjThread4 = new ThreadStart(Thread2);
            Thread threadD = new Thread(delObjThread4);
            threadD.Name = "Thread D";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            label1.Text= "- Thread Starts -";
            Console.WriteLine("- Thread Starts -");
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");
            Console.ReadLine();
            label1.Text = "-End of Thread-";
        }
        public static void Thread1() {
            for (int i = 0; i < 3; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                    Thread.Sleep(500);
            }
        }
        public static void Thread2() 
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(1500);
            }           
        }         
    }
}

