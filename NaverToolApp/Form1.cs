using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Diagnostics;

namespace NaverToolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = Environment.CurrentDirectory.ToString();

        

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            const int kNotFound = -1;

            var startIdx = strSource.IndexOf(strStart);
            if (startIdx != kNotFound)
            {
                startIdx += strStart.Length;
                var endIdx = strSource.IndexOf(strEnd, startIdx);
                if (endIdx > startIdx)
                {
                    return strSource.Substring(startIdx, endIdx - startIdx);
                }
            }
            return String.Empty;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //string url = txtURL.Text;
            string result = "";
            //using (HttpClient client = new HttpClient())
            //{
            //    using (HttpResponseMessage response = client.GetAsync(url).Result)
            //    {
            //        using (HttpContent content = response.Content)
            //        {
            //            result = content.ReadAsStringAsync().Result;
            //            System.IO.File.WriteAllText(path + @"\html.txt", result);
            //        }
            //    }
            //}

            result = rtbSource.Text;
            int number = 1;

            string DATESTAMP = DateTime.Now.ToString("yyyy-MM-dd");
            string DownloadFolder = path + @"\PICTURES_" + DATESTAMP;
            System.IO.Directory.CreateDirectory(DownloadFolder);

            foreach (var line in rtbSource.Lines)
            {
                
                if (line.Contains("?type=w1200"))
                {
                    string data = getBetween(line, "data-src=\"", "?type");
                    string file = System.IO.Path.GetFileName(data);
                    rtbLink.Text += data + "\n";
                    
                    
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(data, DownloadFolder+@"\"+ file);
                    number++;
                }
                
            }
            if (MessageBox.Show(@"Do you want open backup folder?", "DOWNLOAD COMPLETED", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start("explorer.exe", DownloadFolder);
            }

            //foreach (var line in rtbSource.Lines)
            //{

            //}






        }

        

private void rtbSource_Click(object sender, EventArgs e)
        {
            rtbSource.SelectAll();
        }

        private void rtbLink_Click(object sender, EventArgs e)
        {
            rtbLink.SelectAll();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string textfile = rtbLink.Text;
            File.WriteAllText(path + @"\Naver_link.txt", textfile);
            string downloadfile = path + @"\Naver_link.txt";
            if (File.Exists(downloadfile))
            {
                MessageBox.Show("Text file export completed.");
            }
            else
                MessageBox.Show("Can not export file.");

            //WebClient webClient = new WebClient();
            //webClient.DownloadFile(path + @"\Naver_link.txt", @"c:\myfile.txt");
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            rtbSource.Text = Clipboard.GetText();
        }
    }
}
