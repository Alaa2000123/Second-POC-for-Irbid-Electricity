using Second_Electricity_POC.LeaveDemoDataSetTableAdapters;
using Second_Electricity_POC.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Second_Electricity_POC
{
    public partial class frmLeaveRequest : Form
    {
        public frmLeaveRequest()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveDemoDataSet.LeaveType' table. You can move, or remove it, as needed.
            this.leaveTypeTableAdapter.Fill(this.leaveDemoDataSet.LeaveType);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            TaskActionSoapClient K2 = new TaskActionSoapClient();

            string EmpName = "Q.abed";

            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = @"Data Source=154.12.237.206;Initial Catalog=LeaveDemo;User ID=zuhairi;Password=_N3W_Y0r(K)";
            sc.Open();
            int LeaveTypeID = 0;
            com.Connection = sc; 
            if (comboBox1.Text == "اجازة مرضية")
            {
                 LeaveTypeID = 1;
            }
            else if(comboBox1.Text == "اجازة سنوية")
            {
                 LeaveTypeID = 2;
            }
            else
            {
                LeaveTypeID = 3;
            }
            com.CommandText = @"INSERT INTO Emnployee (LeaveTypeID, StartDate, EndDate, LeaveBalance) VALUES (@LeaveTypeID, @StartDate, @EndDate, @LeaveBalance);SELECT SCOPE_IDENTITY();";

            com.Parameters.AddWithValue("@LeaveTypeID", LeaveTypeID);
            com.Parameters.AddWithValue("@StartDate", DateTime.Now);
            com.Parameters.AddWithValue("@EndDate", DateTime.Now);
            com.Parameters.AddWithValue("@LeaveBalance", textBox3.Text);

            int id = Convert.ToInt32(com.ExecuteScalar());

            sc.Close();

           
            
            int reqid = InsertGeneralRequest(id,1,1);
            string workflowName = "WorkFlow\\Leave.wf";
            StartProcessResponse Response = await K2.StartProcessAsync(EmpName, id, reqid, workflowName);
            int ProcessID = int.Parse(Response.Body.StartProcessResult.ToString());
            //GetEmployeeTaskListResponse result = await _K2Service.GetEmployeeTaskListAsync(EmpName, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
            //K2TaskItem[] Items = result.Body.GetEmployeeTaskListResult;
            //K2TaskItem taskitem = Items.Where(leave => leave.ServiceName == "Leave.wf" && leave.Folio == id.ToString()).FirstOrDefault();
            //var action = "Approve";
            LeaveDemoEntities ef = new LeaveDemoEntities();
            
             var leave = ef.Emnployees.FirstOrDefault(idd => idd.ID == id);
            var req = ef.GeneralRequests.FirstOrDefault(idd => idd.RequestId == reqid);
            req.ProcessId = ProcessID;
            leave.RequestId = reqid;
            ef.SaveChanges();
            //ActionWorklistItemResponse response = await _K2Service.ActionWorklistItemAsync(taskitem.serialNumber, action, EmpName);
            //var theresult = response.Body.ActionWorklistItemResult;
            this.Close();
        }
        public int InsertGeneralRequest(int TableID, int ServiceTypeID, int StepID)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlCommand con = new SqlCommand();
            sc.ConnectionString = @"Data Source=154.12.237.206;Initial Catalog=LeaveDemo;User ID=zuhairi;Password=_N3W_Y0r(K)";
            sc.Open(); 
            com.Connection = sc;
            com.CommandText = @"INSERT INTO GeneralRequest (RequestNo, EmpUserName, EmpFullNameAr, EmpFullNameEn, EmpNumber, ActionLastDateTime, CreatedBy, CreatedDateTime, OnBehalf, ServiceTypeId, StatusId, StepId) VALUES (@RequestNo, @EmpUserName, @EmpFullNameAr,@EmpFullNameEn,@EmpNumber,@ActionLastDateTime,@CreatedBy,@CreatedDateTime,@OnBehalf,@ServiceTypeId,@StatusId,@StepId);SELECT SCOPE_IDENTITY();";

            com.Parameters.AddWithValue("@RequestNo", TableID);
            com.Parameters.AddWithValue("@EmpUserName", "Qusai");
            com.Parameters.AddWithValue("@EmpFullNameAr", "قصي");
            com.Parameters.AddWithValue("@EmpFullNameEn", "Qusai");
            com.Parameters.AddWithValue("@EmpNumber", 1);
            com.Parameters.AddWithValue("@ActionLastDateTime",DateTime.Now);
            com.Parameters.AddWithValue("@CreatedBy", "Qusai");
            com.Parameters.AddWithValue("@CreatedDateTime", DateTime.Now);
            com.Parameters.AddWithValue("@OnBehalf", false);
            com.Parameters.AddWithValue("@ServiceTypeId", ServiceTypeID);
            com.Parameters.AddWithValue("@StatusId", 1);
            com.Parameters.AddWithValue("@StepId", StepID);
            

            int Requestid = Convert.ToInt32(com.ExecuteScalar());

            con.Connection = sc;
            con.CommandText = @"INSERT INTO ActionHistory (RequestId, StepId, ActionId, ActionName, ActionByUserName, ActionDateTime, UserActionGroup) VALUES (@RequestId, @StepId, @ActionId,@ActionName,@ActionByUserName,@ActionDateTime,@UserActionGroup);SELECT SCOPE_IDENTITY();";

            con.Parameters.AddWithValue("@RequestId", Requestid);
            con.Parameters.AddWithValue("@StepId", StepID);
            con.Parameters.AddWithValue("@ActionId", 3);
            con.Parameters.AddWithValue("@ActionName", "Complete");
            con.Parameters.AddWithValue("@ActionByUserName", "Qusai");
            con.Parameters.AddWithValue("@ActionDateTime", DateTime.Now);
            con.Parameters.AddWithValue("@UserActionGroup", "user");
            int ActionHistoryId = Convert.ToInt32(con.ExecuteScalar());


            sc.Close();
            return Requestid;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
