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
    public partial class 查询招募信息 : Form
    {
        public 查询招募信息()
        {
            InitializeComponent();
        }
        public string employeeid;
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            { MessageBox.Show("请选择查询对象"); return; }
            else
            {
                string employerid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (employerid == "")
                { MessageBox.Show("请选择查询对象");return;}
                else
                {
                    公司详细信息 z = new 公司详细信息();
                    z.employerid = employerid;
                    z.employeeid = employeeid;
                    z.Show();
                }
            }

        }
        public bool ifhavebutton;
        private void 查询用人单位_Shown(object sender, EventArgs e)
        {
            string sql1 = "select EmpName  from Employer ";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            comboBox1.DataSource=dv1;
            comboBox1.DisplayMember="EmpName";
            comboBox1.Text = "";
            if (ifhavebutton)
            { return; }
            else
            { button3.Visible = false; }
            
        }

        private void 查询用人单位_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox3.Text != "")
            {
                string sql1 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,Employer.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel,Recruitment.salary from Employer,Recruitment where EmpName='" + comboBox1.Text + "' and Area like'%" + comboBox3.Text + "%' and salary between " + textBox2.Text + " and " + textBox3.Text + " and employer.employerid=recruitment.employerid";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                dataGridView1.DataSource = dv1;
            }
            else if (comboBox1.Text != "" && comboBox3.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                string sql2 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,Employer.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel,Recruitment.salary from Employer,Recruitment where EmpName='" + comboBox1.Text + "' and Area like'%" + comboBox3.Text + "%'and employer.employerid=recruitment.employerid";
                DataView dv2 = DB.GetDs(sql2).Tables[0].DefaultView;
                dataGridView1.DataSource = dv2;
            }
            else if (comboBox1.Text != "" && comboBox3.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {   
                string sql3 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,Employer.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel,Recruitment.salary from Employer,Recruitment where EmpName='" + comboBox1.Text + "'and employer.employerid=recruitment.employerid";
                DataView dv3 = DB.GetDs(sql3).Tables[0].DefaultView;
                dataGridView1.DataSource = dv3;
            }
            if (comboBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox3.Text == "")
            {   
                string sql4 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,Employer.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel,Recruitment.salary from Employer,Recruitment where EmpName='" + comboBox1.Text + "'  and salary between " + textBox2.Text + " and " + textBox3.Text + " and employer.employerid=recruitment.employerid";
                DataView dv4 = DB.GetDs(sql4).Tables[0].DefaultView;
                dataGridView1.DataSource = dv4;
            }
            else if(textBox2.Text != "" && textBox3.Text != "" && comboBox3.Text != ""&& comboBox1.Text == "")
            {
                string sql5 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,Employer.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel,Recruitment.salary from Employer,Recruitment where Area like'%" + comboBox3.Text + "%' and salary between " + textBox2.Text + " and " + textBox3.Text + " and employer.employerid=recruitment.employerid";
                DataView dv5 = DB.GetDs(sql5).Tables[0].DefaultView;
                dataGridView1.DataSource = dv5;
            }
            else if (textBox2.Text != "" && textBox3.Text != "" && comboBox3.Text == "" && comboBox1.Text == "")
            {
                string sql6 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,Employer.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel,Recruitment.salary from Employer,Recruitment where salary between " + textBox2.Text + " and " + textBox3.Text + " and employer.employerid=recruitment.employerid";
                DataView dv6 = DB.GetDs(sql6).Tables[0].DefaultView;
                dataGridView1.DataSource = dv6;
            }
            else if(comboBox3.Text != ""&& textBox2.Text == "" && textBox3.Text == "" && comboBox1.Text == "")
            {   
                string sql7 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,Employer.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel,Recruitment.salary from Employer,Recruitment where Area like'%" + comboBox3.Text + "%' and employer.employerid=recruitment.employerid";
                DataView dv7 = DB.GetDs(sql7).Tables[0].DefaultView;
                dataGridView1.DataSource = dv7;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox3.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
