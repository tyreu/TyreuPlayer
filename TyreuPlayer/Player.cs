using System.Collections.Generic;
using System.Xml.Serialization;

namespace TyreuPlayer
{
    public class Player
    {
        public Player()
        {
            //var file = TagLib.File.Create(filename);
            //if (file.Tag.Pictures.Length >= 1)
            //{
            //    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
            //    PreviewPictureBox.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
            //}
        }
        /// <summary>
        /// Включено ли перемешивание
        /// </summary>
        public bool IsShuffle { get; set; }
        /// <summary>
        /// Открыто ли дерево плейлиста
        /// </summary>
        public bool IsPlaylistOpen { get; set; }
        /// <summary>
        /// Включен ли повтор
        /// </summary>
        public bool IsReplay { get; set; }
        /// <summary>
        /// Играет ли музыка
        /// </summary>
        public bool IsPlay { get; set; }
        /// <summary>
        /// Установлена ли пауза
        /// </summary>
        public bool IsPaused { get; set; }
        /// <summary>
        /// Текущий трек
        /// </summary>
        public Track Current { get; set; }
        public string PathToMusic { get; set; } = Properties.Settings.Default.Path;
        /// <summary>
        /// Все треки плеера
        /// </summary>
        public List<Track> Tracks { get; set; } = new List<Track>();
        /// <summary>
        /// История прослушивания
        /// </summary>
        public List<Track> History { get; set; } = new List<Track>();
        /// <summary>
        /// Очередь треков
        /// </summary>
        [XmlIgnore]
        public Queue<Track> Queue { get; set; } = new Queue<Track>();
    }
}
