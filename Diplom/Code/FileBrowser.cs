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
	[Activity (Label = "Список файлов")]			
	public class FileBrowser : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			string type = Intent.GetStringExtra ("type");
			SetContentView (Resource.Layout.File_Browser);
			ListView lv_files 	= 	FindViewById<ListView> (Resource.Id.listView_view);
			Button close 	= 	FindViewById<Button> (Resource.Id.button_viewclose);
			var data = new List<ListView_Model>{};
			data = WorkWithDB.Instance.ReadRecords ();
			RunOnUiThread (() => lv_files.Adapter = new ListView_Adapter (this, data));
			bool yes = false;

			lv_files.ItemClick += delegate(object sender, Android.Widget.AdapterView.ItemClickEventArgs e) {
				if ((int)lv_files.GetItemIdAtPosition (e.Position) != 0) 
				{
					if(type == "2")
					{
						var t = data[e.Position];
						WorkWithDB.Instance.ReturnPath(t.Right);
						if(WorkWithDB.Instance.EmptyCheck())
						{
							StartActivity (typeof(Timer));
							Finish();
						}
						else
						{
							var builder = new AlertDialog.Builder (this); // Создание сообщения оповещения
							builder.SetMessage ("Данный файл уже использовался таймером! Все равно продолжить? (Будет создана копия файла)");
							builder.SetTitle ("Файл не пустой");
							builder.SetPositiveButton ("Да", (s, ee) => { // Действия при нажатие на "Да"
								WorkWithDB.Instance.copy();
								StartActivity (typeof(Timer));
								Finish();
							});
							builder.SetNegativeButton ("Отмена", (s, ee) => { // Действия при нажатии на "Отмена"
								
							});
							builder.Create ().Show ();
							Console.WriteLine(yes.ToString());
						}

					}
					if(type == "1")
					{
						var t = data[e.Position];
						WorkWithDB.Instance.ReturnPath(t.Right);
						var view_activity = new Intent (this, typeof(DB_View));
						StartActivity (typeof(DB_View));
					}
					if(type == "0")
					{
						var builder = new AlertDialog.Builder (this); // Создание сообщения оповещения
						builder.SetMessage ("Удалить запись?");
						builder.SetPositiveButton ("Да", (s, ee) => { // Действия при нажатие на "Да"
							var t = data[e.Position];
							WorkWithDB.Instance.DeleteRecord(t.Right);
							var builder2 = new AlertDialog.Builder (this);
							builder2.SetMessage ("Запись удалена!");
							builder2.SetTitle ("Файл удален");
							builder2.Create ().Show ();
							data = WorkWithDB.Instance.ReadRecords();
							RunOnUiThread (() => lv_files.Adapter = new ListView_Adapter (this, data)); 
						});
						builder.SetNegativeButton ("Отмена", (s, ee) => { // Действия при нажатии на "Отмена"
							/* do something on Cancel click */ 
						});
						builder.Create ().Show ();
					}
				}
			};

			close.Click += delegate {
				Finish();
			};



			
		}
	}
}

