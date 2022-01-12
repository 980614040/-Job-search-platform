using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 求职平台系统
{
    public partial class 收到邀请及收到申请 : Form
    {
        public 收到邀请及收到申请()
        {
            InitializeComponent();
        }
        public string employerid;
        public bool isemployer;
        public string employeeid;
        private void 收到邀请及收到申请_Load(object sender, EventArgs e)
        {

        }

        private void 收到邀请及收到申请_Shown(object sender, EventArgs e)
        {

            if (isemployer)
            {
                string sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,invite .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees,invite,employer where  employees.employeeid=invite.employeeid and employer.employerid=invite.employerid and employer.employerid='" + employerid + "'";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                dataGridView1.DataSource = dv1;
                string states= dv1[0]["states"].ToString();
                if (dv1.Count == 0)
                {
                    MessageBox.Show("没有收到任何信息");
                    this.Close();
                    return;
                }
                 if (states == "0")
                {
                    MessageBox.Show("有求职者接受了你的邀请！");
                }
                 if (states == "2")
                {
                    MessageBox.Show("有求职者拒绝了你的邀请!");
                }
            }
            else
            {
                string sql1 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,invite.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel from Employer,invite,employees where employees.employeeid=invite.employeeid and employer.employerid=invite.employerid and employees.employeeid='"+employeeid+"'";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                dataGridView1.DataSource = dv1;
                
                if (dv1.Count == 0)
                {
                    MessageBox.Show("没有收到任何信息");
                    this.Close();
                    return;
                }
                else
                {  
                    string states = dv1[0]["states"].ToString();
                    if (states == "0")
                    {
                        MessageBox.Show("有用人单位接受了你的邀请！");
                    }
                    if (states == "2")
                    {
                        MessageBox.Show("有用人单位拒绝了你的邀请!");
                    }
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(employeeid + "!!!!!!!!!!!!!" + employerid + "!!!!!!!!!!!!!");
            if (isemployer)
            {
                 employeeid = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                收到申请 z = new 收到申请();
                z.employeeid = employeeid;
                z.employerid = employerid;
                z.ShowDialog();
            }
            else
            {

                employerid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                发布招聘信息 z = new 发布招聘信息();
                z.employeeid = employeeid;
                z.employerid = employerid;
                z.ShowDialog();
            }
        }
    }
}
