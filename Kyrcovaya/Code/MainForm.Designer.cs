namespace Daigorodov_Kyrcova9
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.MoreInfo_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUTF8WordConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(998, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Add_button.Location = new System.Drawing.Point(6, 331);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(133, 33);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Добавить запись";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Delete_button.Location = new System.Drawing.Point(145, 332);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(122, 33);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.Text = "Удалить запись";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Edit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Edit_button.Location = new System.Drawing.Point(273, 332);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(167, 33);
            this.Edit_button.TabIndex = 3;
            this.Edit_button.Text = "Редактировать запись";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Search_button.AutoSize = true;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Search_button.Location = new System.Drawing.Point(884, 332);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(102, 33);
            this.Search_button.TabIndex = 4;
            this.Search_button.Text = "Поиск";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // MoreInfo_button
            // 
            this.MoreInfo_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoreInfo_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoreInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MoreInfo_button.Location = new System.Drawing.Point(446, 332);
            this.MoreInfo_button.Name = "MoreInfo_button";
            this.MoreInfo_button.Size = new System.Drawing.Size(130, 33);
            this.MoreInfo_button.TabIndex = 5;
            this.MoreInfo_button.Text = "Подробнее";
            this.MoreInfo_button.UseVisualStyleBackColor = true;
            this.MoreInfo_button.Click += new System.EventHandler(this.MoreInfo_button_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(720, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Показать все записи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(582, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Изменить шрифт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUTF8WordConvert
            // 
            this.buttonUTF8WordConvert.Location = new System.Drawing.Point(145, 304);
            this.buttonUTF8WordConvert.Name = "buttonUTF8WordConvert";
            this.buttonUTF8WordConvert.Size = new System.Drawing.Size(101, 22);
            this.buttonUTF8WordConvert.TabIndex = 8;
            this.buttonUTF8WordConvert.Text = "Secret button";
            this.buttonUTF8WordConvert.UseVisualStyleBackColor = true;
            this.buttonUTF8WordConvert.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 377);
            this.Controls.Add(this.buttonUTF8WordConvert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MoreInfo_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button MoreInfo_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonUTF8WordConvert;
    }
}