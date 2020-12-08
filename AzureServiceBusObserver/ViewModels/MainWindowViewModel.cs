namespace AzureServiceBusObserver.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Hello World!";
        public string Yo => "Yo";
        public string ConnectionString { get; set; }
    }
}