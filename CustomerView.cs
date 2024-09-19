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

namespace QueuingCashierApp
{
    public partial class CustomerView : Form
    {

        private System.Windows.Forms.Timer timer;
        public CustomerView()
        {
            InitializeComponent();
            InitializeTimer();
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
            if (CashierClass.CashierQueue.Count != 0)
            {
                current_Serving.Text = CashierClass.CashierQueue.Peek();
            }

            else
            {
                current_Serving.Text = "NaN";

            }
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {

            
        }
    }
}