using System;
using System.Net;
using System.Windows.Forms;

namespace Lab4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true; // Vô hiệu hóa thông báo lỗi script
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string filePath = txtFilePath.Text;

            if (string.IsNullOrEmpty(Path.GetExtension(filePath)))
            {
                MessageBox.Show("Please provide a valid file path including file name and extension.");
                return;
            }

            DownloadWebPage(url, filePath);
        }

        private void btnShowContent_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            if (File.Exists(filePath))
            {
                webBrowser.Navigate(filePath);
            }
            else
            {
                MessageBox.Show("File does not exist. Please download it first.");
            }
        }

        private void DownloadWebPage(string url, string filePath)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, filePath);
                    MessageBox.Show("Download completed.");
                }
            }
            catch (WebException webEx)
            {
                string message = $"WebException: {webEx.Message}\nStatus: {webEx.Status}";
                if (webEx.Response != null)
                {
                    using (var reader = new StreamReader(webEx.Response.GetResponseStream()))
                    {
                        message += $"\nResponse: {reader.ReadToEnd()}";
                    }
                }
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
