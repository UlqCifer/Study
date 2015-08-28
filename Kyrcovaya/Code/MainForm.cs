using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Daigorodov_Kyrcova9
{
    public partial class MainForm : Form
    {
        int currentid;
        public MainForm()
        {
            InitializeComponent();
            this.Text = WorkWithDB.Instance.path();
            buttonUTF8WordConvert.Visible = false;
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WorkWithDB.Instance.LoadFile(dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Дата рождения";
            dataGridView1.Columns[6].HeaderText = "Адрес";
            dataGridView1.Columns[8].HeaderText = "Кем является";
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddPeopleForm AddPeople = new AddPeopleForm();
            AddPeople.ShowDialog(this);
            WorkWithDB.Instance.LoadFile(dataGridView1);
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;


                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    
                    if (selectedRow.Cells["ID"].Value == null)
                    {
                        MessageBox.Show("Вы выбрали пустую строку!");
                    }
                    else
                    {
                        currentid = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                         DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo);
                             if (dialogResult == DialogResult.Yes)
                            {
                                 WorkWithDB.Instance.deleterow(currentid);
                                 WorkWithDB.Instance.LoadFile(dataGridView1);
                            }
                    }
                }
            else MessageBox.Show("Вы не выбрали строку!");
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView1.SelectedCells.Count > 0)

                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    if (selectedRow.Cells["ID"].Value == null)
                    {
                        MessageBox.Show("Вы выбрали пустую строку!");
                    }
                    else
                    {
                        currentid = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                        EditPeopleForm EditPeople = new EditPeopleForm(currentid);
                        EditPeople.ShowDialog(this);
                        WorkWithDB.Instance.LoadFile(dataGridView1);
                    }
                }

            else MessageBox.Show("Вы не выбрали строку!");

           
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchForm Search = new SearchForm();
            Search.ShowDialog(this);
            if (Search.DialogResult == DialogResult.OK) WorkWithDB.Instance.LoadFileFiltered(dataGridView1, SearchForm.namecheck, SearchForm.name, SearchForm.lastnamecheck, SearchForm.lastname,SearchForm.whocheck,SearchForm.who);
            
        }

        private void MoreInfo_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView1.SelectedCells.Count > 0)

            {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    if (selectedRow.Cells["ID"].Value == null)
                    {
                        MessageBox.Show("Вы выбрали пустую строку!");
                    }
                    else
                    {
                        currentid = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                        MoreIngoForm moreinfo = new MoreIngoForm(currentid);
                        moreinfo.ShowDialog(this);
                    }
               }
            else MessageBox.Show("Вы не выбрали строку!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkWithDB.Instance.LoadFile(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = fontDialog1.Font;
                c.DefaultCellStyle.ForeColor = fontDialog1.Color;
            }

        }


        //TODO Доделать вывод в WORD
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = new UTF8Encoding(true, true);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.doc)|*.doc";
            sfd.FileName = "export.doc";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name 
            }
        }

    }
}
