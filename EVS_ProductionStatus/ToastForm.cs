using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    public partial class ToastForm : Form
    {
        private readonly string _caption;
        private readonly System.Threading.Timer _timeoutTimer;

        private ToastForm(
            string text,
            string caption,
            int timeout,
            MessageBoxIcon icon)
        {
            _caption = caption;

            _timeoutTimer = new System.Threading.Timer(
                OnTimerElapsed,
                null,
                timeout,
                Timeout.Infinite);

            MessageBox.Show(
                text,
                caption,
                MessageBoxButtons.OK,
                icon);
        }

        public static void Show(
            string title,
            string message,
            int timeout = 2000,
            MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            new ToastForm(
                message,
                title,
                timeout,
                icon);
        }

        private void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow(null, _caption);

            if (mbWnd != IntPtr.Zero)
            {
                SendMessage(
                    mbWnd,
                    WM_CLOSE,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }

            _timeoutTimer.Dispose();
        }

        private const uint WM_CLOSE = 0x0010;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(
            string lpClassName,
            string lpWindowName);

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            uint Msg,
            IntPtr wParam,
            IntPtr lParam);
    }
}