using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace TyreuPlayer
{
    public partial class Main
    {
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
        private void Main_Shown(object sender, EventArgs e) => new Func<double>(ShowForm).BeginInvoke(delegate (IAsyncResult ar) { ((Func<double>)(ar as AsyncResult).AsyncDelegate).EndInvoke(ar); }, null);
        private double ShowForm()
        {
            for (int i = (int)Opacity; i < 100; Thread.Sleep(5), Opacity += 0.01, i++) ;
            return Opacity;
        }
    }
}
