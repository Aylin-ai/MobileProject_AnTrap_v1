using App1.Views_Окна_.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Infrastructure_Доп._Инструментарий_.Commands
{
    internal class MainPageCommands
    {
        public void gotoNextPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new UserPage());
        }
    }
}
