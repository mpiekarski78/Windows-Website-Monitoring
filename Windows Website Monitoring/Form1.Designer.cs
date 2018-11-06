namespace Windows_Website_Monitoring
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.titleText = new System.Windows.Forms.Label();
            this.labelStatusOverview = new System.Windows.Forms.Label();
            this.pictureBoxConfiguration = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.listViewMain = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfiguration)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
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
            this.pictureBoxConfiguration.Image = global::Windows_Website_Monitoring.Properties.Resources._9252;
            this.pictureBoxConfiguration.Location = new System.Drawing.Point(225, 50);
            this.pictureBoxConfiguration.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxConfiguration.MaximumSize = new System.Drawing.Size(20, 20);
            this.pictureBoxConfiguration.Name = "pictureBoxConfiguration";
            this.pictureBoxConfiguration.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxConfiguration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConfiguration.TabIndex = 2;
            this.pictureBoxConfiguration.TabStop = false;
            this.pictureBoxConfiguration.Click += new System.EventHandler(this.pictureBoxConfiguration_Click);
            // 
            // flowLayoutPanel
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.flowLayoutPanel, 2);
            this.flowLayoutPanel.Controls.Add(this.listViewMain);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(250, 700);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.Controls.Add(this.titleText, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanel, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelStatusOverview, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxConfiguration, 1, 1);
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
            // listViewMain
            // 
            this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewMain.Location = new System.Drawing.Point(3, 3);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(247, 249);
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
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
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Website Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfiguration)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label labelStatusOverview;
        private System.Windows.Forms.PictureBox pictureBoxConfiguration;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ListView listViewMain;
    }
}

