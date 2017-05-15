using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using System.Collections.Generic;
using MvvmCross.Binding.iOS.Views;
using Foundation;

namespace XamMVVMCross.iOS
{
	public partial class FirstViewController : MvxViewController<FirstViewModel>
	{
		public FirstViewController () : base ("FirstViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Title = "People";

			// Perform any additional setup after loading the view, typically from a nib.
			var source = new TableSource (peopleTableView);

			this.AddBindings (new Dictionary<object, string> ()
			  {
				{ source, "ItemsSource People" }
			});

			peopleTableView.Source = source;
			peopleTableView.ReloadData ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}

	public class TableSource : MvxTableViewSource
	{
		public TableSource (UITableView tableView)
			: base (tableView)
		{
			tableView.RegisterNibForCellReuse (UINib.FromName (typeof (PeopleCell).Name, NSBundle.MainBundle), typeof (PeopleCell).Name);
		}



		protected override UITableViewCell GetOrCreateCellFor (UITableView tableView, NSIndexPath indexPath, object item)
		{
			var viewModel = (Person)item;
			return (UITableViewCell)tableView.DequeueReusableCell (typeof (PeopleCell).Name, indexPath);
		}
	}
}

