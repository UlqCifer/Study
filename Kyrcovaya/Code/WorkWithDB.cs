using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ADOX;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Daigorodov_Kyrcova9
{
    class WorkWithDB
    {

        string DBpath;
        string DBsettings;
        string DBpass;
        MemoryStream ms;
        byte[] photo_aray;

        static readonly WorkWithDB instance = new WorkWithDB();
        public static WorkWithDB Instance
        {
            get
            {
                return instance;
            }
        }

        public string path()
    {
        return DBpath;
    }

        //Создание нового файла
        public bool CreateFile(string filename, string password)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "DataBase\\"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "DataBase\\");
            }

            ADOX.Catalog cat = new Catalog();
            DBpath = AppDomain.CurrentDomain.BaseDirectory + "DataBase\\" + filename + ".mdb";
            if (File.Exists(DBpath))
            {
                MessageBox.Show("Файл с таким именем уже существует!");
                return false;
            }
            else
            {
                DBsettings = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + DBpath + ";Jet OLEDB:Database Password=" + password + ";";
                cat.Create(DBsettings);
                cat = null;
                CreateTable("CREATE TABLE People(ID Identity(1,1), " + "Фамилия String, " + "Имя String, " + "Отчество String, " + "Дата_Рождения Date, " + "Телефон String, " + "Адресс String, " + "Email String, " + "Кем_Является String, " + "Доп_Информация String, " + "Взял_В_Займы Double, " + "Дал_В_Займы Double, " + "Долг Double, " + "Фото IMAGE, " + "Primary Key (ID));");
                return true;
            }
        }
        //Создание нового файла

        //Создание таблицы в файле
        public void CreateTable(string Que)
        {
            string conn = "provider=Microsoft.Jet.OLEDB.4.0;" + "data source=" + DBsettings;
            OleDbConnection connect = new OleDbConnection(conn);
            connect.Open();
            using (OleDbCommand command = new OleDbCommand(Que, connect))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Произошла ошибка при создании таблицы\n" + ex.Message);
                }
            }
        }
        //Создание таблицы в файле

        //Попытка чтения файла с указанным именем и паролем
        public void TryLogin(string filename, string password)
        {
            string connString = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "DataBase\\" + filename + ".mdb" + ";Jet OLEDB:Database Password=" + password + ";";
            string query = "SELECT * FROM People";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connString);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            DBpath = AppDomain.CurrentDomain.BaseDirectory + "DataBase\\" + filename + ".mdb";
            DBpass = password;
        }
        //Попытка чтения файла с указанным именем и паролем

        //Чтение файла и вывод в DataGridView
        public void LoadFile(DataGridView dataGridView1)
        {

            //create the connection string
            string connString = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + DBpath + ";Jet OLEDB:Database Password=" + DBpass + ";";

            //create the database query
            string query = "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является,Долг FROM People";

            //create an OleDbDataAdapter to execute the query
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connString);

            //create a command builder
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            //create a DataTable to hold the query results
            DataTable dTable = new DataTable();


            //fill the DataTable
            dAdapter.Fill(dTable);

            //the DataGridView


            //BindingSource to sync DataTable and DataGridView
            BindingSource bSource = new BindingSource();

            //set the BindingSource DataSource
            bSource.DataSource = dTable;

            //set the DataGridView DataSource
            dataGridView1.DataSource = bSource;

        }

        //Чтение файла и вывод в DataGridView

        //Чтение файла и вывод в DataGridView с включенным фильтром данных
        public void LoadFileFiltered(DataGridView dataGridView1,bool namecheck,string name, bool lastnamecheck,string lastname,bool whocheck,string who)
        {

            //create the connection string
            string connString = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + DBpath + ";Jet OLEDB:Database Password=" + DBpass + ";";
            //create the database query
            string query = "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является FROM People";

            //Команды поиска

            string name1 =       "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является,Долг FROM People WHERE Имя LIKE'" + name + "'";
            string last =        "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является,Долг FROM People WHERE Фамилия LIKE'" + lastname + "'";
            string who1 =        "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является,Долг FROM People WHERE Кем_Является ='" + who + "'";
            string namelast =    "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является,Долг FROM People WHERE (Имя LIKE'" + name + "' AND Фамилия LIKE'" + lastname + "')";
            string namewho =     "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является,Долг FROM People WHERE (Имя LIKE'" + name + "' AND Кем_Является ='" + who + "')";
            string lastwho =     "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является,Долг FROM People WHERE (Фамилия LIKE'" + lastname + "' AND Кем_Является ='" + who + "')";
            string namelastwho = "SELECT ID,Фамилия,Имя,Отчество,Дата_Рождения,Телефон,Адресс,Email,Кем_Является,Долг FROM People WHERE (Имя LIKE'" + name + "' AND Фамилия LIKE'" + lastname + "' AND Кем_Является ='" + who + "')";

            if (namecheck) query = name1;
            if (lastnamecheck) query = last;
            if (whocheck) query = who1;
            if (namecheck && lastnamecheck) query = namelast;
            if (namecheck && whocheck) query = namewho;
            if (lastnamecheck && whocheck) query = lastwho;
            if (namecheck && lastnamecheck && whocheck) query = namelastwho;

            //create an OleDbDataAdapter to execute the query
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connString);

            //create a command builder
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            //create a DataTable to hold the query results
            DataTable dTable = new DataTable();


            //fill the DataTable
            dAdapter.Fill(dTable);

            //the DataGridView


            //BindingSource to sync DataTable and DataGridView
            BindingSource bSource = new BindingSource();

            //set the BindingSource DataSource
            bSource.DataSource = dTable;

            //set the DataGridView DataSource
            dataGridView1.DataSource = bSource;

        }
        //Чтение файла и вывод в DataGridView с включенным фильтром данных

        //Преобразование массива байтов в картинку
        public static Image byteArrayToImage(byte[] fileBytes)
        {
            using (MemoryStream fileStream = new MemoryStream(fileBytes))
            {
                Image temp;
                try
                {
                    temp = Image.FromStream(fileStream);
                }
                catch (ArgumentException) {
                    return null;
                }
                return temp;
            }
        }
        //Преобразование массива байтов в картинку

        //Преобразование картинки в массив байтов
        public static byte[] ImageTobyteArray(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
        //Преобразование картинки в массив байтов

        //Добавление новой записи
        public void AddNewLine(TextBox textname, TextBox textname2, TextBox textname3, DateTimePicker date, TextBox phone, TextBox addinfo, ComboBox whois, PictureBox photo, TextBox adress,TextBox email, NumericUpDown dal, NumericUpDown vz9l)
        {

            OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OleDb.4.0;Data Source=" + DBpath + ";Jet OLEDB:Database Password=" + DBpass + ";");
            OleDbCommand cmd = new OleDbCommand();
            if (photo.Image != null)
            {
                ms = new MemoryStream();
                photo.Image.Save(ms, ImageFormat.Jpeg);
                photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
            }
            cmd.Connection = con;
            cmd.CommandText = "Insert into [People] (Имя, Фамилия, Отчество, Дата_Рождения, Телефон, Адресс, Email, Кем_Является, Доп_Информация, Взял_В_Займы, Дал_В_Займы, Долг, Фото) VALUES (?,?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, @Фото)";
            cmd.Parameters.AddWithValue("@Имя", textname.Text);
            cmd.Parameters.AddWithValue("@Фамилия", textname2.Text);
            cmd.Parameters.AddWithValue("@Отчество", textname3.Text);
            cmd.Parameters.AddWithValue("@Дата_Рождения,", date.Value);
            cmd.Parameters.AddWithValue("@Телефон,", phone.Text);
            cmd.Parameters.AddWithValue("@Адресс", adress.Text);
            cmd.Parameters.AddWithValue("@Email", email.Text);
            cmd.Parameters.AddWithValue("@Кем_Является", whois.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Доп_Информация", addinfo.Text);
            cmd.Parameters.AddWithValue("@Взял_В_Займы", Convert.ToDouble(vz9l.Value));
            cmd.Parameters.AddWithValue("@Дал_В_Займы", Convert.ToDouble(dal.Value));
            cmd.Parameters.AddWithValue("@Долг", calculate(Convert.ToDouble(vz9l.Value),Convert.ToDouble(dal.Value)));

            if (photo.Image != null)
            {
                cmd.Parameters.AddWithValue("@Фото", photo_aray);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Фото", DBNull.Value);
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Добавление новой записи

        //Чтение из файла с выводом в конкретные поля
        public void ReadFromFileEDIT(int ID,TextBox textname, TextBox textname2, TextBox textname3, DateTimePicker date, TextBox phone, TextBox addinfo, ComboBox whois, PictureBox photo, TextBox adress, TextBox email, NumericUpDown dal, NumericUpDown vz9l)
        {
            OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OleDb.4.0;Data Source=" + DBpath + ";Jet OLEDB:Database Password=" + DBpass + ";");
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select ID,Имя, Фамилия, Отчество, Дата_Рождения, Телефон, Адресс, Email, Кем_Является, Доп_Информация, Взял_В_Займы, Дал_В_Займы, Фото from People";
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int currentid = Convert.ToInt32(dr["ID"]);
                if (currentid == ID)
                {
                    textname.Text = dr["Имя"].ToString();
                    textname2.Text = dr["Фамилия"].ToString();
                    textname3.Text = dr["Отчество"].ToString();
                    date.Value = Convert.ToDateTime(dr["Дата_Рождения"]);
                    phone.Text = dr["Телефон"].ToString();
                    adress.Text = dr["Адресс"].ToString();
                    email.Text = dr["Email"].ToString();
                    whois.SelectedIndex = whois.FindStringExact(dr["Кем_Является"].ToString());
                    addinfo.Text = dr["Доп_Информация"].ToString();
                    vz9l.Value = Convert.ToDecimal(dr["Взял_В_Займы"]);
                    dal.Value =Convert.ToDecimal(dr["Дал_В_Займы"]);
                    
                    photo.Image = null;
                    if (dr["Фото"] != DBNull.Value)
                    {
                        photo_aray = (byte[])dr["Фото"];
                        MemoryStream ms = new MemoryStream(photo_aray);
                        photo.Image = Image.FromStream(ms);
                    }
                }
            }
            con.Close();
        }
        //Чтение из файла с выводом в конкретные поля

        //Чтение из файла с выводом в конкретные поля TODO 
        public void ReadFromFile(int ID, TextBox textname, TextBox textname2, TextBox textname3, TextBox date, TextBox phone, TextBox addinfo, TextBox whois, PictureBox photo, TextBox adress,TextBox email, TextBox dolg)
        {
            OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OleDb.4.0;Data Source=" + DBpath + ";Jet OLEDB:Database Password=" + DBpass + ";");
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select ID,Имя, Фамилия, Отчество, Дата_Рождения, Телефон, Адресс, Email, Кем_Является, Доп_Информация, Взял_В_Займы, Дал_В_Займы, Долг, Фото from People";
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int currentid = Convert.ToInt32(dr["ID"]);
                if (currentid == ID)
                {
                    textname.Text = dr["Имя"].ToString();
                    textname2.Text = dr["Фамилия"].ToString();
                    textname3.Text = dr["Отчество"].ToString();
                    date.Text = dr["Дата_Рождения"].ToString();
                    phone.Text = dr["Телефон"].ToString();
                    adress.Text = dr["Адресс"].ToString();
                    email.Text = dr["Email"].ToString();
                    whois.Text = dr["Кем_Является"].ToString();
                    addinfo.Text = dr["Доп_Информация"].ToString();
                    dolg.Text = dr["Долг"].ToString(); //calculate(Convert.ToDouble(dr["Взял_В_Займы"]),Convert.ToDouble(dr["Дал_В_Займы"])).ToString();
                    photo.Image = null;
                    if (dr["Фото"] != DBNull.Value)
                    {
                        photo_aray = (byte[])dr["Фото"];
                        MemoryStream ms = new MemoryStream(photo_aray);
                        photo.Image = Image.FromStream(ms);
                    }
                }
            }
            con.Close();
        }
        //Чтение из файла с выводом в конкретные поля TODO отредактировать и запихнуть все в 1 функцию

        //Простая формула подсчета
        private double calculate(double Vz9l, double dal)
        {
            return Vz9l - dal;
        }
        //Простая формула подсчета

        //Функция изменения записи
        public void ChangeLine(int ID,TextBox textname, TextBox textname2, TextBox textname3, DateTimePicker date, TextBox phone, TextBox addinfo, ComboBox whois, PictureBox photo, TextBox adress, TextBox email, NumericUpDown dal, NumericUpDown vz9l)
        {

            OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OleDb.4.0;Data Source=" + DBpath + ";Jet OLEDB:Database Password=" + DBpass + ";");
            OleDbCommand cmd = new OleDbCommand();
            if (photo.Image != null)
            {
                ms = new MemoryStream();
                photo.Image.Save(ms, ImageFormat.Jpeg);
                photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
            }
            cmd.Connection = con;

            cmd.CommandText = "UPDATE [People] SET Имя=? , Фамилия=? , Отчество=? , Дата_Рождения=? , Телефон=? , Адресс=? , Email=? , Кем_Является=? , Доп_Информация=? , Взял_В_Займы=? , Дал_В_Займы=? , Долг=?, Фото=? WHERE ID=?;";

            cmd.Parameters.AddWithValue("@Имя", textname.Text);
            cmd.Parameters.AddWithValue("@Фамилия", textname2.Text);
            cmd.Parameters.AddWithValue("@Отчество", textname3.Text);
            cmd.Parameters.AddWithValue("@Дата_Рождения,", date.Value);
            cmd.Parameters.AddWithValue("@Телефон,", phone.Text);
            cmd.Parameters.AddWithValue("@Адресс", adress.Text);
            cmd.Parameters.AddWithValue("@Email", email.Text);
            cmd.Parameters.AddWithValue("@Кем_Является", whois.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Доп_Информация", addinfo.Text);
            cmd.Parameters.AddWithValue("@Взял_В_Займы", Convert.ToDouble(vz9l.Value));
            cmd.Parameters.AddWithValue("@Дал_В_Займы", Convert.ToDouble(dal.Value));
            cmd.Parameters.AddWithValue("@Долг", calculate(Convert.ToDouble(vz9l.Value),Convert.ToDouble(dal.Value)).ToString());

            if (photo.Image != null)
            {
                cmd.Parameters.AddWithValue("@Фото", photo_aray);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Фото", DBNull.Value);
            }
            cmd.Parameters.AddWithValue("@ID", ID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Функция изменения записи


        //Функция удаления записи
        public void deleterow(int ID)
        {
            OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OleDb.4.0;Data Source=" + DBpath + ";Jet OLEDB:Database Password=" + DBpass + ";");
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM People WHERE ID =?";
            con.Open();
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Функция удаления записи
    }
}
