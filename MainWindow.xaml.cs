using System;
using System.Windows;
using WebToAppConverter.Services;
using WebToAppConverter.Views;

namespace WebToAppConverter {
    public partial class MainWindow : Window {
        private readonly UrlValidatorService _urlValidatorService;

        public MainWindow() {
            InitializeComponent();
            _urlValidatorService = new UrlValidatorService();
        }

        private void OpenAsApp_Click(object sender, RoutedEventArgs e) {
            string url = UrlTextBox.Text.Trim();
            if (_urlValidatorService.IsValidUrl(url)) {
                var appWindow = new WebAppWindow(url);
                appWindow.Show();
            }
            else {
                MessageBox.Show("Please enter a valid URL.", "Invalid URL", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}