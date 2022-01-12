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
    public partial class 公司详细信息 : Form
    {
        public 公司详细信息()
        {
            InitializeComponent();
        }

        public string employerid;
        public string employeeid;
        private void 公司详细信息_Load(object sender, EventArgs e)
        {
            
        }

        private void 公司详细信息_Shown(object sender, EventArgs e)
        {
            string sql1 = "select Employer.employerid,Employer.empname,Employer.area,Employer.Lincense,Employer.empdescribes,Employer.tel,Employer.email, Recruitment.jobdescribes,Recruitment.salary from Recruitment,Employer where recruitment.employerid=employer.employerid and employer.employerID='" + employerid + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;

            label4.Text = dv1[0]["Lincense"].ToString();
            label3.Text = dv1[0]["area"].ToString();
            textBox1.Text= dv1[0]["JobDescribes"].ToString();
            textBox2.Text= dv1[0]["empdescribes"].ToString();
            label1.Text = dv1[0]["empname"].ToString();
            label5.Text=dv1[0]["tel"].ToString();
            label7.Text=dv1[0]["email"].ToString();
            label14.Text=dv1[0]["salary"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from employeeblacklist where employeeid='" + employeeid + "'and employerid='" + employerid + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            if (dv1.Count > 0)
            { MessageBox.Show("该用人单位已在黑名单中！"); return; }
            else
            {
                string sql2 = "insert into employeeblacklist(employerid,employeeid) values('" + employerid + "','" + employeeid + "') ";
                DB.Execute(sql2);
                MessageBox.Show("添加成功！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            私密简历 z = new 私密简历();
            z.employeeid = employeeid;
            z.employerid = employerid;
            z.salary = label14.Text;
            z.ShowDialog();
            this.Close();
        }
    }
}
