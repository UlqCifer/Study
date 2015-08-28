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
    public partial class SearchForm : Form
    {
        public static bool namecheck;
        public static bool lastnamecheck;
        public static bool whocheck;
        public static string name;
        public static string lastname;
        public static string who;

        static readonly SearchForm instance = new SearchForm();
        public static SearchForm Instance
        {
            get
            {
                return instance;
            }
        }
        

        public SearchForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            lastname = textBoxLastName.Text;

            namecheck = checkBoxName.Checked;
            lastnamecheck = checkBoxLastName.Checked;

            whocheck = checkBoxWho.Checked;
            who = comboBoxWho.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            comboBoxWho.SelectedIndex = comboBoxWho.FindStringExact("Не выбрано");
        }
    }
}
