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
    public partial class 收到申请 : Form
    {
        public 收到申请()
        {
            InitializeComponent();
        }
        public string employeeid;
        public string employerid;
        private void 收到申请_Shown(object sender, EventArgs e)
        {

            string sql1 = "select  Employees.EmployeeID,Employees.EmpName,invite.jobdescribes,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees,invite,employer where  employees.employeeid=invite.employeeid and employer.employerid=invite.employerid and employer.employerid='" + employerid + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            label13.Text = dv1[0]["empname"].ToString();
            label16.Text = dv1[0]["area"].ToString();
            label14.Text = dv1[0]["workyear"].ToString();
            label15.Text = dv1[0]["sex"].ToString();
            label17.Text = dv1[0]["age"].ToString();
            label18.Text = dv1[0]["identify"].ToString();
            label19.Text = dv1[0]["email"].ToString();
            label20.Text = dv1[0]["tel"].ToString();
            textBox6.Text = dv1[0]["EmpDescribes"].ToString();
            textBox7.Text = dv1[0]["jobdescribes"].ToString();



        }

        private void 收到申请_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql1 = "update invite set states=0 where employerid='"+employerid+"'and employeeid='"+employeeid+"'";
            DB.Execute(sql1);
            DB.Execute("update balance set balance=(select balance from balance where accountid='" + employerid + "')-5 where accountid='" + employerid + "'");
            
            MessageBox.Show("已经接受对方申请，请及时联系！");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "update invite set states=2 where employerid='" + employerid + "'and employeeid='" + employeeid + "'";
            DB.Execute(sql1);
            MessageBox.Show("已经拒绝对方申请!");
        }
    }
}
