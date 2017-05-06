using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace XamMVVMCross.Droid
{
	[Activity(Label = "XamMVVMCross", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/MyTheme")]
	public class MainActivity : MvxAppCompatActivity<FirstViewModel>
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

		}
	}
}

