using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using Telerik.WinControls.UI;
using WMPLib;

/* 1. Автопереключение на след. неслучайный трек
 * 2. Сохранение и загрузка плейлистов
 * 3. Вывод информации о треке
 * 4. Поиск трека
 */
namespace TyreuPlayer
{
    public partial class Main : RadForm
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Player));
        /// <summary>
        /// Экземпляр плеера
        /// </summary>
        public static Player Player { get; set; } = new Player();
        /// <summary>
        /// Экземпляр Windows Media Player для воспроизведения
        /// </summary>
        public WindowsMediaPlayer WMPlayer { get; set; } = new WindowsMediaPlayer();
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Main()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);//отрисовывать ли форму после изменения границ
            Player.IsPlaylistOpen = radCollapsiblePanel1.IsExpanded;//указываем открыт ли плейлист
            PlaylistButton.Image = Player.IsPlaylistOpen ? Properties.Resources.Меню_white : Properties.Resources.Меню_black;//указываем изображение кнопки Play
            VolumeTrackBar.TrackBarElement.Children[0].Click += delegate { if (VolumeTrackBar.Value >= 5) VolumeTrackBar.Value -= 5; else VolumeTrackBar.Value = 0; };//громкость вниз
            VolumeTrackBar.TrackBarElement.Children[2].Click += delegate { if (VolumeTrackBar.Value <= 95) VolumeTrackBar.Value += 5; else VolumeTrackBar.Value = 100; };//громкость вверх
            PlayerContextMenu.Items["AddToQueueItem"].Click += AddToQueue;
            PlayerContextMenu.Items["AddTrackItem"].Click += AddTrack;
            PlayerContextMenu.Items["DeleteFromQueueItem"].Click += DeleteFromQueue;
        }
        /// <summary>
        /// Загрузка данных плеера
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists("player.xml"))
            {
                using (FileStream fs = new FileStream("player.xml", FileMode.OpenOrCreate))
                    Player = (Player)xmlSerializer.Deserialize(fs);
                Playlist.DataSource = Player.Tracks;
            }
            else
                FolderToPlaylist(Player.PathToMusic);//указываем путь к папке с музыкой и конвертируем ее в дерево треков
            LoadSettings();//загружаем настройки
        }
        /// <summary>
        /// Загружает настройки и опции плеера
        /// </summary>
        private void LoadSettings()
        {
            if (Player.IsPlaylistOpen)
            {
                for (int i = 0; i < 37; Thread.Sleep(5), Width += 10, i++) ;
                radCollapsiblePanel1.Expand();
            }
            else Width -= 370;
            if (Player.IsPlay)
            {
                try { PlayTrack(Player.Current.FullName); }
                catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
            }

            ShuffleButton.Image = Player.IsShuffle ? Properties.Resources.Перемешать_white : Properties.Resources.Перемешать_black;
            PlaylistButton.Image = !Player.IsPlaylistOpen ? Properties.Resources.Меню_black : Properties.Resources.Меню_white;
            ReplayButton.Image = Player.IsReplay ? Properties.Resources.Повторение_white : Properties.Resources.Повторение_black;

            WMPlayer.settings.setMode("shuffle", Player.IsShuffle);
            WMPlayer.settings.setMode("loop", Player.IsReplay);
        }
        /// <summary>
        /// Сохранить данные и закрыть программу
        /// </summary>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (FileStream fs = new FileStream("player.xml", FileMode.OpenOrCreate))
                xmlSerializer.Serialize(fs, Player);
        }
        /// <summary>
        /// Открывает диалоговое окно для выбора трека
        /// </summary>
        private void AddTrack(object sender, EventArgs e) => OpenTrack.ShowDialog();
        /// <summary>
        /// Добавляет выбранный трек в очередь
        /// </summary>
        private void AddToQueue(object sender, EventArgs e)
        {
            Player.Queue.Enqueue(Player.Tracks.Find(track => track.FullName.Contains(Playlist.SelectedItem.Text)));
        }
        /// <summary>
        /// Удаляет выбранный трек из очереди
        /// </summary>
        private void DeleteFromQueue(object sender, EventArgs e)
        {
            Player.Queue = new Queue<Track>(Player.Queue.Where(t => t.FullName != Player.Tracks.Find(track => track.FullName.Contains(Playlist.SelectedItem.Text)).FullName));
        }
        /// <summary>
        /// Возвращает строковое представление секунд в формате мм:сс
        /// </summary>
        /// <param name="seconds">Количество секунд</param>
        private string SecondsToTime(int seconds) => $"{(seconds / 60):00}:{(seconds % 60):00}";
        /// <summary>
        /// Меняем значение прозрачности формы для плавного появления на экране
        /// </summary>
        private void Main_Shown(object sender, EventArgs e) { for (int i = (int)Opacity; i < 100; Thread.Sleep(5), Opacity += 0.01, i++) ; }
        private void VolumeTrackBar_ValueChanged(object sender, EventArgs e) => WMPlayer.settings.volume = (int)VolumeTrackBar.Value;
        private void TogglePlaylist(object sender, EventArgs e)
        {
            if (!Player.IsPlaylistOpen)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate { for (int i = 0; i < 74; Thread.Sleep(5), Width += 5, i++) ; }));
                radCollapsiblePanel1.Expand();
                PlaylistButton.Image = Player.IsPlaylistOpen ? Properties.Resources.Меню_black : Properties.Resources.Меню_white;
                Player.IsPlaylistOpen = true;
            }
            else if (Player.IsPlaylistOpen)
                radCollapsiblePanel1.Collapse();
        }
        private void ToggleReplay(object sender, EventArgs e)
        {
            Player.IsReplay = !Player.IsReplay;
            ReplayButton.Image = Player.IsReplay ? Properties.Resources.Повторение_white : Properties.Resources.Повторение_black;
            WMPlayer.settings.setMode("loop", Player.IsReplay);
        }
        private void ToggleShuffle(object sender, EventArgs e)
        {
            Player.IsShuffle = !Player.IsShuffle;
            ShuffleButton.Image = Player.IsShuffle ? Properties.Resources.Перемешать_white : Properties.Resources.Перемешать_black;
            WMPlayer.settings.setMode("shuffle", Player.IsShuffle);
        }
        private void ToggleLike(object sender, EventArgs e)
        {
            if (Player.Current != null)
            {
                LikeButton.Image = Player.Current.IsLike ? Properties.Resources.Дизлайк : Properties.Resources.Лайк;
                Player.Current.IsLike = !Player.Current.IsLike;
            }
        }
        private void TrackPlaying(object sender, EventArgs e)
        {
            if (Player.Current != null)
            {
                DurationTrackBar.Maximum = (int)WMPlayer?.currentMedia.duration + 1;
                DurationTrackBar.Value = (int)(WMPlayer.controls.currentPosition);
                CurrentDurationLabel.Text = SecondsToTime((int)WMPlayer.controls.currentPosition);
            }
        }
        /// <summary>
        /// Устанавливает положение бегунка текущей позиции трека в указанное пользователем место (ручная перемотка)
        /// </summary>
        private void DurationTrackBar_MouseUp(object sender, MouseEventArgs e) => WMPlayer.controls.currentPosition = DurationTrackBar.Value;
        /// <summary>
        /// Обрабатывает нажатие на кнопку Play
        /// </summary>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                //если трек не играет
                if (!Player.IsPlay)
                {
                    if (!Player.IsPaused)//если не играет музыка и она не на паузе
                    {
                        Track track = Player.Current ?? Player.Tracks[new Random().Next(0, Player.Tracks.Count)];
                        PlayTrack(track.FullName);//включаем трек
                        Player.History.Add(track);
                        Player.IsPaused = false;//отключаем паузу
                        timer1.Enabled = true;//включаем таймер для ползунка длительности
                    }
                    if (Player.IsPaused)//если не играет музыка, потому что она паузе
                    {
                        Player.IsPaused = false;//отключаем паузу
                        timer1.Enabled = true;//включаем таймер для ползунка длительности
                        WMPlayer.controls.play();//включаем трек
                        PlayButton.Image = Properties.Resources.Пауза;//меняем изображение кнопки Play
                    }
                }
                //если трек играет
                else
                {
                    WMPlayer.controls.pause();//ставим трек на паузу
                    PlayButton.Image = Properties.Resources.Play;//меняем изображение кнопки Play
                    Player.IsPaused = true;//ставим экземпляр плеера на паузу
                    timer1.Enabled = false;//отключаем таймер для ползунка длительности
                }
                Player.IsPlay = !Player.IsPlay; //меняем состояние воспроизведения трека на противоположное
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /// <summary>
        /// Воспроизвести трек
        /// </summary>
        /// <param name="url">Путь к треку</param>
        private void PlayTrack(string url)
        {
            WMPlayer.URL = url;//записать путь к треку в плеер
            TagLib.File song = TagLib.File.Create(WMPlayer.URL);//создать файл с тегами трека
            FullDurationLabel.Text = SecondsToTime((int)song.Properties.Duration.TotalSeconds);//выводим длительность трека
            TitleLabel.Text = song.Tag.Title;//выводим название трека
            ArtistLabel.Text = song.Tag.FirstPerformer;//выводим исполнителя трека
            timer1.Enabled = true;//включаем таймер для ползунка длительности
            PlayButton.Image = Properties.Resources.Пауза;//меняем изображение кнопки Play на паузу
            Player.Current = Player.Tracks.Find(track => track.FullName == url);//записываем текущий трек
            LikeButton.Image = Player.Current.IsLike ? Properties.Resources.Лайк : Properties.Resources.Дизлайк;
            WMPlayer.controls.play();//включаем воспроизведение

            CoverBox.Image = Properties.Resources.cover;
            TagLib.File f = new TagLib.Mpeg.AudioFile(url);
            if (f.Tag.Pictures.Length > 0)
            {
                TagLib.IPicture pic = f.Tag.Pictures[0];
                MemoryStream ms = new MemoryStream(pic.Data.Data);
                if (ms != null && ms.Length > 4096)
                    CoverBox.Image = Image.FromStream(ms).GetThumbnailImage(240, 240, null, IntPtr.Zero);
                ms.Close();
            }
        }
        /// <summary>
        /// Обработка горячих клавиш программы
        /// </summary>
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.O) MessageBox.Show("Открыть выбор папки");
            else if (e.Control && e.KeyCode == Keys.O) AddTrack(sender, new EventArgs());
            else if (e.KeyCode == Keys.F1) PrevTrackButton_Click(sender, new EventArgs());
            else if (e.KeyCode == Keys.F2) NextTrackButton_Click(sender, new EventArgs());
            else if (e.KeyCode == Keys.F3) MessageBox.Show("Search");
            else if (e.KeyCode == Keys.F4 && Playlist.SelectedItem != null)
            {
                new EditTrackInfoForm(Playlist.SelectedIndex).ShowDialog(this);
                /*обновить название в плейлисте*/
            }
            else if (e.KeyCode == Keys.Space && Player.Current != null) PlayButton_Click(sender, new EventArgs());
        }
        /// <summary>
        /// Сворачивает плейлист
        /// </summary>
        private void ClosingPlaylist(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Player.IsPlaylistOpen = !Player.IsPlaylistOpen;//меняем состояние плейлиста 
            PlaylistButton.Image = Player.IsPlaylistOpen ? Properties.Resources.Меню_white : Properties.Resources.Меню_black;//меняем изображение кнопки плейлиста
            new Thread(new ThreadStart(delegate { for (int i = 0; i < 74; Thread.Sleep(5), Width -= 5, i++) ; })).Start();//сворачиваем плейлист на форме
        }
        /// <summary>
        /// Возвращает список экземпляров класса Track 
        /// </summary>
        /// <param name="path">Путь к директории</param>
        /// <param name="searchPattern">Фильтр поиска</param>
        /// <param name="searchOption">Режим поиска</param>
        public List<Track> GetAllFiles(string path, string searchPattern, SearchOption searchOption)
        {
            try
            {
                List<string> files = new List<string>();
                searchPattern.Split('|').ToList().ForEach(sp => files.AddRange(Directory.GetFiles(path, sp, searchOption)));
                foreach (string filename in files)
                {
                    if (File.Exists(filename))
                    {
                        FileInfo info = new FileInfo(filename);
                        var tag = TagLib.File.Create(filename).Tag;
                        Player.Tracks.Add(new Track
                        {
                            Name = tag.Performers.Length > 0 ? $"{tag.Performers[0]} - {tag.Title}" : info.Name.Replace(info.Extension, "").Replace("_", " ").Trim(),
                            FullName = info.FullName
                        });
                        Player.Tracks = Player.Tracks.OrderBy(t => t.Name).ToList();
                    }
                }
                return Player.Tracks;
            }
            catch (DirectoryNotFoundException) { MessageBox.Show($"Путь '{path}' не найден!"); return null; }
        }
        /// <summary>
        /// Считывает треки и записывает их в плейлист 
        /// </summary>
        /// <param name="path">Путь к директории</param>
        private void FolderToPlaylist(string path) => Playlist.DataSource = GetAllFiles(path, "*.mp3|*.wav|*.m4a|*.flac|*.ogg|*.wma", SearchOption.AllDirectories);
        /// <summary>
        /// Включает следующий трек
        /// </summary>
        private void NextTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Player.Queue.Count > 0)
                {
                    Track track = Player.Queue.Dequeue();
                    PlayTrack(track.FullName);
                    Player.History.Add(track);
                }
                else
                {
                    Track track = Player.IsShuffle ? Player.Tracks[new Random().Next(0, Player.Tracks.Count)] : Player.Tracks[Player.Tracks.IndexOf(Player.Current) + 1];
                    Playlist.SelectedIndex = Player.Tracks.IndexOf(track);
                    PlayTrack(track.FullName);
                    Player.History.Add(track);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Track track = Player.Tracks[0];
                PlayTrack(track.FullName);
                Player.History.Add(track);
            }
        }
        /// <summary>
        /// Включает предыдущий трек
        /// </summary>
        private void PrevTrackButton_Click(object sender, EventArgs e)
        {
            if (Player.History.Count > 1)
            {
                Player.History.Remove(Player.History.Last());
                PlayTrack(Player.History.Last().FullName);
                Playlist.SelectedIndex = Player.Tracks.IndexOf(Player.Current);
            }
        }
        /// <summary>
        /// Добавляет трек в плейлист
        /// </summary>
        private void OpenTrack_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileInfo file = new FileInfo(OpenTrack.FileName);
            Player.Tracks.Add(new Track { Name = file.Name, FullName = file.FullName });
            Player.Tracks.Sort();
            Playlist.DataSource = Player.Tracks;
        }
        /// <summary>
        /// Ручное переключение трека путем клика в списке
        /// </summary>
        private void Playlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlayTrack((Player.Current = Player.Tracks[Playlist.SelectedIndex]).FullName);
            TagLib.Tag tag = TagLib.File.Create(Player.Current.FullName).Tag;
            Player.Current.Artist =
            ArtistLabel.Text = tag.Performers.Length > 0 ? tag.Performers[0] : Playlist.SelectedItem.Text.Split('-')[0];
            Player.Current.Title =
            TitleLabel.Text = tag.Title != "" ? tag.Title : Playlist.SelectedItem.Text.Split('-')[1];
            Player.History.Add(Player.Current);
        }

    }
}