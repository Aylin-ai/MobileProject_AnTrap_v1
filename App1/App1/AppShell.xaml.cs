using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App1.Views_Окна_.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            AppShell.SetNavBarIsVisible(this, false);
        }
    }
}