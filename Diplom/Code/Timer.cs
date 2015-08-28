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
	[Activity (Label = "Таймер")]
	public class Timer : Activity
	{
		System.Timers.Timer timer1 = new System.Timers.Timer ();

		int[] sec = new int[50];
		int[] min = new int[50];
		bool[] stopped = new bool[50];
		int peoplenumber = 1;
		int peoplecount = 0;
		int interval = 1;
		int intervalcount = 1;
		int[] idarray;
		List<ListView_Model> data = new List<ListView_Model>{};
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Timer);
			// Создание объектов
			Button button_stop1 = FindViewById<Button> (Resource.Id.button_stop1);
			EditText edittext_stop1 = FindViewById<EditText> (Resource.Id.editText_stop1);
			Button button_stop2 = FindViewById<Button> (Resource.Id.button_stop2);
			EditText edittext_stop2 = FindViewById<EditText> (Resource.Id.editText_stop2);
			EditText edittext_interval = FindViewById<EditText> (Resource.Id.editText_interval);
			Button button_start = FindViewById<Button> (Resource.Id.button_start);
			ListView listview_timer = FindViewById<ListView> (Resource.Id.listView_timer);
			timer1.Interval = 1000; 
			timer1.Elapsed += OnTimedEvent;
			timer1.Enabled = false;
			button_stop1.Enabled = false;
			button_stop2.Enabled = false;
			edittext_stop1.Enabled = false;
			edittext_stop2.Enabled = false;
			// Создание объектов
			WorkWithDB.Instance.UpdateID ();
			WorkWithDB.Instance.Zero ();
			data = WorkWithDB.Instance.Read ();
			RunOnUiThread (() => listview_timer.Adapter = new ListView_Adapter (this, data));
			var timer = new System.Timers.Timer();
			timer.Interval = 1000; 
			timer.Enabled = false;
			timer.Elapsed += delegate {
				RunOnUiThread (() => listview_timer.Adapter = new ListView_Adapter (this, data));
				if(data.Count == 1)
				{
					timer.Enabled = false;
					timer1.Enabled = false;
					StartActivity (typeof(DB_View));
					Finish();
				}
			};


			WorkWithDB.Instance.IDArray(data.Count-1,out idarray);
			peoplecount = data.Count - 1;
			for (int i = 0; i < 50; i++) 
			{
				stopped [i] = true;	
			}
			for (int i = 0; i < data.Count-1; i++) 
			{
				stopped [i] = false;	
			}
			button_start.Click += delegate {
				if (edittext_interval.Text != "") {
					if (Convert.ToInt32 (edittext_interval.Text) <= 0) {
						var builder2 = new AlertDialog.Builder (this);
						builder2.SetMessage ("Интервал не может быть меньше или равен 0!");
						builder2.SetTitle ("Ошибка интервала");
						builder2.Create ().Show ();
					} else {
						if (Convert.ToInt32 (edittext_interval.Text) >= 1)
							interval = Convert.ToInt32 (edittext_interval.Text);
						intervalcount = interval;
						edittext_interval.Enabled = false;
						button_start.Enabled = false;
						timer1.Enabled = true;
						timer.Enabled = true;
						button_stop1.Enabled = true;
						button_stop2.Enabled = true;
						edittext_stop1.Enabled = true;
						edittext_stop2.Enabled = true;


					}
				} else {
					intervalcount = interval;
					edittext_interval.Enabled = false;
					button_start.Enabled = false;
					timer1.Enabled = true;
					timer.Enabled = true;
					button_stop1.Enabled = true;
					button_stop2.Enabled = true;
					edittext_stop1.Enabled = true;
					edittext_stop2.Enabled = true;

				}
			};

				button_stop1.Click += delegate {
				if( edittext_stop1.Text != "" && Convert.ToInt32(edittext_stop1.Text) != 0)
					{
					try
					{
						stopped[Convert.ToInt32(edittext_stop1.Text)-1] = true;
					}
					catch{}
					RunOnUiThread (() => listview_timer.Adapter = new ListView_Adapter (this, data));


				}
				edittext_stop1.Text="";

				};

				button_stop2.Click += delegate {
				if( edittext_stop2.Text != "" && Convert.ToInt32(edittext_stop2.Text) != 0)
				{
					try
					{
						stopped[Convert.ToInt32(edittext_stop1.Text)-1] = true;
					}
					catch{}
					RunOnUiThread (() => listview_timer.Adapter = new ListView_Adapter (this, data));

				}
				edittext_stop2.Text="";


			};

			listview_timer.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) => // Клик на строку в listview
			{ 
				if ((int)listview_timer.GetItemIdAtPosition (e.Position) != 0) {
					var t = data[e.Position];
					Console.WriteLine("CHECK!!!!");
					Console.WriteLine(listview_timer.GetItemIdAtPosition(e.Position).ToString());
					Console.WriteLine(t.Right.ToString());
					stopped[Convert.ToInt32(t.Right)-1] = true;
					RunOnUiThread (() => listview_timer.Adapter = new ListView_Adapter (this, data));

				}
			};
				

		}

		protected override void OnDestroy()
		{
			base.OnDestroy(); 
			timer1.Enabled = false;
		}



		private void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
		{
			EditText edittext_interval = FindViewById<EditText> (Resource.Id.editText_interval);
			data = WorkWithDB.Instance.ReadFiltered (stopped);
			if (intervalcount == 0) {
				RunOnUiThread (() => edittext_interval.Text = "Старт!");
			} 
			if (intervalcount < 0) {
				RunOnUiThread (() => edittext_interval.Text = "Последний участник уже стартовал");
			}
			if (intervalcount > 0) {
				RunOnUiThread (() => edittext_interval.Text = intervalcount.ToString ());
			}

			if (intervalcount <= 0) 
			{
				if (peoplenumber < peoplecount) 
				{
					peoplenumber++;
					intervalcount = interval;
				} 

				else 
				{
					intervalcount = 0;
				}
			}

			for (int i = 0; i < peoplenumber; i++) {
				if (stopped [i]) {
				} else {
					sec [i]++;
					if (sec [i] == 60) {
						min [i]++;
						sec [i] = 0;
					}
					WorkWithDB.Instance.UpdateTimer (idarray [i].ToString (), sec [i].ToString (), min [i].ToString ());
				}
			}



			intervalcount--;


		}
	}
}

