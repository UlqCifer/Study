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
	[Activity (Label = "Multi Timer", MainLauncher = true, Icon = "@drawable/Icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Основной экран
			SetContentView (Resource.Layout.Main);
			// Создание объектов

			Button button_create 	= 	FindViewById<Button> (Resource.Id.button_create);
			Button button_view 		= 	FindViewById<Button> (Resource.Id.button_view);
			Button button_delete 	= 	FindViewById<Button> (Resource.Id.button_delete);
			//EditText edittext_bdname = FindViewById<EditText> (Resource.Id.editText_bdname);
			// Создание объектов
			WorkWithDB.Instance.FirstRun();
			button_create.Click += delegate {
				StartActivity (typeof(Load_CreateFile));
			};

			button_view.Click += delegate {

				var activity = new Intent (this, typeof(FileBrowser));
				activity.PutExtra("type","1");
				StartActivity (activity);

			};

			button_delete.Click += delegate {

				var activity = new Intent (this, typeof(FileBrowser));
				activity.PutExtra("type","0");
				StartActivity (activity);
			};
		}
	}
}


