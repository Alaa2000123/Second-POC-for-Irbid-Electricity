using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Electricity_POC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var x = new frmActionList2();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new frmLeaveRequest();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = new frmActionList();
            x.Show();
        }
    }
}
