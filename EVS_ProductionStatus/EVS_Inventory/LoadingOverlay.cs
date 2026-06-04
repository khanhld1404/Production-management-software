 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{

    public partial class LoadingOverlay : UserControl
    {
        private Label _label;
        private ProgressBar _progress;
        private FlowLayoutPanel _stack;

        public string Message
        {
            get => _label.Text;
            set => _label.Text = value;
        }

        public LoadingOverlay()
        {
            // Panel overlay phủ đầy
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(180, Color.DarkGray); // mờ giả (WinForms không alpha thật)
            this.Enabled = true; // quan trọng: để overlay bắt chuột

            // Bắt chuột/scroll để chặn thao tác nền
            this.MouseDown += (s, e) => { /* swallow */ };
            this.MouseMove += (s, e) => { /* swallow */ };
            this.MouseWheel += (s, e) => { /* swallow */ };

            _label = new Label
            {
                ForeColor = Color.Black,
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            _progress = new ProgressBar
            {
                Style = ProgressBarStyle.Marquee,
                MarqueeAnimationSpeed = 30,
                Width = 220
            };

            _stack = new FlowLayoutPanel
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                FlowDirection = FlowDirection.TopDown,
                Padding = new Padding(10),
                WrapContents = false
            };
            _stack.Controls.Add(_label);
            _stack.Controls.Add(_progress);

            this.Controls.Add(_stack);
            _stack.Anchor = AnchorStyles.None;

            this.Resize += (s, e) => CenterStack();
            this.Load += (s, e) => CenterStack();
        }

        private void CenterStack()
        {
            // Căn giữa
            _stack.Left = (this.ClientSize.Width - _stack.Width) / 2;
            _stack.Top = (this.ClientSize.Height - _stack.Height) / 2;
        }
    }

}
