using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WMPLib;

namespace TyreuPlayer
{
    public partial class Main : RadForm
    {
        private string pathToMusic = @"C:\Users\semenko-vo\Downloads\music";
        public bool IsShuffle { get; set; }
        public bool IsPlaylistOpen { get; set; }
        public bool IsReplay { get; set; }
        public bool IsPlay { get; set; }
        public bool IsPaused { get; set; }
        public static Player Player { get; set; } = new Player();
        public WindowsMediaPlayer WMPlayer { get; set; } = new WindowsMediaPlayer();
        public Main()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            FolderToMusicTree(pathToMusic);
            IsPlaylistOpen = radCollapsiblePanel1.IsExpanded;
            PlaylistButton.Image = IsPlaylistOpen ? Properties.Resources.Меню_white : Properties.Resources.Меню_black;
        }
        private string SecondsToTime(int seconds) => $"{(seconds / 60):00}:{(seconds % 60):00}";
        private void Main_Shown(object sender, EventArgs e) { for (int i = (int)Opacity; i < 100; Thread.Sleep(5), Opacity += 0.01, i++) ; }
        private void VolumeTrackBar_ValueChanged(object sender, EventArgs e) => WMPlayer.settings.volume = (int)VolumeTrackBar.Value;
        private void TogglePlaylist(object sender, EventArgs e)
        {
            if (!IsPlaylistOpen)
            {
                new Thread(new ThreadStart(delegate { for (int i = 0; i < 74; Thread.Sleep(5), Width += 5, i++) ; })).Start();
                radCollapsiblePanel1.Expand();
                PlaylistButton.Image = IsPlaylistOpen ? Properties.Resources.Меню_black : Properties.Resources.Меню_white;
                IsPlaylistOpen = true;
            }
            else if (IsPlaylistOpen)
                radCollapsiblePanel1.Collapse();
        }
        private void ToggleReplay(object sender, EventArgs e)
        {
            IsReplay = !IsReplay;
            ReplayButton.Image = IsReplay ? Properties.Resources.Повторение_white : Properties.Resources.Повторение_black;
            WMPlayer.settings.setMode("loop", IsReplay);
        }
        private void ToggleShuffle(object sender, EventArgs e)
        {
            IsShuffle = !IsShuffle;
            ShuffleButton.Image = IsShuffle ? Properties.Resources.Перемешать_white : Properties.Resources.Перемешать_black;
            WMPlayer.settings.setMode("shuffle", IsShuffle);
        }
        private void TrackPlaying(object sender, EventArgs e)
        {
            DurationTrackBar.Maximum = (int)WMPlayer.currentMedia.duration + 1;
            DurationTrackBar.Value = (int)(WMPlayer.controls.currentPosition);
            CurrentDurationLabel.Text = SecondsToTime((int)WMPlayer.controls.currentPosition);
        }
        private void DurationTrackBar_MouseUp(object sender, MouseEventArgs e) => WMPlayer.controls.currentPosition = DurationTrackBar.Value;
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!IsPlay)
            {
                //если не играет музыка и она не на паузе
                if (!IsPaused)
                {
                    CurrentDurationLabel.Text = SecondsToTime((int)WMPlayer.controls.currentPosition);
                    PlayTrack(Player.Tracks[new Random().Next(0, Player.Tracks.Count)].FullName);
                }
                //если не играет музыка, потому что она паузе
                if (IsPaused)
                {
                    IsPaused = false;
                    timer1.Enabled = timer2.Enabled = true;
                    WMPlayer.controls.play();
                    PlayButton.Image = Properties.Resources.Пауза;
                }
            }
            else
            {
                WMPlayer.controls.pause();
                PlayButton.Image = Properties.Resources.Play;
                IsPaused = true;
                timer1.Enabled = false;
            }
            IsPlay = !IsPlay;
        }
        private void PlayTrack(string url)
        {
            WMPlayer.URL = url;
            TagLib.File song = TagLib.File.Create(WMPlayer.URL);
            FullDurationLabel.Text = SecondsToTime((int)song.Properties.Duration.TotalSeconds);
            TitleLabel.Text = song.Tag.Title;
            ArtistLabel.Text = song.Tag.FirstPerformer;
            timer1.Enabled = timer2.Enabled = true;
            PlayButton.Image = Properties.Resources.Пауза;
            Player.Current = Player.Tracks.Find(track => track.FullName == url);
            WMPlayer.controls.play();
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.O) MessageBox.Show("Открыть выбор папки");
            else if (e.Control && e.KeyCode == Keys.O) MessageBox.Show("Открыть выбор трека");
            else if (e.KeyCode == Keys.F1) MessageBox.Show("Prev");
            else if (e.KeyCode == Keys.F2) MessageBox.Show("Next");
            else if (e.KeyCode == Keys.F3) MessageBox.Show("Search");
            else if (e.KeyCode == Keys.F4) MessageBox.Show("Track info");
            else if (e.KeyCode == Keys.Space) PlayButton_Click(sender, new EventArgs());
        }
        private void ClosingPlaylist(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsPlaylistOpen = !IsPlaylistOpen;
            PlaylistButton.Image = IsPlaylistOpen ? Properties.Resources.Меню_white : Properties.Resources.Меню_black;
            new Thread(new ThreadStart(delegate { for (int i = 0; i < 74; Thread.Sleep(5), Width -= 5, i++) ; })).Start();
        }
        public string[] GetAllFiles(string path, string searchPattern, SearchOption searchOption)
        {
            List<string> files = new List<string>();
            searchPattern.Split('|').ToList().ForEach(sp => files.AddRange(Directory.GetFiles(path, sp, searchOption)));
            files.Sort();
            return files.ToArray();
        }
        private static RadTreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new RadTreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles().Where(f => "*.mp3|*.wav|*.m4a|*.flac|*.ogg|*.wma".Contains(f.Extension)))
            {
                directoryNode.Nodes.Add(new RadTreeNode(file.Name.Replace(file.Extension, "").Replace("_", " ").Trim()));
                Player.Tracks.Add(new Track { Name = file.Name, FullName = file.FullName });
            }
            return directoryNode;
        }
        private void FolderToMusicTree(string path)
        {
            PlayListTree.Nodes.Clear();
            PlayListTree.Nodes.Add(CreateDirectoryNode(Directory.CreateDirectory(path)));
            IWMPPlaylist playlist = WMPlayer.playlistCollection.newPlaylist("tyreuList");
            IWMPMedia media;
            foreach (Track track in Player.Tracks)
            {
                media = WMPlayer.newMedia(track.FullName);
                playlist.appendItem(media);
            }
            WMPlayer.currentPlaylist = playlist;
            WMPlayer.controls.stop();
        }
        private void PlayListTree_NodeMouseDoubleClick(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                PlayTrack((Player.Current = Player.Tracks.Find(track => track.FullName.Contains(e.Node.Text))).FullName);
                TagLib.Tag tag = TagLib.File.Create(Player.Current.FullName).Tag;
                if (tag.Title != null && tag.FirstPerformer != null)
                {
                    ArtistLabel.Text = TagLib.File.Create(Player.Current.FullName).Tag.Performers.First();
                    TitleLabel.Text = TagLib.File.Create(Player.Current.FullName).Tag.Title+ " | ";
                }
                else
                {
                    ArtistLabel.Text = e.Node.Text.Split('-')[0];
                    TitleLabel.Text = e.Node.Text.Split('-')[1] + " | ";
                }
                Player.Current.Artist = ArtistLabel.Text;
                Player.Current.Title = TitleLabel.Text;
            }
        }
        private void ScrollArtist(object sender, EventArgs e)
        {
            if (TitleLabel.Text.Length > 0)
                TitleLabel.Text = TitleLabel.Text.Substring(1) + TitleLabel.Text.Substring(0, 1);
        }
        private void NextTrackButton_Click(object sender, EventArgs e)
        {
            if(IsShuffle)
                PlayTrack(Player.Tracks[new Random().Next(0, Player.Tracks.Count)].FullName);
            else
                PlayTrack(Player.Tracks[Player.Tracks.IndexOf(Player.Current)+1].FullName);
        }
        private void PrevTrackButton_Click(object sender, EventArgs e)
        {
            if (IsShuffle)
                PlayTrack(Player.Tracks[new Random().Next(0, Player.Tracks.Count)].FullName);           //переделать чтоб брал из истории, а не рандом
            else
                PlayTrack(Player.Tracks[Player.Tracks.IndexOf(Player.Current) - 1].FullName);
        }
    }
}