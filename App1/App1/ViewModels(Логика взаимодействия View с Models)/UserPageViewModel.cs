using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using App1.Views_Окна_.Windows;
using System.Windows.Input;
using Xamarin.Essentials;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_
{
    internal class UserPageViewModel : ViewModel
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

        #region Команда смены аватарки пользователя

        public Command changeAvatCommand;

        public ICommand ChangeAvatCommand
        {
            get
            {
                if (changeAvatCommand == null)
                {
                    changeAvatCommand = new Command(OnChangeAvatCommandExecute);
                }

                return changeAvatCommand;
            }
        }

        public void OnChangeAvatCommandExecute(object obj)
        {
            var options = new PickOptions
            {
                PickerTitle = "Выберите изображение",
                FileTypes = FilePickerFileType.Images
            };
            FilePicker.PickAsync(options);
        }

        public bool CanChangeAvatCommandExecute(Object obj) => true;

        #endregion


        #endregion

    }
}
