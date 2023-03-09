using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using App1.Views_Окна_.Windows.Аниме;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ShikimoriSharp;
using ShikimoriSharp.Settings;
using ShikimoriSharp.Bases;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using ShikimoriSharp.Classes;
using App1.Models_Бизнес_логика_;
using System.Linq;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_.Аниме
{
    internal class AllAnimeViewModel : ViewModel
    {
        static ILogger logger = null;
        ShikimoriClient client = new(logger, new ClientSettings("AylinF",
"bce7ad35b631293ff006be882496b29171792c8839b5094115268da7a97ca34c",
"811459eada36b14ff0cf0cc353f8162e72a7d6e6c7930b647a5c587d1beffe68"));
        public bool IsRefreshing { get; set; } = false;

        #region Данные об аниме

        public string AnimeName { get; set; } = "что-то";
        public string AnimeScores { get; set; } = "";
        public List<String> AnimeGenres { get; set; } = new List<String>() { "ПО", "лват" };

        #endregion

        #region Список названий аниме

        static public List<AnimeTitle> animeNames { get; set; }

        #endregion

        #region Команды

        #region Команда для перехода на страницу аниме

        private Command animePageCommand;

        public ICommand AnimePageCommand
        {
            get
            {
                if (animePageCommand == null)
                    animePageCommand = new Command(OnAnimePageCommandExecuted);
                return animePageCommand;
            }
        }

        private void OnAnimePageCommandExecuted()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AnimePage());
        }

        #endregion

        #region Команда для обновления списка аниме

        private Command getAnimeCommand;

        public ICommand GetAnimeCommand
        {
            get
            {
                if (getAnimeCommand == null)
                    getAnimeCommand = new Command(async () =>
                    {
                        await OnGetAnimeCommandExecutedAsync();
                        IsRefreshing = false;
                    });
                return getAnimeCommand;
            }
        }

        public async Task OnGetAnimeCommandExecutedAsync()
        {

            var token = client.Client.AuthorizationManager.GetAccessToken("VVEp6u4qNalmmJxIXLXUij-tNKdD_wZHAiUZmiB-TOk");


            var search = await client.Animes.GetAnime(new AnimeRequestSettings()
            {
                search = "Lucky"
            });

            var id = search.First().Id;
            var conan = await client.Animes.GetAnime(id);

            AnimeName = conan.Name;

            var genres = conan.Genres;
            for (int i = 0; i < genres.Length; i++)
            {
                AnimeGenres.Add(genres[i].Name);
            }
        }

        #endregion

        #endregion

    }
}
