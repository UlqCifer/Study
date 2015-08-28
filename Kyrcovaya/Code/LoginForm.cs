using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ADOX;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Daigorodov_Kyrcova9
{
    public partial class LoginForm : Form
    {
 

        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            try
            {
                WorkWithDB.Instance.TryLogin(Login_textBox.Text, Pass_textBox.Text);
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль!");
            }


        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            if (Login_textBox.Text == "")
            {
                MessageBox.Show("Введите логин (имя файла)");
            }
            else
            {
                if (Pass_textBox.Text == "")
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите создать новый файл БЕЗ пароля?", "Вы не ввели пароль!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        if (WorkWithDB.Instance.CreateFile(Login_textBox.Text, Pass_textBox.Text))
                        {
                            WorkWithDB.Instance.TryLogin(Login_textBox.Text, Pass_textBox.Text);
                            MainForm mainform = new MainForm();
                            mainform.Show();
                            this.Hide();
                        }

                    }

                }
                else
                {
                    if (WorkWithDB.Instance.CreateFile(Login_textBox.Text, Pass_textBox.Text))
                    {
                        WorkWithDB.Instance.TryLogin(Login_textBox.Text, Pass_textBox.Text);
                        MainForm mainform = new MainForm();
                        mainform.Show();
                        this.Hide();
                    }

                }

            }
        }
    }
}
