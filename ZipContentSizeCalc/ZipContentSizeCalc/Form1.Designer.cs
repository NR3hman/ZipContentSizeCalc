namespace ZipContentSizeCalc
{
    partial class zipContentSizeCalc
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
            this.openDirectoryPath = new System.Windows.Forms.TextBox();
            this.searchForZips = new System.Windows.Forms.Button();
            this.openDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openDirectoryPath
            // 
            this.openDirectoryPath.Location = new System.Drawing.Point(38, 103);
            this.openDirectoryPath.Name = "openDirectoryPath";
            this.openDirectoryPath.Size = new System.Drawing.Size(494, 26);
            this.openDirectoryPath.TabIndex = 0;
            // 
            // searchForZips
            // 
            this.searchForZips.Location = new System.Drawing.Point(38, 156);
            this.searchForZips.Name = "searchForZips";
            this.searchForZips.Size = new System.Drawing.Size(120, 43);
            this.searchForZips.TabIndex = 1;
            this.searchForZips.Text = "Search";
            this.searchForZips.UseVisualStyleBackColor = true;
            // 
            // openDirectory
            // 
            this.openDirectory.Location = new System.Drawing.Point(538, 100);
            this.openDirectory.Name = "openDirectory";
            this.openDirectory.Size = new System.Drawing.Size(97, 33);
            this.openDirectory.TabIndex = 2;
            this.openDirectory.Text = "Open";
            this.openDirectory.UseVisualStyleBackColor = true;
            this.openDirectory.Click += new System.EventHandler(this.openDirectory_Click);
            // 
            // zipContentSizeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 511);
            this.Controls.Add(this.openDirectory);
            this.Controls.Add(this.searchForZips);
            this.Controls.Add(this.openDirectoryPath);
            this.Name = "zipContentSizeCalc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox openDirectoryPath;
        private System.Windows.Forms.Button searchForZips;
        private System.Windows.Forms.Button openDirectory;
    }
}

