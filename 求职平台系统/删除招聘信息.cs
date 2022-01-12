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
    public partial class 删除招聘信息 : Form
    {
        public 删除招聘信息()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox2.Text != "" && textBox1.Text != "" && comboBox3.Text != "")
            {
                string sql1 = "select empname,Recruitment.* from Recruitment,Employer where EmpName='" + comboBox1.Text + "' and Area like'%" + comboBox3.Text + "%' and salary between " + textBox2.Text + " and " + textBox1.Text + " and employer.employerid=recruitment.employerid";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                dataGridView1.DataSource = dv1;
            }
            else if (comboBox1.Text != "" && comboBox3.Text != "" && textBox2.Text == "" && textBox1.Text == "")
            {
                string sql2 = "select empname,Recruitment.* from Recruitment,Employer  where EmpName='" + comboBox1.Text + "' and Area like'%" + comboBox3.Text + "%'and employer.employerid=recruitment.employerid";
                DataView dv2 = DB.GetDs(sql2).Tables[0].DefaultView;
                dataGridView1.DataSource = dv2;
            }
            else if (comboBox1.Text != "" && comboBox3.Text == "" && textBox2.Text == "" && textBox1.Text == "")
            {
                string sql3 = "select empname,Recruitment.* from Recruitment,Employer  where EmpName='" + comboBox1.Text + "'and employer.employerid=recruitment.employerid";
                DataView dv3 = DB.GetDs(sql3).Tables[0].DefaultView;
                dataGridView1.DataSource = dv3;
            }
            if (comboBox1.Text != "" && textBox2.Text != "" && textBox1.Text != "" && comboBox3.Text == "")
            {
                string sql4 = "select empname,Recruitment.* from Recruitment,Employer  where EmpName='" + comboBox1.Text + "'  and salary between " + textBox2.Text + " and " + textBox1.Text + " and employer.employerid=recruitment.employerid";
                DataView dv4 = DB.GetDs(sql4).Tables[0].DefaultView;
                dataGridView1.DataSource = dv4;
            }
            else if (textBox2.Text != "" && textBox1.Text != "" && comboBox3.Text != "" && comboBox1.Text == "")
            {
                string sql5 = "select empname,Recruitment.* from Recruitment,Employer  where Area like'%" + comboBox3.Text + "%' and salary between " + textBox2.Text + " and " + textBox1.Text + " and employer.employerid=recruitment.employerid";
                DataView dv5 = DB.GetDs(sql5).Tables[0].DefaultView;
                dataGridView1.DataSource = dv5;
            }
            else if (textBox2.Text != "" && textBox1.Text != "" && comboBox3.Text == "" && comboBox1.Text == "")
            {
                string sql6 = "select empname,Recruitment.* from Recruitment,Employer  where salary between " + textBox2.Text + " and " + textBox1.Text + " and employer.employerid=recruitment.employerid";
                DataView dv6 = DB.GetDs(sql6).Tables[0].DefaultView;
                dataGridView1.DataSource = dv6;
            }
            else if (comboBox3.Text != "" && textBox2.Text == "" && textBox1.Text == "" && comboBox1.Text == "")
            {
                string sql7 = "select empname,Recruitment.* from Recruitment,Employer  where Area like'%" + comboBox3.Text + "%' and employer.employerid=recruitment.employerid";
                DataView dv7 = DB.GetDs(sql7).Tables[0].DefaultView;
                dataGridView1.DataSource = dv7;
            }
        }

        private void 删除招聘信息_Shown(object sender, EventArgs e)
        {
            string sql1 = "select EmpName  from Employer ";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            comboBox1.DataSource = dv1;
            comboBox1.DisplayMember = "EmpName";
            comboBox1.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sql1 = "delete from Recruitment where Recruitmentid='" + id + "'";
            DB.Execute(sql1);
            MessageBox.Show("删除成功！");
        }

        private void 删除招聘信息_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
