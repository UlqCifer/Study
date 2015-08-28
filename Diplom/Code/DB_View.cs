using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mono.Data.Sqlite;
using System.IO;

namespace Multi_Timer
{
	[Activity (Label = "Просмотр записи")]			
	public class DB_View : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.DB_View);
			Button button_sort_time = FindViewById<Button> (Resource.Id.button_sort_time);
			Button button_sort_name = FindViewById<Button> (Resource.Id.button_sort_name);
			Button button_close = FindViewById<Button> (Resource.Id.button_close);
			ListView listview_view = FindViewById<ListView> (Resource.Id.listView_view);
			var data = new List<ListView_Model>{};
			data = WorkWithDB.Instance.Read ();
			RunOnUiThread (() => listview_view.Adapter = new ListView_Adapter (this, data));
			button_sort_name.Click += delegate {
				data = WorkWithDB.Instance.OrderByName();
				RunOnUiThread (() => listview_view.Adapter = new ListView_Adapter (this, data));
			};

			button_sort_time.Click += delegate {
				data = WorkWithDB.Instance.OrderByTime();
				RunOnUiThread (() => listview_view.Adapter = new ListView_Adapter (this, data));
			};

			button_close.Click += delegate {
				Finish();
			};

		}
	}
}

