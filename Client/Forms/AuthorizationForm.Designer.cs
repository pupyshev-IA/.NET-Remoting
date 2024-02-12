using System.Windows.Forms;

namespace DB_project
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Entr = new System.Windows.Forms.Label();
            this.button_ExitA = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.panel_Password = new System.Windows.Forms.Panel();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Entry = new System.Windows.Forms.Button();
            this.linkLabel_Registration = new System.Windows.Forms.LinkLabel();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.maskedTextBox_Login = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label_Entr
            // 
            this.label_Entr.AutoSize = true;
            this.label_Entr.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_Entr.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label_Entr.ForeColor = System.Drawing.Color.White;
            this.label_Entr.Location = new System.Drawing.Point(224, 9);
            this.label_Entr.Name = "label_Entr";
            this.label_Entr.Size = new System.Drawing.Size(98, 46);
            this.label_Entr.TabIndex = 0;
            this.label_Entr.Text = "Вход";
            this.label_Entr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ExitA
            // 
            this.button_ExitA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_ExitA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ExitA.FlatAppearance.BorderSize = 0;
            this.button_ExitA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExitA.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ExitA.ForeColor = System.Drawing.Color.White;
            this.button_ExitA.Location = new System.Drawing.Point(503, 12);
            this.button_ExitA.Name = "button_ExitA";
            this.button_ExitA.Size = new System.Drawing.Size(35, 35);
            this.button_ExitA.TabIndex = 6;
            this.button_ExitA.Text = "✕";
            this.button_ExitA.UseVisualStyleBackColor = false;
            this.button_ExitA.Click += new System.EventHandler(this.button_exitA_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Login.ForeColor = System.Drawing.Color.White;
            this.label_Login.Location = new System.Drawing.Point(59, 93);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(128, 23);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "Введите логин:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password.ForeColor = System.Drawing.Color.White;
            this.label_Password.Location = new System.Drawing.Point(59, 186);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(139, 23);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Введите пароль:";
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Login.Location = new System.Drawing.Point(63, 156);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(422, 1);
            this.panel_Login.TabIndex = 5;
            // 
            // panel_Password
            // 
            this.panel_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Password.Location = new System.Drawing.Point(63, 250);
            this.panel_Password.Name = "panel_Password";
            this.panel_Password.Size = new System.Drawing.Size(422, 1);
            this.panel_Password.TabIndex = 5;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(63, 217);
            this.textBox_Password.MaxLength = 15;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(422, 27);
            this.textBox_Password.TabIndex = 2;
            // 
            // button_Entry
            // 
            this.button_Entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Entry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Entry.FlatAppearance.BorderSize = 0;
            this.button_Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Entry.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Entry.ForeColor = System.Drawing.Color.White;
            this.button_Entry.Location = new System.Drawing.Point(121, 306);
            this.button_Entry.Name = "button_Entry";
            this.button_Entry.Size = new System.Drawing.Size(313, 57);
            this.button_Entry.TabIndex = 4;
            this.button_Entry.Text = "Войти";
            this.button_Entry.UseVisualStyleBackColor = false;
            this.button_Entry.Click += new System.EventHandler(this.button_entry_Click);
            // 
            // linkLabel_Registration
            // 
            this.linkLabel_Registration.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel_Registration.AutoSize = true;
            this.linkLabel_Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Registration.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.linkLabel_Registration.LinkColor = System.Drawing.Color.White;
            this.linkLabel_Registration.Location = new System.Drawing.Point(223, 383);
            this.linkLabel_Registration.Name = "linkLabel_Registration";
            this.linkLabel_Registration.Size = new System.Drawing.Size(109, 23);
            this.linkLabel_Registration.TabIndex = 5;
            this.linkLabel_Registration.TabStop = true;
            this.linkLabel_Registration.Text = "Регистрация";
            this.linkLabel_Registration.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLabel_Registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_registration_LinkClicked);
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.2F);
            this.checkBox_ShowPassword.ForeColor = System.Drawing.Color.White;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(337, 257);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(138, 23);
            this.checkBox_ShowPassword.TabIndex = 3;
            this.checkBox_ShowPassword.Text = "Показать пароль";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // maskedTextBox_Login
            // 
            this.maskedTextBox_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maskedTextBox_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_Login.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBox_Login.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_Login.Location = new System.Drawing.Point(63, 123);
            this.maskedTextBox_Login.Mask = "000000";
            this.maskedTextBox_Login.Name = "maskedTextBox_Login";
            this.maskedTextBox_Login.Size = new System.Drawing.Size(422, 27);
            this.maskedTextBox_Login.TabIndex = 1;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(550, 425);
            this.Controls.Add(this.maskedTextBox_Login);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.linkLabel_Registration);
            this.Controls.Add(this.button_Entry);
            this.Controls.Add(this.panel_Password);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.button_ExitA);
            this.Controls.Add(this.label_Entr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Authorization_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Entr;
        private System.Windows.Forms.Button button_ExitA;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
        private Panel panel_Login;
        private Panel panel_Password;
        private TextBox textBox_Password;
        private Button button_Entry;
        private LinkLabel linkLabel_Registration;
        private CheckBox checkBox_ShowPassword;
        private MaskedTextBox maskedTextBox_Login;
    }
}