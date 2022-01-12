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
    public partial class 管理者窗体 : Form
    {
        public 管理者窗体()
        {
            InitializeComponent();
        }

        private void 缴费管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 缴费记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 删除招聘信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询招募信息 z = new 查询招募信息();
            z.ifhavebutton = false;
            z.ShowDialog();

        }

        private void 求职人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询求职人员 z = new 查询求职人员();
            z.ifhavebutton = false;
            z.ShowDialog();
        }

        private void 删除招聘信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new 删除招聘信息().ShowDialog();
        }

        private void 招聘信息审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 招聘信息审核().ShowDialog();
        }

        private void 缴费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 缴费设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 管理招聘信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public string i;
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            修改密码界面 z = new 修改密码界面();
            z.i = this.i;
            z.y = 1;
            z.ShowDialog();
        }
        
       
       
        private void 管理者窗体_Load(object sender, EventArgs e)
        {
            
        }
    }
}
