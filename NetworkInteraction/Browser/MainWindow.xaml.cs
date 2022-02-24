using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Browser
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void WebClient()
        {
            _webBroser.Navigate("https://www.flenov.info");
            _webBroser.Navigated += _webBroser_Navigated;
        }

        private void _webBroser_Navigated(object sender, NavigationEventArgs e)
        {
            MessageBox.Show("Document is loaded.");
        }

        private void Sockets()
        {
            MyHttpClient client = new MyHttpClient();
            client.GetPageStatus(new Uri("http://www.flenov.info"));
            _httpTextContent.Text = client.PageContent.ToString();
        }

        private void WebProxies()
        {
            string uri = "https://www.flenov.info/folder/test.php?param1=value%22:";
            WebProxy proxy = new("192.168.0.100", 8080);
            proxy.Credentials = new NetworkCredential("username", "password");

            Uri url = new(uri);
            _httpTextContent.Text += $"{url.Host}\n{url.AbsolutePath}\n{url.PathAndQuery}\n{url.Query}\n{string.Join(" ",url.Segments)}";
        }

        private void LoadPage(string uri)
        {
            try
            {
                HttpClient flenovSite = new();
                flenovSite.BaseAddress = new Uri(uri);
                HttpResponseMessage response = flenovSite.Send(new HttpRequestMessage(new HttpMethod("Get"), uri));
                using MemoryStream stream = (MemoryStream)response.Content.ReadAsStream();
                byte[] content = new byte[stream.Length];
                stream.Read(content, 0, content.Length);
                string responseMessage = Encoding.UTF8.GetString(content, 0, content.Length);
                
                _httpTextContent.Text = responseMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _getHttpContent_Click(object sender, RoutedEventArgs e)
        {
            string site = "https://www.flenov.info";
            LoadPage(site);
        }

        private void _loadPage_Click(object sender, RoutedEventArgs e)
        {
            WebClient();
        }
    }
}
