using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using Xamarin.Forms;
using App1.Views_Окна_.Windows;
using System.Windows.Input;
using App1.Views_Окна_.Windows.Аниме;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_
{
    internal class MainPageViewModel: ViewModel
    {

        #region Заголовок страницы
        private string _Title = "Главная страница";

        /// <summary>
        /// Заголовок страницы
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion


        #region Команды


        #region Команда перехода на страницу с данными о пользователе

        /// <summary>
        /// Команда перехода на страницу с данными о пользователе
        /// </summary>
        private Command userInfoCommand;


        public ICommand UserInfoCommand
        {
            get
            {
                if (userInfoCommand == null)
                {
                    userInfoCommand = new Command(OnUserInfoCommandExecuted);
                }

                return userInfoCommand;
            }
        }
        private void OnUserInfoCommandExecuted(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new UserPage());
        }

        private bool CanUserInfoCommandExecute(object obj) => true;

        #endregion

        #region Команда перехода на главную страницу аниме

        private Command mainAnimePageCommand;

        public ICommand MainAnimePageCommand
        {
            get
            {
                if (mainAnimePageCommand == null)
                {
                    mainAnimePageCommand = new Command(OnMainAnimePageCommandExecuted);
                }

                return mainAnimePageCommand;
            }
        }

        private void OnMainAnimePageCommandExecuted(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new MainAnimePage());
        }

        #endregion

        #endregion

    }
}
