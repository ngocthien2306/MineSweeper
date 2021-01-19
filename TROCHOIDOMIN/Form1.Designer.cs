namespace TROCHOIDOMIN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_audio = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LanClick = new System.Windows.Forms.Button();
            this.pic_audio = new System.Windows.Forms.PictureBox();
            this.cb_level = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnCáchChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_trangthai = new System.Windows.Forms.PictureBox();
            this.label_time = new System.Windows.Forms.Label();
            this.label_flag = new System.Windows.Forms.Label();
            this.pic_flag = new System.Windows.Forms.PictureBox();
            this.pic_clock = new System.Windows.Forms.PictureBox();
            this.bt_setgame = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel_audio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_audio)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_trangthai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel_audio);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 55);
            this.panel1.TabIndex = 0;
            // 
            // panel_audio
            // 
            this.panel_audio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_audio.BackColor = System.Drawing.Color.LightCyan;
            this.panel_audio.Controls.Add(this.textBox1);
            this.panel_audio.Controls.Add(this.LanClick);
            this.panel_audio.Controls.Add(this.pic_audio);
            this.panel_audio.Controls.Add(this.cb_level);
            this.panel_audio.Location = new System.Drawing.Point(3, 3);
            this.panel_audio.Name = "panel_audio";
            this.panel_audio.Size = new System.Drawing.Size(157, 52);
            this.panel_audio.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 10;
            // 
            // LanClick
            // 
            this.LanClick.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LanClick.Location = new System.Drawing.Point(0, 27);
            this.LanClick.Name = "LanClick";
            this.LanClick.Size = new System.Drawing.Size(54, 23);
            this.LanClick.TabIndex = 3;
            this.LanClick.Text = "LAN";
            this.LanClick.UseVisualStyleBackColor = false;
            this.LanClick.Click += new System.EventHandler(this.LanClick_Click);
            // 
            // pic_audio
            // 
            this.pic_audio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic_audio.Image = ((System.Drawing.Image)(resources.GetObject("pic_audio.Image")));
            this.pic_audio.Location = new System.Drawing.Point(112, 0);
            this.pic_audio.Name = "pic_audio";
            this.pic_audio.Size = new System.Drawing.Size(41, 28);
            this.pic_audio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_audio.TabIndex = 9;
            this.pic_audio.TabStop = false;
            this.pic_audio.Click += new System.EventHandler(this.pic_music_Click);
            // 
            // cb_level
            // 
            this.cb_level.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_level.BackColor = System.Drawing.Color.LightBlue;
            this.cb_level.DisplayMember = "Dễ";
            this.cb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_level.FormattingEnabled = true;
            this.cb_level.ItemHeight = 20;
            this.cb_level.Items.AddRange(new object[] {
            "Dễ",
            "Vừa",
            "Khó",
            "Custom"});
            this.cb_level.Location = new System.Drawing.Point(0, 0);
            this.cb_level.Name = "cb_level";
            this.cb_level.Size = new System.Drawing.Size(111, 28);
            this.cb_level.TabIndex = 2;
            this.cb_level.Tag = "";
            this.cb_level.TextChanged += new System.EventHandler(this.cb_level_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pic_trangthai);
            this.panel3.Controls.Add(this.label_time);
            this.panel3.Controls.Add(this.label_flag);
            this.panel3.Controls.Add(this.pic_flag);
            this.panel3.Controls.Add(this.pic_clock);
            this.panel3.Location = new System.Drawing.Point(140, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 55);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Location = new System.Drawing.Point(0, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(63, 40);
            this.panel4.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(24, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(52, 40);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.tùyChỉnhToolStripMenuItem,
            this.hướngDẫnCáchChơiToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 36);
            this.toolStripMenuItem1.Text = "≡";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.saveGameToolStripMenuItem.Text = "Kỷ Lục";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // tùyChỉnhToolStripMenuItem
            // 
            this.tùyChỉnhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tùyChỉnhToolStripMenuItem.Name = "tùyChỉnhToolStripMenuItem";
            this.tùyChỉnhToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.tùyChỉnhToolStripMenuItem.Text = "Tùy Chỉnh";
            this.tùyChỉnhToolStripMenuItem.Click += new System.EventHandler(this.tùyChỉnhToolStripMenuItem_Click);
            // 
            // hướngDẫnCáchChơiToolStripMenuItem
            // 
            this.hướngDẫnCáchChơiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hướngDẫnCáchChơiToolStripMenuItem.Name = "hướngDẫnCáchChơiToolStripMenuItem";
            this.hướngDẫnCáchChơiToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.hướngDẫnCáchChơiToolStripMenuItem.Text = "Hướng Dẫn";
            this.hướngDẫnCáchChơiToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnCáchChơiToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pic_trangthai
            // 
            this.pic_trangthai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_trangthai.Image = ((System.Drawing.Image)(resources.GetObject("pic_trangthai.Image")));
            this.pic_trangthai.Location = new System.Drawing.Point(79, 3);
            this.pic_trangthai.Name = "pic_trangthai";
            this.pic_trangthai.Size = new System.Drawing.Size(41, 43);
            this.pic_trangthai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_trangthai.TabIndex = 8;
            this.pic_trangthai.TabStop = false;
            this.pic_trangthai.Click += new System.EventHandler(this.pic_trangthai_Click);
            // 
            // label_time
            // 
            this.label_time.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_time.Location = new System.Drawing.Point(276, 17);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(19, 20);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "0";
            // 
            // label_flag
            // 
            this.label_flag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_flag.AutoSize = true;
            this.label_flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_flag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_flag.Location = new System.Drawing.Point(183, 17);
            this.label_flag.Name = "label_flag";
            this.label_flag.Size = new System.Drawing.Size(19, 20);
            this.label_flag.TabIndex = 6;
            this.label_flag.Text = "0";
            // 
            // pic_flag
            // 
            this.pic_flag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic_flag.BackColor = System.Drawing.Color.Transparent;
            this.pic_flag.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_flag.Image = ((System.Drawing.Image)(resources.GetObject("pic_flag.Image")));
            this.pic_flag.Location = new System.Drawing.Point(141, 1);
            this.pic_flag.Name = "pic_flag";
            this.pic_flag.Size = new System.Drawing.Size(36, 43);
            this.pic_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_flag.TabIndex = 5;
            this.pic_flag.TabStop = false;
            // 
            // pic_clock
            // 
            this.pic_clock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic_clock.BackColor = System.Drawing.Color.Transparent;
            this.pic_clock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_clock.Image = ((System.Drawing.Image)(resources.GetObject("pic_clock.Image")));
            this.pic_clock.Location = new System.Drawing.Point(226, 0);
            this.pic_clock.Name = "pic_clock";
            this.pic_clock.Size = new System.Drawing.Size(55, 46);
            this.pic_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_clock.TabIndex = 3;
            this.pic_clock.TabStop = false;
            // 
            // bt_setgame
            // 
            this.bt_setgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_setgame.BackgroundImage")));
            this.bt_setgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setgame.Location = new System.Drawing.Point(113, -31);
            this.bt_setgame.Name = "bt_setgame";
            this.bt_setgame.Size = new System.Drawing.Size(83, 31);
            this.bt_setgame.TabIndex = 7;
            this.bt_setgame.Text = "Tùy Chỉnh";
            this.bt_setgame.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.bt_setgame);
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 360);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dò Mìn ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel_audio.ResumeLayout(false);
            this.panel_audio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_audio)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_trangthai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox cb_level;
        private System.Windows.Forms.Button bt_setgame;
        private System.Windows.Forms.PictureBox pic_audio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tùyChỉnhToolStripMenuItem;
        private System.Windows.Forms.Panel panel_audio;
        private System.Windows.Forms.Label label_flag;
        private System.Windows.Forms.PictureBox pic_flag;
        private System.Windows.Forms.PictureBox pic_clock;
        private System.Windows.Forms.PictureBox pic_trangthai;
        public System.Windows.Forms.Label label_time;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnCáchChơiToolStripMenuItem;
        private System.Windows.Forms.Button LanClick;
        private System.Windows.Forms.TextBox textBox1;
    }
}

