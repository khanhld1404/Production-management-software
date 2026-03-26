using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class Form1 : Form
    {

        //đường dẫn đến nơi lưu trữ file đã được tải về và giải nén
        string download_url = Application.StartupPath + "\\DownloadedFiles\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kiểm tra sự tồn tại của file dẫn đến nơi lưu trữ dữ liệu
            CreateURL();
            //Thay file từ thư mục tải sang đường dẫn thực sự
            CopyFile(download_url, Application.StartupPath);

            Process.Start("EVS_ProductionStatus.exe");
            Application.Exit();
        }

        private void CreateURL()
        {
            if (!Directory.Exists(download_url))
                Directory.CreateDirectory(download_url);
        }

        //copy thông tin từ folder tải sang folder chạy
        private void CopyFile(string sourceDir, string targetDir)
        {

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                if (!file.Contains("Package.zip"))
                    File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);
            }
            foreach (var directory in Directory.GetDirectories(sourceDir))
                CopyFile(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }
    }
}
