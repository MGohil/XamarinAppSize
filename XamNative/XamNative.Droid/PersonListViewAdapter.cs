using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;

namespace XamNative.Droid
{
	public class PersonListViewAdapter : BaseAdapter<Person>
	{
		Activity context;
		List<Person> list;

		public PersonListViewAdapter(Activity _context, List<Person> _list)
		: base()
		{
			this.context = _context;
			this.list = _list;
		}

		public override int Count
		{
			get { return list.Count; }
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override Person this[int index]
		{
			get { return list[index]; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View view = convertView;

			// re-use an existing view, if one is available
			// otherwise create a new one
			if (view == null)
				view = context.LayoutInflater.Inflate(Resource.Layout.list_item_view, parent, false);

			Person item = this[position];
			view.FindViewById<TextView>(Resource.Id.lbl_fullname).Text = item.FullName;
			view.FindViewById<TextView>(Resource.Id.lbl_mobileno).Text = item.MobileNo;

			return view;
		}
	}
}

