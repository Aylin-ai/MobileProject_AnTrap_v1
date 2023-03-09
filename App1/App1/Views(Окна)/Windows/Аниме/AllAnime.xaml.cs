using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Аниме;
using Microsoft.Extensions.Logging;
using ShikimoriSharp;
using ShikimoriSharp.Bases;
using ShikimoriSharp.Classes;
using ShikimoriSharp.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views_Окна_.Windows.Аниме
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllAnime : ContentPage
    {
        static ILogger logger;
        static ShikimoriClient client = new(logger, new ClientSettings("AylinF",
"bce7ad35b631293ff006be882496b29171792c8839b5094115268da7a97ca34c",
"811459eada36b14ff0cf0cc353f8162e72a7d6e6c7930b647a5c587d1beffe68"));

        public AllAnime()
        {
            InitializeComponent();
        }
    }

}