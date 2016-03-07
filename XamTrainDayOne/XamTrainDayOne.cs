using System;

using Xamarin.Forms;

namespace XamTrainDayOne
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			//MainPage = new CodePage();
			//MainPage = new XamlPage();
			MainPage = new UInteractionEx();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

