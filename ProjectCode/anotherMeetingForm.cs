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
    public partial class anotherMeetingForm : Form
    {
        string cusID;
        public anotherMeetingForm(string cusID)
        {
            this.cusID = cusID;
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            ScheduleMeeting f = new ScheduleMeeting(cusID);
            f.Show();
            this.Hide();
        }

        private void anotherMeetingForm_Load(object sender, EventArgs e)
        {

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f = new HomePage(cusID, true);
            f.Show();
            this.Hide();
        }
    }
}
