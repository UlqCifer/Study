namespace Daigorodov_Kyrcova9
{
    partial class EditPeopleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCreditTake = new System.Windows.Forms.Label();
            this.labelCreditGive = new System.Windows.Forms.Label();
            this.numericUpDownCreditTake = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCreditGive = new System.Windows.Forms.NumericUpDown();
            this.labelWho = new System.Windows.Forms.Label();
            this.comboBoxWho = new System.Windows.Forms.ComboBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.textBoxOtshestvo = new System.Windows.Forms.TextBox();
            this.labelOtshestvo = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonCleanPhoto = new System.Windows.Forms.Button();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonAddPeople = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreditTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreditGive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreditTake
            // 
            this.labelCreditTake.AutoSize = true;
            this.labelCreditTake.Location = new System.Drawing.Point(10, 226);
            this.labelCreditTake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreditTake.Name = "labelCreditTake";
            this.labelCreditTake.Size = new System.Drawing.Size(99, 13);
            this.labelCreditTake.TabIndex = 43;
            this.labelCreditTake.Text = "Взял в долг (руб): ";
            // 
            // labelCreditGive
            // 
            this.labelCreditGive.AutoSize = true;
            this.labelCreditGive.Location = new System.Drawing.Point(10, 206);
            this.labelCreditGive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreditGive.Name = "labelCreditGive";
            this.labelCreditGive.Size = new System.Drawing.Size(103, 13);
            this.labelCreditGive.TabIndex = 42;
            this.labelCreditGive.Text = "Дал взаймы (руб): ";
            // 
            // numericUpDownCreditTake
            // 
            this.numericUpDownCreditTake.Location = new System.Drawing.Point(118, 224);
            this.numericUpDownCreditTake.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCreditTake.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownCreditTake.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericUpDownCreditTake.Name = "numericUpDownCreditTake";
            this.numericUpDownCreditTake.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownCreditTake.TabIndex = 41;
            // 
            // numericUpDownCreditGive
            // 
            this.numericUpDownCreditGive.Location = new System.Drawing.Point(118, 204);
            this.numericUpDownCreditGive.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCreditGive.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownCreditGive.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericUpDownCreditGive.Name = "numericUpDownCreditGive";
            this.numericUpDownCreditGive.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownCreditGive.TabIndex = 40;
            // 
            // labelWho
            // 
            this.labelWho.AutoSize = true;
            this.labelWho.Location = new System.Drawing.Point(10, 184);
            this.labelWho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWho.Name = "labelWho";
            this.labelWho.Size = new System.Drawing.Size(84, 13);
            this.labelWho.TabIndex = 39;
            this.labelWho.Text = "Кем является: ";
            // 
            // comboBoxWho
            // 
            this.comboBoxWho.FormattingEnabled = true;
            this.comboBoxWho.Items.AddRange(new object[] {
            "Не выбрано",
            "Родственник",
            "Друг",
            "Коллега",
            "Одногруппник",
            "Знакомый",
            "Враг"});
            this.comboBoxWho.Location = new System.Drawing.Point(116, 179);
            this.comboBoxWho.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWho.Name = "comboBoxWho";
            this.comboBoxWho.Size = new System.Drawing.Size(142, 21);
            this.comboBoxWho.TabIndex = 38;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(117, 131);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(142, 20);
            this.textBoxAdress.TabIndex = 37;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(11, 131);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(41, 13);
            this.labelAdress.TabIndex = 36;
            this.labelAdress.Text = "Адрес:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(117, 107);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(142, 20);
            this.textBoxPhone.TabIndex = 35;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(11, 107);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 34;
            this.labelPhone.Text = "Телефон:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(117, 83);
            this.dateTimePickerBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickerBirthday.TabIndex = 33;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(11, 83);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(89, 13);
            this.labelBirthday.TabIndex = 32;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // textBoxOtshestvo
            // 
            this.textBoxOtshestvo.Location = new System.Drawing.Point(117, 57);
            this.textBoxOtshestvo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOtshestvo.Name = "textBoxOtshestvo";
            this.textBoxOtshestvo.Size = new System.Drawing.Size(142, 20);
            this.textBoxOtshestvo.TabIndex = 31;
            // 
            // labelOtshestvo
            // 
            this.labelOtshestvo.AutoSize = true;
            this.labelOtshestvo.Location = new System.Drawing.Point(11, 57);
            this.labelOtshestvo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtshestvo.Name = "labelOtshestvo";
            this.labelOtshestvo.Size = new System.Drawing.Size(57, 13);
            this.labelOtshestvo.TabIndex = 30;
            this.labelOtshestvo.Text = "Отчество:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(116, 5);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(142, 20);
            this.textBoxLastName.TabIndex = 26;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(10, 5);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Фамилия:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 32);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(117, 29);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 29;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(618, 13);
            this.labelPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(38, 13);
            this.labelPhoto.TabIndex = 49;
            this.labelPhoto.Text = "Фото:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(272, 8);
            this.labelNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(163, 13);
            this.labelNote.TabIndex = 48;
            this.labelNote.Text = "Дополнительная информация:";
            // 
            // buttonCleanPhoto
            // 
            this.buttonCleanPhoto.Location = new System.Drawing.Point(621, 239);
            this.buttonCleanPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCleanPhoto.Name = "buttonCleanPhoto";
            this.buttonCleanPhoto.Size = new System.Drawing.Size(153, 21);
            this.buttonCleanPhoto.TabIndex = 47;
            this.buttonCleanPhoto.Text = "Убрать фото";
            this.buttonCleanPhoto.UseVisualStyleBackColor = true;
            this.buttonCleanPhoto.Click += new System.EventHandler(this.buttonCleanPhoto_Click);
            // 
            // AddPhoto
            // 
            this.AddPhoto.Location = new System.Drawing.Point(621, 216);
            this.AddPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(153, 20);
            this.AddPhoto.TabIndex = 46;
            this.AddPhoto.Text = "Добавить фотографию";
            this.AddPhoto.UseVisualStyleBackColor = true;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(621, 32);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(153, 184);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 45;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(275, 32);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(342, 228);
            this.textBoxInfo.TabIndex = 44;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(137, 246);
            this.buttonCloseForm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(121, 22);
            this.buttonCloseForm.TabIndex = 51;
            this.buttonCloseForm.Text = "Закрыть";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonAddPeople
            // 
            this.buttonAddPeople.Location = new System.Drawing.Point(13, 246);
            this.buttonAddPeople.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPeople.Name = "buttonAddPeople";
            this.buttonAddPeople.Size = new System.Drawing.Size(109, 22);
            this.buttonAddPeople.TabIndex = 50;
            this.buttonAddPeople.Text = "Изменить";
            this.buttonAddPeople.UseVisualStyleBackColor = true;
            this.buttonAddPeople.Click += new System.EventHandler(this.buttonAddPeople_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(117, 155);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(142, 20);
            this.textBox_Email.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Email:";
            // 
            // EditPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 275);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonAddPeople);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonCleanPhoto);
            this.Controls.Add(this.AddPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelCreditTake);
            this.Controls.Add(this.labelCreditGive);
            this.Controls.Add(this.numericUpDownCreditTake);
            this.Controls.Add(this.numericUpDownCreditGive);
            this.Controls.Add(this.labelWho);
            this.Controls.Add(this.comboBoxWho);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.textBoxOtshestvo);
            this.Controls.Add(this.labelOtshestvo);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditPeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить выбранную запись";
            this.Load += new System.EventHandler(this.EditPeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreditTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreditGive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreditTake;
        private System.Windows.Forms.Label labelCreditGive;
        private System.Windows.Forms.NumericUpDown numericUpDownCreditTake;
        private System.Windows.Forms.NumericUpDown numericUpDownCreditGive;
        private System.Windows.Forms.Label labelWho;
        private System.Windows.Forms.ComboBox comboBoxWho;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.TextBox textBoxOtshestvo;
        private System.Windows.Forms.Label labelOtshestvo;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonCleanPhoto;
        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonAddPeople;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label1;
    }
}