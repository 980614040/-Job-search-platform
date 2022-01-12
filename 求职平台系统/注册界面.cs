using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 求职平台系统
{
    public partial class 注册界面 : Form
    {
        public 注册界面()
        {
            InitializeComponent();
        }

        private void 注册界面_Shown(object sender, EventArgs e)
        {

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            panel2.Visible = false;
            panel4.Visible = false;
            button1.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
           
            panel4.Visible = false;
            panel2.Visible = true;
            button1.Visible = true; 
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            panel2.Visible = false;
            panel4.Visible = true;
            button1.Visible = true;
            

        }

        private void 注册界面_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox9.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox5.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox1.Text.Length !=11)
                {
                    MessageBox.Show("账号长度等于11位"); return;
                }
                if ((!Regex.IsMatch(textBox4.Text, @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase))) 
                {
                    MessageBox.Show("请输入正确身份证号");return;
                }
                if (textBox5.Text.Length!=11)
                {
                    MessageBox.Show("请输入正确手机号");return;
                }
                if (textBox2.Text.Length > 16)
                {
                    MessageBox.Show("请输入正确新密码，密码小于16位"); return;
                }
                if (textBox2.Text.Length < 5)
                {
                    MessageBox.Show("请输入正确新密码，密码大于5位"); return;
                }
                if (textBox9.Text != textBox2.Text)
                {
                    MessageBox.Show("重复输入密码不一致"); return;
                }
                int s;
                s = DateTime.Now.Year - dateTimePicker1.Value.Year;
                if (s < 18)
                {
                    MessageBox.Show("未成年人无法创建账号"); return;
                }

                else
                {
                    string sex="";
                    if(radioButton3.Checked)
                    {
                        sex="男";
                    }
                    if(radioButton4.Checked)
                    {
                        sex="女";
                    }
                    DB.Execute("insert into Employees(EmployeeID,passwords,EmpName,Sex,Age,Identify,tel) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + sex + "','" + s + "','" + textBox4.Text + "','" + textBox5.Text + "')");
                    MessageBox.Show("注册成功");
                    this.Close();
                }

                }
            if (radioButton2.Checked)
            
            {
                Size Size = new Size(520, 505);
                this.Size = Size;

                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox9.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox6.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox7.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (textBox8.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("请输入完整信息"); return;
                }

                if (textBox1.Text.Length <11)
                {
                    MessageBox.Show("账号长度大于11位"); return;
                }
                
                if (textBox2.Text.Length > 16)
                {
                    MessageBox.Show("请输入正确新密码，密码小于16位"); return;
                }
                if (textBox2.Text.Length < 5)
                {
                    MessageBox.Show("请输入正确新密码，密码大于5位"); return;
                }
                if (textBox9.Text != textBox2.Text)
                {
                    MessageBox.Show("重复输入密码不一致"); return;
                }
                else
                {
                    DB.Execute("insert into Employer(EmployerID,passwords,EmpName,Lincense,tel,Area) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "')");
                    MessageBox.Show("注册成功");
                    this.Close();
                }
               
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            Size Size = new Size(520, 505);
            this.Size = Size;
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            Size Size = new Size(520, 505);
            this.Size = Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
