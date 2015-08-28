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
	[Activity (Label = "Создание записи")]			
	public class DB_Create : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.DB_Create);

			// Создание объектов
			EditText edittext1 = FindViewById<EditText> (Resource.Id.editText_add);
			Button button_add = FindViewById<Button> (Resource.Id.button_add);
			Button button_next = FindViewById<Button> (Resource.Id.button_next);
			Button button_save = FindViewById<Button> (Resource.Id.button_save);
			ListView listview_create = FindViewById<ListView> (Resource.Id.listView_create);
			// Создание объектов
			var data = new List<ListView_Model>{};
			data = WorkWithDB.Instance.Read ();
			RunOnUiThread (() => listview_create.Adapter = new ListView_Adapter (this, data)); // Заполнение listview
			button_add.Click += delegate // Нажатие на кнопку "Добавить"
			{ 
				WorkWithDB.Instance.AddNewLine(edittext1.Text);
				data = WorkWithDB.Instance.Read ();
				RunOnUiThread (() => listview_create.Adapter = new ListView_Adapter (this, data));
				edittext1.Text = "";

			};

			button_save.Click += delegate // Нажатие на кнопку "Добавить"
			{ 
				if(data.Count <= 2)
				{
					var builder = new AlertDialog.Builder (this);
					builder.SetMessage ("Для продолжения должно быть минимум 2 участника!");
					builder.SetTitle ("Слишком мало участников");
					builder.Create ().Show ();
				}
				else
				{

					if(data.Count > 50)
					{
						var builder = new AlertDialog.Builder (this);
						builder.SetMessage ("Максимальное кол-во участников 49!");
						builder.SetTitle ("Слишком много участников");
						builder.Create ().Show ();
					}
					else
					{
						Finish();
					}
				}
			};

			listview_create.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) => // Клик на строку в listview
			{ 
				var builder = new AlertDialog.Builder (this); // Создание сообщения оповещения
				if ((int)listview_create.GetItemIdAtPosition (e.Position) != 0) {
					builder.SetMessage ("Удалить запись?");
					builder.SetPositiveButton ("Да", (s, ee) => { // Действия при нажатие на "Да"
						var t = data[e.Position];
						WorkWithDB.Instance.DeleteLine(t.Right);
						WorkWithDB.Instance.UpdateID();
						data = WorkWithDB.Instance.Read ();
						RunOnUiThread (() => listview_create.Adapter = new ListView_Adapter (this, data)); // Заполнение адаптера новой бд
					});
					builder.SetNegativeButton ("Отмена", (s, ee) => { // Действия при нажатии на "Отмена"
						/* do something on Cancel click */ 
					});
					builder.Create ().Show (); // Создание сообщения оповещения
				}
			};



			button_next.Click += delegate // "Продолжить"
			{ 		
				if(data.Count <= 2)
				{
					var builder = new AlertDialog.Builder (this);
					builder.SetMessage ("Для продолжения должно быть минимум 2 участника!");
					builder.SetTitle ("Слишком мало участников");
					builder.Create ().Show ();
				}
				else
				{

					if(data.Count > 50)
					{
						var builder = new AlertDialog.Builder (this);
						builder.SetMessage ("Максимальное кол-во участников 49!");
						builder.SetTitle ("Слишком много участников");
						builder.Create ().Show ();
					}
					else
					{
						var Timer_activity = new Intent (this, typeof(Timer));
						StartActivity (typeof(Timer));
						Finish();
					}
				}
			};

		}
	}
}


