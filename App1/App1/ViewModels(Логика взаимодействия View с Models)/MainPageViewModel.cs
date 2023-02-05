using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using Xamarin.Forms;
using App1.Views_Окна_.Windows;

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


        public MainPageViewModel()
        {
            UserInfoCommand = new Command(OnUserInfoCommandExecuted);
        }

        #region Команды


        #region Команда перехода на страницу с данными о пользователе

        /// <summary>
        /// Команда перехода на страницу с данными о пользователе
        /// </summary>
        public Command UserInfoCommand { get; }

        /// <summary>
        /// Команда перехода на страницу с данными о пользователе
        /// </summary>
        /// <param name="obj"></param>
        private void OnUserInfoCommandExecuted(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new UserPage());
        }

        private bool CanUserInfoCommandExecute(object obj) => true;

        #endregion


        #endregion
    }
}
