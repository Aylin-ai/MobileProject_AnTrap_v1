using App1.Models_Бизнес_логика_;
using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_.Аниме
{
    internal class AnimePageViewModel : ViewModel
    {

        #region Ссылка на аватарку

        private string _ImageLink = "/Resources/drawable/Avat.png";
        /// <summary>
        /// Ссылка на аватарку пользователя
        /// </summary>
        public string ImageLink
        {
            get => _ImageLink;
            set => Set(ref _ImageLink, value);
        }

        #endregion

        #region Даты выхода серий аниме

        public ObservableCollection<AnimeSeries> series { get; set; } = new ObservableCollection<AnimeSeries>()
        {
            new AnimeSeries {Number = "1 серия", Date = "05.10.2022"},
            new AnimeSeries {Number = "2 серия", Date = "12.10.2022"}
        };

        #endregion

        #region Теги и жанры

        public ObservableCollection<Tag> Tags { get; set; } = new ObservableCollection<Tag>()
        {
            new Tag { Name = "Герой имба" },
            new Tag { Name = "Умный герой" },
            new Tag { Name = "Антигерой" },
            new Tag { Name = "Амнезия" },
            new Tag { Name = "Магия" },
            new Tag { Name = "Духи" }
        };

        public ObservableCollection<Genre> Genres { get; set; } = new ObservableCollection<Genre>
        {
            new Genre {Name = "Комедия"},
            new Genre {Name = "Фентези"},
        };

        #endregion

        #region Описание

        public string Synopsis { get; set; } = "Кем вы хотели стать в детстве? Известным футболистом? " +
                                               "Супергероем? Или, быть может, певцом, собирающим огромную толпу на концертах? " +
                                               "Всё это не про нашего главного героя Сида, ведь он всегда восхищался людьми из закулисья, " +
                                               "теми, кто почти не предпринимает никаких действий в открытую, а появляется лишь в самый ответственный " +
                                               "момент и, сделав дело, бесследно исчезает. " +
                                               "В нашем мире такое трудно провернуть, ведь что ни делай, а против атомной бомбы не попрёшь. И вот, раздумывая " +
                                               "о способах отражения ядерного оружия голыми руками, наш герой приходит к умозаключению, что без магии никак. " +
                                               "Удобно получилось, ведь вскоре после этого парень встретил пресловутый грузовик, который и отправил его на " +
                                               "тот свет, а если быть точнее, то в мир, полный мечей, магии и прочих прелестей фэнтези-вселенных.Уж теперь-то у " +
                                               "Сида не будет препятствий на пути к становлению величайшим правителем из тени.";

        #endregion

    }
}
