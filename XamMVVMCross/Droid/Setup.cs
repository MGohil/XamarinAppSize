using System;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

namespace XamMVVMCross.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext)
			: base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new XamMVVMCross.App();
		}

		protected override IMvxAndroidViewPresenter CreateViewPresenter()
		{
			var mvxFragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
			Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);

			//add a presentation hint handler to listen for pop to root
			mvxFragmentsPresenter.AddPresentationHintHandler<MvxPanelPopToRootPresentationHint>(hint =>
			{
				var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
				var fragmentActivity = activity as Android.Support.V4.App.FragmentActivity;

				for (int i = 0; i < fragmentActivity.SupportFragmentManager.BackStackEntryCount; i++)
				{
					fragmentActivity.SupportFragmentManager.PopBackStack();
				}
				return true;
			});
			//register the presentation hint to pop to root
			//picked up in the third view model
			Mvx.RegisterSingleton<MvxPresentationHint>(() => new MvxPanelPopToRootPresentationHint());
			return mvxFragmentsPresenter;
		}
	}

	internal class MvxPanelPopToRootPresentationHint : MvxPresentationHint
	{
		public MvxPanelPopToRootPresentationHint()
		{
		}
	}
}
