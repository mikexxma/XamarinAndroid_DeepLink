using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinAndroidDeepLink
{
    [Activity(Label = "XamarinAndroidDeepLink", MainLauncher = true, Icon = "@drawable/icon")]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
    DataScheme = "wori",
    DataHost = "example.com",
    DataPathPrefix ="/",
    Categories = new[] { Android.Content.Intent.CategoryDefault,Android.Content.Intent.CategoryBrowsable })]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

           

        }

       
    }
}

