using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TROCHOIDOMIN
{
    public partial class HUONGDAN : Form
    {
        Form1 ori;
        public HUONGDAN(Form1 f2)
        {
            ori = f2;
            InitializeComponent();
        }

        private void HUONGDAN_Load(object sender, EventArgs e)
        {
            ori.timer1.Stop();
            ori.Enabled = false;
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://facebook.com/kusok.kg123");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ori.stopgame == false && ori.clickFirst == false)
            {
                ori.timer1.Enabled = true;
                ori.timer1.Start();
                Thread.Sleep(200);
            }
            ori.cb_level.Focus();
            ori.Enabled = true;
            this.Close();
        }
    }
}
