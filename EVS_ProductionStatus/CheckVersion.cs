using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    public partial class CheckVersion : Form
    {
        //Đường dẫn đến version hiện tại
        string path_file_Version = Application.StartupPath + "\\Version.txt";
        //đường dẫn  version mới nhất
        string server_file_version = "http://10.239.1.54/VerControl/Uploaded/03/Version.txt";
        //đường dẫn đến nơi để tải file package về
        string server_zip_file = "http://10.239.1.54/VerControl/Uploaded/03/Package.zip";
        //Đường dẫn đến nơi lưu trữ các package
        string download_url = Application.StartupPath + "\\DownloadedFiles\\";

        public CheckVersion()
        {
            InitializeComponent();
        }
        private void CheckVersion_Load(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra xem đường dẫn có thực sự tồn tại không, nếu không có thì tự tạo đường dẫn
                CreateURL(download_url);
                //Đọc phiên bản version hiện tại
                string path_ver = File.ReadAllText(path_file_Version).Trim();

                string server_ver = "";

                //Đọc phiên bản version trên server
                using (WebClient w = new WebClient())
                {
                    Stream s = w.OpenRead(server_file_version);
                    StreamReader r = new StreamReader(s);
                    server_ver = r.ReadToEnd();
                }

                if (path_ver != server_ver)
                {
                    //Nếu khác phiên bản thì tải file package 
                    getFiles();
                    //Viết lại version ở máy local
                    File.WriteAllText(path_file_Version, server_ver);
                    //Copy file
                    this.Dispose();
                    // Gọi đến chương trình update để cập nhật lại file
                    Process.Start("Updater.exe");
                    Application.Exit();
                }
                else
                {
                    this.Hide();
                    //Mở chương trình chính
                    //CẬP NHẬT FORM ỨNG DỤNG MỞ ĐẦU TIÊN
                    HomeForm f = new HomeForm();
                    f.ShowDialog();
                    this.Dispose();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CreateURL(string _url)
        {
            //Kiểm tra đường dẫn
            if (!Directory.Exists(_url))
                Directory.CreateDirectory(_url);
        }

        private void getFiles()
        {
            //trỏ đến file package trong thư mục của máy local
            string download_zip_file = download_url + "Package.zip";

            //tải file package từ server về máy
            WebClient client = new WebClient();
            client.DownloadFile(server_zip_file, download_zip_file);

            //Giải nén file package
            using (ZipFile zip = new ZipFile(download_zip_file))
            {
                zip.ExtractAll(download_url, ExtractExistingFileAction.OverwriteSilently);
            }
        }
    }
}
