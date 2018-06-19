using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2. Коллекция избранных треков
 * 3. Добавление и удаление из очереди треков
 * 6. Сохранение настроек
 * 7. Возможность редактировать информацию о треке
 * 8. Возможность устанавливать обложку
 * 9. Сохранение и загрузка плейлистов
 * 10. Вывод информации о треке
 */
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
        public Track Current { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();
    }
}
