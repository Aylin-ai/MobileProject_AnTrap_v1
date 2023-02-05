using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_
{
    internal class UserPageViewModel : ViewModel
    {
        public UserPageViewModel()
        {

        }

        #region Имя пользователя

        private string _UserName = "Aylin";

        public string UserName
        {
            get => _UserName;
            set => Set(ref _UserName, value);
        }

        #endregion
    }
}
