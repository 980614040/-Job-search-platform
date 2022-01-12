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
    public partial class 私密简历 : Form
    {
        public 私密简历()
        {
            InitializeComponent();
        }

        public string employeeid;
        public string employerid;
        public string salary;
        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from employeeblacklist where employeeid='" + employeeid + "'and employerid='" + employerid + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            if (dv1.Count > 0)
            { MessageBox.Show("该用人单位在黑名单中！"); return; }
            else
            {
                string sql2 = "select balance from balance where accountid=" + employerid + "";
                DataView dv2 = DB.GetDs(sql2).Tables[0].DefaultView;
                float balance = Convert.ToSingle(dv2[0]["balance"].ToString());
                if (balance < 5)
                { MessageBox.Show("余额不足五元请充值！"); }
                else
                {
                    string i;
                    string sql3 = "select * from invite ";
                    DataView dv3 = DB.GetDs(sql3).Tables[0].DefaultView;
                    i = (dv3.Count + 1).ToString();
                    DB.Execute("insert into invite(inviteID,EmployerID,employeeid,salary,JobDescribes,states) values('21250" + "" + i + "','" + employerid + "','" + employeeid + "','" + salary + "','" + textBox1.Text + "',-1)");
                    MessageBox.Show("申请成功，请等待！");
                    this.Close();
                }

                
            }
               
        }

        private void 私密简历_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void 私密简历_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
