namespace ClickPuli
{
    partial class FrmAbout
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
            this.btnQuitAboutDialog = new System.Windows.Forms.Button();
            this.lblAboutName = new System.Windows.Forms.Label();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.llAboutLink = new System.Windows.Forms.LinkLabel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnShowHelp = new System.Windows.Forms.Button();
            this.btnShowLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuitAboutDialog
            // 
            this.btnQuitAboutDialog.Location = new System.Drawing.Point(317, 348);
            this.btnQuitAboutDialog.Name = "btnQuitAboutDialog";
            this.btnQuitAboutDialog.Size = new System.Drawing.Size(152, 53);
            this.btnQuitAboutDialog.TabIndex = 1;
            this.btnQuitAboutDialog.Text = "Close";
            this.btnQuitAboutDialog.UseVisualStyleBackColor = true;
            this.btnQuitAboutDialog.Click += new System.EventHandler(this.btnQuitAboutDialog_Click);
            // 
            // lblAboutName
            // 
            this.lblAboutName.AutoSize = true;
            this.lblAboutName.Cursor = System.Windows.Forms.Cursors.No;
            this.lblAboutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutName.Location = new System.Drawing.Point(314, 12);
            this.lblAboutName.Name = "lblAboutName";
            this.lblAboutName.Size = new System.Drawing.Size(295, 31);
            this.lblAboutName.TabIndex = 2;
            this.lblAboutName.Text = "ClickPuli (by BattlePuli)";
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.AutoSize = true;
            this.lblAboutVersion.Cursor = System.Windows.Forms.Cursors.No;
            this.lblAboutVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutVersion.Location = new System.Drawing.Point(317, 63);
            this.lblAboutVersion.Name = "lblAboutVersion";
            this.lblAboutVersion.Size = new System.Drawing.Size(102, 31);
            this.lblAboutVersion.TabIndex = 3;
            this.lblAboutVersion.Text = "version";
            this.lblAboutVersion.Click += new System.EventHandler(this.lblAboutVersion_Click);
            // 
            // llAboutLink
            // 
            this.llAboutLink.AutoSize = true;
            this.llAboutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAboutLink.LinkArea = new System.Windows.Forms.LinkArea(0, 33);
            this.llAboutLink.Location = new System.Drawing.Point(320, 118);
            this.llAboutLink.Name = "llAboutLink";
            this.llAboutLink.Size = new System.Drawing.Size(378, 31);
            this.llAboutLink.TabIndex = 4;
            this.llAboutLink.TabStop = true;
            this.llAboutLink.Text = "https://battlepuli.com/clickpuli/";
            this.llAboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAboutLink_LinkClicked);
            // 
            // btnLogo
            // 
            this.btnLogo.BackgroundImage = global::ClickPuli.Properties.Resources.clickpuli_tiny;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.Location = new System.Drawing.Point(12, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(282, 282);
            this.btnLogo.TabIndex = 7;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.BackgroundImage = global::ClickPuli.Properties.Resources.help_tiny;
            this.btnShowHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowHelp.Location = new System.Drawing.Point(646, 348);
            this.btnShowHelp.Name = "btnShowHelp";
            this.btnShowHelp.Size = new System.Drawing.Size(52, 53);
            this.btnShowHelp.TabIndex = 6;
            this.btnShowHelp.UseVisualStyleBackColor = true;
            this.btnShowHelp.Click += new System.EventHandler(this.btnShowHelp_Click);
            // 
            // btnShowLicense
            // 
            this.btnShowLicense.BackgroundImage = global::ClickPuli.Properties.Resources.license_tiny;
            this.btnShowLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowLicense.Location = new System.Drawing.Point(709, 348);
            this.btnShowLicense.Name = "btnShowLicense";
            this.btnShowLicense.Size = new System.Drawing.Size(51, 53);
            this.btnShowLicense.TabIndex = 5;
            this.btnShowLicense.UseVisualStyleBackColor = true;
            this.btnShowLicense.Click += new System.EventHandler(this.btnShowLicense_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.btnShowHelp);
            this.Controls.Add(this.btnShowLicense);
            this.Controls.Add(this.llAboutLink);
            this.Controls.Add(this.lblAboutVersion);
            this.Controls.Add(this.lblAboutName);
            this.Controls.Add(this.btnQuitAboutDialog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuitAboutDialog;
        private System.Windows.Forms.Label lblAboutName;
        private System.Windows.Forms.Label lblAboutVersion;
        private System.Windows.Forms.LinkLabel llAboutLink;
        private System.Windows.Forms.Button btnShowLicense;
        private System.Windows.Forms.Button btnShowHelp;
        private System.Windows.Forms.Button btnLogo;
    }
}