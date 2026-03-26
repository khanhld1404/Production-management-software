using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool ownsMutex;
            using (Mutex mutex = new Mutex(true, "EVS_ProductionStatus", out ownsMutex))
            {
                if (ownsMutex)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new CheckVersion());
                    mutex.ReleaseMutex();//chi duoc mo 1 chuong trinh trong cua mot thoi diem
                }
                else MessageBox.Show("Đang mở chương trình ở cửa sổ khác, vui lòng đóng hết cửa sổ", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
