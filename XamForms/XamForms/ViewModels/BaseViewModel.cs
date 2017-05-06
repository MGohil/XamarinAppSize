using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamForms
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel()
		{
		}
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged<T>(System.Linq.Expressions.Expression<Func<T>> property)
		{
			if (PropertyChanged != null)
				PropertyChanged(this,
					new PropertyChangedEventArgs(property.GetType().Name));
		}
	}

}
