using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace XamNative.Droid
{
	[Activity (Label = "XamNative", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/MyTheme")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			var toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById (Resource.Id.toolbar);
			if (toolbar != null) {
				toolbar.Title = "People";
			}

			//Initializing listview
			var listView = FindViewById<ListView> (Resource.Id.listView);
			listView.Adapter = new PersonListViewAdapter (this, Person.GetItems ());
		}
	}
}

