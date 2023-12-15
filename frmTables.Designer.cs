namespace BilliardManagment_Simple_
{
    partial class frmTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTables));
            this.btnDone3 = new System.Windows.Forms.Button();
            this.btnDone1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnPause3 = new System.Windows.Forms.Button();
            this.btnPause2 = new System.Windows.Forms.Button();
            this.btnPause1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDone2 = new System.Windows.Forms.Button();
            this.btnStart3 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.lblTimerTable3 = new System.Windows.Forms.Label();
            this.lblTimerTable2 = new System.Windows.Forms.Label();
            this.lblTimerTable1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone3
            // 
            this.btnDone3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone3.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDone3.Enabled = false;
            this.btnDone3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDone3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone3.Location = new System.Drawing.Point(592, 382);
            this.btnDone3.Name = "btnDone3";
            this.btnDone3.Size = new System.Drawing.Size(156, 39);
            this.btnDone3.TabIndex = 31;
            this.btnDone3.Tag = "";
            this.btnDone3.Text = "Done";
            this.btnDone3.UseVisualStyleBackColor = false;
            this.btnDone3.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDone1
            // 
            this.btnDone1.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDone1.Enabled = false;
            this.btnDone1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDone1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone1.Location = new System.Drawing.Point(52, 382);
            this.btnDone1.Name = "btnDone1";
            this.btnDone1.Size = new System.Drawing.Size(156, 39);
            this.btnDone1.TabIndex = 29;
            this.btnDone1.Tag = "";
            this.btnDone1.Text = "Done";
            this.btnDone1.UseVisualStyleBackColor = false;
            this.btnDone1.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(265, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 49);
            this.label1.TabIndex = 28;
            this.label1.Text = "0,01 Per Second";
            // 
            // btnPause3
            // 
            this.btnPause3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause3.Enabled = false;
            this.btnPause3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPause3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause3.Location = new System.Drawing.Point(673, 337);
            this.btnPause3.Name = "btnPause3";
            this.btnPause3.Size = new System.Drawing.Size(75, 39);
            this.btnPause3.TabIndex = 27;
            this.btnPause3.Tag = "3";
            this.btnPause3.Text = "Pause";
            this.btnPause3.UseVisualStyleBackColor = true;
            this.btnPause3.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPause2
            // 
            this.btnPause2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPause2.Enabled = false;
            this.btnPause2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPause2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause2.Location = new System.Drawing.Point(403, 337);
            this.btnPause2.Name = "btnPause2";
            this.btnPause2.Size = new System.Drawing.Size(75, 39);
            this.btnPause2.TabIndex = 26;
            this.btnPause2.Tag = "2";
            this.btnPause2.Text = "Pause";
            this.btnPause2.UseVisualStyleBackColor = true;
            this.btnPause2.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPause1
            // 
            this.btnPause1.Enabled = false;
            this.btnPause1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPause1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause1.Location = new System.Drawing.Point(133, 337);
            this.btnPause1.Name = "btnPause1";
            this.btnPause1.Size = new System.Drawing.Size(75, 39);
            this.btnPause1.TabIndex = 25;
            this.btnPause1.Tag = "1";
            this.btnPause1.Text = "Pause";
            this.btnPause1.UseVisualStyleBackColor = true;
            this.btnPause1.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnDone2
            // 
            this.btnDone2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDone2.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDone2.Enabled = false;
            this.btnDone2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDone2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone2.Location = new System.Drawing.Point(322, 382);
            this.btnDone2.Name = "btnDone2";
            this.btnDone2.Size = new System.Drawing.Size(156, 39);
            this.btnDone2.TabIndex = 30;
            this.btnDone2.Tag = "";
            this.btnDone2.Text = "Done";
            this.btnDone2.UseVisualStyleBackColor = false;
            this.btnDone2.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnStart3
            // 
            this.btnStart3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart3.Location = new System.Drawing.Point(592, 337);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(75, 39);
            this.btnStart3.TabIndex = 24;
            this.btnStart3.Tag = "false";
            this.btnStart3.Text = "Start";
            this.btnStart3.UseVisualStyleBackColor = true;
            this.btnStart3.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart2.Location = new System.Drawing.Point(322, 337);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(75, 39);
            this.btnStart2.TabIndex = 23;
            this.btnStart2.Tag = "false";
            this.btnStart2.Text = "Start";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStart1
            // 
            this.btnStart1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart1.Location = new System.Drawing.Point(52, 337);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(75, 39);
            this.btnStart1.TabIndex = 22;
            this.btnStart1.Tag = "false";
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimerTable3
            // 
            this.lblTimerTable3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerTable3.AutoSize = true;
            this.lblTimerTable3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTable3.Location = new System.Drawing.Point(622, 114);
            this.lblTimerTable3.Name = "lblTimerTable3";
            this.lblTimerTable3.Size = new System.Drawing.Size(96, 28);
            this.lblTimerTable3.TabIndex = 21;
            this.lblTimerTable3.Tag = "0";
            this.lblTimerTable3.Text = "00:00:00";
            // 
            // lblTimerTable2
            // 
            this.lblTimerTable2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimerTable2.AutoSize = true;
            this.lblTimerTable2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTable2.Location = new System.Drawing.Point(352, 114);
            this.lblTimerTable2.Name = "lblTimerTable2";
            this.lblTimerTable2.Size = new System.Drawing.Size(96, 28);
            this.lblTimerTable2.TabIndex = 19;
            this.lblTimerTable2.Tag = "0";
            this.lblTimerTable2.Text = "00:00:00";
            // 
            // lblTimerTable1
            // 
            this.lblTimerTable1.AutoSize = true;
            this.lblTimerTable1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTable1.Location = new System.Drawing.Point(82, 114);
            this.lblTimerTable1.Name = "lblTimerTable1";
            this.lblTimerTable1.Size = new System.Drawing.Size(96, 28);
            this.lblTimerTable1.TabIndex = 17;
            this.lblTimerTable1.Tag = "0";
            this.lblTimerTable1.Text = "00:00:00";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(592, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(322, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDone3);
            this.Controls.Add(this.btnDone1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPause3);
            this.Controls.Add(this.btnPause2);
            this.Controls.Add(this.btnPause1);
            this.Controls.Add(this.btnDone2);
            this.Controls.Add(this.btnStart3);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.lblTimerTable3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblTimerTable2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTimerTable1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTables";
            this.Text = "frmTables";
            this.Load += new System.EventHandler(this.frmTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone3;
        private System.Windows.Forms.Button btnDone1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPause3;
        private System.Windows.Forms.Button btnPause2;
        private System.Windows.Forms.Button btnPause1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDone2;
        private System.Windows.Forms.Button btnStart3;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Label lblTimerTable3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTimerTable2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTimerTable1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}