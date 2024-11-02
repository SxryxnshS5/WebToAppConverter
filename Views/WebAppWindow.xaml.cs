using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace WebToAppConverter.Views {
    public partial class WebAppWindow : Window {
        public WebAppWindow(string url) {
            InitializeComponent();
            InitializeWebView(url);
        }

        private async void InitializeWebView(string url) {
            await WebView.EnsureCoreWebView2Async(null);
            WebView.CoreWebView2.Navigate(url);
        }
    }
}