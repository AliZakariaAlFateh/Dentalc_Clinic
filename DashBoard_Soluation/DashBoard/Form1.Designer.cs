namespace DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMenue = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitlBar = new System.Windows.Forms.Panel();
            this.label1_title = new System.Windows.Forms.Label();
            this.panel1_Content = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.PanelMenue.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTitlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenue
            // 
            this.PanelMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            this.PanelMenue.Controls.Add(this.button2);
            this.PanelMenue.Controls.Add(this.button1);
            this.PanelMenue.Controls.Add(this.BtnPatient);
            this.PanelMenue.Controls.Add(this.PanelLogo);
            this.PanelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenue.Location = new System.Drawing.Point(0, 0);
            this.PanelMenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenue.Name = "PanelMenue";
            this.PanelMenue.Size = new System.Drawing.Size(165, 514);
            this.PanelMenue.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 236);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(165, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "    Patient";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DashBoard.Properties.Resources.Appointment_Icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(165, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "    Appointment";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPatient.FlatAppearance.BorderSize = 0;
            this.BtnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatient.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.BtnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPatient.Location = new System.Drawing.Point(0, 138);
            this.BtnPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnPatient.Size = new System.Drawing.Size(165, 49);
            this.BtnPatient.TabIndex = 1;
            this.BtnPatient.Text = "    Patient";
            this.BtnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatient.UseVisualStyleBackColor = true;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(165, 138);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DashBoard.Properties.Resources.Logo_Clinic1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelTitlBar
            // 
            this.PanelTitlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.PanelTitlBar.Controls.Add(this.btnMaximize);
            this.PanelTitlBar.Controls.Add(this.btnMinimize);
            this.PanelTitlBar.Controls.Add(this.btnClose);
            this.PanelTitlBar.Controls.Add(this.label1_title);
            this.PanelTitlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitlBar.Location = new System.Drawing.Point(165, 0);
            this.PanelTitlBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelTitlBar.Name = "PanelTitlBar";
            this.PanelTitlBar.Size = new System.Drawing.Size(863, 78);
            this.PanelTitlBar.TabIndex = 1;
            this.PanelTitlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitlBar_MouseDown);
            // 
            // label1_title
            // 
            this.label1_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_title.AutoSize = true;
            this.label1_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1_title.Location = new System.Drawing.Point(371, 3);
            this.label1_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1_title.Name = "label1_title";
            this.label1_title.Size = new System.Drawing.Size(62, 24);
            this.label1_title.TabIndex = 0;
            this.label1_title.Text = "Home";
            // 
            // panel1_Content
            // 
            this.panel1_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_Content.Location = new System.Drawing.Point(165, 78);
            this.panel1_Content.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1_Content.Name = "panel1_Content";
            this.panel1_Content.Size = new System.Drawing.Size(863, 436);
            this.panel1_Content.TabIndex = 2;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(794, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 21);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 8;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(756, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 21);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(830, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 21);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 514);
            this.Controls.Add(this.panel1_Content);
            this.Controls.Add(this.PanelTitlBar);
            this.Controls.Add(this.PanelMenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(980, 484);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelMenue.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTitlBar.ResumeLayout(false);
            this.PanelTitlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenue;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelTitlBar;
        private System.Windows.Forms.Label label1_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1_Content;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

