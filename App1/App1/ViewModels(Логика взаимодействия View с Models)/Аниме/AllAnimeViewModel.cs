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

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_.Аниме
{
    internal class AllAnimeViewModel : ViewModel
    {

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
            Application.Current.MainPage.Navigation.PushAsync(new Anime());
        }

        #endregion

        #endregion

    }
}
