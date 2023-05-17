using Plugin.FirebasePushNotification;

namespace DemoWebProjection;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //CrossFirebasePushNotification.Current.on

        MainPage = new AppShell();
	}
}
