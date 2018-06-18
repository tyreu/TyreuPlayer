using NAudio.CoreAudioApi;
using System;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace TyreuPlayer
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        public bool IsShuffle { get; set; }
        public bool IsPlaylistOpen { get; set; }
        public bool IsReplay { get; set; }
        public bool IsPlay { get; set; }
        public bool IsPaused { get; set; }
        public WindowsMediaPlayer Player { get; set; } = new WindowsMediaPlayer();
        public Main() => InitializeComponent();
        private string SecondsToTime(int seconds) => $"{(seconds / 60):00}:{(seconds % 60):00}";
        private void VolumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active).ToList().ForEach(device => device.AudioEndpointVolume.MasterVolumeLevelScalar = VolumeTrackBar.Value / 100);
        }
        private void TogglePlaylist(object sender, EventArgs e)
        {
            IsPlaylistOpen = !IsPlaylistOpen;
            PlaylistButton.Image = IsPlaylistOpen ? Properties.Resources.Меню_white : Properties.Resources.Меню_black;
        }
        private void ToggleReplay(object sender, EventArgs e)
        {
            IsReplay = !IsReplay;
            ReplayButton.Image = IsReplay ? Properties.Resources.Повторение_white : Properties.Resources.Повторение_black;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DurationTrackBar.Maximum = (int)Player.currentMedia.duration;
            DurationTrackBar.Value = (int)(Player.controls.currentPosition);
            CurrentDurationLabel.Text = SecondsToTime((int)Player.controls.currentPosition);
        }
        private void DurationTrackBar_MouseUp(object sender, MouseEventArgs e)=> Player.controls.currentPosition = DurationTrackBar.Value;
        private void ToggleShuffle(object sender, EventArgs e)
        {
            IsShuffle = !IsShuffle;
            ShuffleButton.Image = IsShuffle ? Properties.Resources.Перемешать_white : Properties.Resources.Перемешать_black;
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!IsPlay && !IsPaused)
            {
                CurrentDurationLabel.Text = SecondsToTime((int)Player.controls.currentPosition);
                Player.URL = @"1.mp3";
                Player.controls.play();
                TagLib.File song = TagLib.File.Create(Player.URL);
                FullDurationLabel.Text = SecondsToTime((int)song.Properties.Duration.TotalSeconds);
                TitleLabel.Text = song.Tag.Title;
                ArtistLabel.Text = song.Tag.FirstPerformer;
                timer1.Enabled = true;

                PlayButton.Image = Properties.Resources.Пауза;
            }
            else if (!IsPlay && IsPaused)
            {
                timer1.Enabled = true;
                Player.controls.play();
                PlayButton.Image = Properties.Resources.Play;
            }
            else
            {
                timer1.Enabled = false;
                Player.controls.pause();
                PlayButton.Image = Properties.Resources.Play;
                IsPaused = true;
            }
            IsPlay = !IsPlay;
        }
    }
}