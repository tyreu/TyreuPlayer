using System;
using System.Windows.Forms;

namespace TyreuPlayer
{
    public partial class EditTrackInfoForm : Telerik.WinControls.UI.RadForm
    {
        Track track;
        TagLib.File file;
        public EditTrackInfoForm(int index)
        {
            InitializeComponent();
            track = Main.Player.Tracks[index];
            file = TagLib.File.Create(track.FullName);
            ArtistTextBox.Text = file.Tag.Performers.Length > 0 ? file.Tag.Performers[0] : "";
            AlbumTextBox.Text = file.Tag.Album;
            TitleTextBox.Text = file.Tag.Title;
        }
        private void Close(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Сохранить изменения?", "Подтверждение изменений", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                file.Tag.Performers = new[] { ArtistTextBox.Text };
                file.Tag.Album = AlbumTextBox.Text;
                file.Tag.Title = TitleTextBox.Text;
                file.Save();
            }
            Close();
        }
    }
}
