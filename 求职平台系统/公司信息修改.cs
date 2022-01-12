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
    public partial class 公司信息修改 : Form
    {
        public 公司信息修改()
        {
            InitializeComponent();
        }

        private void 公司信息修改_Load(object sender, EventArgs e)
        {

        }
        public string a, b, c, d,id;
        private void 公司信息修改_Shown(object sender, EventArgs e)
        {
            
            textBox2.Text = c;
            textBox7.Text = b;
            textBox8.Text = a;
            comboBox1.Text = d;
            string sql1 = "select email,tel from Employer where Employer.EmployerID='"+id+"'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            textBox6.Text = dv1[0]["tel"].ToString();
            textBox1.Text = dv1[0]["email"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "update employer set tel='" + textBox6.Text + "' where employerid='"+id+"'";
            string sql2 = "update employer set email='" + textBox1.Text + "' where employerid='" + id + "'";
            string sql3 = "update employer set area='" + comboBox1.Text + "' where employerid='" + id + "'";
            string sql4 = "update employer set empname='" + textBox8.Text + "' where employerid='" + id + "'";
            string sql5 = "update employer set lincense='" + textBox7.Text + "' where employerid='" + id + "'";
            string sql6 = "update employer set EmpDescribes='" + textBox2.Text + "' where employerid='" + id + "'";
            DB.Execute(sql1);
            DB.Execute(sql2);
            DB.Execute(sql3);
            DB.Execute(sql4);
            DB.Execute(sql5);
            DB.Execute(sql6);
            MessageBox.Show("修改成功");
            this.Close();
        }
    }
}
