using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TROCHOIDOMIN
{
    public partial class THUAGAME : Form
    {
        Form1 ori;
        public THUAGAME(Form1 incom)
        {
            ori = incom;
            InitializeComponent();
        }
        public int nBoom, nHang, nCot;
        private void button1_Click(object sender, EventArgs e)
        {
            ori.Enabled = true;
            this.Close(); 
            ori.resetGame();

            if (ori.cb_level.Text == "Dễ")
            {
                ori.StartGame(10, 10, 8);
            }
            else if (ori.cb_level.Text == "Vừa")
            {
                ori.StartGame(35, 18, 14); //18-14
            }
            else if (ori.cb_level.Text == "Khó")
            {
                ori.StartGame(70, 24, 20); //24-20
            }
            else
            {
                
                ori.StartGame(nBoom, nCot, nHang);
            }
            ori.tomauSo();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ori.Enabled = true;
            this.Close();
        }

        private void THUAGAME_Load(object sender, EventArgs e)
        {
            ori.Enabled = false;
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
        }

    }
}
