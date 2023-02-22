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
    public partial class CRUDSupplier : Form
    {
        string empID;
        public CRUDSupplier(string empID)
        {
            this.empID = empID;
            InitializeComponent();
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            addSupplier c = new addSupplier(empID);
            c.Show();
            this.Hide();
        }

        private void searchSupplier_Click(object sender, EventArgs e)
        {
            searchSupplier c = new searchSupplier(empID);
            c.Show();
            this.Hide();
        }

        private void CRUDSupplier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage(empID,false);
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
