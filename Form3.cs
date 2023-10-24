using Second_Electricity_POC.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Second_Electricity_POC
{
    public partial class Form3 : Form
    {
        public Form3(int id, string user)
        {
            
            InitializeComponent();
            label4.Text = id.ToString();
            LeaveDemoEntities ef = new LeaveDemoEntities();
            var emp =ef.Emnployees.FirstOrDefault(e=>e.ID == id);
            string leave = emp.LeaveType.Name;
            label5.Text= leave;
            GetAction(id,user);
           
        }
        public async void GetAction(int id, string user)
        {
            TaskActionSoapClient k2 = new TaskActionSoapClient();

            string EmpName = "Q.abed";
            GetEmployeeTaskListResponse result = await k2.GetEmployeeTaskListAsync(EmpName, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
            K2TaskItem[] Items = result.Body.GetEmployeeTaskListResult;
            K2TaskItem taskitem;
            if (user == "Hr")
            {
                 taskitem = Items.Where(e => e.ServiceName == "Leave.wf" && e.Folio == id.ToString()).FirstOrDefault(e=>e.serialNumber.EndsWith("_14"));
            }
            else
            {
                 taskitem = Items.Where(leave => leave.ServiceName == "Leave.wf" && leave.Folio == id.ToString()).FirstOrDefault(e => e.serialNumber.EndsWith("_20"));
            }

            List<ComboItem> Actions = new List<ComboItem>();
            int a = 0;
            LeaveDemoEntities ef = new LeaveDemoEntities();
            foreach (var item in taskitem.Actions)
            {
                a++;
                var dbactions =ef.Actions.FirstOrDefault(e => e.ActionNameEn == item);
                var x = new ComboItem
                {
                    ID = dbactions.Id,
                    Text = dbactions.ActionNameAr
                };
                Actions.Add(x);
            }
            comboBox2.DataSource = Actions;
            comboBox2.DisplayMember= "Text";
            comboBox2.ValueMember = "ID";
            
        }
        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            LeaveDemoEntities ef = new LeaveDemoEntities();
            TaskActionSoapClient k2 = new TaskActionSoapClient();
            string Id = label4.Text;
            string EmpName = "Q.abed";
            int actionId = Convert.ToInt32(comboBox2.SelectedValue);

            GetEmployeeTaskListResponse result = await k2.GetEmployeeTaskListAsync(EmpName, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
            K2TaskItem[] Items = result.Body.GetEmployeeTaskListResult;
            K2TaskItem taskitem;
            if (actionId == 1)
            {
                 taskitem = Items.Where(leave => leave.ServiceName == "Leave.wf" && leave.Folio == Id.ToString()).FirstOrDefault(leave=>leave.serialNumber.EndsWith("_20"));
            }
            else
            {
                 taskitem = Items.Where(leave => leave.ServiceName == "Leave.wf" && leave.Folio == Id.ToString()).FirstOrDefault(leave=>leave.serialNumber.EndsWith("_14"));
            }
            string action = ef.Actions.FirstOrDefault(a => a.Id == actionId).ActionNameEn;
            ActionWorklistItemResponse response = await k2.ActionWorklistItemAsync(taskitem.serialNumber, action, EmpName);
            var result1 = response.Body.ActionWorklistItemResult;

            int EmpId = Convert.ToInt32(Id);
            var emp = ef.Emnployees.FirstOrDefault(r => r.ID == EmpId);
            //string workflowName = "WorkFlow\\HR Management";
            //StartProcessResponse Response = await k2.StartProcessAsync(EmpName,EmpId, EmpId, workflowName);
            //int ProcessID = int.Parse(Response.Body.StartProcessResult.ToString());

            var gen = ef.GeneralRequests.FirstOrDefault(r=>r.RequestId == emp.RequestId);
            gen.StepId += 1;
            if (actionId == 1)
            {
                emp.LineManagerRemark = "Done";
            }
            else
            {
                emp.HRRemark = " Done";
            }
            //gen.ProcessId = ProcessID;
            ef.SaveChanges();
            
            this.Close();
            var xx = new Form4();
            xx.Show();
        }
    }
}
