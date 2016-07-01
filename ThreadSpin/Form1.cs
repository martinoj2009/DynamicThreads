using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSpin
{
    public partial class Form1 : Form
    {
        public List<BackgroundWorker> workers = new List<BackgroundWorker>();
        public bool STOP = false;
        int workerNumber = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            STOP = false;

            list_Text.Items.Insert(list_Text.Items.Count, "Starting worker: " + workerNumber + "...");
            workers.Add(new BackgroundWorker());
            workers.Last().DoWork += doWork;
            workers.Last().RunWorkerAsync(workerNumber);

            workerNumber++;

            label_ThreadCount.Text = workers.Count.ToString();
        }

        public void doWork(object sender, DoWorkEventArgs e)
        {
            int myWorkerNumber = (int)e.Argument;
            int times = 0;
            while (STOP == false)
            {
                list_Text.Invoke(new Action(() =>
                {
                    list_Text.Items[myWorkerNumber-1] = "Worker: " + myWorkerNumber + " ran " + times + "s.";
                }));
                
                Thread.Sleep(1000);

                times++;
                
            }

            list_Text.Invoke(new Action(() =>
            {
            list_Text.Items[myWorkerNumber - 1] = "Worker: " + myWorkerNumber + " Stop";
            }));
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            STOP = true;
        }
    }
}
