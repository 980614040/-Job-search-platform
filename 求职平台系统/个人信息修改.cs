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
    public partial class 个人信息修改 : Form
    {
        public 个人信息修改()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public string employeeid;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入完整信息"); return;
            }
            if (comboBox3.Text == "")
            {
                MessageBox.Show("请输入完整信息"); return;
            }
            if (radioButton3.Checked == false && radioButton4.Checked == false)
            { 
                MessageBox.Show("请输入完整信息"); return;
            }
            if (textBox5.Text.Length != 11)
            {
                MessageBox.Show("请输入正确手机号"); return;
            }
            if (numericUpDown1.Value < 18)
            {
                MessageBox.Show("请输入正确年龄"); return;
            }
            if ((!Regex.IsMatch(textBox2.Text, @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
            {
                MessageBox.Show("请输入正确身份证号"); return;
            }
            if (textBox2.Text == "")
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
            
            else
            {
                string sex = "";
                if (radioButton3.Checked)
                {
                    sex = "男";
                }
                if (radioButton4.Checked)
                {
                    sex = "女";
                }
                DB.Execute("update employees set EmpName='"+ textBox1.Text + "' where employeeid='"+employeeid+"'");
                DB.Execute("update employees set area='"+comboBox3.Text+"' where employeeid='"+employeeid+"'");
                DB.Execute("update employees set sex='"+sex+"' where employeeid='"+employeeid+"'");
                DB.Execute("update employees set age='"+numericUpDown1.Value+"' where employeeid='"+employeeid+"'");
                DB.Execute("update employees set email='"+textBox4.Text+"' where employeeid='"+employeeid+"'");
                DB.Execute("update employees set workyear='"+numericUpDown2.Value+"' where employeeid='"+employeeid+"'");
                DB.Execute("update employees set identify='"+textBox2.Text+"' where employeeid='"+employeeid+"'");
                DB.Execute("update employees set tel='"+textBox5.Text+"' where employeeid='"+employeeid+"'");
                MessageBox.Show("修改成功");
                this.Close();
                
            }
        }

        private void 个人信息修改_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void 个人信息修改_Shown(object sender, EventArgs e)
        {
            string sql1 = "select Employees.EmployeeID,Employees.EmpName,Employees .Sex,Employees .Age,Employees .Workyear,Employees.Area,Employees .States,Employees .EmpDescribes,Employees.Blacklist,Employees .Identify,Employees .Email,Employees .tel from Employees where employeeid='" + employeeid + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            textBox1.Text = dv1[0]["empname"].ToString();
            comboBox3.Text = dv1[0]["area"].ToString();
            Object workyear=dv1[0]["workyear"];
            numericUpDown2.Value = Convert.ToDecimal(workyear);
            string sex = dv1[0]["sex"].ToString();
            if (sex == "男")
            { 
                radioButton3.Checked = true;
                radioButton4.Checked = false;
            }
            else if (sex == "女")
            { 
                radioButton4.Checked = true; 
                radioButton3.Checked = false; 
            }
            Object age = dv1[0]["age"];
            numericUpDown1.Value = Convert.ToDecimal(age);
            textBox2.Text= dv1[0]["identify"].ToString();
            textBox4.Text = dv1[0]["email"].ToString();
            textBox5.Text = dv1[0]["tel"].ToString();
            
        }
    }
}
