using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AzureServiceBusObserver.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.AttachDevTools();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}