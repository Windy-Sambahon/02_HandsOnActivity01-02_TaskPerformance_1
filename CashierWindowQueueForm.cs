using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Queuing_System
{
    public partial class CashierWindowQueue : Form
    {

        CustomerView csv;
        public CashierWindowQueue()
        {
            csv = new CustomerView();
            InitializeComponent();
            timer1.Start();
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

        private void CashierWindowQueue_Load(object sender, EventArgs e)
        {
            csv.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

            if (CashierClass.CashierQueue.Count == 0)
            {
                MessageBox.Show("The Queue List is 0");
            }

            try
            {

                csv.lblOutofService.Text = CashierClass.CashierQueue.Peek();
            }
           
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(" The Queue List is 0");
                Console.WriteLine(ex);
                timer1.Stop();
            
            }
            finally
            {
                CashierClass.CashierQueue.Dequeue();
                timer1.Start();
            }
        }
    }
}

    
 
 
