using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using App1.Views_Окна_.Windows;
using App1.Views_Окна_.Windows.Настройки;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_.Настройки
{
    internal class UserSettingsViewModel : ViewModel
    {

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

        public Command mainPageCommand;

        public ICommand MainPageCommand
        {
            get
            {
                if (mainPageCommand == null)
                {
                    mainPageCommand = new Command(OnMainPageCommandExecuted);
                }

                return mainPageCommand;
            }
        }

        private void OnMainPageCommandExecuted(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        private bool CanMainPageCommandExecute(object obj) => true;

        #endregion

        #region Команда подтверждения изменений

        public Command confirmCommand;

        public ICommand ConfirmCommand
        {
            get
            {
                if (confirmCommand == null)
                {
                    confirmCommand = new Command(OnConfirmCommandExecute);
                }

                return confirmCommand;
            }
        }

        public void OnConfirmCommandExecute(object obj)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }

        public bool CanConfirmCommandExecute(object obj) => true;

        #endregion

        #region Команда перехода к странице редактирования пользователя

        public Command editProfileCommand;

        public ICommand EditProfileCommand
        {
            get
            {
                if (editProfileCommand == null)
                {
                    editProfileCommand = new Command(OnEditProfileCommandExecute);
                }

                return editProfileCommand;
            }
        }

        public void OnEditProfileCommandExecute(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new EditUser());
        }

        public bool CanEditProfileCommandExecute(Object obj) => true;

        #endregion


        #endregion

    }
}
