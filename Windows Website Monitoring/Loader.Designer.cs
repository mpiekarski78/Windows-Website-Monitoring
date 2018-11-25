namespace Windows_Website_Monitoring
{
    partial class FormLoader
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
            this.metroProgressBarLoader = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // metroProgressBarLoader
            // 
            this.metroProgressBarLoader.Location = new System.Drawing.Point(53, 164);
            this.metroProgressBarLoader.Name = "metroProgressBarLoader";
            this.metroProgressBarLoader.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBarLoader.Size = new System.Drawing.Size(300, 25);
            this.metroProgressBarLoader.TabIndex = 2;
            // 
            // FormLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Windows_Website_Monitoring.Properties.Resources.loading_screen_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(397, 247);
            this.ControlBox = false;
            this.Controls.Add(this.metroProgressBarLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormLoader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar metroProgressBarLoader;
    }
}