using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.Update_Inventory.Class
{
    internal class Placeholder
    {

        public static string GetRealText(TextBox tb)
        {
            var tag = tb.Tag as string;
            var text = tb.Text?.Trim();
            return (tag != null && text == tag) ? string.Empty : text;
        }
        public static void SetupPlaceholder(TextBox tb, string placeholder, Color? hintColor = null)
        {
            // Lưu placeholder vào Tag (đơn giản)
            tb.Tag = placeholder;

            // Màu chữ gợi ý (mặc định xám)
            Color phColor = hintColor ?? Color.Gray;
            Color normalColor = SystemColors.WindowText;

            // Hàm hiển thị gợi ý
            void ShowPlaceholder()
            {
                if (string.IsNullOrEmpty(tb.Text) || tb.Text == (string)tb.Tag)
                {
                    tb.ForeColor = phColor;
                    tb.Text = (string)tb.Tag;
                }
            }

            // Hàm xóa gợi ý
            void HidePlaceholder()
            {
                if (tb.Text == (string)tb.Tag)
                {
                    tb.Text = string.Empty;
                    tb.ForeColor = normalColor;
                }
            }

            // Khởi tạo trạng thái lúc đầu
            ShowPlaceholder();

            // Sự kiện vào/ra focus
            tb.Enter += (s, e) => HidePlaceholder();
            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                    ShowPlaceholder();
            };

            // Nếu cần: làm sạch gợi ý khi Text thay đổi bởi code bên ngoài
            tb.TextChanged += (s, e) =>
            {
                // Nếu người dùng đang gõ, tránh ghi đè
                if (!tb.Focused && string.IsNullOrWhiteSpace(tb.Text))
                {
                    ShowPlaceholder();
                }
                else if (tb.Focused && tb.ForeColor == phColor && tb.Text != (string)tb.Tag)
                {
                    tb.ForeColor = normalColor;
                }
            };
        }
    }
}
