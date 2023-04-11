namespace MyRadio
{
    partial class MyRadio
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyRadio));
            this.mpRadio = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbRadio = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbFavList = new System.Windows.Forms.GroupBox();
            this.pb15 = new System.Windows.Forms.PictureBox();
            this.pb14 = new System.Windows.Forms.PictureBox();
            this.pb13 = new System.Windows.Forms.PictureBox();
            this.pb16 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mpRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRadio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFavList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // mpRadio
            // 
            this.mpRadio.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpRadio.Enabled = true;
            this.mpRadio.Location = new System.Drawing.Point(0, 0);
            this.mpRadio.Name = "mpRadio";
            this.mpRadio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpRadio.OcxState")));
            this.mpRadio.Size = new System.Drawing.Size(678, 206);
            this.mpRadio.TabIndex = 0;
            // 
            // pbRadio
            // 
            this.pbRadio.Location = new System.Drawing.Point(532, 123);
            this.pbRadio.Name = "pbRadio";
            this.pbRadio.Size = new System.Drawing.Size(146, 83);
            this.pbRadio.TabIndex = 1;
            this.pbRadio.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRadio);
            this.groupBox1.Controls.Add(this.btnMute);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Location = new System.Drawing.Point(0, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRadio.Location = new System.Drawing.Point(29, 22);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(60, 24);
            this.lblRadio.TabIndex = 6;
            this.lblRadio.Text = "label1";
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMute.Location = new System.Drawing.Point(554, 52);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(102, 33);
            this.btnMute.TabIndex = 5;
            this.btnMute.Tag = "mute";
            this.btnMute.Text = "Mute";
            this.btnMute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.Raido_Action);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(446, 52);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 33);
            this.btnNext.TabIndex = 4;
            this.btnNext.Tag = "next";
            this.btnNext.Text = "İleri >>";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.Raido_Action);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(338, 52);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(102, 33);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Tag = "record";
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.Raido_Action);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPause.Location = new System.Drawing.Point(230, 52);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(102, 33);
            this.btnPause.TabIndex = 2;
            this.btnPause.Tag = "pause";
            this.btnPause.Text = "Pause | |";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.Raido_Action);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Location = new System.Drawing.Point(122, 52);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(102, 33);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Tag = "play";
            this.btnPlay.Text = "Play >";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.Raido_Action);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(14, 52);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Tag = "back";
            this.btnBack.Text = "<< Geri";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Raido_Action);
            // 
            // gbFavList
            // 
            this.gbFavList.Controls.Add(this.pb15);
            this.gbFavList.Controls.Add(this.pb14);
            this.gbFavList.Controls.Add(this.pb13);
            this.gbFavList.Controls.Add(this.pb16);
            this.gbFavList.Controls.Add(this.pb7);
            this.gbFavList.Controls.Add(this.pb6);
            this.gbFavList.Controls.Add(this.pb5);
            this.gbFavList.Controls.Add(this.pb8);
            this.gbFavList.Controls.Add(this.pb11);
            this.gbFavList.Controls.Add(this.pb10);
            this.gbFavList.Controls.Add(this.pb9);
            this.gbFavList.Controls.Add(this.pb12);
            this.gbFavList.Controls.Add(this.pb3);
            this.gbFavList.Controls.Add(this.pb2);
            this.gbFavList.Controls.Add(this.pb1);
            this.gbFavList.Controls.Add(this.pb4);
            this.gbFavList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbFavList.Location = new System.Drawing.Point(0, 318);
            this.gbFavList.Name = "gbFavList";
            this.gbFavList.Size = new System.Drawing.Size(678, 251);
            this.gbFavList.TabIndex = 3;
            this.gbFavList.TabStop = false;
            this.gbFavList.Text = "Favori Liste";
            // 
            // pb15
            // 
            this.pb15.Location = new System.Drawing.Point(157, 132);
            this.pb15.Name = "pb15";
            this.pb15.Size = new System.Drawing.Size(122, 50);
            this.pb15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb15.TabIndex = 18;
            this.pb15.TabStop = false;
            // 
            // pb14
            // 
            this.pb14.Location = new System.Drawing.Point(157, 76);
            this.pb14.Name = "pb14";
            this.pb14.Size = new System.Drawing.Size(122, 50);
            this.pb14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb14.TabIndex = 17;
            this.pb14.TabStop = false;
            // 
            // pb13
            // 
            this.pb13.Location = new System.Drawing.Point(157, 19);
            this.pb13.Name = "pb13";
            this.pb13.Size = new System.Drawing.Size(122, 50);
            this.pb13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb13.TabIndex = 16;
            this.pb13.TabStop = false;
            // 
            // pb16
            // 
            this.pb16.Location = new System.Drawing.Point(157, 189);
            this.pb16.Name = "pb16";
            this.pb16.Size = new System.Drawing.Size(122, 50);
            this.pb16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb16.TabIndex = 15;
            this.pb16.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(413, 132);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(122, 50);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 14;
            this.pb7.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(413, 76);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(122, 50);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 13;
            this.pb6.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(413, 19);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(122, 50);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 12;
            this.pb5.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(413, 189);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(122, 50);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 11;
            this.pb8.TabStop = false;
            // 
            // pb11
            // 
            this.pb11.Location = new System.Drawing.Point(285, 132);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(122, 50);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb11.TabIndex = 10;
            this.pb11.TabStop = false;
            // 
            // pb10
            // 
            this.pb10.Location = new System.Drawing.Point(285, 76);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(122, 50);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb10.TabIndex = 9;
            this.pb10.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.Location = new System.Drawing.Point(285, 19);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(122, 50);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 8;
            this.pb9.TabStop = false;
            // 
            // pb12
            // 
            this.pb12.Location = new System.Drawing.Point(285, 189);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(122, 50);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb12.TabIndex = 7;
            this.pb12.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(541, 132);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(122, 50);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 6;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(541, 76);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(122, 50);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(541, 19);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(122, 50);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(541, 189);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(122, 50);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 0;
            this.pb4.TabStop = false;
            // 
            // MyRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 569);
            this.Controls.Add(this.gbFavList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbRadio);
            this.Controls.Add(this.mpRadio);
            this.Name = "MyRadio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mpRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRadio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFavList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mpRadio;
        private System.Windows.Forms.PictureBox pbRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFavList;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb15;
        private System.Windows.Forms.PictureBox pb14;
        private System.Windows.Forms.PictureBox pb13;
        private System.Windows.Forms.PictureBox pb16;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
    }
}

