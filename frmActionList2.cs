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
    public partial class frmActionList2 : Form
    {
        public frmActionList2()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveDemoDataSet.Emnployee' table. You can move, or remove it, as needed.
            LeaveDemoEntities db = new LeaveDemoEntities();
            var x = db.Emnployees.Where(a => a.LineManagerRemark == null).ToList();
            List<Emnployee> emps = new List<Emnployee>();






            dgvData.DataSource = x;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[0].Value);
            var x = new frmAction(Id, "Admin");
            x.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvData.Rows[dgvData.CurrentRow.Index].Cells[0].Value);
            var x = new frmAction(Id, "Admin");
            x.Show();
            this.Close();
        }
    }
}
