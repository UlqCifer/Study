using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Multi_Timer
{
	public class ListView_Adapter : BaseAdapter<ListView_Model>
	{
		private readonly IList<ListView_Model> _items;
		private readonly Context _context;

		public ListView_Adapter(Context context, IList<ListView_Model> items)
		{
			_items = items;
			_context = context;
		}

		public override long GetItemId(int position)
		{

			return position;
		}



		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = _items[position];
			var view = convertView;

			if (view == null)
			{
				var inflater = LayoutInflater.FromContext(_context);
				view = inflater.Inflate(Resource.Layout.row, parent, false);
			}

			view.FindViewById<TextView>(Resource.Id.left).Text = item.Left;
			view.FindViewById<TextView>(Resource.Id.mid).Text = item.Mid;
			view.FindViewById<TextView>(Resource.Id.right).Text = item.Right;

			return view;
		}


		public override int Count
		{
			get { return _items.Count; }
		}

		public override ListView_Model this[int position]
		{
			get { return _items[position]; }
		}


	}
}