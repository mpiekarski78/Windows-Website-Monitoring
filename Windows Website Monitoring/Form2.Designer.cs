namespace Windows_Website_Monitoring
{
    partial class Form2
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
            this.panelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.titleText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxNewUrl = new System.Windows.Forms.TextBox();
            this.labelNewUrl = new System.Windows.Forms.Label();
            this.labelWebsiteName = new System.Windows.Forms.Label();
            this.textBoxWebsiteName = new System.Windows.Forms.TextBox();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Coral;
            this.panelBottom.Controls.Add(this.titleText);
            this.panelBottom.Location = new System.Drawing.Point(0, 0);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(856, 46);
            this.panelBottom.TabIndex = 1;
            // 
            // titleText
            // 
            this.titleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleText.ForeColor = System.Drawing.Color.White;
            this.titleText.Location = new System.Drawing.Point(5, 5);
            this.titleText.Margin = new System.Windows.Forms.Padding(5, 5, 100, 150);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(243, 30);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Website Monitoring";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Windows_Website_Monitoring.Properties.Resources._61685;
            this.pictureBox1.Location = new System.Drawing.Point(712, 739);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(44, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 318);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(522, 172);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(432, 382);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(114, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove Selected";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxNewUrl
            // 
            this.textBoxNewUrl.Location = new System.Drawing.Point(522, 100);
            this.textBoxNewUrl.Name = "textBoxNewUrl";
            this.textBoxNewUrl.Size = new System.Drawing.Size(250, 20);
            this.textBoxNewUrl.TabIndex = 6;
            // 
            // labelNewUrl
            // 
            this.labelNewUrl.AutoSize = true;
            this.labelNewUrl.Location = new System.Drawing.Point(427, 103);
            this.labelNewUrl.Name = "labelNewUrl";
            this.labelNewUrl.Size = new System.Drawing.Size(74, 13);
            this.labelNewUrl.TabIndex = 7;
            this.labelNewUrl.Text = "Website URL:";
            // 
            // labelWebsiteName
            // 
            this.labelWebsiteName.AutoSize = true;
            this.labelWebsiteName.Location = new System.Drawing.Point(427, 138);
            this.labelWebsiteName.Name = "labelWebsiteName";
            this.labelWebsiteName.Size = new System.Drawing.Size(80, 13);
            this.labelWebsiteName.TabIndex = 8;
            this.labelWebsiteName.Text = "Website Name:";
            // 
            // textBoxWebsiteName
            // 
            this.textBoxWebsiteName.Location = new System.Drawing.Point(522, 135);
            this.textBoxWebsiteName.Name = "textBoxWebsiteName";
            this.textBoxWebsiteName.Size = new System.Drawing.Size(250, 20);
            this.textBoxWebsiteName.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 811);
            this.Controls.Add(this.textBoxWebsiteName);
            this.Controls.Add(this.labelWebsiteName);
            this.Controls.Add(this.labelNewUrl);
            this.Controls.Add(this.textBoxNewUrl);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wesite Monitoring - Setup";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelBottom;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxNewUrl;
        private System.Windows.Forms.Label labelNewUrl;
        private System.Windows.Forms.Label labelWebsiteName;
        private System.Windows.Forms.TextBox textBoxWebsiteName;
    }
}