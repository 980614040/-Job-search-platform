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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入账号");
                return;
            }
             else if (textBox2.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    string sql1 = "select * from Employees where EmployeeID='" + textBox1.Text + "' and passwords=" + textBox2.Text + "";
                    DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                    if (dv1.Count == 0)
                    {
                        MessageBox.Show("用户名不存在，或密码错误！");
                        return;
                    }

                    else
                    
                    {
                        求职人员窗体 z = new 求职人员窗体();
                        z.i = textBox1.Text;
                        z.ShowDialog();
                    }
                }
                if (radioButton2.Checked)
                {
                    string sql2 = "select * from Employer where EmployerID='" + textBox1.Text + "'and passwords=" + textBox2.Text + "";
                    DataView dv2 = DB.GetDs(sql2).Tables[0].DefaultView;
                    if (dv2.Count == 0)
                    {
                        MessageBox.Show("用户名不存在，或密码错误！");
                        return;
                    }
                    
                    else
                    {
                        用人单位窗体 z = new 用人单位窗体();
                        z.i = textBox1.Text;
                        z.ShowDialog();
                    }
                }
                if (radioButton3.Checked)
                {
                    string sql3 = "select * from Administrator where AdminID='" + textBox1.Text + "'and passwords=" + textBox2.Text + "";
                    DataView dv3 = DB.GetDs(sql3).Tables[0].DefaultView;
                    if (dv3.Count == 0)
                    {
                        MessageBox.Show("用户名不存在，或密码错误！");
                        return;
                    }

                    else
                    {
                        管理者窗体 z = new 管理者窗体();
                        z.i = textBox1.Text;
                        z.ShowDialog();
                    }


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new 注册界面().ShowDialog();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
