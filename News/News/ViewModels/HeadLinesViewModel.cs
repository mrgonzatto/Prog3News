using News.Models;
using News.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Input;
using Xamarin.Forms;

namespace News.ViewModels
{
    public class HeadLinesViewModel : ViewModel
    {
        private readonly NewsService newsService;
        public NewsResult CurrentNews { get; set; }

        public HeadLinesViewModel(NewsService newsService)
        {
            this.newsService = newsService;
        }

        public async Task Initialize(string scope)
        { 
            var resolvedScope = scope.ToLower() switch
            { 
                "local" => NewsScope.Local,
                "global" => NewsScope.Global,
                "headlines" => NewsScope.HeadLines,
                _ => NewsScope.HeadLines
            };

            await Initialize(resolvedScope);
        }

        public async Task Initialize(NewsScope scope)
        {
            CurrentNews = await newsService.GetNews(scope);
        }

        public ICommand ItemSelected =>
            new Command( async (selectedItem) => {
                var selectedArticle = selectedItem as Article;
                var url = HttpUtility.UrlEncode(selectedArticle.Url);
                //Mais implementações na próxima aula
            } );

    }
}
