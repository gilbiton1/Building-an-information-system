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
    public partial class CRUDEmployee : Form
    {
        string empID;
        public CRUDEmployee(string empID)
        {
            this.empID = empID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmployee c = new addEmployee(empID);
            c.Show();
            this.Hide();
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            searchEmployee c = new searchEmployee(empID);
            c.Show();
            this.Hide();
        }

        private void CRUDEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomePage f = new HomePage(empID, false);
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
