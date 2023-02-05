﻿using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
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

        public Command cmdUserInfo { get; set; }

        public MainPageViewModel()
        {
            cmdUserInfo = new Command(gotoNextPage);
        }

        private void gotoNextPage()
        {
            App.Current.MainPage.Navigation.PushAsync(new UserPage());
        }
    }
}
