using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_.Настройки
{
    internal class EditUserViewModel : ViewModel
    {

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

        #region Команда возвращения на прошлую страницу

        private Command closePageCommand;

        public ICommand ClosePageCommand
        {
            get
            {
                if (closePageCommand == null)
                    closePageCommand = new Command(OnClosePageCommandExecuted);
                return closePageCommand;
            }
        }

        private void OnClosePageCommandExecuted()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        #endregion

        #endregion
    }
}
