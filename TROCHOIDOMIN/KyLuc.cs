using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
namespace TROCHOIDOMIN
{
    public partial class KyLuc : Form
    {
        Form1 ori;
        public KyLuc(Form1 f2)
        {
            ori = f2;
            InitializeComponent();
        }

        private void KyLuc_Load(object sender, EventArgs e)
        {
            //string line;
            ori.timer1.Stop();
            ori.Enabled = false;
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
            try
            {
                StreamReader file = new StreamReader(@"text\diemcao.txt");
                string S = file.ReadToEnd();
                string[] strS = S.Split('-');
                lb_de.Text = strS[0];
                lb_vua.Text = strS[1];
                lb_kho.Text = strS[2];
                lb_custom.Text = strS[3];
                file.Close();
            }
            catch { 
            
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes) {
                ori.Enabled = true;
                try
                {

                    File.Delete(@"text\diemcao.txt"); //xóa file cũ
                    StreamWriter file = new StreamWriter(@"text\diemcao.txt", true); //true nếu chưa có file 
                    file.WriteLine("0 giây-0 giây-0 giây-0 giây");
                    file.Close();
                    
                }
                catch { }
                lb_de.Text = "0 giây";
                lb_vua.Text = "0 giây";
                lb_kho.Text = "0 giây";
                lb_custom.Text = "0 giây";
 
            }
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
