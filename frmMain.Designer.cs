namespace BilliardManagment_Simple_
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelScreens = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLineOnTheLeftBtn = new System.Windows.Forms.Label();
            this.btnFrmTables = new System.Windows.Forms.Button();
            this.panelCorner = new System.Windows.Forms.Panel();
            this.lblScreenTitle = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelScreens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelScreens
            // 
            this.panelScreens.Controls.Add(this.pictureBox1);
            this.panelScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreens.Location = new System.Drawing.Point(179, 79);
            this.panelScreens.Name = "panelScreens";
            this.panelScreens.Size = new System.Drawing.Size(621, 371);
            this.panelScreens.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BilliardManagment_Simple_.Properties.Resources.billiard;
            this.pictureBox1.Location = new System.Drawing.Point(119, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLineOnTheLeftBtn
            // 
            this.lblLineOnTheLeftBtn.BackColor = System.Drawing.Color.Black;
            this.lblLineOnTheLeftBtn.Location = new System.Drawing.Point(3, 79);
            this.lblLineOnTheLeftBtn.Name = "lblLineOnTheLeftBtn";
            this.lblLineOnTheLeftBtn.Size = new System.Drawing.Size(4, 79);
            this.lblLineOnTheLeftBtn.TabIndex = 3;
            this.lblLineOnTheLeftBtn.Visible = false;
            // 
            // btnFrmTables
            // 
            this.btnFrmTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrmTables.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFrmTables.FlatAppearance.BorderSize = 0;
            this.btnFrmTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmTables.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmTables.Location = new System.Drawing.Point(0, 79);
            this.btnFrmTables.Name = "btnFrmTables";
            this.btnFrmTables.Size = new System.Drawing.Size(179, 79);
            this.btnFrmTables.TabIndex = 0;
            this.btnFrmTables.Text = "Tables Page";
            this.btnFrmTables.UseVisualStyleBackColor = true;
            this.btnFrmTables.Click += new System.EventHandler(this.btnfrmTables_Click);
            // 
            // panelCorner
            // 
            this.panelCorner.BackColor = System.Drawing.Color.LightGray;
            this.panelCorner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCorner.Location = new System.Drawing.Point(0, 0);
            this.panelCorner.Name = "panelCorner";
            this.panelCorner.Size = new System.Drawing.Size(179, 79);
            this.panelCorner.TabIndex = 0;
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.BackColor = System.Drawing.Color.Silver;
            this.lblScreenTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScreenTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenTitle.Location = new System.Drawing.Point(179, 0);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(621, 79);
            this.lblScreenTitle.TabIndex = 5;
            this.lblScreenTitle.Text = "Billiard Manager";
            this.lblScreenTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControl.Controls.Add(this.lblLineOnTheLeftBtn);
            this.panelControl.Controls.Add(this.btnFrmTables);
            this.panelControl.Controls.Add(this.panelCorner);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(179, 450);
            this.panelControl.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelScreens);
            this.Controls.Add(this.lblScreenTitle);
            this.Controls.Add(this.panelControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Billiard Managment";
            this.panelScreens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelScreens;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLineOnTheLeftBtn;
        private System.Windows.Forms.Button btnFrmTables;
        private System.Windows.Forms.Panel panelCorner;
        private System.Windows.Forms.Label lblScreenTitle;
        private System.Windows.Forms.Panel panelControl;
    }
}

