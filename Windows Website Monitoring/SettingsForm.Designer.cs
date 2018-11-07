namespace Windows_Website_Monitoring
{
    partial class SettingsForm
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
            this.titleText = new System.Windows.Forms.Label();
            this.pictureBoxApply = new System.Windows.Forms.PictureBox();
            this.listViewWebsites = new System.Windows.Forms.ListView();
            this.columnHeaderWebsiteUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWebsiteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxNewUrl = new System.Windows.Forms.TextBox();
            this.labelNewUrl = new System.Windows.Forms.Label();
            this.labelWebsiteName = new System.Windows.Forms.Label();
            this.textBoxWebsiteName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelmain = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApply)).BeginInit();
            this.tableLayoutPanelmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanelmain.SetColumnSpan(this.titleText, 7);
            this.titleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleText.ForeColor = System.Drawing.Color.White;
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Margin = new System.Windows.Forms.Padding(0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(784, 45);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Website Monitoring";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxApply
            // 
            this.pictureBoxApply.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxApply.Location = new System.Drawing.Point(704, 731);
            this.pictureBoxApply.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxApply.Name = "pictureBoxApply";
            this.pictureBoxApply.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxApply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxApply.TabIndex = 2;
            this.pictureBoxApply.TabStop = false;
            this.pictureBoxApply.WaitOnLoad = true;
            this.pictureBoxApply.Click += new System.EventHandler(this.pictureBoxApply_Click);
            // 
            // listViewWebsites
            // 
            this.listViewWebsites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWebsiteUrl,
            this.columnHeaderWebsiteName});
            this.listViewWebsites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWebsites.FullRowSelect = true;
            this.listViewWebsites.Location = new System.Drawing.Point(20, 85);
            this.listViewWebsites.Margin = new System.Windows.Forms.Padding(0);
            this.listViewWebsites.MultiSelect = false;
            this.listViewWebsites.Name = "listViewWebsites";
            this.tableLayoutPanelmain.SetRowSpan(this.listViewWebsites, 6);
            this.listViewWebsites.Size = new System.Drawing.Size(379, 603);
            this.listViewWebsites.TabIndex = 3;
            this.listViewWebsites.UseCompatibleStateImageBehavior = false;
            this.listViewWebsites.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderWebsiteUrl
            // 
            this.columnHeaderWebsiteUrl.Text = "Website URL";
            this.columnHeaderWebsiteUrl.Width = 200;
            // 
            // columnHeaderWebsiteName
            // 
            this.columnHeaderWebsiteName.Text = "Website Name";
            this.columnHeaderWebsiteName.Width = 150;
            // 
            // buttonAdd
            // 
            this.tableLayoutPanelmain.SetColumnSpan(this.buttonAdd, 2);
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(504, 135);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(260, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemove.Location = new System.Drawing.Point(20, 688);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(379, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove Selected";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxNewUrl
            // 
            this.tableLayoutPanelmain.SetColumnSpan(this.textBoxNewUrl, 2);
            this.textBoxNewUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewUrl.Location = new System.Drawing.Point(504, 85);
            this.textBoxNewUrl.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNewUrl.Name = "textBoxNewUrl";
            this.textBoxNewUrl.Size = new System.Drawing.Size(260, 20);
            this.textBoxNewUrl.TabIndex = 6;
            // 
            // labelNewUrl
            // 
            this.labelNewUrl.AutoSize = true;
            this.labelNewUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNewUrl.Location = new System.Drawing.Point(404, 85);
            this.labelNewUrl.Margin = new System.Windows.Forms.Padding(0);
            this.labelNewUrl.Name = "labelNewUrl";
            this.labelNewUrl.Size = new System.Drawing.Size(100, 20);
            this.labelNewUrl.TabIndex = 7;
            this.labelNewUrl.Text = "Website URL:";
            this.labelNewUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWebsiteName
            // 
            this.labelWebsiteName.AutoSize = true;
            this.labelWebsiteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWebsiteName.Location = new System.Drawing.Point(404, 110);
            this.labelWebsiteName.Margin = new System.Windows.Forms.Padding(0);
            this.labelWebsiteName.Name = "labelWebsiteName";
            this.labelWebsiteName.Size = new System.Drawing.Size(100, 20);
            this.labelWebsiteName.TabIndex = 8;
            this.labelWebsiteName.Text = "Website Name:";
            this.labelWebsiteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxWebsiteName
            // 
            this.tableLayoutPanelmain.SetColumnSpan(this.textBoxWebsiteName, 2);
            this.textBoxWebsiteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWebsiteName.Location = new System.Drawing.Point(504, 110);
            this.textBoxWebsiteName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxWebsiteName.Name = "textBoxWebsiteName";
            this.textBoxWebsiteName.Size = new System.Drawing.Size(260, 20);
            this.textBoxWebsiteName.TabIndex = 9;
            // 
            // tableLayoutPanelmain
            // 
            this.tableLayoutPanelmain.ColumnCount = 7;
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.Controls.Add(this.titleText, 0, 0);
            this.tableLayoutPanelmain.Controls.Add(this.pictureBoxApply, 5, 10);
            this.tableLayoutPanelmain.Controls.Add(this.buttonRemove, 1, 8);
            this.tableLayoutPanelmain.Controls.Add(this.textBoxWebsiteName, 4, 4);
            this.tableLayoutPanelmain.Controls.Add(this.buttonAdd, 4, 6);
            this.tableLayoutPanelmain.Controls.Add(this.listViewWebsites, 1, 2);
            this.tableLayoutPanelmain.Controls.Add(this.textBoxNewUrl, 4, 2);
            this.tableLayoutPanelmain.Controls.Add(this.labelNewUrl, 3, 2);
            this.tableLayoutPanelmain.Controls.Add(this.labelWebsiteName, 3, 4);
            this.tableLayoutPanelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelmain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelmain.Name = "tableLayoutPanelmain";
            this.tableLayoutPanelmain.RowCount = 12;
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.Size = new System.Drawing.Size(784, 811);
            this.tableLayoutPanelmain.TabIndex = 10;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 811);
            this.Controls.Add(this.tableLayoutPanelmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wesite Monitoring - Setup";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApply)).EndInit();
            this.tableLayoutPanelmain.ResumeLayout(false);
            this.tableLayoutPanelmain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.PictureBox pictureBoxApply;
        private System.Windows.Forms.ListView listViewWebsites;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxNewUrl;
        private System.Windows.Forms.Label labelNewUrl;
        private System.Windows.Forms.Label labelWebsiteName;
        private System.Windows.Forms.TextBox textBoxWebsiteName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelmain;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteName;
    }
}