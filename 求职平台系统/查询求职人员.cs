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
    public partial class 查询求职人员 : Form
    {
        public 查询求职人员()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public bool ifhavebutton;
        
        public string employerid;
        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.DataSource==null)
            {MessageBox.Show("请选择查询对象"); return;}
            else
            {
                string employeeid=dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (employeeid == "")
                { MessageBox.Show("请选择查询对象"); return; }
                else
                {
                    公开简历 z = new 公开简历();
                    z.employeeid = employeeid;
                    z.employerid = employerid;
                    z.issetting = false;
                    z.ShowDialog();
                }
            }

        }
        
        private void 查询求职人员_Shown(object sender, EventArgs e)
        {
            string sql1 = "select EmpName from Employees ";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            comboBox1.DataSource = dv1;
            comboBox1.DisplayMember = "EmpName";
            comboBox1.Text = "";
            if (ifhavebutton)
            { return; }
            else
            { button3.Visible = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i="";
            if (radioButton3.Checked)
                i = "男";
            else if (radioButton4.Checked)
                i = "女";

            string sql1;
            DataView dv1;
            if (comboBox1.Text != "")
            {
                if (comboBox3.Text != "")
                {
                    if (i != "")
                    {
                        if (textBox1.Text != "")
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where EmpName='" + comboBox1.Text + "' and Area like'%" + comboBox3.Text + "%' and workyear='" + textBox1.Text + "' and sex='" + i + "'";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                        else
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where EmpName='" + comboBox1.Text + "' and Area like'%" + comboBox3.Text + "%'  and sex='" + i + "'";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                        
                    }
                    else
                    {
                        if (textBox1.Text != "")
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where EmpName='" + comboBox1.Text + "' and Area like'%" + comboBox3.Text + "%' and workyear='" + textBox1.Text + "' ";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                        else
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where EmpName='" + comboBox1.Text + "' and Area like'%" + comboBox3.Text + "%'  ";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                    }
                }
                else 
                {
                    if (i != "")
                    {
                        if (textBox1.Text != "")
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where EmpName='" + comboBox1.Text + "' and  workyear='" + textBox1.Text + "' and sex='" + i + "'";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                        else
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where EmpName='" + comboBox1.Text + "' and  sex='" + i + "'";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }

                    }
                    else
                    {
                        if (textBox1.Text != "")
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where EmpName='" + comboBox1.Text + "' and  workyear='" + textBox1.Text + "' ";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                        else
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where EmpName='" + comboBox1.Text + "'   ";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                    }
                    
                }

            }
            else 
            {
                if (comboBox3.Text != "")
                {
                    if (i != "")
                    {
                        if (textBox1.Text != "")
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where  Area like'%" + comboBox3.Text + "%' and workyear='" + textBox1.Text + "' and sex='" + i + "'";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                        else
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where Area like'%" + comboBox3.Text + "%'  and sex='" + i + "'";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }

                    }
                    else
                    {
                        if (textBox1.Text != "")
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where  Area like'%" + comboBox3.Text + "%' and workyear='" + textBox1.Text + "' ";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                        else
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where  Area like'%" + comboBox3.Text + "%'  ";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                    }
                }
                else
                {
                    if (i != "")
                    {
                        if (textBox1.Text != "")
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where   workyear='" + textBox1.Text + "' and sex='" + i + "'";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                        else
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where   sex='" + i + "'";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }

                    }
                    else
                    {
                        if (textBox1.Text != "")
                        {
                            sql1 = "select Employees.EmployeeID,Employees .EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where  workyear='" + textBox1.Text + "' ";
                            dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            dataGridView1.DataSource = dv1;
                        }
                       
                    }

                }

           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void 查询求职人员_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
