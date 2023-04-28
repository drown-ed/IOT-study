using AladinBookSearch.Logic;
using AladinBookSearch.Model;
using MahApps.Metro.Controls;
using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Utilities;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace AladinBookSearch
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        static int page = 1;
        static int totalpage = 0;
        public MainWindow()
        {
            InitializeComponent();
            PageNum.Text = page.ToString();
        }
        private async void BtnSearchBook_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearchName.Text))
            {
                await Commons.ShowMessageAsync("검색", "검색할 도서명을 입력하세요.");
                return;
            }

            try
            {
                SearchBook(TxtSearchName.Text);
            }
            catch (Exception ex)
            {
                await Commons.ShowMessageAsync("오류", $"오류 발생 : {ex.Message}");
            }
        }

        private void TxtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnSearchBook_Click(sender, e);
            }
        }

        private async void SearchBook(string BookName)
        {
            string apikey = "ttbotooe121744001";
            string encoding_BookName = HttpUtility.UrlEncode(BookName, Encoding.UTF8);
            string openApiUri = $"http://www.aladin.co.kr/ttb/api/ItemSearch.aspx?ttbkey={apikey}" +
                                  $"&Query={encoding_BookName}" + $"&start={page}";
            //  + "&QueryType=Title" + "&MaxResults=10" + "&start=1&" + $"SearchTarget=Book" + "&output=xml&Version=20131101"
            string result = string.Empty;

            WebRequest req = null;
            WebResponse res = null;
            StreamReader reader = null;

            try
            {
                req = WebRequest.Create(openApiUri); // URL을 넣어서 객체를 생성
                res = await req.GetResponseAsync(); // 요청한 결과를 비동기 응답에 할당
                reader = new StreamReader(res.GetResponseStream());
                result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
                res.Close();
            }

            XmlDocument XmlFile = new XmlDocument();
            XmlFile.LoadXml(result);
            XmlNodeList PageNum = XmlFile.GetElementsByTagName("object");
            foreach(XmlNode PageNode in PageNum)
            {
                totalpage = Convert.ToInt32(PageNode["totalResults"].InnerText);
            }

            XmlNodeList XmlList = XmlFile.GetElementsByTagName("item");

            var bookItems = new List<BookItem>();
            foreach (XmlNode item in XmlList)
            {
                var BookItems = new BookItem()
                {
                    Title = item["title"].InnerText,
                    Author = item["author"].InnerText
                };
                bookItems.Add(BookItems);
                Debug.WriteLine(BookItems.Title, BookItems.Author);
            }
            this.DataContext = bookItems;
        }

        private void Left_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (page == 1)
            {
                page = 1;
            } else page -= 1;
            PageNum.Text= page.ToString();
            SearchBook(TxtSearchName.Text);
        }

        private void Right_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (totalpage / page == 0)
            {

            }
            page += 1;
            PageNum.Text = page.ToString();
            SearchBook(TxtSearchName.Text);
        }
    }
}
