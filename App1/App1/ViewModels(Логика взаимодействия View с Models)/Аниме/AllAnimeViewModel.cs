using App1.ViewModels_Логика_взаимодействия_View_с_Models_.Base;
using App1.Views_Окна_.Windows.Аниме;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels_Логика_взаимодействия_View_с_Models_.Аниме
{
    internal class AllAnimeViewModel : ViewModel
    {

        public static string GetHtmlPage(string url)
        {
            string HtmlText;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader strm = new(httpWebResponse.GetResponseStream());
                HtmlText = strm.ReadToEnd();
                return HtmlText;
        }

        public static Titles[] GetTitle(string url)
        {
                string HtmlText = GetHtmlPage(url);
                const string quote = "\"";
                string[] splitter = { "<div class=" + quote + "h5 font-weight-normal mb-1" + quote + ">", "</div>" };
                string[] massive = HtmlText.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                var prefinalMassive = new List<string>();

                for (int i = 0; i < massive.Length; ++i)
                {
                    if (i % 2 != 0)
                    {
                        prefinalMassive.Add(massive[i]);
                    }
                }

                Titles[] finalMassive = new Titles[prefinalMassive.Count];
                for (int i = 0; i < finalMassive.Length; ++i)
                {
                    string str = prefinalMassive[i].Split('<', '>')[0];
                    finalMassive[i] = new Titles() { Title = str};
                }

                return finalMassive;
        }

        public static Titles[] elements = GetTitle("https://animego.org/");

    }
    public class Titles
    {
        public string Title { get; set; }
        public Titles(string Title)
        {
            this.Title = Title;
        }
        public Titles() { }
    }
}
