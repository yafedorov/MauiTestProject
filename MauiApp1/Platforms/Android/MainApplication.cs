using Android.App;
using Android.Runtime;
using MauiApp1.Platforms.Android;

namespace MauiApp1;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp()
	{
        DependencyService.Register<IViewHelper, ViewHelper>();
        return MauiProgram.CreateMauiApp();
	}
}

