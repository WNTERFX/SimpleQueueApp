using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace QueuingCashierApp
{
    public partial class CashierWindowQueueForm : Form
    {

        private System.Windows.Forms.Timer timer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            InitializeTimer();

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {

            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += tick_Timer;
            timer.Start();
        }



        private void tick_Timer(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);


        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            listCashierQueue.Items.RemoveAt(0);
            CashierClass.CashierQueue.Dequeue();
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   
    }
}
