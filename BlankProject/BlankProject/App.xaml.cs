namespace BlankProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Console.WriteLine($"App {DateTime.Now}");
            MainPage = new AppShell();         
        }
    }
}