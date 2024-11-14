namespace missPACMAN
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            txtScore = new Label();
            wall4 = new PictureBox();
            wall3 = new PictureBox();
            wall2 = new PictureBox();
            wall1 = new PictureBox();
            YellowGhost = new PictureBox();
            PinkGhost = new PictureBox();
            RedGhost = new PictureBox();
            Pacman = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox43 = new PictureBox();
            pictureBox44 = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            pictureBox24 = new PictureBox();
            pictureBox30 = new PictureBox();
            pictureBox31 = new PictureBox();
            pictureBox32 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox29 = new PictureBox();
            pictureBox33 = new PictureBox();
            pictureBox34 = new PictureBox();
            pictureBox35 = new PictureBox();
            pictureBox36 = new PictureBox();
            pictureBox37 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)wall4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YellowGhost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PinkGhost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedGhost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pacman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox43).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox44).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox34).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox35).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox36).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox37).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(4, 3);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(68, 19);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score: 0";
            // 
            // wall4
            // 
            wall4.Image = (Image)resources.GetObject("wall4.Image");
            wall4.Location = new Point(495, 385);
            wall4.Name = "wall4";
            wall4.Size = new Size(44, 174);
            wall4.SizeMode = PictureBoxSizeMode.StretchImage;
            wall4.TabIndex = 4;
            wall4.TabStop = false;
            wall4.Tag = "wall";
            wall4.Click += pictureBox3_Click;
            // 
            // wall3
            // 
            wall3.Image = (Image)resources.GetObject("wall3.Image");
            wall3.Location = new Point(225, 385);
            wall3.Name = "wall3";
            wall3.Size = new Size(44, 174);
            wall3.SizeMode = PictureBoxSizeMode.StretchImage;
            wall3.TabIndex = 5;
            wall3.TabStop = false;
            wall3.Tag = "wall";
            // 
            // wall2
            // 
            wall2.Image = (Image)resources.GetObject("wall2.Image");
            wall2.Location = new Point(440, -42);
            wall2.Name = "wall2";
            wall2.Size = new Size(44, 174);
            wall2.SizeMode = PictureBoxSizeMode.StretchImage;
            wall2.TabIndex = 6;
            wall2.TabStop = false;
            wall2.Tag = "wall";
            // 
            // wall1
            // 
            wall1.Image = (Image)resources.GetObject("wall1.Image");
            wall1.Location = new Point(138, -42);
            wall1.Name = "wall1";
            wall1.Size = new Size(44, 174);
            wall1.SizeMode = PictureBoxSizeMode.StretchImage;
            wall1.TabIndex = 7;
            wall1.TabStop = false;
            wall1.Tag = "wall";
            // 
            // YellowGhost
            // 
            YellowGhost.Image = (Image)resources.GetObject("YellowGhost.Image");
            YellowGhost.Location = new Point(439, 437);
            YellowGhost.Name = "YellowGhost";
            YellowGhost.Size = new Size(45, 60);
            YellowGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            YellowGhost.TabIndex = 8;
            YellowGhost.TabStop = false;
            YellowGhost.Tag = "ghost";
            // 
            // PinkGhost
            // 
            PinkGhost.Image = Properties.Resources.pinkGhost;
            PinkGhost.Location = new Point(495, 221);
            PinkGhost.Name = "PinkGhost";
            PinkGhost.Size = new Size(45, 60);
            PinkGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            PinkGhost.TabIndex = 9;
            PinkGhost.TabStop = false;
            PinkGhost.Tag = "ghost";
            // 
            // RedGhost
            // 
            RedGhost.Image = Properties.Resources.redGhost;
            RedGhost.Location = new Point(188, 40);
            RedGhost.Name = "RedGhost";
            RedGhost.Size = new Size(45, 60);
            RedGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            RedGhost.TabIndex = 10;
            RedGhost.TabStop = false;
            RedGhost.Tag = "ghost";
            // 
            // Pacman
            // 
            Pacman.Image = Properties.Resources.right;
            Pacman.Location = new Point(17, 36);
            Pacman.Name = "Pacman";
            Pacman.Size = new Size(55, 55);
            Pacman.SizeMode = PictureBoxSizeMode.StretchImage;
            Pacman.TabIndex = 11;
            Pacman.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.coin;
            pictureBox7.Location = new Point(17, 494);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 25);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "coin";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.coin;
            pictureBox8.Location = new Point(188, 494);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "coin";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.coin;
            pictureBox15.Location = new Point(188, 463);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(25, 25);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 20;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "coin";
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.coin;
            pictureBox16.Location = new Point(17, 463);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(25, 25);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 19;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "coin";
            // 
            // pictureBox21
            // 
            pictureBox21.Image = Properties.Resources.coin;
            pictureBox21.Location = new Point(188, 432);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(25, 25);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 26;
            pictureBox21.TabStop = false;
            pictureBox21.Tag = "coin";
            // 
            // pictureBox22
            // 
            pictureBox22.Image = Properties.Resources.coin;
            pictureBox22.Location = new Point(17, 432);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(25, 25);
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.TabIndex = 25;
            pictureBox22.TabStop = false;
            pictureBox22.Tag = "coin";
            // 
            // pictureBox43
            // 
            pictureBox43.Image = Properties.Resources.coin;
            pictureBox43.Location = new Point(17, 400);
            pictureBox43.Name = "pictureBox43";
            pictureBox43.Size = new Size(25, 25);
            pictureBox43.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox43.TabIndex = 13;
            pictureBox43.TabStop = false;
            pictureBox43.Tag = "coin";
            // 
            // pictureBox44
            // 
            pictureBox44.Image = Properties.Resources.coin;
            pictureBox44.Location = new Point(188, 400);
            pictureBox44.Name = "pictureBox44";
            pictureBox44.Size = new Size(25, 25);
            pictureBox44.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox44.TabIndex = 14;
            pictureBox44.TabStop = false;
            pictureBox44.Tag = "coin";
            // 
            // GameTimer
            // 
            GameTimer.Interval = 20;
            GameTimer.Tick += MainGameTimer;
            // 
            // pictureBox24
            // 
            pictureBox24.Image = Properties.Resources.coin;
            pictureBox24.Location = new Point(391, 107);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(25, 25);
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox24.TabIndex = 12;
            pictureBox24.TabStop = false;
            pictureBox24.Tag = "coin";
            // 
            // pictureBox30
            // 
            pictureBox30.Image = Properties.Resources.coin;
            pictureBox30.Location = new Point(208, 106);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(25, 25);
            pictureBox30.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox30.TabIndex = 12;
            pictureBox30.TabStop = false;
            pictureBox30.Tag = "coin";
            // 
            // pictureBox31
            // 
            pictureBox31.Image = Properties.Resources.coin;
            pictureBox31.Location = new Point(336, 107);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(25, 25);
            pictureBox31.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox31.TabIndex = 18;
            pictureBox31.TabStop = false;
            pictureBox31.Tag = "coin";
            // 
            // pictureBox32
            // 
            pictureBox32.Image = Properties.Resources.coin;
            pictureBox32.Location = new Point(275, 107);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(25, 25);
            pictureBox32.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox32.TabIndex = 24;
            pictureBox32.TabStop = false;
            pictureBox32.Tag = "coin";
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.coin;
            pictureBox18.Location = new Point(495, 106);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(25, 25);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.TabIndex = 14;
            pictureBox18.TabStop = false;
            pictureBox18.Tag = "coin";
            // 
            // pictureBox19
            // 
            pictureBox19.Image = Properties.Resources.coin;
            pictureBox19.Location = new Point(495, 12);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(25, 25);
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.TabIndex = 14;
            pictureBox19.TabStop = false;
            pictureBox19.Tag = "coin";
            // 
            // pictureBox20
            // 
            pictureBox20.Image = Properties.Resources.coin;
            pictureBox20.Location = new Point(495, 75);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(25, 25);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.TabIndex = 20;
            pictureBox20.TabStop = false;
            pictureBox20.Tag = "coin";
            // 
            // pictureBox23
            // 
            pictureBox23.Image = Properties.Resources.coin;
            pictureBox23.Location = new Point(495, 44);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(25, 25);
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox23.TabIndex = 26;
            pictureBox23.TabStop = false;
            pictureBox23.Tag = "coin";
            // 
            // pictureBox29
            // 
            pictureBox29.Image = Properties.Resources.coin;
            pictureBox29.Location = new Point(119, 246);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(25, 25);
            pictureBox29.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox29.TabIndex = 27;
            pictureBox29.TabStop = false;
            pictureBox29.Tag = "coin";
            // 
            // pictureBox33
            // 
            pictureBox33.Image = Properties.Resources.coin;
            pictureBox33.Location = new Point(175, 246);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(25, 25);
            pictureBox33.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox33.TabIndex = 28;
            pictureBox33.TabStop = false;
            pictureBox33.Tag = "coin";
            // 
            // pictureBox34
            // 
            pictureBox34.Image = Properties.Resources.coin;
            pictureBox34.Location = new Point(225, 246);
            pictureBox34.Name = "pictureBox34";
            pictureBox34.Size = new Size(25, 25);
            pictureBox34.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox34.TabIndex = 29;
            pictureBox34.TabStop = false;
            pictureBox34.Tag = "coin";
            // 
            // pictureBox35
            // 
            pictureBox35.Image = Properties.Resources.coin;
            pictureBox35.Location = new Point(376, 246);
            pictureBox35.Name = "pictureBox35";
            pictureBox35.Size = new Size(25, 25);
            pictureBox35.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox35.TabIndex = 32;
            pictureBox35.TabStop = false;
            pictureBox35.Tag = "coin";
            // 
            // pictureBox36
            // 
            pictureBox36.Image = Properties.Resources.coin;
            pictureBox36.Location = new Point(326, 246);
            pictureBox36.Name = "pictureBox36";
            pictureBox36.Size = new Size(25, 25);
            pictureBox36.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox36.TabIndex = 31;
            pictureBox36.TabStop = false;
            pictureBox36.Tag = "coin";
            // 
            // pictureBox37
            // 
            pictureBox37.Image = Properties.Resources.coin;
            pictureBox37.Location = new Point(270, 246);
            pictureBox37.Name = "pictureBox37";
            pictureBox37.Size = new Size(25, 25);
            pictureBox37.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox37.TabIndex = 30;
            pictureBox37.TabStop = false;
            pictureBox37.Tag = "coin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coin;
            pictureBox1.Location = new Point(391, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "coin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.coin;
            pictureBox2.Location = new Point(208, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "coin";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.coin;
            pictureBox3.Location = new Point(336, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "coin";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.coin;
            pictureBox4.Location = new Point(275, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "coin";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.coin;
            pictureBox5.Location = new Point(464, 385);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "coin";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.coin;
            pictureBox6.Location = new Point(281, 384);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "coin";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.coin;
            pictureBox9.Location = new Point(409, 385);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(25, 25);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "coin";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.coin;
            pictureBox10.Location = new Point(348, 385);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(25, 25);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 24;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "coin";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.coin;
            pictureBox11.Location = new Point(464, 504);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(25, 25);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 12;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "coin";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.coin;
            pictureBox12.Location = new Point(281, 503);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(25, 25);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 12;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "coin";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.coin;
            pictureBox13.Location = new Point(409, 504);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(25, 25);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 18;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "coin";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.coin;
            pictureBox14.Location = new Point(348, 504);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(25, 25);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 24;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "coin";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(609, 531);
            Controls.Add(Pacman);
            Controls.Add(RedGhost);
            Controls.Add(PinkGhost);
            Controls.Add(YellowGhost);
            Controls.Add(pictureBox35);
            Controls.Add(pictureBox36);
            Controls.Add(pictureBox37);
            Controls.Add(pictureBox34);
            Controls.Add(pictureBox33);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox32);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox31);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox44);
            Controls.Add(pictureBox43);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox7);
            Controls.Add(wall1);
            Controls.Add(wall2);
            Controls.Add(wall3);
            Controls.Add(wall4);
            Controls.Add(txtScore);
            Name = "Game";
            Tag = "ghost";
            Text = "Miss PACMAN";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)wall4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall1).EndInit();
            ((System.ComponentModel.ISupportInitialize)YellowGhost).EndInit();
            ((System.ComponentModel.ISupportInitialize)PinkGhost).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedGhost).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pacman).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox43).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox44).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox34).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox35).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox36).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox37).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtScore;
        private PictureBox wall4;
        private PictureBox wall3;
        private PictureBox wall2;
        private PictureBox wall1;
        private PictureBox YellowGhost;
        private PictureBox PinkGhost;
        private PictureBox RedGhost;
        private PictureBox Pacman;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox43;
        private PictureBox pictureBox44;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox pictureBox24;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox23;
        private PictureBox pictureBox29;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
    }
}
