namespace Daigorodov_Kyrcova9
{
    partial class SearchForm
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
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.checkBoxWho = new System.Windows.Forms.CheckBox();
            this.comboBoxWho = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(13, 13);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(75, 17);
            this.checkBoxName.TabIndex = 0;
            this.checkBoxName.Text = "По имени";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Location = new System.Drawing.Point(13, 37);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(89, 17);
            this.checkBoxLastName.TabIndex = 1;
            this.checkBoxLastName.Text = "По фамилии";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(131, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(131, 37);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(150, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(48, 103);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(177, 34);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Применить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // checkBoxWho
            // 
            this.checkBoxWho.AutoSize = true;
            this.checkBoxWho.Location = new System.Drawing.Point(13, 64);
            this.checkBoxWho.Name = "checkBoxWho";
            this.checkBoxWho.Size = new System.Drawing.Size(100, 17);
            this.checkBoxWho.TabIndex = 5;
            this.checkBoxWho.Text = "По отношению";
            this.checkBoxWho.UseVisualStyleBackColor = true;
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
            this.comboBoxWho.Location = new System.Drawing.Point(131, 62);
            this.comboBoxWho.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWho.Name = "comboBoxWho";
            this.comboBoxWho.Size = new System.Drawing.Size(150, 21);
            this.comboBoxWho.TabIndex = 39;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 149);
            this.Controls.Add(this.comboBoxWho);
            this.Controls.Add(this.checkBoxWho);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.checkBoxLastName);
            this.Controls.Add(this.checkBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.CheckBox checkBoxWho;
        private System.Windows.Forms.ComboBox comboBoxWho;
    }
}