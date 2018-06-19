using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TyreuPlayer
{
    public partial class Main
    {
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height
        protected override void WndProc(ref Message message)
        {
            const int border = 10, HTLEFT = 10,
                                   HTRIGHT = 11,
                                   HTTOP = 12,
                                   HTTOPLEFT = 13,
                                   HTTOPRIGHT = 14,
                                   HTBOTTOM = 15,
                                   HTBOTTOMLEFT = 16,
                                   HTBOTTOMRIGHT = 17;
            Rectangle Top = new Rectangle(0, 0, this.ClientSize.Width, border);
            Rectangle Left = new Rectangle(0, 0, border, this.ClientSize.Height);
            Rectangle Bottom = new Rectangle(0, this.ClientSize.Height - border, this.ClientSize.Width, border);
            Rectangle Right = new Rectangle(this.ClientSize.Width - border, 0, border, this.ClientSize.Height);

            Rectangle TopLeft = new Rectangle(0, 0, border, border);
            Rectangle TopRight = new Rectangle(this.ClientSize.Width - border, 0, border, border);
            Rectangle BottomLeft = new Rectangle(0, this.ClientSize.Height - border, border, border);
            Rectangle BottomRight = new Rectangle(this.ClientSize.Width - border, this.ClientSize.Height - border, border, border);

            if (message.Msg == 0x84)
            {
                var cursor = PointToClient(new Point(message.LParam.ToInt32()));

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;

                return;
            }
            base.WndProc(ref message);
        }
        private void CloseLabel_Click(object sender, EventArgs e) => Close();
        private void CloseLabel_MouseHover(object sender, EventArgs e) => CloseLabel.BackColor = Color.Red;
        private void CloseLabel_MouseDown(object sender, MouseEventArgs e) => CloseLabel.BackColor = Color.DarkRed;
        private void MinimizeLabel_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void MaximizeLabel_Click(object sender, EventArgs e) => WindowState = FormWindowState.Maximized;
        private void MinimizeAndMaximize_MouseHover(object sender, EventArgs e) => (sender as Telerik.WinControls.UI.RadLabel).BackColor = Color.DarkGray;
        private void MinimizeAndMaximize_MouseDown(object sender, MouseEventArgs e) => (sender as Telerik.WinControls.UI.RadLabel).BackColor = Color.Gray;
        private void AnyLabel_MouseLeave(object sender, EventArgs e) => (sender as Telerik.WinControls.UI.RadLabel).BackColor = Color.Transparent;
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                (sender as Control).Capture = false;//не ловит событие
                Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                DefWndProc(ref m);
            }
        }
        private void NameLabel_MouseHover(object sender, EventArgs e) => NameLabel.ForeColor = Color.Red;
        private void NameLabel_Click(object sender, EventArgs e) => Process.Start("http://t.me/vlad_semenko");
        private void NameLabel_MouseLeave(object sender, EventArgs e) => NameLabel.ForeColor = Color.White;
        private void NameLabel_MouseDown(object sender, MouseEventArgs e) => NameLabel.Location = new Point(NameLabel.Location.X + 3, NameLabel.Location.Y + 3);
        private void NameLabel_MouseUp(object sender, MouseEventArgs e) => NameLabel.Location = new Point(NameLabel.Location.X - 3, NameLabel.Location.Y - 3);
    }
}
