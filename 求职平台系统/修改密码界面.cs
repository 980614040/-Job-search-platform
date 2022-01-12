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
    public partial class 修改密码界面 : Form
    {
        public 修改密码界面()
        {
            InitializeComponent();
        }
        
        private void 修改密码界面_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            


        }
        string z = "";
        public string i;
        public int y;
        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            
            if (y == 1)
            {
                string sql1 = "select passwords from administrator where adminid='" + label2.Text + "'";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                s = dv1[0]["passwords"].ToString(); 
            }
            else if (y == -1)
            {
                string sql1 = "select passwords from employees where employeeid='" + label2.Text + "'";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                s = dv1[0]["passwords"].ToString(); 
            }
            else if (y == 0)
            {
                string sql1 = "select passwords from employer where employerid='" + label2.Text + "'";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                s = dv1[0]["passwords"].ToString(); 
            }

            if (s!=z)
            {
                MessageBox.Show("原密码错误");
                return;
            }
            if (textBox2.Text.Length > 16)
            {
                MessageBox.Show("请输入正确新密码，密码小于16位"); return;
            }
            if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("请输入正确新密码，密码大于5位"); 
                return;
            }
            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("重复输入密码不一致"); return;
            }
            else
            {
                if (y == 1)
                {
                    DB.Execute("update administrator set passwords='" + textBox2.Text + "' where adminid='" + i + "'");
                    MessageBox.Show("修改成功"); this.Close();
                }
                else if (y == -1)
                {
                    DB.Execute("update employees set passwords='" + textBox2.Text + "' where employeeid='" + i + "'");
                    MessageBox.Show("修改成功"); this.Close();
                }
                else if (y == 0)
                {
                    DB.Execute("update employer set passwords='" + textBox2.Text + "' where employerid='" + i + "'");
                    MessageBox.Show("修改成功"); this.Close();
                }
            }
        }
        
        private void 修改密码界面_Shown(object sender, EventArgs e)
        {
            label2.Text = i;
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            z =textBox1.Text.ToString();
            textBox1.PasswordChar = '*';
        }
    }
}
