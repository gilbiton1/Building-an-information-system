using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partBproject
{
    public partial class CRUDCustomer : Form
    {
        string empID;
        public CRUDCustomer(string empID)
        {
            this.empID = empID;
            InitializeComponent();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            searchCustomer c = new searchCustomer(empID);
            c.Show();
            this.Hide();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            addCustomer c = new addCustomer(empID);
            c.Show();
            this.Hide();
        }

        private void CRUDCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage g = new HomePage(empID, false);
            g.Show();
            this.Hide();
        }
    }
}
