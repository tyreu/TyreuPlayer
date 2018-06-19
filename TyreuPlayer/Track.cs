/*
 * 1. Вид группировки треков: Исполнитель -> Альбом -> Треки
 * 2. Коллекция избранных треков
 * 3. Добавление и удаление из очереди треков
 * 5. Смешанное воспроизведение треков
 * 6. Сохранение настроек
 * 7. Возможность редактировать информацию о треке
 * 8. Возможность устанавливать обложку
 * 9. Сохранение и загрузка плейлистов
 * 10. Вывод информации о треке
 */
namespace TyreuPlayer
{
    public class Track
    {
        public Track() { }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
    }
}
