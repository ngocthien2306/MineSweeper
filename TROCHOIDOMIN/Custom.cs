using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TROCHOIDOMIN
{
    public partial class Custom : Form
    {
        Form1 ori;
        public string level;
        public Custom(Form1 f2)
        {
            ori = f2;
            InitializeComponent();
        }

        private void Custom_Load(object sender, EventArgs e)
        {
            ori.timer1.Stop();
            ori.Enabled = false;
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
            readCustom();
            
        }

        string btemp = "", rtemp = "", ctemp = "";
        public void readCustom() {
            StreamReader r = new StreamReader(@"text\custom.txt", true);
            try
            {
                r = new StreamReader(@"text\custom.txt", true);
                string S = r.ReadToEnd();
                string[] strS = S.Split('-');

                txt_boom.Text = strS[0];
                txt_cao.Text = strS[1];
                txt_rong.Text = strS[2];
                btemp = strS[0];
                ctemp = strS[1];
                rtemp = strS[2];
                txt_boom.Focus();
                r.Close();
            }
            catch {
                r.Close();
            }
        }

        public Boolean ktRong(){
            Boolean kq = true;
            if (txt_rong.Text==""){
                kq= false;
                
            }
            else {
                int rong = 0;
                try
                {
                    rong = Int32.Parse(txt_rong.Text);
                }
                catch { }
                if (txt_cao.Text == "")
                {
                    if (rong < 15 || rong > 45)
                    {
                        labelR.Text = "từ 15->45";
                        kq = false;
                    }
                    else kq = true;
                }
                else {
                    int cao = 0;
                    try
                    {
                        cao = Int32.Parse(txt_cao.Text);
                    }
                    catch { }
                    if (cao >= 19)
                    {
                        if (rong < 15 || rong > 45)
                        {
                            labelR.Text = "từ 15->45";
                            kq = false;
                        }
                        else kq = true;
                    }
                    else {
                        if (rong < 15 || rong > 45)
                        {
                            labelR.Text = "từ 15->45";
                            kq = false;
                        }
                        else kq = true;

                    }
                
                }

            }
            if (kq == false)
            {
                txt_rong.ForeColor = System.Drawing.Color.Red;
                txt_rong.Focus();
            }
            else {
                txt_rong.ForeColor = System.Drawing.Color.Black;
                labelR.Text = "OK!";
            }
            return kq;
        }

        public Boolean ktCao(){
            Boolean kq = true;
            if (txt_cao.Text == "") {
                kq = false;
            }
            else {
                int cao = 0;
                try
                {
                    cao = Int32.Parse(txt_cao.Text);
                }
                catch { }
                if (cao < 6 || cao > 22)
                {
                    labelC.Text = "từ 6 đến 22";
                    kq = false;
                }
                else {
                    if (cao >= 19) {

                        if (txt_rong.Text == "")
                        {
                            labelR.Text = "từ 15->45";
                        }
                        else
                        {
                            int rong = Int32.Parse(txt_rong.Text);
                            if (rong < 15)
                            {
                                labelR.Text = "từ 15->45";
                                txt_rong.ForeColor = System.Drawing.Color.Red;
                            }
                            
                        }
                    }
                    else
                    {
                        labelR.Text = "OK!";
                        txt_rong.ForeColor = System.Drawing.Color.Black;

                    }
                    kq = true; }
            }
            if (kq == false)
            {
                txt_cao.ForeColor = System.Drawing.Color.Red;
                txt_cao.Focus();
                try
                {
                    int rong = Int32.Parse(txt_rong.Text);
                    if (rong >= 10 && rong <= 45)
                    {
                        labelR.Text = "OK!";
                        txt_rong.ForeColor = System.Drawing.Color.Black;

                    }
                }
                catch { }
            }
            else
            {
                txt_cao.ForeColor = System.Drawing.Color.Black;
                labelC.Text = "OK!";
                
            }
            return kq;
        }

        public Boolean ktBoom() {
            Boolean kq = true;
            if (txt_boom.Text == "")
            {
                kq = false;
            }
            else {
                int boom = 0;
                try
                {
                    boom = Int32.Parse(txt_boom.Text);
                }
                catch { }
                if (txt_rong.Text == "" || txt_cao.Text == "")
                {
                    if (boom < 5 || boom > 198)
                    {
                        labelB.Text = "từ 5->198";
                        kq = false;
                    }
                    else kq = true;
                }
                else {
                    int rong = Int32.Parse(txt_rong.Text);
                    int cao = Int32.Parse(txt_cao.Text);
                    int tongsoo = rong * cao;
                    int max = tongsoo / 5;
                    int min = tongsoo / 12;
                    if (boom < min || boom > max)
                    {
                        labelB.Text = "từ " + min + "->" + max;
                        kq = false;

                    }
                    else kq = true;
                
                }
            }
            if (kq == false)
            {
                txt_boom.ForeColor = System.Drawing.Color.Red;
                txt_boom.Focus();
            }
            else
            {
                txt_boom.ForeColor = System.Drawing.Color.Black;
                labelB.Text = "OK!";
            }
            return kq;
        
        
        }

        public void playGame(){
            if (ori.stopgame == false && ori.clickFirst == false)
            {
                ori.timer1.Enabled = true;
                ori.timer1.Start();
                Thread.Sleep(200);
            }
            ori.cb_level.Focus();
            ori.Enabled = true;
            
                
            try
            {
                if (txt_boom.Text == btemp && txt_cao.Text == ctemp && txt_rong.Text == rtemp)
                {

                    this.Close();

                }
                else
                {
                    if (ktBoom() == true && ktCao() == true && ktRong() == true)
                    {
                        {
                            DialogResult dlr = MessageBox.Show("Kỷ lục Custom sẽ bị xóa", "Thông báo", MessageBoxButtons.OKCancel);
                            if (dlr == DialogResult.OK)
                            {
                                int rong = Int32.Parse(txt_rong.Text);
                                int cao = Int32.Parse(txt_cao.Text);
                                int boom = Int32.Parse(txt_boom.Text);
                                File.Delete(@"text\custom.txt"); //xóa file cũ
                                StreamWriter w = new StreamWriter(@"text\custom.txt", true); //true nếu chưa có file 
                                w.WriteLine(boom + "-" + cao + "-" + rong);
                                w.Close();

                                try
                                {
                                    StreamReader file = new StreamReader(@"text\diemcao.txt");
                                    string S = file.ReadToEnd();
                                    string[] strS = S.Split('-');
                                    string de = strS[0];
                                    string vua = strS[1];
                                    string kho = strS[2];
                                    string custom = "0 giây";
                                    file.Close();

                                    File.Delete(@"text\diemcao.txt"); //xóa file cũ
                                    StreamWriter fileR = new StreamWriter(@"text\diemcao.txt", true); //true nếu chưa có file 
                                    fileR.WriteLine(de+"-"+vua+"-"+kho+"-"+custom);
                                    fileR.Close();
                                }
                                catch
                                {

                                }

                                if (ori.cb_level.Text == "Custom")
                                {
                                    ori.resetGame();
                                    ori.StartGame(boom, rong, cao);
                                    ori.tomauSo();
                                    this.Close();
                                }
                                else
                                {
                                    //ori.cb_level.Text = "Custom";
                                    this.Close();
                                }



                            }
                        }
                    }


                }
            }
            catch
            {

            }
        
        }

        private void bt_close_Click(object sender, EventArgs e)
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


        private void bt_save_Click(object sender, EventArgs e)
        {
            playGame();
        }

        private void txt_boom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                playGame();
            }
        }

        private void txt_rong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            if (e.KeyChar == 13)
            {
                playGame();
            }
        }

        private void txt_cao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            if (e.KeyChar == 13)
            {
                playGame();
            }
            
        }

        private void txt_rong_TextChanged(object sender, EventArgs e)
        {
            ktRong();
        }

        private void txt_cao_TextChanged(object sender, EventArgs e)
        {
            ktCao();
        }

        private void txt_boom_TextChanged(object sender, EventArgs e)
        {
            ktBoom();
        }

        private void txt_boom_MouseClick(object sender, MouseEventArgs e)
        {
            ktBoom();
        }

        private void txt_cao_MouseClick(object sender, MouseEventArgs e)
        {
            ktCao();
        }

        private void txt_rong_MouseClick(object sender, MouseEventArgs e)
        {
            ktRong();
        }

        private void txt_boom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                ktBoom();
        }

    }
}
