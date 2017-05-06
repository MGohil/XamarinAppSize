using System;
using MvvmCross.Core.ViewModels;

namespace XamMVVMCross
{
	class AppStart : MvxNavigatingObject, IMvxAppStart
	{
		public void Start(object hint = null)
		{
			ShowViewModel<FirstViewModel>();
		}
	}
}
