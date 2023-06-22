using Android.Content;
using System;
using Content = Android.Content;
using static Microsoft.Maui.ApplicationModel.Platform;

namespace CallingApp;

public partial class App : Application
{

    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MainPage());
    }

    protected override void OnStart()
    {
        base.OnStart();
        OnStartOrResume();
    }

    private void OnStartOrResume()
    {
        TryLogin();
    }

    private void TryLogin()
    {
#if ANDROID
        Content.Intent intent = new Content.Intent(Content.Intent.ActionGetContent);
        intent.SetComponent(new ComponentName("com.mycompany.loginapp", "LoginApp.Ui.Droid.MainActivity"));
        Platform.CurrentActivity.StartActivityForResult(intent, 1234);
#endif
    }
}
