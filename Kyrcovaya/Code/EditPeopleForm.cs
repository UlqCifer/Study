using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daigorodov_Kyrcova9
{
    public partial class EditPeopleForm : Form
    {
        int CurrentId;
        public EditPeopleForm(int id)
        {
            InitializeComponent();
            CurrentId=id;
        }

        private void EditPeopleForm_Load(object sender, EventArgs e)
        {
            dateTimePickerBirthday.Value = DateTime.Now;
            WorkWithDB.Instance.ReadFromFileEDIT(CurrentId,textBoxName,textBoxLastName,textBoxOtshestvo,dateTimePickerBirthday,textBoxPhone,textBoxInfo,comboBoxWho,pictureBoxPhoto,textBoxAdress,textBox_Email,numericUpDownCreditGive,numericUpDownCreditTake);
        }

        private void buttonAddPeople_Click(object sender, EventArgs e)
        {
            string sPattern1 = "@";
            string sPattern2 = ".ru";
            string sPattern3 = ".com";
            string sPattern4 = ".net";
            if (textBox_Email.Text != "")
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Email.Text, sPattern1, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                && (System.Text.RegularExpressions.Regex.IsMatch(textBox_Email.Text, sPattern2, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                || System.Text.RegularExpressions.Regex.IsMatch(textBox_Email.Text, sPattern3, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                || System.Text.RegularExpressions.Regex.IsMatch(textBox_Email.Text, sPattern4, System.Text.RegularExpressions.RegexOptions.IgnoreCase)))
                {
                    WorkWithDB.Instance.ChangeLine(CurrentId, textBoxName, textBoxLastName, textBoxOtshestvo, dateTimePickerBirthday, textBoxPhone, textBoxInfo, comboBoxWho, pictureBoxPhoto, textBoxAdress, textBox_Email, numericUpDownCreditGive, numericUpDownCreditTake);
                    this.Close();
                }
                else MessageBox.Show("Email введен не верно");
            else
            {
                WorkWithDB.Instance.ChangeLine(CurrentId, textBoxName, textBoxLastName, textBoxOtshestvo, dateTimePickerBirthday, textBoxPhone, textBoxInfo, comboBoxWho, pictureBoxPhoto, textBoxAdress, textBox_Email, numericUpDownCreditGive, numericUpDownCreditTake);
                this.Close();
            }
            
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Multiselect = false;
            openDialog.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg|All Files (*.*)|*.*";

            if (openDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    pictureBoxPhoto.Image = Image.FromFile(openDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Это не изображение");
                }
            }
        }

        private void buttonCleanPhoto_Click(object sender, EventArgs e)
        {
            pictureBoxPhoto.Image = null;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
