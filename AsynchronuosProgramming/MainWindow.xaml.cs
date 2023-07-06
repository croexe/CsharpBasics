using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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

namespace AsynchronuosProgramming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           // DownLoadHtmlAsync("https://www.vecernji.hr/");

            var taskGetHtml = GetHtmlAsync("https://www.vecernji.hr/");
            MessageBox.Show("Waiting task to be complited");
            var html = await taskGetHtml;
            MessageBox.Show(html.Substring(0, 100));
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }

        public async Task DownLoadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\Irinej\result1.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownLoadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using(var streamWriter = new StreamWriter(@"C:\Users\Irinej\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
