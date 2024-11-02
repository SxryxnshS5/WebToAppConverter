using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WebToAppConverter.Views;

namespace WebToAppConverter.ViewModels {
    public class MainViewModel : INotifyPropertyChanged {
        private string _url;
        public string Url {
            get => _url;
            set {
                _url = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenAsAppCommand { get; set; }

        public MainViewModel() {
            OpenAsAppCommand = new RelayCommand(OpenAsApp);
        }

        private void OpenAsApp(object? parameter) {
            if (!string.IsNullOrEmpty(Url)) {
                // Create and show a new WebAppWindow with the specified URL
                var appWindow = new WebAppWindow(Url);
                appWindow.Show();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}