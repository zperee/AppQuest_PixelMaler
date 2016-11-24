using AppQuest_PixelMaler.Pages;
using Xamarin.Forms;

namespace AppQuest_PixelMaler
{
	public partial class App : Application
	{

		public static int ScreenWidth = 0;
		public App()
		{
			InitializeComponent();

			MainPage = new HomePage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
