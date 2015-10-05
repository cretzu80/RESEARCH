using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threading_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdm = new Random();
        }

        Thread th;
        Thread th1;
        Random rdm;

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(threadr);
            th.Start();
        }

        public void threadr()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("completed red");
        }

        public void threadb()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("completed blue");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(threadb);
            th.Start();

        }
    }
}
