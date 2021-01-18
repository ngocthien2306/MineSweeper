using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using WMPLib;
using System.IO;

namespace TROCHOIDOMIN
{
    public partial class Form1 : Form
    {
        // lớp CELL là mỗi ô trong trò chơi
        public class CELL
        {
            public Button bt; //button hiện thị trên game để người dùng chọn
            public Boolean open; // đánh dấu ô được mở là true
            public Boolean flag; // đánh dấu ô được người chơi gắn cờ có boom là true
            public int boom; //số boom xung quanh CELL (từ 0-8) -1 là boom
        }
        public Boolean stopgame = false;
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        CELL[,] cell; int x; int y; int nflag; string level;
        public int nHang, nCot, nboom;
        public Boolean clickFirst = false;
        public void khoitao(int nCot,int nHang)
        {
            for (int i = 0; i < nHang; i++)
            {
                for (int j = 0; j < nCot; j++)
                {
                    cell[i, j] = new CELL(); //số ô           
                    cell[i, j].bt = new Button(); //các button
                    cell[i, j].open = false; // chưa mở
                    cell[i, j].flag = false; // chưa gắn cờ
                    cell[i, j].boom = 0; // số boom 0
                }
            }

        }
        //khởi tạo game với tham số truyền vào là số boom, số hàng, số cột
        public void StartGame(int nBoom, int nCot, int nHang)
        {
            clickFirst = true;
            string duongdan = @"pictures\binhthuong1.png";
            pic_trangthai.Image = Image.FromFile(duongdan);
            if (click == 1)
            {
                sound.URL = @"sounds\coin.mp3";
                sound1.URL = @"sounds\nhacnengame.mp3";
                sound1.settings.setMode("loop", true); 
            }
            this.nHang = nHang;
            this.nCot = nCot;
            this.nboom = nBoom;
            nflag = nBoom;
            label_flag.Text = nflag + "";
            cell = new CELL[nHang, nCot]; //game với nHàng và ncột
            khoitao(nCot, nHang);
            //VẼ Ô
            paintCELL(nBoom, nCot, nHang);
            //ĐẶT BOOM
            Random rd = new Random(); //random boom
            //Random rdC = new Random(); //random boom
            int b = 0; //số boom đã được đặt
            while (b != nBoom)
            { //cho dòng while chạy đến khi đặt đc hết số boom truyền vào
                int hang = rd.Next(1, nHang);
                int cot = rd.Next(1, nCot);
                if (cell[hang, cot].boom != -1) //nếu ô [h,c] được chọn đặt boom chưa được đặt
                {
                    cell[hang, cot].boom = -1; // cho ô này là boom
                    b++; //số boom đã đặt tăng lên
                }
            }
            //for (int i = 0; i < nHang; i++)
            //{
            //    for (int j = 0; j < nCot; j++)
            //    {
            //        if (cell[i, j].boom == -1)
            //        {
            //            MessageBox.Show("có boom: [" + i + "-" + j + "]");
            //        }
            //    }
            //}

            //ĐẾM BOOM

            for (int i = 0; i < nHang; i++)
            { 
                for (int j = 0; j < nCot; j++)
                {
                    cell[i, j].boom = countBoom(i, j, nHang, nCot);
                   // MessageBox.Show("số boom:" + cell[i, j].boom);
                }
            }
        }
        public int countBoom(int x, int y, int nHang, int nCot)
        { //vị trí của ô
            int b = 0;
            if (cell[x, y].boom == -1) // là trái boom
                b = -1;
            else
            {

                for (int i = x - 1; i <= x + 1; i++)
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i != -1 && j != -1 && i != nHang && j != nCot)
                            if (cell[i, j].boom == -1)
                                b++;
                    }
            }
            return b;
        }

        public int countFlag(int x, int y, int nHang, int nCot)
        {
            int b = 0;
                for (int i = x - 1; i <= x + 1; i++)
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i != -1 && j != -1 && i != nHang && j != nCot)
                            if (cell[i, j].flag == true)
                                b++;
                    }
            return b;
        
        }

        public void tomauSo() {
            for (int i = 0; i < nHang; i++)
            {
                for (int j = 0; j < nCot; j++)
                {
                    if (cell[i, j].boom == 1)
                    {
                        cell[i, j].bt.ForeColor = System.Drawing.Color.Blue;
                    }
                    else if (cell[i, j].boom == 2)
                    {
                        cell[i, j].bt.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (cell[i, j].boom == 3)
                    {
                        cell[i, j].bt.ForeColor = System.Drawing.Color.Orange;

                    }
                    else if (cell[i, j].boom == 4)
                    {
                        cell[i, j].bt.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                        cell[i, j].bt.ForeColor = System.Drawing.Color.DarkRed;
                }
            }
        }
        int size = 45;
        public void paintCELL(int nBoom, int nCot, int nHang) {
            size = 45;
            Font f = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            int x = 0, y = 0;
            if ((nCot > 34 && nCot <= 45) || (nHang > 18 && nHang <= 22))
            {
                size = 30;
                f = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
            }
            if (size > 30) {
                if ((nCot > 26 && nCot <= 34)|| (nHang>11 && nHang <=18))
                    size = 35;                        
            }

            //Vẽ lại kích thước
            panel3.Hide();
            
            panel1.Size = new System.Drawing.Size(size * nCot, 55);
            panel2.Size = new System.Drawing.Size(size * nCot, size * nHang+10);
            this.Size = new System.Drawing.Size(size * nCot + 16, size * nHang + 95);
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
            panel3.Show();
            
 

            Color a = System.Drawing.Color.LightSkyBlue;
            Color b = System.Drawing.Color.DeepSkyBlue;
            for (int i = 0; i < nHang; i++)
            {
                for (int j = 0; j < nCot; j++)
                {
                    if (nCot % 2 == 0)
                    {
                        if (i % 2 == 0) {
                            if (j % 2==0)
                                cell[i, j].bt.BackColor = a;
                            else
                                cell[i, j].bt.BackColor = b;

                        }
                        else {
                            if (j % 2 == 1)
                                cell[i, j].bt.BackColor = a;
                            else
                                cell[i, j].bt.BackColor = b;
                        }
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                                cell[i, j].bt.BackColor = b;
                            else
                                cell[i, j].bt.BackColor = a;

                        }
                        else
                        {
                            if (j % 2 == 1)
                                cell[i, j].bt.BackColor = b;
                            else
                                cell[i, j].bt.BackColor = a;
                        }
                    }
                    cell[i, j].bt.Font = f;
                    if (cell[i, j].boom == 1) {
                        cell[i, j].bt.ForeColor = System.Drawing.Color.Blue;
                    }
                    else if (cell[i, j].boom == 2) {
                        cell[i, j].bt.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (cell[i,j].boom == 3)
                        cell[i, j].bt.ForeColor = System.Drawing.Color.Red;
                    else
                        cell[i, j].bt.ForeColor = System.Drawing.Color.Orange;
                    
                    cell[i, j].bt.Location = new System.Drawing.Point(x, y);
                    x += size;
                    cell[i, j].bt.Name = i + "-" + j;
                    cell[i, j].bt.Size = new System.Drawing.Size(size+1, size+1);
                    panel2.Controls.Add(cell[i, j].bt);
                    //cell[i, j].bt.FlatAppearance.BorderSize = 10;
                    cell[i, j].bt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    //cell[i, j].bt.TabIndex = 0;
                    cell[i, j].bt.Text = "";
                    //bt1.Click += new System.EventHandler(this.bt1_Click);
                    //cell[i, j].bt.Click += new System.EventHandler(this.bt_Click);
                    cell[i, j].bt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_MouseDown);
                    
                    panel2.Controls.Add(cell[i, j].bt);

                }

                x = 0;
                y = y + size;
            }

        
        }


        //sự kiện click chuột vào ô

        private void bt_MouseDown(object sender, MouseEventArgs e)
        {
            Button TX = ((Button)sender);
            string str = TX.Name.ToString().Trim();
            string[] toado = str.Split('-');
            //gán tọa độ
            x = Int32.Parse(toado[0]);
            y = Int32.Parse(toado[1]);
            //MessageBox.Show("" + countBoom(x, y, nHang, nCot));
            //MessageBox.Show("" + countFlag(x, y, nHang, nCot));
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                rightMouse(x,y);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                leftMouse(x,y);   
            }    
        }

        public void rightMouse(int x, int y){
            string duongdan = @"pictures\error.png";
            
            if (cell[x, y].open == false)
            {
                if (cell[x, y].flag == true)
                {
                    cell[x, y].bt.Image = null;
                    cell[x, y].flag = false;
                    nflag = Int32.Parse(label_flag.Text) + 1;
                    label_flag.Text = nflag + "";
                   

                }
                else
                {
                    //sound.URL = @"G:\Visual Studio\TROCHOIDOMIN\TROCHOIDOMIN\sound\flag2.ogg";
                    cell[x, y].flag = true;
                    cell[x, y].bt.Image = Image.FromFile(duongdan);
                    nflag = Int32.Parse(label_flag.Text) - 1;
                    label_flag.Text = nflag + "";
                    
                }
            }
            if (nflag==0)
                if (testWin() == true) {
                    wingame(x,y);
                }
    
        }

        public void tomauCell(int a, int b){
            if (a % 2 != 1)
            {
                if (b % 2 != 1)
                    cell[a, b].bt.BackColor = System.Drawing.Color.DarkGray;
                else
                    cell[a, b].bt.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                if (b % 2 != 1)
                    cell[a, b].bt.BackColor = System.Drawing.Color.Gray;
                else
                    cell[a, b].bt.BackColor = System.Drawing.Color.DarkGray;
            }
        }
        //int a = 0, b = 0; int dem = 0;
        public void leftMouse(int x, int y){
            if (cell[x, y].flag != true)
            {
                if (clickFirst == true)
                {
                    timer1.Enabled = true;
                    timer1.Start();
                    clickFirst = false;
                }
                if (cell[x, y].open == false)
                {

                    //Tô màu ô mở
                    tomauCell(x, y);

                    //
                    if (cell[x, y].boom == -1) //chọn trúng boom
                    {
                        if (click == 1)
                        {
                            sound.URL = @"sounds\gameoversound.mp3";

                            sound1.URL = @"sounds\boom_1.mp3";
   
                        }
                        selectBoom(x, y);
                    }
                    else if (cell[x, y].boom == 0)
                    { //   chọn ngay ô trống 
                        if (click == 1)
                        {
                            sound.URL = @"sounds\coin.mp3";
      
                        }
                        selectEmpty(x, y);
                    }
                    else //chọn ô có số
                        selectSafe(x, y);

                }
                else
                {
                    if (cell[x, y].boom > 0)
                    {
                        if (cell[x, y].boom <= countFlag(x, y, nHang, nCot))
                            openQuick(x, y);
                    }
                }
            }
        }
        public void openQuick(int x, int y) {
            
            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i != -1 && j != -1 && i != nHang && j != nCot)
                    {
                        if (cell[i, j].flag == false && cell[i, j].open == false)
                        {
                            leftMouse(x, y);
                        }
                    }
                }              
        }

        public Boolean testWin() {
            int flagged = 0;
            int flag = Int32.Parse(label_flag.Text);
            if (flag == 0)
            {
                for (int i = 0; i < nHang; i++)
                    for (int j = 0; j < nCot; j++)
                    {
                        if (cell[i, j].boom == -1 && cell[i, j].flag == true)
                        {
                            flagged++;
                        }
                    }
                if (nboom == flagged)
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public void wingame(int a, int b) {
            if (click ==1)
            sound1.URL = @"sounds\win1.wav";
            sound1.settings.setMode("loop", false); 
            string boom = @"pictures\bomb45.png";
            if (size == 35)
            {
                boom = @"pictures\bomb35.png";
            }
            if (size == 30)
            {
                boom = @"pictures\bomb30.png";
            }
            for (int i = 0; i < nHang; i++)
            {
                for (int j = 0; j < nCot; j++)
                {
                    if (cell[i, j].boom == -1)
                    {
                        cell[i, j].bt.Image = Image.FromFile(boom);
                        cell[i, j].bt.BackColor = System.Drawing.Color.LightYellow;
                        cell[i, j].open = true;
                    }
                    else
                    {
                        cell[i, j].open = true;
                    }
                }
            }
            endgame();
            string duongdan = @"pictures\vuive.png";
            pic_trangthai.Image = Image.FromFile(duongdan);
            THANGGAME tf = new THANGGAME(this);
            tf.nBoom = nboom;
            tf.nHang = nHang;
            tf.nCot = nCot;
            tf.thoigian = Int32.Parse(label_time.Text);
            tf.Show();
        }

        public void selectBoom(int a, int b) {
            string boom = @"pictures\bomb45.png";
            if (size == 35) {
                boom = @"pictures\bomb35.png";
            }
            if (size == 30) {
                boom = @"pictures\bomb30.png";
            }
            //string boom = @"\bomb2.png";   
            for (int i = 0; i < nHang; i++)
            {        
                for (int j = 0; j < nCot; j++)
                {  
                    if (cell[i, j].boom == -1)
                    {
                        
                        cell[i, j].bt.Image = Image.FromFile(boom);

                        cell[i, j].bt.BackColor = System.Drawing.Color.LightYellow;
                            if (i == a && j == b)
                            cell[i, j].bt.BackColor = System.Drawing.Color.Red;
                        cell[i, j].open = true;
                        
                        

                    }
                    else
                    {
                        cell[i, j].open = true;
                    }
                }
            }
            endgame();
            string duongdan = @"pictures\buon.png";
            pic_trangthai.Image = Image.FromFile(duongdan);
            THUAGAME tf = new THUAGAME(this);
            tf.nBoom = nboom;
            tf.nHang = nHang;
            tf.nCot = nCot;
            tf.Show();
        }
        public void endgame() {

            timer1.Stop();
            stopgame = true;
            stopgame = false;
            clickFirst = false;
        
        }
        public void resetGame() {
            for (int i = 0; i < nHang; i++)
                for (int j = 0; j < nCot; j++)
                    cell[i, j].bt.Hide();
            timer1.Stop();
            cb_level.Focus();
            label_time.Text = "0";
            
        }

        public void selectEmpty(int a, int b) {
            openEmpty(a,b);
        }

        public void openEmpty(int a, int b){
            tomauCell(a,b);
            //cell[a, b].bt.Image = null;
            cell[a, b].open = true;
            for (int i = a - 1; i <= a + 1; i++)
                for (int j = b - 1; j <= b + 1; j++)
                {
                    if (i != -1 && j != -1 && i != nHang && j != nCot)
                    {
                        if (cell[i, j].boom == 0 && cell[i, j].open == false)
                        {
                            openEmpty(i, j);
                        }
                        if (cell[i, j].boom != 0 && cell[i, j].boom != -1) {
                            selectSafe(i,j);
                            tomauCell(i,j);
                            //cell[i, j].bt.Image = null;
                        }
                    }

                            
                }
        }
        public void selectSafe(int a, int b) {
            cell[a, b].bt.Text = cell[a, b].boom.ToString();
            cell[a, b].open = true;
            cell[a, b].bt.Image = null;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_level.Text = "Dễ";
            level = cb_level.Text;

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tg = Int32.Parse(label_time.Text) + 1;
            label_time.Text = tg.ToString();
        }

        private void cb_level_TextChanged(object sender, EventArgs e)
        {
            level = cb_level.Text;
            if (cb_level.Text != "Custom")
            {

                try
                {
                    resetGame();
                }

                catch
                {

                }
            }
            else
            {

            }
            if (cb_level.Text == "") { }
            else if (cb_level.Text == "Dễ")
            {
                StartGame(10, 10, 8);    //mim 10-6      
            }
            else if (cb_level.Text == "Vừa")
            {

                StartGame(35, 18, 14); //18-14               
            }
            else if (cb_level.Text == "Khó")
            {

                StartGame(70, 24, 20); //24-20     44-22       
            }
            else
            {
                try
                {
                    StreamReader rc = new StreamReader(@"text\custom.txt");
                    string S = rc.ReadToEnd();
                    string[] strS = S.Split('-');
                    int boom = Int32.Parse(strS[0]);
                    int hang = Int32.Parse(strS[1]);
                    int cot = Int32.Parse(strS[2]);
                    rc.Close();
                    resetGame();
                    StartGame(boom, cot, hang);
                }
                catch {
                    resetGame();
                    StartGame(10, 10, 10);
                }
                
            }
            tomauSo();
          
        }

        int click = 1;
        WindowsMediaPlayer sound1 = new WindowsMediaPlayer();

        private void pic_music_Click(object sender, EventArgs e)
        {
            string duongdan;
            
        if (click == 0)
        {
            
            duongdan = @"pictures\audio_high.png";
            sound1.controls.play();
            click++;        
        }
        else
        {
            duongdan = @"pictures\audio_mute.png";
            sound1.controls.pause();
            click--;
        }

            pic_audio.Image = Image.FromFile(duongdan);

        }
 

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        public void newGame() {
            level = cb_level.Text;
            if (cb_level.Text != "Custom")
            {

                try
                {
                    resetGame();
                }

                catch
                {

                }
            }
            else
            {

            }
            if (cb_level.Text == "") { }
            else if (cb_level.Text == "Dễ")
            {
                StartGame(10, 10, 8);    //mim 10-6      
            }
            else if (cb_level.Text == "Vừa")
            {

                StartGame(35, 18, 14); //18-14               
            }
            else if (cb_level.Text == "Khó")
            {

                StartGame(70, 24, 20); //24-20     44-22       
            }
            else
            {

                int boom = nboom;
                int cot = nCot;
                int hang = nHang;
                resetGame();
                StartGame(boom, cot, hang);
            }
            tomauSo();
        
        }
        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KyLuc f = new KyLuc(this);
            f.Show();
        }

        private void tùyChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Custom cus = new Custom(this);
                cus.Show();          
        }

        private void hướngDẫnCáchChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HUONGDAN hd = new HUONGDAN(this);
            hd.Show();
        }

        private void pic_trangthai_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About tt = new About(this);
            tt.Show();
        }


    }


}
