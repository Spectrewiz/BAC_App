using System;

using Xamarin.Forms;

namespace BAC_App
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{

			// Sup chris, it's Nelson

		}

		protected override void OnSleep ()
		{
			// Test edit
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

