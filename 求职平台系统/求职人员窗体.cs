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
    public partial class 求职人员窗体 : Form
    {
        public 求职人员窗体()
        {
            InitializeComponent();
        }
        public string i;
        private void 公开简历设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            公开简历 z = new 公开简历();
            z.issetting = true;
            z.employeeid = label2.Text;
            z.ShowDialog();
            string sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where  employeeid='" + i + "' ";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;

            label2.Text = i;
            label4.Text = dv1[0]["empname"].ToString();
            label12.Text = dv1[0]["area"].ToString();
            label10.Text = dv1[0]["workyear"].ToString();
            label6.Text = dv1[0]["sex"].ToString();
            label8.Text = dv1[0]["age"].ToString();
            label14.Text = dv1[0]["identify"].ToString();
            label16.Text = dv1[0]["email"].ToString();
            label17.Text = dv1[0]["tel"].ToString();
            textBox1.Text = dv1[0]["EmpDescribes"].ToString();
            
        }

        private void 个人信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            个人信息修改 z =new 个人信息修改();
            z.employeeid = label2.Text;
            z.ShowDialog();
            string sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where  employeeid='" + i + "' ";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;

            label2.Text = i;
            label4.Text = dv1[0]["empname"].ToString();
            label12.Text = dv1[0]["area"].ToString();
            label10.Text = dv1[0]["workyear"].ToString();
            label6.Text = dv1[0]["sex"].ToString();
            label8.Text = dv1[0]["age"].ToString();
            label14.Text = dv1[0]["identify"].ToString();
            label16.Text = dv1[0]["email"].ToString();
            label17.Text = dv1[0]["tel"].ToString();
            textBox1.Text = dv1[0]["EmpDescribes"].ToString();

        }

        private void 查询用人单位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询招募信息 z = new 查询招募信息();
            z.ifhavebutton=true;
            z.employeeid = label2.Text;
            z.ShowDialog();
        }

        private void 收到邀请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            收到邀请及收到申请 z = new 收到邀请及收到申请();
            z.employeeid = label2.Text;
            z.isemployer = false;
            z.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码界面 z = new 修改密码界面();
            z.i = this.i;
            z.y = -1;
            z.ShowDialog();
        }

        private void 求职人员窗体_Load(object sender, EventArgs e)
        {

        }

        private void 求职人员窗体_Shown(object sender, EventArgs e)
        {
            string sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where  employeeid='" + i + "' ";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;

            label2.Text = i;
            label4.Text = dv1[0]["empname"].ToString();
            label12.Text = dv1[0]["area"].ToString();
            label10.Text = dv1[0]["workyear"].ToString();
            label6.Text = dv1[0]["sex"].ToString();
            label8.Text = dv1[0]["age"].ToString();
            label14.Text = dv1[0]["identify"].ToString();
            label16.Text = dv1[0]["email"].ToString();
            label17.Text = dv1[0]["tel"].ToString();
            textBox1.Text = dv1[0]["EmpDescribes"].ToString();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
