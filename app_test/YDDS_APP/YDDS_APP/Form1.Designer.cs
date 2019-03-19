namespace YDDS_APP
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cboport = new System.Windows.Forms.ComboBox();
            this.btconnect = new System.Windows.Forms.Button();
            this.lbport = new System.Windows.Forms.Label();
            this.btndisconnect = new System.Windows.Forms.Button();
            this.grbvitri = new System.Windows.Forms.GroupBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaHaiY = new System.Windows.Forms.TextBox();
            this.txtNuY = new System.Windows.Forms.TextBox();
            this.txtNamY = new System.Windows.Forms.TextBox();
            this.txtCaHaiX = new System.Windows.Forms.TextBox();
            this.txtNuX = new System.Windows.Forms.TextBox();
            this.txtNamX = new System.Windows.Forms.TextBox();
            this.pnCOM = new System.Windows.Forms.Panel();
            this.btminimize = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.picTim = new System.Windows.Forms.PictureBox();
            this.pictrai = new System.Windows.Forms.PictureBox();
            this.picphai = new System.Windows.Forms.PictureBox();
            this.piccahai = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbvitri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.pnCOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picphai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccahai)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cboport
            // 
            this.cboport.Font = new System.Drawing.Font("San Francisco Display Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboport.FormattingEnabled = true;
            this.cboport.Location = new System.Drawing.Point(33, 48);
            this.cboport.Margin = new System.Windows.Forms.Padding(4);
            this.cboport.Name = "cboport";
            this.cboport.Size = new System.Drawing.Size(293, 31);
            this.cboport.TabIndex = 0;
            // 
            // btconnect
            // 
            this.btconnect.BackColor = System.Drawing.Color.DeepPink;
            this.btconnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btconnect.FlatAppearance.BorderSize = 0;
            this.btconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btconnect.Location = new System.Drawing.Point(342, 22);
            this.btconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btconnect.Name = "btconnect";
            this.btconnect.Size = new System.Drawing.Size(159, 57);
            this.btconnect.TabIndex = 1;
            this.btconnect.Text = "Kết Nối";
            this.btconnect.UseVisualStyleBackColor = false;
            this.btconnect.Click += new System.EventHandler(this.btconnect_Click);
            // 
            // lbport
            // 
            this.lbport.AutoSize = true;
            this.lbport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbport.Location = new System.Drawing.Point(32, 22);
            this.lbport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbport.Name = "lbport";
            this.lbport.Size = new System.Drawing.Size(86, 20);
            this.lbport.TabIndex = 2;
            this.lbport.Text = "Tên Cổng";
            // 
            // btndisconnect
            // 
            this.btndisconnect.BackColor = System.Drawing.Color.DeepPink;
            this.btndisconnect.FlatAppearance.BorderSize = 0;
            this.btndisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisconnect.ForeColor = System.Drawing.Color.White;
            this.btndisconnect.Location = new System.Drawing.Point(519, 22);
            this.btndisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btndisconnect.Name = "btndisconnect";
            this.btndisconnect.Size = new System.Drawing.Size(204, 57);
            this.btndisconnect.TabIndex = 1;
            this.btndisconnect.Text = "Ngắt Kết Nối";
            this.btndisconnect.UseVisualStyleBackColor = false;
            this.btndisconnect.Click += new System.EventHandler(this.btndisconnect_Click);
            // 
            // grbvitri
            // 
            this.grbvitri.BackColor = System.Drawing.Color.YellowGreen;
            this.grbvitri.Controls.Add(this.bunifuImageButton1);
            this.grbvitri.Controls.Add(this.label2);
            this.grbvitri.Controls.Add(this.label1);
            this.grbvitri.Controls.Add(this.label5);
            this.grbvitri.Controls.Add(this.label4);
            this.grbvitri.Controls.Add(this.label3);
            this.grbvitri.Controls.Add(this.txtCaHaiY);
            this.grbvitri.Controls.Add(this.txtNuY);
            this.grbvitri.Controls.Add(this.txtNamY);
            this.grbvitri.Controls.Add(this.txtCaHaiX);
            this.grbvitri.Controls.Add(this.txtNuX);
            this.grbvitri.Controls.Add(this.txtNamX);
            this.grbvitri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grbvitri.Location = new System.Drawing.Point(36, 115);
            this.grbvitri.Margin = new System.Windows.Forms.Padding(4);
            this.grbvitri.Name = "grbvitri";
            this.grbvitri.Padding = new System.Windows.Forms.Padding(4);
            this.grbvitri.Size = new System.Drawing.Size(811, 197);
            this.grbvitri.TabIndex = 4;
            this.grbvitri.TabStop = false;
            this.grbvitri.Text = "Thiết Lập Vị Trí video";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.YellowGreen;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(642, 29);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(141, 144);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(489, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cả Hai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(303, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(103, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nam";
            // 
            // txtCaHaiY
            // 
            this.txtCaHaiY.Font = new System.Drawing.Font("San Francisco Display Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaHaiY.Location = new System.Drawing.Point(455, 128);
            this.txtCaHaiY.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaHaiY.Name = "txtCaHaiY";
            this.txtCaHaiY.Size = new System.Drawing.Size(148, 36);
            this.txtCaHaiY.TabIndex = 3;
            this.txtCaHaiY.Text = "772";
            this.txtCaHaiY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNuY
            // 
            this.txtNuY.Font = new System.Drawing.Font("San Francisco Display Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuY.Location = new System.Drawing.Point(257, 127);
            this.txtNuY.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuY.Name = "txtNuY";
            this.txtNuY.Size = new System.Drawing.Size(148, 36);
            this.txtNuY.TabIndex = 3;
            this.txtNuY.Text = "772";
            this.txtNuY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNamY
            // 
            this.txtNamY.Font = new System.Drawing.Font("San Francisco Display Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamY.Location = new System.Drawing.Point(57, 127);
            this.txtNamY.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamY.Name = "txtNamY";
            this.txtNamY.Size = new System.Drawing.Size(148, 36);
            this.txtNamY.TabIndex = 3;
            this.txtNamY.Text = "769";
            this.txtNamY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCaHaiX
            // 
            this.txtCaHaiX.Font = new System.Drawing.Font("San Francisco Display Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaHaiX.Location = new System.Drawing.Point(455, 70);
            this.txtCaHaiX.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaHaiX.Name = "txtCaHaiX";
            this.txtCaHaiX.Size = new System.Drawing.Size(148, 36);
            this.txtCaHaiX.TabIndex = 3;
            this.txtCaHaiX.Text = "1221";
            this.txtCaHaiX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNuX
            // 
            this.txtNuX.Font = new System.Drawing.Font("San Francisco Display Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuX.Location = new System.Drawing.Point(257, 69);
            this.txtNuX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuX.Name = "txtNuX";
            this.txtNuX.Size = new System.Drawing.Size(148, 36);
            this.txtNuX.TabIndex = 3;
            this.txtNuX.Text = "947";
            this.txtNuX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNamX
            // 
            this.txtNamX.Font = new System.Drawing.Font("San Francisco Display Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamX.Location = new System.Drawing.Point(57, 69);
            this.txtNamX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamX.Name = "txtNamX";
            this.txtNamX.Size = new System.Drawing.Size(148, 36);
            this.txtNamX.TabIndex = 3;
            this.txtNamX.Text = "694";
            this.txtNamX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnCOM
            // 
            this.pnCOM.BackColor = System.Drawing.Color.YellowGreen;
            this.pnCOM.Controls.Add(this.cboport);
            this.pnCOM.Controls.Add(this.btminimize);
            this.pnCOM.Controls.Add(this.btclose);
            this.pnCOM.Controls.Add(this.btndisconnect);
            this.pnCOM.Controls.Add(this.lbport);
            this.pnCOM.Controls.Add(this.btconnect);
            this.pnCOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCOM.Location = new System.Drawing.Point(0, 0);
            this.pnCOM.Name = "pnCOM";
            this.pnCOM.Size = new System.Drawing.Size(873, 100);
            this.pnCOM.TabIndex = 5;
            // 
            // btminimize
            // 
            this.btminimize.BackColor = System.Drawing.Color.Transparent;
            this.btminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btminimize.BackgroundImage")));
            this.btminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btminimize.FlatAppearance.BorderSize = 0;
            this.btminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btminimize.ForeColor = System.Drawing.Color.White;
            this.btminimize.Location = new System.Drawing.Point(765, 30);
            this.btminimize.Margin = new System.Windows.Forms.Padding(4);
            this.btminimize.Name = "btminimize";
            this.btminimize.Size = new System.Drawing.Size(40, 40);
            this.btminimize.TabIndex = 1;
            this.btminimize.Text = "-";
            this.btminimize.UseVisualStyleBackColor = false;
            this.btminimize.Click += new System.EventHandler(this.btminimize_Click);
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.Color.Transparent;
            this.btclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btclose.BackgroundImage")));
            this.btclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btclose.FlatAppearance.BorderSize = 0;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclose.ForeColor = System.Drawing.Color.White;
            this.btclose.Location = new System.Drawing.Point(822, 30);
            this.btclose.Margin = new System.Windows.Forms.Padding(4);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(40, 40);
            this.btclose.TabIndex = 1;
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnCOM;
            this.bunifuDragControl1.Vertical = true;
            // 
            // picTim
            // 
            this.picTim.Image = ((System.Drawing.Image)(resources.GetObject("picTim.Image")));
            this.picTim.Location = new System.Drawing.Point(310, 312);
            this.picTim.Name = "picTim";
            this.picTim.Size = new System.Drawing.Size(268, 208);
            this.picTim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTim.TabIndex = 6;
            this.picTim.TabStop = false;
            // 
            // pictrai
            // 
            this.pictrai.BackColor = System.Drawing.Color.Transparent;
            this.pictrai.Image = ((System.Drawing.Image)(resources.GetObject("pictrai.Image")));
            this.pictrai.Location = new System.Drawing.Point(310, 312);
            this.pictrai.Name = "pictrai";
            this.pictrai.Size = new System.Drawing.Size(268, 208);
            this.pictrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictrai.TabIndex = 8;
            this.pictrai.TabStop = false;
            // 
            // picphai
            // 
            this.picphai.BackColor = System.Drawing.Color.Transparent;
            this.picphai.Image = ((System.Drawing.Image)(resources.GetObject("picphai.Image")));
            this.picphai.Location = new System.Drawing.Point(310, 312);
            this.picphai.Name = "picphai";
            this.picphai.Size = new System.Drawing.Size(268, 208);
            this.picphai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picphai.TabIndex = 8;
            this.picphai.TabStop = false;
            // 
            // piccahai
            // 
            this.piccahai.Image = ((System.Drawing.Image)(resources.GetObject("piccahai.Image")));
            this.piccahai.Location = new System.Drawing.Point(310, 312);
            this.piccahai.Name = "piccahai";
            this.piccahai.Size = new System.Drawing.Size(268, 208);
            this.piccahai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piccahai.TabIndex = 6;
            this.piccahai.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.picTim);
            this.Controls.Add(this.piccahai);
            this.Controls.Add(this.pictrai);
            this.Controls.Add(this.grbvitri);
            this.Controls.Add(this.pnCOM);
            this.Controls.Add(this.picphai);
            this.Font = new System.Drawing.Font("San Francisco Display Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yêu đi đừng sợ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.grbvitri.ResumeLayout(false);
            this.grbvitri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.pnCOM.ResumeLayout(false);
            this.pnCOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picphai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccahai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cboport;
        private System.Windows.Forms.Button btconnect;
        private System.Windows.Forms.Label lbport;
        private System.Windows.Forms.Button btndisconnect;
        private System.Windows.Forms.GroupBox grbvitri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaHaiY;
        private System.Windows.Forms.TextBox txtNuY;
        private System.Windows.Forms.TextBox txtNamY;
        private System.Windows.Forms.TextBox txtCaHaiX;
        private System.Windows.Forms.TextBox txtNuX;
        private System.Windows.Forms.TextBox txtNamX;
        private System.Windows.Forms.Panel pnCOM;
        private System.Windows.Forms.Button btminimize;
        private System.Windows.Forms.Button btclose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox picTim;
        private System.Windows.Forms.PictureBox pictrai;
        private System.Windows.Forms.PictureBox picphai;
        private System.Windows.Forms.PictureBox piccahai;
        private System.Windows.Forms.Timer timer1;
    }
}

