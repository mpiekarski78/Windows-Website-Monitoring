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
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnHeaderWebsiteUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWebsiteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelSideBar.SuspendLayout();
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
            this.titleText.Size = new System.Drawing.Size(270, 50);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Website Monitoring";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatusOverview
            // 
            this.labelStatusOverview.AutoSize = true;
            this.labelStatusOverview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelStatusOverview, 2);
            this.labelStatusOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatusOverview.Location = new System.Drawing.Point(0, 50);
            this.labelStatusOverview.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatusOverview.Name = "labelStatusOverview";
            this.labelStatusOverview.Size = new System.Drawing.Size(270, 40);
            this.labelStatusOverview.TabIndex = 1;
            this.labelStatusOverview.Text = "Status Overview";
            this.labelStatusOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStatusOverview.Click += new System.EventHandler(this.labelStatusOverview_Click);
            // 
            // listViewMain
            // 
            this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWebsiteUrl,
            this.columnHeaderWebsiteName,
            this.columnHeaderStatus,
            this.columnHeaderResponse});
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMain.Location = new System.Drawing.Point(0, 90);
            this.listViewMain.Margin = new System.Windows.Forms.Padding(0);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(230, 695);
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderWebsiteUrl
            // 
            this.columnHeaderWebsiteUrl.Text = "Website Url";
            this.columnHeaderWebsiteUrl.Width = 0;
            // 
            // columnHeaderWebsiteName
            // 
            this.columnHeaderWebsiteName.Text = "Website Name";
            this.columnHeaderWebsiteName.Width = 110;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 46;
            // 
            // columnHeaderResponse
            // 
            this.columnHeaderResponse.Text = "Response";
            this.columnHeaderResponse.Width = 68;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.Controls.Add(this.titleText, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelStatusOverview, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.listViewMain, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelSideBar, 1, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(270, 795);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // flowLayoutPanelSideBar
            // 
            this.flowLayoutPanelSideBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelSideBar.Controls.Add(this.buttonConfig);
            this.flowLayoutPanelSideBar.Controls.Add(this.buttonDetails);
            this.flowLayoutPanelSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSideBar.Location = new System.Drawing.Point(230, 90);
            this.flowLayoutPanelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelSideBar.Name = "flowLayoutPanelSideBar";
            this.flowLayoutPanelSideBar.Size = new System.Drawing.Size(40, 695);
            this.flowLayoutPanelSideBar.TabIndex = 2;
            // 
            // buttonConfig
            // 
            this.buttonConfig.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConfig.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonConfig.FlatAppearance.BorderSize = 0;
            this.buttonConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.Location = new System.Drawing.Point(0, 0);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(40, 40);
            this.buttonConfig.TabIndex = 0;
            this.buttonConfig.UseCompatibleTextRendering = true;
            this.buttonConfig.UseVisualStyleBackColor = false;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.BackColor = System.Drawing.Color.Transparent;
            this.buttonDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDetails.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDetails.FlatAppearance.BorderSize = 0;
            this.buttonDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetails.Location = new System.Drawing.Point(0, 40);
            this.buttonDetails.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(40, 40);
            this.buttonDetails.TabIndex = 1;
            this.buttonDetails.UseVisualStyleBackColor = false;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 795);
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
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.flowLayoutPanelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label labelStatusOverview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteName;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderResponse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSideBar;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonDetails;
    }
}

