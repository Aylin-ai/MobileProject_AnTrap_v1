using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using App1.Views_Окна_.Windows;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_
{
    internal class UserPageViewModel : ViewModel
    {
        public UserPageViewModel()
        {
            MainPageCommand = new Command(OnMainPageCommandExecuted);
            ConfirmCommand = new Command(OnConfirmCommandExecute);
            ChangeAvatCommand = new Command(OnChangeAvatCommandExecute);
        }

        #region Имя пользователя

        private string _UserName = "Aylin";
        /// <summary>
        /// Имя пользователя в системе
        /// </summary>
        public string UserName
        {
            get => _UserName;
            set => Set(ref _UserName, value);
        }

        #endregion

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

        #region Команды


        #region Команда перехода к начальному экрану

        public Command MainPageCommand { get; }

        private void OnMainPageCommandExecuted(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        private bool CanMainPageCommandExecute(object obj) => true;

        #endregion

        #region Команда подтверждения изменений

        public Command ConfirmCommand { get; }

        public void OnConfirmCommandExecute(object obj)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }

        public bool CanConfirmCommandExecute(object obj) => true;

        #endregion

        #region Команда смены аватарки пользователя

        public Command ChangeAvatCommand { get; }

        public void OnChangeAvatCommandExecute(object obj)
        {
            Console.WriteLine("Еще не реализовано");
        }

        public bool CanChangeAvatCommandExecute(Object obj) => true;

        #endregion


        #endregion
    }
}
