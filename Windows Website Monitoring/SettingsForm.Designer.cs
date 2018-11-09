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
            this.listViewWebsites = new System.Windows.Forms.ListView();
            this.columnHeaderWebsiteUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWebsiteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelNewUrl = new System.Windows.Forms.Label();
            this.labelWebsiteName = new System.Windows.Forms.Label();
            this.textBoxWebsiteName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelmain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTopToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.panelWebsiteUrl = new System.Windows.Forms.Panel();
            this.textBoxWebSiteUrl = new System.Windows.Forms.TextBox();
            this.panelWebsiteName = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelListView = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tableLayoutPanelmain.SuspendLayout();
            this.tableLayoutPanelTopToolbar.SuspendLayout();
            this.panelWebsiteUrl.SuspendLayout();
            this.panelWebsiteName.SuspendLayout();
            this.flowLayoutPanelBottom.SuspendLayout();
            this.panelListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.Coral;
            this.titleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleText.ForeColor = System.Drawing.Color.White;
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Margin = new System.Windows.Forms.Padding(0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(800, 40);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Website Monitoring";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listViewWebsites
            // 
            this.listViewWebsites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewWebsites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWebsiteName,
            this.columnHeaderWebsiteUrl});
            this.listViewWebsites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWebsites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listViewWebsites.FullRowSelect = true;
            this.listViewWebsites.Location = new System.Drawing.Point(0, 0);
            this.listViewWebsites.Margin = new System.Windows.Forms.Padding(0);
            this.listViewWebsites.MultiSelect = false;
            this.listViewWebsites.Name = "listViewWebsites";
            this.listViewWebsites.Size = new System.Drawing.Size(800, 280);
            this.listViewWebsites.TabIndex = 3;
            this.listViewWebsites.UseCompatibleStateImageBehavior = false;
            this.listViewWebsites.View = System.Windows.Forms.View.Details;
            this.listViewWebsites.SelectedIndexChanged += new System.EventHandler(this.listViewWebsites_SelectedIndexChanged);
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
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Location = new System.Drawing.Point(759, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(41, 40);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseCompatibleTextRendering = true;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelNewUrl
            // 
            this.labelNewUrl.AutoSize = true;
            this.labelNewUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNewUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNewUrl.Location = new System.Drawing.Point(386, 5);
            this.labelNewUrl.Margin = new System.Windows.Forms.Padding(5);
            this.labelNewUrl.Name = "labelNewUrl";
            this.labelNewUrl.Size = new System.Drawing.Size(112, 30);
            this.labelNewUrl.TabIndex = 7;
            this.labelNewUrl.Text = "Website URL:";
            this.labelNewUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWebsiteName
            // 
            this.labelWebsiteName.AutoSize = true;
            this.labelWebsiteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWebsiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWebsiteName.Location = new System.Drawing.Point(5, 5);
            this.labelWebsiteName.Margin = new System.Windows.Forms.Padding(5);
            this.labelWebsiteName.Name = "labelWebsiteName";
            this.labelWebsiteName.Size = new System.Drawing.Size(115, 30);
            this.labelWebsiteName.TabIndex = 8;
            this.labelWebsiteName.Text = "Website Name:";
            this.labelWebsiteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxWebsiteName
            // 
            this.textBoxWebsiteName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWebsiteName.BackColor = System.Drawing.Color.White;
            this.textBoxWebsiteName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWebsiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxWebsiteName.Location = new System.Drawing.Point(5, 5);
            this.textBoxWebsiteName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWebsiteName.MinimumSize = new System.Drawing.Size(0, 20);
            this.textBoxWebsiteName.Name = "textBoxWebsiteName";
            this.textBoxWebsiteName.Size = new System.Drawing.Size(234, 20);
            this.textBoxWebsiteName.TabIndex = 9;
            // 
            // tableLayoutPanelmain
            // 
            this.tableLayoutPanelmain.ColumnCount = 1;
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelmain.Controls.Add(this.tableLayoutPanelTopToolbar, 0, 1);
            this.tableLayoutPanelmain.Controls.Add(this.titleText, 0, 0);
            this.tableLayoutPanelmain.Controls.Add(this.flowLayoutPanelBottom, 0, 3);
            this.tableLayoutPanelmain.Controls.Add(this.panelListView, 0, 2);
            this.tableLayoutPanelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelmain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelmain.Name = "tableLayoutPanelmain";
            this.tableLayoutPanelmain.RowCount = 4;
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelmain.Size = new System.Drawing.Size(800, 400);
            this.tableLayoutPanelmain.TabIndex = 10;
            // 
            // tableLayoutPanelTopToolbar
            // 
            this.tableLayoutPanelTopToolbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelTopToolbar.ColumnCount = 5;
            this.tableLayoutPanelTopToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanelTopToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTopToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanelTopToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTopToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelTopToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTopToolbar.Controls.Add(this.labelNewUrl, 2, 0);
            this.tableLayoutPanelTopToolbar.Controls.Add(this.labelWebsiteName, 0, 0);
            this.tableLayoutPanelTopToolbar.Controls.Add(this.panelWebsiteName, 1, 0);
            this.tableLayoutPanelTopToolbar.Controls.Add(this.buttonAdd, 4, 0);
            this.tableLayoutPanelTopToolbar.Controls.Add(this.panelWebsiteUrl, 3, 0);
            this.tableLayoutPanelTopToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTopToolbar.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanelTopToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTopToolbar.Name = "tableLayoutPanelTopToolbar";
            this.tableLayoutPanelTopToolbar.RowCount = 1;
            this.tableLayoutPanelTopToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTopToolbar.Size = new System.Drawing.Size(800, 40);
            this.tableLayoutPanelTopToolbar.TabIndex = 11;
            // 
            // panelWebsiteUrl
            // 
            this.panelWebsiteUrl.BackColor = System.Drawing.Color.White;
            this.panelWebsiteUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWebsiteUrl.Controls.Add(this.textBoxWebSiteUrl);
            this.panelWebsiteUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWebsiteUrl.Location = new System.Drawing.Point(508, 5);
            this.panelWebsiteUrl.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panelWebsiteUrl.Name = "panelWebsiteUrl";
            this.panelWebsiteUrl.Size = new System.Drawing.Size(251, 30);
            this.panelWebsiteUrl.TabIndex = 12;
            // 
            // textBoxWebSiteUrl
            // 
            this.textBoxWebSiteUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWebSiteUrl.BackColor = System.Drawing.Color.White;
            this.textBoxWebSiteUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWebSiteUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxWebSiteUrl.Location = new System.Drawing.Point(5, 5);
            this.textBoxWebSiteUrl.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWebSiteUrl.MinimumSize = new System.Drawing.Size(0, 20);
            this.textBoxWebSiteUrl.Name = "textBoxWebSiteUrl";
            this.textBoxWebSiteUrl.Size = new System.Drawing.Size(239, 20);
            this.textBoxWebSiteUrl.TabIndex = 9;
            // 
            // panelWebsiteName
            // 
            this.panelWebsiteName.BackColor = System.Drawing.Color.White;
            this.panelWebsiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWebsiteName.Controls.Add(this.textBoxWebsiteName);
            this.panelWebsiteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWebsiteName.Location = new System.Drawing.Point(130, 5);
            this.panelWebsiteName.Margin = new System.Windows.Forms.Padding(5);
            this.panelWebsiteName.Name = "panelWebsiteName";
            this.panelWebsiteName.Size = new System.Drawing.Size(246, 30);
            this.panelWebsiteName.TabIndex = 12;
            // 
            // flowLayoutPanelBottom
            // 
            this.flowLayoutPanelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelBottom.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelBottom.Controls.Add(this.buttonSave);
            this.flowLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBottom.Location = new System.Drawing.Point(0, 360);
            this.flowLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            this.flowLayoutPanelBottom.Size = new System.Drawing.Size(800, 40);
            this.flowLayoutPanelBottom.TabIndex = 10;
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(675, 0);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 40);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseCompatibleTextRendering = true;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(550, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 40);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseCompatibleTextRendering = true;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelListView
            // 
            this.panelListView.Controls.Add(this.buttonRemove);
            this.panelListView.Controls.Add(this.listViewWebsites);
            this.panelListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListView.Location = new System.Drawing.Point(0, 80);
            this.panelListView.Margin = new System.Windows.Forms.Padding(0);
            this.panelListView.Name = "panelListView";
            this.panelListView.Size = new System.Drawing.Size(800, 280);
            this.panelListView.TabIndex = 11;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRemove.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRemove.Location = new System.Drawing.Point(760, 0);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(40, 280);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.UseCompatibleTextRendering = true;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
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
            this.tableLayoutPanelmain.ResumeLayout(false);
            this.tableLayoutPanelTopToolbar.ResumeLayout(false);
            this.tableLayoutPanelTopToolbar.PerformLayout();
            this.panelWebsiteUrl.ResumeLayout(false);
            this.panelWebsiteUrl.PerformLayout();
            this.panelWebsiteName.ResumeLayout(false);
            this.panelWebsiteName.PerformLayout();
            this.flowLayoutPanelBottom.ResumeLayout(false);
            this.panelListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.ListView listViewWebsites;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelNewUrl;
        private System.Windows.Forms.Label labelWebsiteName;
        private System.Windows.Forms.TextBox textBoxWebsiteName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelmain;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsiteName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBottom;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelListView;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Panel panelWebsiteName;
        private System.Windows.Forms.Panel panelWebsiteUrl;
        private System.Windows.Forms.TextBox textBoxWebSiteUrl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopToolbar;
    }
}