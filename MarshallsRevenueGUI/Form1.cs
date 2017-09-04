using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsRevenueGUI
{
    public partial class marshallsRevenue : Form
    {
        public marshallsRevenue()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            const int Ext = 750;
            const int Int = 500;
            int total = 0;
            int IntAmount = 0;
            int ExtAmount = 0;

            IntAmount = Convert.ToInt32(txtInt.Text);
            ExtAmount = Convert.ToInt32(txtExt.Text);
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
