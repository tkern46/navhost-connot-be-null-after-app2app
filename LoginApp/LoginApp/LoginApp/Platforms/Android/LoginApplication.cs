using Android.App;
using Android.Runtime;

namespace LoginApp;

[Application(Name = "LoginApp.Ui.Droid.LoginApplication")]
public class LoginApplication : MauiApplication
{
	public LoginApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
