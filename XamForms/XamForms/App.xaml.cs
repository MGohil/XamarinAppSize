﻿using Xamarin.Forms;

namespace XamForms
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();

			MainPage = new NavigationPage (new FirstPage ());
			//MainPage = new FirstPage ();
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
