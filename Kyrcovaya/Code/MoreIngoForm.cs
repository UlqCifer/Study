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
    public partial class MoreIngoForm : Form
    {
        int currentid;
        public MoreIngoForm(int ID)
        {
            InitializeComponent();
            currentid = ID;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoreIngoForm_Load(object sender, EventArgs e)
        {
            WorkWithDB.Instance.ReadFromFile(currentid, textBoxName, textBoxLastName, textBoxOtshestvo, textBoxDate, textBoxPhone,textBoxInfo, textBoxWho, pictureBoxPhoto,textBoxAdress,textBox_Email,textBoxDolg);
        }
    }
}
