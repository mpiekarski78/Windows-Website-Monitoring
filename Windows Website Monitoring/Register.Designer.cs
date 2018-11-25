namespace Windows_Website_Monitoring
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.ThankYou = new System.Windows.Forms.Label();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.labelProductKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.metroButtonRegister = new MetroFramework.Controls.MetroButton();
            this.labelNotification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ThankYou
            // 
            this.ThankYou.AutoSize = true;
            this.ThankYou.BackColor = System.Drawing.Color.Transparent;
            this.ThankYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ThankYou.ForeColor = System.Drawing.Color.White;
            this.ThankYou.Location = new System.Drawing.Point(59, 21);
            this.ThankYou.Name = "ThankYou";
            this.ThankYou.Size = new System.Drawing.Size(520, 25);
            this.ThankYou.TabIndex = 0;
            this.ThankYou.Text = "Thank You For Downloading Website Monitoring";
            this.ThankYou.Click += new System.EventHandler(this.ThankYou_Click);
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelRegister.Location = new System.Drawing.Point(133, 64);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(374, 20);
            this.linkLabelRegister.TabIndex = 2;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Tag = "http://pragmio.com/website-monitoring/";
            this.linkLabelRegister.Text = "If you haven‘t ordered yet, you can order online now.";
            this.linkLabelRegister.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // labelProductKey
            // 
            this.labelProductKey.AutoSize = true;
            this.labelProductKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProductKey.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelProductKey.Location = new System.Drawing.Point(59, 332);
            this.labelProductKey.Name = "labelProductKey";
            this.labelProductKey.Size = new System.Drawing.Size(132, 25);
            this.labelProductKey.TabIndex = 3;
            this.labelProductKey.Text = "Product key:";
            this.labelProductKey.Click += new System.EventHandler(this.labelProductKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(60, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a product key to activate Website Monitoring";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKey.Location = new System.Drawing.Point(197, 331);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(275, 26);
            this.textBoxKey.TabIndex = 5;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 129;
            this.iconPictureBox1.Location = new System.Drawing.Point(244, 113);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(143, 129);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // metroButtonRegister
            // 
            this.metroButtonRegister.Location = new System.Drawing.Point(492, 332);
            this.metroButtonRegister.Name = "metroButtonRegister";
            this.metroButtonRegister.Size = new System.Drawing.Size(87, 25);
            this.metroButtonRegister.TabIndex = 7;
            this.metroButtonRegister.Text = "Register";
            this.metroButtonRegister.UseSelectable = true;
            this.metroButtonRegister.Click += new System.EventHandler(this.metroButtonRegister_ClickAsync);
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNotification.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.labelNotification.Location = new System.Drawing.Point(194, 378);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(0, 16);
            this.labelNotification.TabIndex = 8;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.ControlBox = false;
            this.Controls.Add(this.labelNotification);
            this.Controls.Add(this.metroButtonRegister);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProductKey);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.ThankYou);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.Text = "Website Monitoring Activation";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThankYou;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Label labelProductKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKey;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MetroFramework.Controls.MetroButton metroButtonRegister;
        private System.Windows.Forms.Label labelNotification;
    }
}