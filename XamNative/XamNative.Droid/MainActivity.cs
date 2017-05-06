using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace XamNative.Droid
{
	[Activity(Label = "XamNative", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/MyTheme")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			var toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolbar);
			if (toolbar != null)
			{
				toolbar.Title = "People";
			}

			var People = new List<Person>()
			{
				new Person(){ FullName = "AAA 111", MobileNo = "1111111111"},
				new Person(){ FullName = "BBB 222", MobileNo = "2222222222"},
				new Person(){ FullName = "CCC 333", MobileNo = "3333333333"},
				new Person(){ FullName = "DDD 444", MobileNo = "4444444444"},
				new Person(){ FullName = "EEE 555", MobileNo = "5555555555"},
				new Person(){ FullName = "FFF 666", MobileNo = "6666666666"},
				new Person(){ FullName = "GGG 777", MobileNo = "7777777777"},
			};

			//Initializing listview
			var listView = FindViewById<ListView>(Resource.Id.listView);
			listView.Adapter = new PersonListViewAdapter(this, People);
		}
	}
}

