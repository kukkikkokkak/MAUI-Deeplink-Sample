using Android.App;
using Android.Runtime;

namespace BlankProject
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            Console.WriteLine($"MainApplication: MainApplication {DateTime.Now}");
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}