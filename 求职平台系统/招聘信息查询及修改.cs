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
    public partial class 招聘信息查询及修改 : Form
    {
        public 招聘信息查询及修改()
        {
            InitializeComponent();
        }
        public string i;
        private void 招聘信息查询及修改_Shown(object sender, EventArgs e)
        {
            string sql1 = "select * from Recruitment where employerid='"+i+"' ";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            dataGridView1.DataSource = dv1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            发布招聘信息 z = new 发布招聘信息();
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string sql1 = "select Recruitment.*,empname,area,Lincense,empdescribes from Recruitment,Employer where Recruitment.EmployerID=Employer.EmployerID and RecruitmentID='" + s + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;

            z.b= dv1[0]["Lincense"].ToString();
            z.h= dv1[0]["salary"].ToString();
            z.d= dv1[0]["area"].ToString();
            z.g = dv1[0]["JobDescribes"].ToString();
            z.c = dv1[0]["empdescribes"].ToString();
            z.a = dv1[0]["empname"].ToString();
            z.f = dv1[0]["EmployerID"].ToString();
            z.RecruitmentID = s;
            z.employerid = dv1[0]["EmployerID"].ToString();
            z.isupdate=true;
            z.ShowDialog();


            string sql2 = "select * from Recruitment where employerid='" + i + "' ";
            DataView dv2 = DB.GetDs(sql2).Tables[0].DefaultView;
            dataGridView1.DataSource = dv2;
            
        }

        private void 招聘信息查询及修改_Load(object sender, EventArgs e)
        {

        }
    }
}
