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



        #endregion

    }
}
