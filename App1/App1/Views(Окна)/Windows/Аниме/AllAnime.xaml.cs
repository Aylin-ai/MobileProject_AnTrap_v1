using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Аниме;
using Microsoft.Extensions.Logging;
using ShikimoriSharp;
using ShikimoriSharp.Bases;
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
        ILogger logger;
        public AllAnime()
        {
            InitializeComponent();

//            ShikimoriClient client = new(logger, new ClientSettings("AylinF",
//"bce7ad35b631293ff006be882496b29171792c8839b5094115268da7a97ca34c",
//"811459eada36b14ff0cf0cc353f8162e72a7d6e6c7930b647a5c587d1beffe68"));

//            var token = client.Client.AuthorizationManager.GetAccessToken("Bf635DZ_ZDteNSfYY-mEyggZLRvl4OBsDq6ZYEL9hq0");


//            var search = client.Animes.GetAnime(new AnimeRequestSettings 
//            {
//                search = "Detective Conan"
//            });
//            var animes = search.Result;


//            //for (int i = 0; i < 10; i++)
//            //{
//            //    var anime = animes[i];
//            //    AnimeNames.Add(new AnimeTitle() { Name = anime.Name, Kind = anime.Kind, Score = anime.Score });
//            //}

//            var stack = new StackLayout();

//            for (int i = 0; i < 1; i++)
//            {
//                var frame = new Frame();
//                frame.Margin = 15;
//                frame.Padding = 0;
//                frame.CornerRadius = 20;
//                frame.BackgroundColor = Color.FromHex("#1D252A");

//                var stacklayout = new StackLayout();

//                var stacklayout2 = new StackLayout();
//                stacklayout2.Margin = new Thickness(10, 10, 10, 0);
//                stacklayout2.Orientation = StackOrientation.Horizontal;

//                var image = new Xamarin.Forms.Image { Source = "/Resources/drawable/Avat.png" };
//                image.WidthRequest = 100;

//                var stacklayout3 = new StackLayout();

//                var stacklayout4 = new StackLayout();
//                stacklayout4.Orientation = StackOrientation.Horizontal;
//                var label1 = new Label();
//                label1.Text = animes[i].Name;
//                stacklayout4.Children.Add(label1);

//                var stacklayout5 = new StackLayout();
//                stacklayout5.Orientation = StackOrientation.Horizontal;
//                var label2 = new Label();
//                label2.Text = "Жанры: " + animes[i].Kind;
//                stacklayout5.Children.Add(label2);

//                var stacklayout6 = new StackLayout();
//                stacklayout6.Orientation = StackOrientation.Horizontal;
//                stacklayout6.VerticalOptions = LayoutOptions.EndAndExpand;
//                var label4 = new Label();
//                label4.Text = "Оценка: " + animes[i].Score;
//                stacklayout6.Children.Add(label4);

//                stacklayout3.Children.Add(stacklayout4);
//                stacklayout3.Children.Add(stacklayout5);
//                stacklayout3.Children.Add(stacklayout6);

//                stacklayout2.Children.Add(image);
//                stacklayout2.Children.Add(stacklayout3);

//                var picker = new Picker();
//                picker.Margin = new Thickness(10, 0);
//                picker.FontSize = 16;
//                picker.TextColor = Color.FromHex("#9FA1A3");
//                picker.ItemsSource = new[] { "Выбрать", "Смотрю" };

//                stacklayout.Children.Add(stacklayout2);
//                stacklayout.Children.Add(picker);

//                frame.Content = stacklayout;

//                stack.Children.Add(frame);

//                scroll.Content = stack;
//            }
        }
    }

}