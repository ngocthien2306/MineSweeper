using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TROCHOIDOMIN
{
    public partial class THANGGAME : Form
    {
        Form1 ori;
        public THANGGAME(Form1 incom)
        {
            ori = incom;
            InitializeComponent();
        }
        public int nBoom, nHang, nCot;
        public int thoigian;
        private void THANGGAME_Load(object sender, EventArgs e)
        {
            ori.timer1.Stop();
            ori.Enabled = false;
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
            lb_thoigian.Text = thoigian + " giây";
            kiemtra();
        }

        public void kiemtra() {
            StreamReader file = new StreamReader(@"text\diemcao.txt");
            string S = file.ReadToEnd();
            string[] strS = S.Split('-');
            int diem=0;
            string de="0 giây", vua="0 giây", kho="0 giây", custom="0 giây";
            de = strS[0];
            vua = S = strS[1];
            kho = S = strS[2];
            custom = S = strS[3];

            if (ori.cb_level.Text == "Dễ")
            {
                
                string[] de1 = de.Split(' ');
                diem = Int32.Parse(de1[0]);
            }
            else if (ori.cb_level.Text == "Vừa")
            {
                
                string[] vua1 = vua.Split(' ');
                diem = Int32.Parse(vua1[0]);

            }
            else if (ori.cb_level.Text == "Khó")
            {
               
                string[] kho1 = kho.Split(' ');
                diem = Int32.Parse(kho1[0]);

            }
            else
            {
                
                string[] custom1 = custom.Split(' ');
                diem = Int32.Parse(custom1[0]);

            }
            file.Close();
            if (thoigian < diem || diem == 0)
            {   
                label1.Text = "PHÁ KỶ LỤC!!";
                File.Delete(@"text\diemcao.txt"); //xóa file cũ
                StreamWriter w = new StreamWriter(@"text\diemcao.txt", true); //true nếu chưa có file 
                if (ori.cb_level.Text == "Dễ")
                {
                    w.WriteLine(thoigian+" giây"+"-"+vua+"-"+kho+"-"+custom);
                    

                }
                else if (ori.cb_level.Text == "Vừa")
                {
                    w.WriteLine(de+"-"+thoigian + " giây" + "-" + kho + "-" + custom);

                }
                else if (ori.cb_level.Text == "Khó")
                {
                    w.WriteLine(de + "-" +vua+ "-" + thoigian + " giây" + "-" + custom);

                }
                else
                {
                    w.WriteLine(de+"-"+vua+"-"+kho+"-"+thoigian + " giây");
                }

                w.Close();

            }
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ori.Enabled = true;
            this.Close();
        }

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
    }
}
