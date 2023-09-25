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
            this.PanelMenue = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitlBar = new System.Windows.Forms.Panel();
            this.label1_title = new System.Windows.Forms.Label();
            this.panel1_Content = new System.Windows.Forms.Panel();
            this.PanelMenue.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTitlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenue
            // 
            this.PanelMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            this.PanelMenue.Controls.Add(this.button2);
            this.PanelMenue.Controls.Add(this.button2);
            this.PanelMenue.Controls.Add(this.BtnPatient);
            this.PanelMenue.Controls.Add(this.PanelLogo);
            this.PanelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenue.Location = new System.Drawing.Point(0, 0);
            this.PanelMenue.Name = "PanelMenue";
            this.PanelMenue.Size = new System.Drawing.Size(220, 633);
            this.PanelMenue.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 290);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(220, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Diagnosis";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Diagnosis_Click);
            // 
            // btnAddPatient
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DashBoard.Properties.Resources.Appointment_Icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 230);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "    Appointment";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Appointment_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPatient.FlatAppearance.BorderSize = 0;
            this.BtnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatient.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.BtnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPatient.Location = new System.Drawing.Point(0, 170);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnPatient.Size = new System.Drawing.Size(220, 60);
            this.BtnPatient.TabIndex = 1;
            this.BtnPatient.Text = "    Patient";
            this.BtnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatient.UseVisualStyleBackColor = true;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(158)))), ((int)(((byte)(187)))));
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 170);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DashBoard.Properties.Resources.Logo_Clinic1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelTitlBar
            // 
            this.PanelTitlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.PanelTitlBar.Controls.Add(this.label1_title);
            this.PanelTitlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitlBar.Location = new System.Drawing.Point(220, 0);
            this.PanelTitlBar.Name = "PanelTitlBar";
            this.PanelTitlBar.Size = new System.Drawing.Size(1612, 80);
            this.PanelTitlBar.TabIndex = 1;
            // 
            // label1_title
            // 
            this.label1_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_title.AutoSize = true;
            this.label1_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1_title.Location = new System.Drawing.Point(496, 31);
            this.label1_title.Name = "label1_title";
            this.label1_title.Size = new System.Drawing.Size(86, 31);
            this.label1_title.TabIndex = 0;
            this.label1_title.Text = "Home";
            // 
            // panel1_Content
            // 
            this.panel1_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_Content.Location = new System.Drawing.Point(220, 80);
            this.panel1_Content.Name = "panel1_Content";
            this.panel1_Content.Size = new System.Drawing.Size(1612, 553);
            this.panel1_Content.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 633);
            this.Controls.Add(this.panel1_Content);
            this.Controls.Add(this.PanelTitlBar);
            this.Controls.Add(this.PanelMenue);
            this.MinimumSize = new System.Drawing.Size(1850, 587);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelMenue.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTitlBar.ResumeLayout(false);
            this.PanelTitlBar.PerformLayout();
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
    }
}

