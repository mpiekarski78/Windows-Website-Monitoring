namespace Windows_Website_Monitoring
{
    partial class DetailViewForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailViewForm));
            this.listViewMain = new Windows_Website_Monitoring.Controls.CustomListView();
            this.columnHeaderWebsiteUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWebsiteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAverageResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEvents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chartResponseTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelWebsiteName = new System.Windows.Forms.Label();
            this.labelDetailed = new System.Windows.Forms.Label();
            this.richTextBoxEventLog = new System.Windows.Forms.RichTextBox();
            this.labelEventOverview = new System.Windows.Forms.Label();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.labelWebsiteInfo = new System.Windows.Forms.Label();
            this.richTextBoxWebsiteOverview = new System.Windows.Forms.RichTextBox();
            this.richTextBox3rdParty = new System.Windows.Forms.RichTextBox();
            this.label3rdParty = new System.Windows.Forms.Label();
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartResponseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMain
            // 
            this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWebsiteUrl,
            this.columnHeaderWebsiteName,
            this.columnHeaderStatus,
            this.columnHeaderResponse,
            this.columnHeaderAverageResponse,
            this.columnHeaderEvents});
            this.listViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMain.Location = new System.Drawing.Point(5, 75);
            this.listViewMain.Margin = new System.Windows.Forms.Padding(0);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.OwnerDraw = true;
            this.listViewMain.Size = new System.Drawing.Size(621, 442);
            this.listViewMain.TabIndex = 1;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.listViewMain_SelectedIndexChanged);
            // 
            // columnHeaderWebsiteUrl
            // 
            this.columnHeaderWebsiteUrl.Text = "Website Url";
            this.columnHeaderWebsiteUrl.Width = 174;
            // 
            // columnHeaderWebsiteName
            // 
            this.columnHeaderWebsiteName.Text = "Website Name";
            this.columnHeaderWebsiteName.Width = 146;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 69;
            // 
            // columnHeaderResponse
            // 
            this.columnHeaderResponse.Text = "Response Time";
            this.columnHeaderResponse.Width = 104;
            // 
            // columnHeaderAverageResponse
            // 
            this.columnHeaderAverageResponse.Text = "Average";
            // 
            // columnHeaderEvents
            // 
            this.columnHeaderEvents.Text = "Events";
            this.columnHeaderEvents.Width = 65;
            // 
            // chartResponseTime
            // 
            this.chartResponseTime.BorderlineColor = System.Drawing.Color.Navy;
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX2.LabelStyle.Format = "mm:ss";
            chartArea1.AxisX2.Title = "Time";
            chartArea1.Name = "ChartArea1";
            this.chartResponseTime.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResponseTime.Legends.Add(legend1);
            this.chartResponseTime.Location = new System.Drawing.Point(619, 75);
            this.chartResponseTime.Name = "chartResponseTime";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Response Time";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartResponseTime.Series.Add(series1);
            this.chartResponseTime.Size = new System.Drawing.Size(878, 442);
            this.chartResponseTime.TabIndex = 2;
            this.chartResponseTime.Text = "chart1";
            this.chartResponseTime.Click += new System.EventHandler(this.chartResponseTime_Click);
            // 
            // labelWebsiteName
            // 
            this.labelWebsiteName.AutoSize = true;
            this.labelWebsiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWebsiteName.ForeColor = System.Drawing.Color.White;
            this.labelWebsiteName.Location = new System.Drawing.Point(238, 17);
            this.labelWebsiteName.Name = "labelWebsiteName";
            this.labelWebsiteName.Size = new System.Drawing.Size(97, 24);
            this.labelWebsiteName.TabIndex = 3;
            this.labelWebsiteName.Text = "loading...";
            // 
            // labelDetailed
            // 
            this.labelDetailed.AutoSize = true;
            this.labelDetailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDetailed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelDetailed.Location = new System.Drawing.Point(77, 21);
            this.labelDetailed.Name = "labelDetailed";
            this.labelDetailed.Size = new System.Drawing.Size(166, 20);
            this.labelDetailed.TabIndex = 6;
            this.labelDetailed.Text = "Viewing details for: ";
            // 
            // richTextBoxEventLog
            // 
            this.richTextBoxEventLog.Location = new System.Drawing.Point(5, 583);
            this.richTextBoxEventLog.Name = "richTextBoxEventLog";
            this.richTextBoxEventLog.Size = new System.Drawing.Size(621, 231);
            this.richTextBoxEventLog.TabIndex = 7;
            this.richTextBoxEventLog.Text = "";
            // 
            // labelEventOverview
            // 
            this.labelEventOverview.AutoSize = true;
            this.labelEventOverview.BackColor = System.Drawing.Color.Transparent;
            this.labelEventOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEventOverview.ForeColor = System.Drawing.Color.White;
            this.labelEventOverview.Location = new System.Drawing.Point(2, 564);
            this.labelEventOverview.Margin = new System.Windows.Forms.Padding(0);
            this.labelEventOverview.Name = "labelEventOverview";
            this.labelEventOverview.Size = new System.Drawing.Size(154, 16);
            this.labelEventOverview.TabIndex = 8;
            this.labelEventOverview.Text = "Real-Time Event Log";
            this.labelEventOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(5, 834);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToFile.TabIndex = 9;
            this.buttonSaveToFile.Text = "Save";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // labelWebsiteInfo
            // 
            this.labelWebsiteInfo.AutoSize = true;
            this.labelWebsiteInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelWebsiteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWebsiteInfo.ForeColor = System.Drawing.Color.White;
            this.labelWebsiteInfo.Location = new System.Drawing.Point(636, 564);
            this.labelWebsiteInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelWebsiteInfo.Name = "labelWebsiteInfo";
            this.labelWebsiteInfo.Size = new System.Drawing.Size(133, 16);
            this.labelWebsiteInfo.TabIndex = 10;
            this.labelWebsiteInfo.Text = "Website Overview";
            this.labelWebsiteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWebsiteInfo.Click += new System.EventHandler(this.labelUrlInfo_Click);
            // 
            // richTextBoxWebsiteOverview
            // 
            this.richTextBoxWebsiteOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxWebsiteOverview.Location = new System.Drawing.Point(639, 583);
            this.richTextBoxWebsiteOverview.Name = "richTextBoxWebsiteOverview";
            this.richTextBoxWebsiteOverview.Size = new System.Drawing.Size(422, 234);
            this.richTextBoxWebsiteOverview.TabIndex = 11;
            this.richTextBoxWebsiteOverview.Text = "";
            // 
            // richTextBox3rdParty
            // 
            this.richTextBox3rdParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox3rdParty.Location = new System.Drawing.Point(1075, 583);
            this.richTextBox3rdParty.Name = "richTextBox3rdParty";
            this.richTextBox3rdParty.Size = new System.Drawing.Size(422, 234);
            this.richTextBox3rdParty.TabIndex = 12;
            this.richTextBox3rdParty.Text = "";
            // 
            // label3rdParty
            // 
            this.label3rdParty.AutoSize = true;
            this.label3rdParty.BackColor = System.Drawing.Color.Transparent;
            this.label3rdParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3rdParty.ForeColor = System.Drawing.Color.White;
            this.label3rdParty.Location = new System.Drawing.Point(1072, 564);
            this.label3rdParty.Margin = new System.Windows.Forms.Padding(0);
            this.label3rdParty.Name = "label3rdParty";
            this.label3rdParty.Size = new System.Drawing.Size(58, 16);
            this.label3rdParty.TabIndex = 13;
            this.label3rdParty.Text = "WHOIS";
            this.label3rdParty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetails.BackgroundImage")));
            this.pictureBoxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDetails.Location = new System.Drawing.Point(-9, 4);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(84, 68);
            this.pictureBoxDetails.TabIndex = 14;
            this.pictureBoxDetails.TabStop = false;
            this.pictureBoxDetails.Click += new System.EventHandler(this.pictureBoxDetails_Click);
            // 
            // DetailViewForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1501, 877);
            this.Controls.Add(this.pictureBoxDetails);
            this.Controls.Add(this.label3rdParty);
            this.Controls.Add(this.richTextBox3rdParty);
            this.Controls.Add(this.richTextBoxWebsiteOverview);
            this.Controls.Add(this.labelWebsiteInfo);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.labelEventOverview);
            this.Controls.Add(this.richTextBoxEventLog);
            this.Controls.Add(this.labelDetailed);
            this.Controls.Add(this.labelWebsiteName);
            this.Controls.Add(this.chartResponseTime);
            this.Controls.Add(this.listViewMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailViewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Website Monitoring - Details";
            this.Load += new System.EventHandler(this.FormDetailedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartResponseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows_Website_Monitoring.Controls.CustomListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteName;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderResponse;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResponseTime;
        private System.Windows.Forms.Label labelWebsiteName;
        private System.Windows.Forms.ColumnHeader columnHeaderAverageResponse;
        private System.Windows.Forms.ColumnHeader columnHeaderEvents;
        private System.Windows.Forms.Label labelDetailed;
        private System.Windows.Forms.RichTextBox richTextBoxEventLog;
        private System.Windows.Forms.Label labelEventOverview;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Label labelWebsiteInfo;
        private System.Windows.Forms.RichTextBox richTextBoxWebsiteOverview;
        private System.Windows.Forms.RichTextBox richTextBox3rdParty;
        private System.Windows.Forms.Label label3rdParty;
        private System.Windows.Forms.PictureBox pictureBoxDetails;
    }
}