namespace BlankProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Console.WriteLine($"AppShell {DateTime.Now}");
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
        }
    }
}