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

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_.Аниме
{
    internal class AllAnimeViewModel : ViewModel
    {
        static readonly ILogger logger;
        static public bool IsRefreshing { get; set; } = true;

        #region Список названий аниме

        static public ObservableCollection<AnimeTitle> AnimeNames { get; set; }

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
                    getAnimeCommand = new Command(OnGetAnimeCommandExecutedAsync);
                return getAnimeCommand;
            }
        }

        private async void OnGetAnimeCommandExecutedAsync()
        {
            ShikimoriClient client = new(logger, new ClientSettings("AylinF",
"bce7ad35b631293ff006be882496b29171792c8839b5094115268da7a97ca34c",
"811459eada36b14ff0cf0cc353f8162e72a7d6e6c7930b647a5c587d1beffe68"));

            var token = client.Client.AuthorizationManager.GetAccessToken("Bf635DZ_ZDteNSfYY-mEyggZLRvl4OBsDq6ZYEL9hq0");


            var search = await client.Animes.GetAnime();


            for (int i = 0; i < 10; i++)
            {
                var anime = search[i];
                AnimeNames.Add(new AnimeTitle() { Name = anime.Name, Kind = anime.Kind, Score = anime.Score});
            }
        }

        #endregion

        #endregion

    }
}
