namespace Windows_Website_Monitoring
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.titleText = new System.Windows.Forms.Label();
            this.labelStatusOverview = new System.Windows.Forms.Label();
            this.pictureBoxConfiguration = new System.Windows.Forms.PictureBox();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnHeaderWebsiteUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWebsiteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.columnHeaderResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfiguration)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanelMain.SetColumnSpan(this.titleText, 2);
            this.titleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleText.ForeColor = System.Drawing.Color.White;
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Margin = new System.Windows.Forms.Padding(0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(250, 45);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Website Monitoring";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatusOverview
            // 
            this.labelStatusOverview.AutoSize = true;
            this.labelStatusOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatusOverview.Location = new System.Drawing.Point(0, 45);
            this.labelStatusOverview.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatusOverview.Name = "labelStatusOverview";
            this.labelStatusOverview.Size = new System.Drawing.Size(220, 30);
            this.labelStatusOverview.TabIndex = 1;
            this.labelStatusOverview.Text = "Status Overview";
            this.labelStatusOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStatusOverview.Click += new System.EventHandler(this.labelStatusOverview_Click);
            // 
            // pictureBoxConfiguration
            // 
            this.pictureBoxConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxConfiguration.Location = new System.Drawing.Point(220, 45);
            this.pictureBoxConfiguration.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxConfiguration.Name = "pictureBoxConfiguration";
            this.pictureBoxConfiguration.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxConfiguration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConfiguration.TabIndex = 2;
            this.pictureBoxConfiguration.TabStop = false;
            this.pictureBoxConfiguration.Click += new System.EventHandler(this.pictureBoxConfiguration_Click);
            // 
            // listViewMain
            // 
            this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWebsiteUrl,
            this.columnHeaderWebsiteName,
            this.columnHeaderStatus,
            this.columnHeaderResponse});
            this.tableLayoutPanelMain.SetColumnSpan(this.listViewMain, 2);
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMain.Location = new System.Drawing.Point(3, 88);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(244, 694);
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderWebsiteUrl
            // 
            this.columnHeaderWebsiteUrl.Text = "Website Url";
            this.columnHeaderWebsiteUrl.Width = 80;
            // 
            // columnHeaderWebsiteName
            // 
            this.columnHeaderWebsiteName.Text = "Website Name";
            this.columnHeaderWebsiteName.Width = 110;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 50;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.Controls.Add(this.titleText, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelStatusOverview, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxConfiguration, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.listViewMain, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(250, 795);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // columnHeaderResponse
            // 
            this.columnHeaderResponse.Text = "Response";
            this.columnHeaderResponse.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(250, 795);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Website Monitoring";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfiguration)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label labelStatusOverview;
        private System.Windows.Forms.PictureBox pictureBoxConfiguration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteName;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderResponse;
    }
}

