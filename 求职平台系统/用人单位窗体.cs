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
    public partial class 用人单位窗体 : Form
    {
        public 用人单位窗体()
        {
            InitializeComponent();
        }
        public string i;
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            招聘信息查询及修改 z = new 招聘信息查询及修改();
            z.i = this.i;
            z.ShowDialog();
        }

        
        private void 发布ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            发布招聘信息 z = new 发布招聘信息();
            z.a = label2.Text;
            z.b = label4.Text;
            z.c = textBox1.Text;
            z.d = label7.Text;
            z.f = label9.Text;
            z.isupdate = false;
            z.isemployer = true;
            z.ShowDialog();   
            
        }

        private void 收到申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            收到邀请及收到申请 z = new 收到邀请及收到申请();
            z.employerid = label9.Text;
            z.isemployer = true;
            z.ShowDialog();
        }

        private void 查询及邀请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询求职人员 z = new 查询求职人员();
            z.ifhavebutton = true;
            z.employerid = label9.Text;
            z.ShowDialog();
        }

        private void 公司信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            公司信息修改 z = new 公司信息修改();
            z.a = label2.Text;
            z.b = label4.Text;
            z.c = textBox1.Text;
            z.d = label7.Text;
            z.id = label9.Text;
            z.ShowDialog();
            string sql1 = "select employer.*,area,Lincense,empdescribes from Employer where  Employer.employerid='" + i + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            label2.Text = dv1[0]["empname"].ToString();
            label4.Text = dv1[0]["Lincense"].ToString();
            textBox1.Text = dv1[0]["EmpDescribes"].ToString();
            label7.Text = dv1[0]["area"].ToString();
            label9.Text = dv1[0]["employerid"].ToString();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码界面 z = new 修改密码界面();
            z.i = this.i;
            z.y = 0;
            z.ShowDialog();
        }

        private void 用人单位窗体_Load(object sender, EventArgs e)
        {
            

        }

        private void 用人单位窗体_Shown(object sender, EventArgs e)
        {
            string sql1 = "select employer.*,area,Lincense,empdescribes from Employer where  Employer.employerid='" + i + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            label2.Text = dv1[0]["empname"].ToString();
            label4.Text = dv1[0]["Lincense"].ToString();
            textBox1.Text = dv1[0]["EmpDescribes"].ToString();
            label7.Text = dv1[0]["area"].ToString();
            label9.Text = dv1[0]["employerid"].ToString();
        }

        private void 招聘信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 求职者信箱ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
