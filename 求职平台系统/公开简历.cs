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
    public partial class 公开简历 : Form
    {
        public 公开简历()
        {
            InitializeComponent();
        }
        
        public string employerid;
        public string employeeid;
        
        public bool issetting;

        private void 公开简历_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            邀请函 z = new 邀请函();
            z.employeeid = employeeid;
            z.employerid = employerid;
            z.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 公开简历_Shown(object sender, EventArgs e)
        {
            if (issetting)
            {   
                textBox1.ReadOnly = false;
                button1.Visible = false;
                button3.Visible = false;
                string sql1 = "select Employees.EmployeeID,Employees.EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where employeeid='" + employeeid + "'";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                label8.Text = dv1[0]["empname"].ToString();
                label9.Text = dv1[0]["area"].ToString();
                label10.Text = dv1[0]["workyear"].ToString();
                label12.Text = dv1[0]["sex"].ToString();
                label11.Text = dv1[0]["age"].ToString();
                label14.Text = dv1[0]["identify"].ToString();
                label17.Text = dv1[0]["email"].ToString();
                label18.Text = dv1[0]["tel"].ToString();
                textBox1.Text = dv1[0]["EmpDescribes"].ToString();

                
            }
            else
            {
                textBox1.ReadOnly = true;
                button1.Visible = true;
                button3.Visible = true;
                button2.Visible = false;

                string sql1 = "select Employees.EmployeeID,Employees.EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where employeeid='"+employeeid+"'";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                label8.Text = dv1[0]["empname"].ToString();
                label9.Text = dv1[0]["area"].ToString();
                label10.Text = dv1[0]["workyear"].ToString();
                label12.Text = dv1[0]["sex"].ToString();
                label11.Text = dv1[0]["age"].ToString();
                label14.Text = dv1[0]["identify"].ToString();
                label17.Text = dv1[0]["email"].ToString();
                label18.Text = dv1[0]["tel"].ToString();
                textBox1.Text = dv1[0]["EmpDescribes"].ToString();




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from employerblacklist where employeeid='" + employeeid + "'and employerid='"+employerid+"'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            if(dv1.Count>0)
            { MessageBox.Show("该求职者已在黑名单中！"); return; }
            else
            {
                string sql2 = "insert into employerblacklist(employerid,employeeid) values('" + employerid + "','" + employeeid + "') ";
                DB.Execute(sql2);
                MessageBox.Show("添加成功！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql1 = "update employees set empdescribes='" + textBox1.Text + "' where employeeid='"+employeeid+"'";
            DB.Execute(sql1);
            MessageBox.Show("修改成功！");
            this.Close();
        }
    }
}
