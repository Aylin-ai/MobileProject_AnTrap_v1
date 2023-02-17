using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Аниме;
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
        public AllAnime()
        {
            InitializeComponent();
            for (int i = 0; i < AllAnimeViewModel.elements.Length; i++)
            {
                stack.Children.Add(new Label() { Text = AllAnimeViewModel.elements[i].Title + '\n', FontSize = 16, TextColor = Color.White });
            }
        }
    }

}