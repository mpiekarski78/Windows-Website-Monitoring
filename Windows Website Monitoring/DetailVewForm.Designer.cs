namespace Windows_Website_Monitoring
{
    partial class DetailVewForm
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
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnHeaderWebsiteUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWebsiteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chartResponseTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelWebsiteName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartResponseTime)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMain
            // 
            this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWebsiteUrl,
            this.columnHeaderWebsiteName,
            this.columnHeaderStatus,
            this.columnHeaderResponse});
            this.listViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMain.Location = new System.Drawing.Point(8, 8);
            this.listViewMain.Margin = new System.Windows.Forms.Padding(0);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(479, 442);
            this.listViewMain.TabIndex = 1;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderWebsiteUrl
            // 
            this.columnHeaderWebsiteUrl.Text = "Website Url";
            this.columnHeaderWebsiteUrl.Width = 161;
            // 
            // columnHeaderWebsiteName
            // 
            this.columnHeaderWebsiteName.Text = "Website Name";
            this.columnHeaderWebsiteName.Width = 115;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 58;
            // 
            // columnHeaderResponse
            // 
            this.columnHeaderResponse.Text = "Response Time";
            this.columnHeaderResponse.Width = 100;
            // 
            // chartResponseTime
            // 
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX2.LabelStyle.Format = "mm:ss";
            chartArea1.AxisX2.Title = "Time";
            chartArea1.Name = "ChartArea1";
            this.chartResponseTime.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResponseTime.Legends.Add(legend1);
            this.chartResponseTime.Location = new System.Drawing.Point(494, 8);
            this.chartResponseTime.Name = "chartResponseTime";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Response Time";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartResponseTime.Series.Add(series1);
            this.chartResponseTime.Size = new System.Drawing.Size(1030, 442);
            this.chartResponseTime.TabIndex = 2;
            this.chartResponseTime.Text = "chart1";
            // 
            // labelWebsiteName
            // 
            this.labelWebsiteName.AutoSize = true;
            this.labelWebsiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWebsiteName.Location = new System.Drawing.Point(490, 8);
            this.labelWebsiteName.Name = "labelWebsiteName";
            this.labelWebsiteName.Size = new System.Drawing.Size(0, 20);
            this.labelWebsiteName.TabIndex = 3;
            // 
            // DetailVewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 990);
            this.Controls.Add(this.labelWebsiteName);
            this.Controls.Add(this.chartResponseTime);
            this.Controls.Add(this.listViewMain);
            this.Name = "DetailVewForm";
            this.Text = "FormDetailedView";
            this.Load += new System.EventHandler(this.FormDetailedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartResponseTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteName;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderResponse;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResponseTime;
        private System.Windows.Forms.Label labelWebsiteName;
    }
}