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
    public partial class 发布招聘信息 : Form
    {
        public 发布招聘信息()
        {
            InitializeComponent();
        }

        public bool isupdate;
        public string RecruitmentID;
        public bool isemployer;
        public string employeeid;
        public string employerid;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox3.Text != ""&&textBox1.Text!="")
            {
                    
                    if (!isupdate)
                    {
                        string sql2 = "select balance from balance where accountid=" + employerid + "";
                        DataView dv2= DB.GetDs(sql2).Tables[0].DefaultView;
                        float balance=Convert.ToSingle( dv2[0]["balance"].ToString());
                        if (balance < 5)
                            MessageBox.Show("余额不足五元，请充值！");
                        else
                        {
                            string i;
                            string sql1 = "select * from Recruitment ";
                            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                            i = (dv1.Count + 1).ToString();
                            DB.Execute("insert into Recruitment(RecruitmentID,EmployerID,salary,JobDescribes,states) values('2000000000" + "" + i + "','" + label11.Text + "','" + textBox1.Text + "','" + textBox3.Text + "',0)");
                            DB.Execute("update balance set balance=(select balance from balance where accountid='" + employerid + "')-5 where accountid='" + employerid + "'");
                            MessageBox.Show("发布成功，请等待审核");
                            this.Close();
                        }
                    }
                    else if(isupdate)
                    {
                        DB.Execute("update Recruitment set JobDescribes='" + textBox3.Text + "' where RecruitmentID='" + RecruitmentID + "'");
                        DB.Execute("update Recruitment set states=0 where RecruitmentID='" + RecruitmentID + "'");
                        DB.Execute("update Recruitment set salary="+textBox1.Text+" where RecruitmentID='" + RecruitmentID + "'");
                        MessageBox.Show("修改成功，请等待审核");
                        this.Close();
                    }
            }
            else
            {MessageBox.Show("请输入完整信息！");return;}
        }
        public string a,b,c,d,f,g,h;
        private void 发布招聘信息_Load(object sender, EventArgs e)
        {
           
            
        }
        
        private void 发布招聘信息_Shown(object sender, EventArgs e)
        {
            if (isemployer)
            {
                label6.Text = a;
                label8.Text = b;
                textBox2.Text = c;
                label9.Text = d;
                label11.Text = f;
                textBox3.Text = g;
                textBox1.Text = h;
                button3.Visible = false;
                textBox1.ReadOnly = false;
                textBox3.ReadOnly = false;
                button4.Visible = false;
                button5.Visible = false;
            }
            else
            {
                Console.Write(employeeid + "!!!!!!!!!!!!!!!!");//出错原因，employerid没有从父窗口调用。
                Console.Write(employerid+"!!!!!!!!!!!!!!!!");//出错原因，employerid没有从父窗口调用。
                string sql1 = "select Employer.EmployerID,Employer.EmpName,Employer.Area,Employer.States,Employer.EmpDescribes,Employer.JobDescribes,Employer.JobDescribes,Employer.Lincense,Employer.Blacklist,Employer.Email,Employer.tel,Recruitment.salary from Employer,Recruitment,invite where  employer.employerid=recruitment.employerid and  employer.employerid=invite.employerid and invite.employerid='" + employerid + "'";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
               

                button1.Visible = false;
                textBox1.ReadOnly = true;
                textBox3.ReadOnly = true;
                
                
                    label8.Text = dv1[0]["Lincense"].ToString();
                    textBox1.Text = dv1[0]["salary"].ToString();
                    label9.Text = dv1[0]["area"].ToString();
                    textBox3.Text = dv1[0]["JobDescribes"].ToString();
                    textBox2.Text = dv1[0]["empdescribes"].ToString();
                    label6.Text = dv1[0]["empname"].ToString();
                    label11.Text = dv1[0]["EmployerID"].ToString();
                   
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from employeeblacklist where employeeid='" + employeeid + "'and employerid='" + employerid + "'";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            if (dv1.Count > 0)
            { MessageBox.Show("该用人单位已在黑名单中！"); return; }
            else
            {
                string sql2 = "insert into employeeblacklist(employerid,employeeid) values('" + employerid + "','" + employeeid + "') ";
                DB.Execute(sql2);
                MessageBox.Show("添加成功！");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql2 = "select balance from balance where accountid=" + employeeid + "";
                        DataView dv2= DB.GetDs(sql2).Tables[0].DefaultView;
                        float balance=Convert.ToSingle( dv2[0]["balance"].ToString());
                        if (balance < 5)
                            MessageBox.Show("余额不足五元，请充值！");
                        else
                        {
                            string sql1 = "update invite set states=0 where employerid='" + employerid + "'and employeeid='" + employeeid + "'";
                            DB.Execute(sql1);
                            DB.Execute("update balance set balance=(select balance from balance where accountid='" + employerid + "')-5 where accountid='" + employerid + "'");
                            DB.Execute("update balance set balance=(select balance from balance where accountid='" + employeeid + "')-5 where accountid='" + employeeid + "'");
                            MessageBox.Show("已经接受对方邀请，请及时联系!");
                        }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql1 = "update invite set states=2 where employerid='" + employerid + "'and employeeid='" + employeeid + "'";
            DB.Execute(sql1);
            MessageBox.Show("已经拒绝邀请");
        }
    }
}
