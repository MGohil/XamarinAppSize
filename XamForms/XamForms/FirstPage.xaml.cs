using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamForms
{
	public partial class FirstPage : ContentPage
	{
		public FirstPage()
		{
			InitializeComponent();
			BindingContext = new FirstViewModel();
		}
	}
}
