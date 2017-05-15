using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace XamNative.iOS
{
	public partial class ViewController : UIViewController
	{
		List<Person> People;

		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			People = Person.GetItems ();

			peopleTableView.WeakDataSource = peopleTableView.WeakDelegate = this;
			peopleTableView.ReloadData ();

			//this.NavigationController.NavigationBarHidden = false;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}




		[Export ("tableView:cellForRowAtIndexPath:")]
		public UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (typeof (PeopleCell).Name) as PeopleCell;
			if (cell == null) {
				var views = NSBundle.MainBundle.LoadNib (typeof (PeopleCell).Name, tableView, null);
				cell = ObjCRuntime.Runtime.GetNSObject (views.ValueAt (0)) as PeopleCell;
			}

			cell.TextLabel.Text = People [indexPath.Row].FullName;
			cell.DetailTextLabel.Text = People [indexPath.Row].MobileNo;
			return cell;
		}

		[Export ("tableView:numberOfRowsInSection:")]
		public nint RowsInSection (UITableView tableview, nint section)
		{
			return People == null ? 0 : People.Count;
		}

		[Export ("numberOfSectionsInTableView:")]
		public nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}
	}
}
