using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsRevenueModify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int Ext = 750;
            int Int = 500;
            int total = 0;
            int IntAmount = 0;
            int ExtAmount = 0;
            int Month = 0;

            Month = Convert.ToInt32(txtMonth.Text);
            IntAmount = Convert.ToInt32(txtInt.Text);
            ExtAmount = Convert.ToInt32(txtExt.Text);

            if (Month == 12 || Month == 1 || Month == 2)
                ExtAmount = 0;

            if (Month == 4 || Month == 5 || Month == 9 || Month == 10)
                Ext = 699;

            if (Month == 7 || Month == 8)
                Int = 450;
            total = (IntAmount * Int) + (ExtAmount * Ext);

            lblTotal.Text = "The total revenue from all the murals painted this month is $" + total + ".00.";

            if (IntAmount > ExtAmount)
                lblMore.Text = "There were more interior murals painted than exterior murals";
            else if (ExtAmount > IntAmount)
                lblMore.Text = "There were more exterior murals painted than exterior murals";
            else
                lblMore.Text = "There were exactly the same amount of exterior and interior murals painted, " + IntAmount + ".";
        }
    }
}
