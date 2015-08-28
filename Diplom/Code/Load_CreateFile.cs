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
	[Activity (Label = "Выбор файла")]			
	public class Load_CreateFile : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Load_CreateFile);
			Button button_createnew 	= 	FindViewById<Button> (Resource.Id.button_createnew);
			Button button_loadFile 		= 	FindViewById<Button> (Resource.Id.button_old);
			EditText edittext_bdname = FindViewById<EditText> (Resource.Id.editText_bdname);

			button_createnew.Click += delegate {
				if (edittext_bdname.Text == "") {
					var builder2 = new AlertDialog.Builder (this);
					builder2.SetMessage ("Для создания нового таймера нужно ввести имя файла!");
					builder2.SetTitle ("Ошибка создания базы данных");
					builder2.Create ().Show ();
				} else {
					string filename = edittext_bdname.Text;
					var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
					var directoryname = Path.Combine (docsFolder, "MultiTimerDB");
					if(!Directory.Exists (directoryname)) Directory.CreateDirectory(directoryname);
					string pathToDatabase = System.IO.Path.Combine (docsFolder, filename);
					if (File.Exists (pathToDatabase)) {
						var builder2 = new AlertDialog.Builder (this);
						builder2.SetMessage ("Файл с таким именем уже существует!");
						builder2.SetTitle ("Ошибка создания базы данных");
						builder2.Create ().Show ();
					} else {
						WorkWithDB.Instance.getpath(filename);
						WorkWithDB.Instance.CreateFile();
						WorkWithDB.Instance.AddNewRecord(filename);
						StartActivity (typeof(DB_Create));
						Finish();
					}
				}
			};

			button_loadFile.Click += delegate {
				var activity = new Intent (this, typeof(FileBrowser));
				activity.PutExtra("type","2");
				StartActivity (activity);
				Finish();
			};


		}
	}
}

