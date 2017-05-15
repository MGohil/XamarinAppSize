using Foundation;
using System;
using UIKit;
using MvvmCross.Binding.iOS.Views;

namespace XamMVVMCross.iOS
{
	public partial class PeopleCell : MvxTableViewCell
	{

		public const string BindingText = @"
NameText FullName; 
MobileText MobileNo";

		public PeopleCell ()
			: base (BindingText)
		{
		}

		public PeopleCell (IntPtr handle)
			: base (BindingText, handle)
		{
		}

		public string NameText {
			get { return this.TextLabel.Text; }
			set { this.TextLabel.Text = value; }
		}

		public string MobileText {
			get { return this.DetailTextLabel.Text; }
			set { this.DetailTextLabel.Text = value; }
		}
	}
}