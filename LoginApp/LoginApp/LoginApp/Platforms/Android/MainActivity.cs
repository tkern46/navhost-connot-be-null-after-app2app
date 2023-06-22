using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Content;
using Newtonsoft.Json;
using Microsoft.Maui.Platform;
using AndroidX.Activity.Result;

namespace LoginApp;

[Activity(Name = "LoginApp.Ui.Droid.MainActivity", Theme = "@style/Maui.SplashTheme", LaunchMode = LaunchMode.SingleTop, MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(new[] { Intent.ActionView, Intent.ActionGetContent }, Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable }, DataScheme = "login-scheme")]
public class MainActivity : MauiAppCompatActivity
{
    protected override async void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Platform.Init(this, savedInstanceState);
        await HandleLoginRequest();
    }

    protected override async void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);
        await HandleLoginRequest();
    }

    private async Task HandleLoginRequest()
    {
        var requestIntentData = Intent.Data;
        var action = Intent.Action;
        if (Intent.Action == Android.Content.Intent.ActionGetContent)
        {
            await Task.Delay(2000);
            var responseIntent = new Intent(Intent.ActionDefault);
            responseIntent.PutExtra("response", "hello from loginapp...");
            SetResult(Result.Ok, responseIntent);
            Finish();
         
        }
    }
}
