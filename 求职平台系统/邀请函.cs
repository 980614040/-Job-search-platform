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
    public partial class 邀请函 : Form
    {
        public 邀请函()
        {
            InitializeComponent();
        }
        public string employeeid, employerid;
        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from employerblacklist where employeeid='" + employeeid + "'and employerid='" + employerid + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            if (dv1.Count > 0)
            { MessageBox.Show("该求职者在黑名单中！"); return; }
            else
            {
                string sql2 = "select * from employeeblacklist where employeeid='" + employeeid + "'and employerid='" + employerid + "'";
                DataView dv2 = DB.GetDs(sql2).Tables[0].DefaultView;
                if (dv2.Count > 0)
                { MessageBox.Show("该求职者在黑名单中！"); return; }
                else
                {
                    string i;
                    string sql3 = "select * from invite ";
                    DataView dv3 = DB.GetDs(sql3).Tables[0].DefaultView;
                    i = (dv3.Count + 1).ToString();
                    DB.Execute("insert into invite(inviteID,EmployerID,employeeid,salary,JobDescribes,states) values('21250" + "" + i + "','" + employerid + "','" + employeeid + "','" + textBox1.Text + "','" + textBox2.Text + "',1)");
                    MessageBox.Show("邀请成功，请等待！");
                    this.Close();


                }
            }
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
