using _01_MovieFinder.Logics;
using _01_MovieFinder.Models;
using MahApps.Metro.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01_MovieFinder
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BtnNaverMovie_Click(object sender, RoutedEventArgs e)
        {
            await Commons.ShowMessageAsync("영화", "영화 사이트로 갑니다.");
        }

        // 검색 버튼 (네이버 API 영화 검색)
        private async void BtnSearchMovie_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMovieName.Text))
            {
                await Commons.ShowMessageAsync("검색", "검색할 영화를 입력하세요.");
                return;
            }

            if (TxtMovieName.Text.Length <=2)
            {
                await Commons.ShowMessageAsync("검색", "검색어를 2자 이상 입력하세요.");
                return;
            }

            try
            {
                SearchMovie(TxtMovieName.Text);
                
            }
            catch (Exception ex)
            {
                await Commons.ShowMessageAsync("오류", $"오류 발생 : {ex.Message}");
            }
        }

        

        // 텍스트 박스에서 키를 입력할 때 엔터를 누르면 검색
        private void TxtMovieName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnSearchMovie_Click(sender, e);
            }
        }

        private async void SearchMovie(string MovieName)
        {
            string tmdb_apiKey = "6b6db733e476807df21e2c518c204061";
            string encoding_movieName = HttpUtility.UrlEncode(MovieName, Encoding.UTF8);
            string openApiUri = $"https://api.themoviedb.org/3/search/movie?api_key={tmdb_apiKey}" + 
                                $"&language=ko-KR&page=1&include_adult=false&query={encoding_movieName}";
            string result = string.Empty;

            WebRequest req = null;
            WebResponse res = null;
            StreamReader reader = null;

            try
            {
                req = WebRequest.Create(openApiUri);
                res = req.GetResponse();
                reader = new StreamReader(res.GetResponseStream()); 
                result = reader.ReadToEnd();

                Debug.WriteLine(result);
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                res.Close();
            }

            var jsonResult = JObject.Parse(result);

            var total = Convert.ToInt32(jsonResult["total_results"]);
            //await Commons.ShowMessageAsync("검색결과", total.ToString());
            var items = jsonResult["results"];
            var json_array = items as JArray;
            var movieItems = new List<MovieItem>();

            foreach(var val in json_array)
            {
                var MovieItem = new MovieItem()
                {
                    ID = Convert.ToInt32(val["id"]),
                    Title = Convert.ToString(val["title"]),
                    Original_Title = Convert.ToString(val["original_title"]),
                    Release_Date = Convert.ToString(val["release_date"]),
                    Vote_Average = Convert.ToDouble(val["vote_average"])
                };
                movieItems.Add(MovieItem);
            }

            this.DataContext = movieItems;
        }
    }
}
