using Android.App;
using Android.Runtime;

namespace CallingApp;

[Application]
public class MainApplication : MauiApplication
{
	public static MauiApplication Instance;
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
		Instance = this;
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
