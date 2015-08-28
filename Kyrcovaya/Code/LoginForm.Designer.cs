namespace Daigorodov_Kyrcova9
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.Enter_button = new System.Windows.Forms.Button();
            this.Create_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(55, 7);
            this.Login_textBox.MaxLength = 15;
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(156, 20);
            this.Login_textBox.TabIndex = 0;
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Location = new System.Drawing.Point(55, 33);
            this.Pass_textBox.MaxLength = 15;
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.PasswordChar = '*';
            this.Pass_textBox.Size = new System.Drawing.Size(156, 20);
            this.Pass_textBox.TabIndex = 1;
            // 
            // Enter_button
            // 
            this.Enter_button.Location = new System.Drawing.Point(55, 60);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(75, 23);
            this.Enter_button.TabIndex = 2;
            this.Enter_button.Text = "Войти";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(136, 60);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(75, 23);
            this.Create_button.TabIndex = 3;
            this.Create_button.Text = "Создать";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 86);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.Pass_textBox);
            this.Controls.Add(this.Login_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

