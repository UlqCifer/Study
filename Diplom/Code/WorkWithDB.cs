using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using System.IO;

namespace Multi_Timer
{
	public class WorkWithDB
	{
		public static SqliteConnection connection;
		string pathToDatabase = "";
		static readonly WorkWithDB instance = new WorkWithDB();
		public static WorkWithDB Instance
		{
			get
			{
				return instance;
			}
		}

		public void getpath(string filename)
		{
			var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (docsFolder, "MultiTimerDB");
			if(!Directory.Exists (directoryname)) Directory.CreateDirectory(directoryname);
			pathToDatabase = System.IO.Path.Combine (docsFolder, filename);
		}

		public void CreateFile()
		{
			SqliteConnection.CreateFile (pathToDatabase);
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);

			var command = "CREATE TABLE [People] (_ID INTEGER PRIMARY KEY AUTOINCREMENT, Name ntext, Time ntext);";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();
		}

		public void AddNewLine(string name)
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);

			var command = "INSERT INTO [People] ([Name], [Time]) VALUES ('" + name + "', '00:00');";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();
		}

		public void DeleteLine(string ID)
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);

			var command = "DELETE FROM [People] WHERE _ID =" + ID + ";";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();
		}

		public List<ListView_Model> Read()
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);
			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT [_ID], [Name], [Time] from [People]";
				var r = contents.ExecuteReader ();
				var data = new List<ListView_Model>{ new ListView_Model{ Left = "Имя", Mid = "Время", Right = "№", } };
				while (r.Read ()) 
				{
					data.Add (new ListView_Model { Left = r["Name"].ToString(), Mid = r["Time"].ToString(), Right = r["_ID"].ToString(), });
				}
				connection.Close ();
				return data;
			}

		}

		public void Zero()
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);
			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT [_ID], [Name], [Time] from [People]";
				var r = contents.ExecuteReader ();
				while (r.Read ()) 
				{
					var command = "UPDATE [People] SET Time='00:00' WHERE _ID =" + r["_ID"].ToString() + ";";

					using (var c = connection.CreateCommand ()) 
					{
						c.CommandText = command;
						var rowcount = c.ExecuteNonQuery ();
					}
				}
				connection.Close ();
			}
		}

		public bool EmptyCheck()
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);
			connection.Open ();
			bool check = true;
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT [_ID], [Name], [Time] from [People] WHERE _ID='1'";
				var r = contents.ExecuteReader ();
				while (r.Read ()) 
				{
					if (r ["Time"].ToString () != "00:00") check = false;
				}
				connection.Close ();
				return check;
			}

		}

		public List<ListView_Model> ReadFiltered(bool[] a)
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);
			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT [_ID], [Name], [Time] from [People]";
				var r = contents.ExecuteReader ();
				var data = new List<ListView_Model>{ new ListView_Model{ Left = "Имя", Mid = "Время", Right = "№", } };
				while (r.Read ()) 
				{
					if(a[Convert.ToInt32(r["_ID"])-1] == false) data.Add (new ListView_Model { Left = r["Name"].ToString(), Mid = r["Time"].ToString(), Right = r["_ID"].ToString(), });
				}
				connection.Close ();
				return data;
			}

		}


		public void UpdateTimer(string ID,string sec,string min)
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);
			if (Convert.ToInt32 (sec) < 10)
				sec = "0" + sec;
			if (Convert.ToInt32 (min) < 10)
				min = "0" + min;
			var command = "UPDATE [People] SET Time='" + min + ":" + sec + "' WHERE _ID =" + ID + ";";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();

		}

		public void UpdateID()
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);

			var command = "CREATE TABLE [People2] (_ID INTEGER PRIMARY KEY AUTOINCREMENT, Name ntext, Time ntext);";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();

			command = "INSERT INTO [People2] ([Name], [Time]) SELECT [Name], [Time] FROM [People];";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			command = "DROP TABLE [People];";
			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			command = "ALTER TABLE [People2] RENAME TO People";
			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();

		}

		public void IDArray(int idcount, out int[] idarray)
		{
			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT [_ID] from [People]";
				var r = contents.ExecuteReader ();
				int count = 0;
				idarray = new int[idcount];
				while (r.Read ()) 
				{	
					idarray [count] = Convert.ToInt32(r["_ID"]);
					count++;
				}
				connection.Close ();
			}
		}

		public List<ListView_Model> OrderByTime()
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);
			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT [_ID], [Name], [Time] FROM [People] ORDER BY Time ASC;";
				var r = contents.ExecuteReader ();
				var data = new List<ListView_Model>{ new ListView_Model{ Left = "Имя", Mid = "Время", Right = "№", } };
				while (r.Read ()) 
				{
					data.Add (new ListView_Model { Left = r["Name"].ToString(), Mid = r["Time"].ToString(), Right = r["_ID"].ToString(), });
				}
				connection.Close ();
				return data;
			}
		}

		public List<ListView_Model> OrderByName()
		{
			connection = new SqliteConnection ("Data Source=" + pathToDatabase);
			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT [_ID], [Name], [Time] FROM [People] ORDER BY Name ASC;";
				var r = contents.ExecuteReader ();
				var data = new List<ListView_Model>{ new ListView_Model{ Left = "Имя", Mid = "Время", Right = "№", } };
				while (r.Read ()) 
				{
					data.Add (new ListView_Model { Left = r["Name"].ToString(), Mid = r["Time"].ToString(), Right = r["_ID"].ToString(), });
				}
				connection.Close ();
				return data;
			}
		}

		public void DeleteFile(string filename)
		{
			File.Delete (filename);
		}

		public void FirstRun()
		{
			var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (docsFolder, "MultiTimerDB");
			if(!Directory.Exists (directoryname)) Directory.CreateDirectory(directoryname);
			directoryname = Path.Combine (docsFolder, "Records");
			if(!Directory.Exists (directoryname)) Directory.CreateDirectory(directoryname);
			string path = System.IO.Path.Combine (docsFolder, "Records.db");
			if (!File.Exists (path)) {
				SqliteConnection.CreateFile (path);
				connection = new SqliteConnection ("Data Source=" + path);

				var command = "CREATE TABLE [Records] (_ID INTEGER PRIMARY KEY AUTOINCREMENT, Name ntext, Time ntext, Path ntext);";

				connection.Open ();

				using (var c = connection.CreateCommand ()) {
					c.CommandText = command;
					var rowcount = c.ExecuteNonQuery ();
				}
				connection.Close ();
			}
		}

		public void AddNewRecord(string name)
		{
			var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			Path.Combine (docsFolder, "MultiTimerDB");
			Path.Combine (docsFolder, "Records");
			string path = System.IO.Path.Combine (docsFolder, "Records.db");
			connection = new SqliteConnection ("Data Source=" + path);

			var command = "INSERT INTO [Records] ([Name], [Time], [Path]) VALUES ('" + name + "', '"+ DateTime.Now.ToString("dd-MM HH:mm") + "', '" + pathToDatabase + "');";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();
		}

		public void UpdateRecordsID()
		{
			var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			Path.Combine (docsFolder, "MultiTimerDB");
			Path.Combine (docsFolder, "Records");
			string path = System.IO.Path.Combine (docsFolder, "Records.db");
			connection = new SqliteConnection ("Data Source=" + path);

			var command = "CREATE TABLE [Records2] (_ID INTEGER PRIMARY KEY AUTOINCREMENT, Name ntext, Time ntext, Path ntext);";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();

			command = "INSERT INTO [Records2] ([Name], [Time], [Path]) SELECT [Name], [Time], [Path] FROM [Records];";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			command = "DROP TABLE [Records];";
			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			command = "ALTER TABLE [Records2] RENAME TO Records";
			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();

		}

		public void DeleteRecord(string id)
		{
			var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			Path.Combine (docsFolder, "MultiTimerDB");
			Path.Combine (docsFolder, "Records");
			string path = System.IO.Path.Combine (docsFolder, "Records.db");
			connection = new SqliteConnection ("Data Source=" + path);

			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT Path FROM [Records] WHERE _ID =" + id + ";";
				var r = contents.ExecuteReader ();
				while (r.Read ()) 
				{	
					DeleteFile(r["Path"].ToString());
				}
				connection.Close ();
			}

			var command = "DELETE FROM [Records] WHERE _ID =" + id + ";";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();

			UpdateRecordsID ();

		}

		public List<ListView_Model> ReadRecords()
		{
			var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			Path.Combine (docsFolder, "MultiTimerDB");
			Path.Combine (docsFolder, "Records");
			string path = System.IO.Path.Combine (docsFolder, "Records.db");
			connection = new SqliteConnection ("Data Source=" + path);

			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT [_ID], [Name], [Time] from [Records]";
				var r = contents.ExecuteReader ();
				var data = new List<ListView_Model>{ new ListView_Model{ Left = "Имя файла", Mid = "Время создания", Right = "№", } };
				while (r.Read ()) 
				{
					data.Add (new ListView_Model { Left = r["Name"].ToString(), Mid = r["Time"].ToString(), Right = r["_ID"].ToString(), });
				}
				connection.Close ();
				return data;
			}

		}

		public void ReturnPath(string id)
		{
			var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			Path.Combine (docsFolder, "MultiTimerDB");
			Path.Combine (docsFolder, "Records");
			string path = System.IO.Path.Combine (docsFolder, "Records.db");
			connection = new SqliteConnection ("Data Source=" + path);

			connection.Open ();
			using (var contents = connection.CreateCommand ()) 
			{
				contents.CommandText = "SELECT Path FROM [Records] WHERE _ID =" + id + ";";
				var r = contents.ExecuteReader ();
				while (r.Read ()) 
				{	
					pathToDatabase = r["Path"].ToString();
				}
				connection.Close ();
			}
		}

		public void copy()
		{	
			var docsFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			string path2 = System.IO.Path.Combine (docsFolder, Path.GetFileName(pathToDatabase) + "_Копия");
			for(int i=1;i<100;i++)
			{
				path2 = System.IO.Path.Combine (docsFolder, Path.GetFileName(pathToDatabase) + "_Копия_" + i);
				if (!File.Exists (path2)) {
					path2 = System.IO.Path.Combine (docsFolder, Path.GetFileName (pathToDatabase) + "_Копия_" + i);
					break;
				}
			}
			File.Copy (pathToDatabase, path2);

			Path.Combine (docsFolder, "MultiTimerDB");
			Path.Combine (docsFolder, "Records");
			string path = System.IO.Path.Combine (docsFolder, "Records.db");
			connection = new SqliteConnection ("Data Source=" + path);

			var command = "INSERT INTO [Records] ([Name], [Time], [Path]) VALUES ('" + Path.GetFileName(path2) + "', '"+ DateTime.Now.ToString("dd-MM HH:mm") + "', '" + path2 + "');";

			connection.Open ();

			using (var c = connection.CreateCommand ()) 
			{
				c.CommandText = command;
				var rowcount = c.ExecuteNonQuery ();
			}
			connection.Close ();
		}


	}
}

