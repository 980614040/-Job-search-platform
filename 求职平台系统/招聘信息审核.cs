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
    public partial class 招聘信息审核 : Form
    {
        public 招聘信息审核()
        {
            InitializeComponent();
        }

        private void 招聘信息审核_Shown(object sender, EventArgs e)
        {
            
            string sql1 = "select EmpName  from Employer,recruitment where Recruitment.EmployerID=Employer.EmployerID and recruitment.states=0";
            DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
            comboBox1.DataSource = dv1;
            comboBox1.ValueMember = "EmpName";
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "select Recruitment.*,area,Lincense,empdescribes from Recruitment,Employer where Recruitment.EmployerID=Employer.EmployerID and Employer.EmpName like '%" + comboBox1.Text + "%'and recruitment.states=0";
                DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                
                label8.Text = dv1[0]["Lincense"].ToString();
                label9.Text = dv1[0]["salary"].ToString();
                label10.Text = dv1[0]["area"].ToString();
                textBox3.Text = dv1[0]["JobDescribes"].ToString();
                textBox2.Text = dv1[0]["empdescribes"].ToString();
                label12.Text = dv1[0]["RecruitmentID"].ToString();
                
            }
            catch (Exception y)
            { }
           
        }

        private void 招聘信息审核_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
                 try
                    {
                        string sql2 = "update Recruitment set States=-1 from Employer,Recruitment where Employer.EmployerID=Recruitment.EmployerID and RecruitmentID='" + label12.Text + "'";
                        DB.Execute(sql2);
                        comboBox1.Text = "春木镇幼儿园";
                        string sql1 = "select Recruitment.*,area,Lincense,empdescribes from Recruitment,Employer where Recruitment.EmployerID=Employer.EmployerID and Employer.EmpName like '%" + comboBox1.Text + "%'and recruitment.states=0";
                        DataView dv1 = DB.GetDs(sql1).Tables[0].DefaultView;
                        comboBox1.Text = dv1[0]["EMPNAME"].ToString();
                        label8.Text = dv1[0]["Lincense"].ToString();
                        label9.Text = dv1[0]["salary"].ToString();
                        label10.Text = dv1[0]["area"].ToString();
                        textBox3.Text = dv1[0]["JobDescribes"].ToString();
                        textBox2.Text = dv1[0]["empdescribes"].ToString();
                       
                    }
                    catch (Exception y)
                    { }
                 
                 MessageBox.Show("已审核");
                
                
            
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sql3 = "select employer.employerid from employer,Recruitment where Recruitmentid='" + label12.Text + "'and employer.employerid=Recruitment.employerid";
            DataView dv3 = DB.GetDs(sql3).Tables[0].DefaultView;
            string employerid=dv3[0]["employerid"].ToString();
                  
                            string sql1 = "update Recruitment set States=1 from Employer,Recruitment where Employer.EmployerID=Recruitment.EmployerID and RecruitmentID='" + label12.Text + "'";
                            DB.Execute("update balance set balance=(select balance from balance where accountid='" + employerid + "')-5 where accountid='" + employerid + "'");
                            DB.Execute(sql1);
                            MessageBox.Show("已审核");
                        
            
            
        }
    }
}
