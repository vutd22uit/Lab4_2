namespace Lab4_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUrl = new TextBox();
            txtFilePath = new TextBox();
            btnDownload = new Button();
            btnShowContent = new Button();
            webBrowser = new WebBrowser();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(21, 26);
            txtUrl.Margin = new Padding(5, 6, 5, 6);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(1257, 39);
            txtUrl.TabIndex = 0;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(21, 84);
            txtFilePath.Margin = new Padding(5, 6, 5, 6);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(1257, 39);
            txtFilePath.TabIndex = 1;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(21, 142);
            btnDownload.Margin = new Padding(5, 6, 5, 6);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(145, 46);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnShowContent
            // 
            btnShowContent.Location = new Point(176, 142);
            btnShowContent.Margin = new Padding(5, 6, 5, 6);
            btnShowContent.Name = "btnShowContent";
            btnShowContent.Size = new Size(122, 46);
            btnShowContent.TabIndex = 3;
            btnShowContent.Text = "Show";
            btnShowContent.UseVisualStyleBackColor = true;
            btnShowContent.Click += btnShowContent_Click;
            // 
            // webBrowser
            // 
            webBrowser.Location = new Point(21, 202);
            webBrowser.Margin = new Padding(5, 6, 5, 6);
            webBrowser.MinimumSize = new Size(32, 40);
            webBrowser.Name = "webBrowser";
            webBrowser.Size = new Size(1259, 674);
            webBrowser.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 900);
            Controls.Add(webBrowser);
            Controls.Add(btnShowContent);
            Controls.Add(btnDownload);
            Controls.Add(txtFilePath);
            Controls.Add(txtUrl);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Download Web Page";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnShowContent;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}
