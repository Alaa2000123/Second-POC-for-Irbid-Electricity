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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveDemoDataSet.Emnployee' table. You can move, or remove it, as needed.
            LeaveDemoEntities db = new LeaveDemoEntities();
            var x = db.Emnployees.Where(a=>a.LineManagerRemark == null).ToList();
            List<Emnployee> emps = new List<Emnployee>();
  
               
                
               
                
          
            dataGridView1.DataSource = x;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var x = new Form3(Id ,"Admin");
            x.Show();
            this.Close();
        }
    }
}
