using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using AndroidX.Navigation;

namespace BlankProject
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]

    [IntentFilter(
       new string[] { Intent.ActionView },
       AutoVerify = true,
       Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
       DataScheme = "test",
       DataHost = "deeplink")]

    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);

                Intent intent = this.Intent;
                var action = intent.Action;
                var strLink = intent.DataString;
                if (Intent.ActionView == action && !string.IsNullOrWhiteSpace(strLink))
                {
                    //handle intent routing
                    Shell.Current.GoToAsync(nameof(SecondPage));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception OnCreate() => {ex} ");
            }
        }

        //You also need to add this logic to handle the actions:
        protected override void OnResume()
        {
            base.OnResume();

            Platform.OnResume(this);
        }

        //You also need to add this logic to handle the actions:
        protected override void OnNewIntent(Android.Content.Intent intent)
        {
            base.OnNewIntent(intent);

            Platform.OnNewIntent(intent);
        }
    }
}