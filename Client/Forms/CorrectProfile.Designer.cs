namespace DB_project.Forms
{
    partial class CorrectProfile
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
            this.label_CorrectProf = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Birth = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_PassportID = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_CardNum = new System.Windows.Forms.MaskedTextBox();
            this.panel_Address = new System.Windows.Forms.Panel();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.panel_Phone = new System.Windows.Forms.Panel();
            this.label_Phone = new System.Windows.Forms.Label();
            this.panel_Birth = new System.Windows.Forms.Panel();
            this.label_Birth = new System.Windows.Forms.Label();
            this.panel_Gender = new System.Windows.Forms.Panel();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.panel_PassportID = new System.Windows.Forms.Panel();
            this.label_PassportID = new System.Windows.Forms.Label();
            this.panel_CardNum = new System.Windows.Forms.Panel();
            this.label_CardNum = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CorrectProf
            // 
            this.label_CorrectProf.AutoSize = true;
            this.label_CorrectProf.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_CorrectProf.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label_CorrectProf.ForeColor = System.Drawing.Color.White;
            this.label_CorrectProf.Location = new System.Drawing.Point(80, 12);
            this.label_CorrectProf.Name = "label_CorrectProf";
            this.label_CorrectProf.Size = new System.Drawing.Size(314, 46);
            this.label_CorrectProf.TabIndex = 15;
            this.label_CorrectProf.Text = "Внести изменения";
            this.label_CorrectProf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(244, 622);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(205, 70);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Gender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_Gender.ForeColor = System.Drawing.Color.White;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.comboBox_Gender.Location = new System.Drawing.Point(27, 342);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(422, 31);
            this.comboBox_Gender.TabIndex = 4;
            // 
            // maskedTextBox_Phone
            // 
            this.maskedTextBox_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maskedTextBox_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_Phone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maskedTextBox_Phone.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_Phone.Location = new System.Drawing.Point(27, 497);
            this.maskedTextBox_Phone.Mask = "+7 000 000 0000";
            this.maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            this.maskedTextBox_Phone.Size = new System.Drawing.Size(422, 23);
            this.maskedTextBox_Phone.TabIndex = 6;
            this.maskedTextBox_Phone.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_Birth
            // 
            this.maskedTextBox_Birth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maskedTextBox_Birth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_Birth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maskedTextBox_Birth.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_Birth.Location = new System.Drawing.Point(27, 421);
            this.maskedTextBox_Birth.Mask = "00/00/0000";
            this.maskedTextBox_Birth.Name = "maskedTextBox_Birth";
            this.maskedTextBox_Birth.Size = new System.Drawing.Size(422, 23);
            this.maskedTextBox_Birth.TabIndex = 5;
            this.maskedTextBox_Birth.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_PassportID
            // 
            this.maskedTextBox_PassportID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maskedTextBox_PassportID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_PassportID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maskedTextBox_PassportID.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_PassportID.Location = new System.Drawing.Point(27, 192);
            this.maskedTextBox_PassportID.Mask = "0000-000000";
            this.maskedTextBox_PassportID.Name = "maskedTextBox_PassportID";
            this.maskedTextBox_PassportID.Size = new System.Drawing.Size(422, 23);
            this.maskedTextBox_PassportID.TabIndex = 2;
            // 
            // maskedTextBox_CardNum
            // 
            this.maskedTextBox_CardNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maskedTextBox_CardNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_CardNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maskedTextBox_CardNum.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_CardNum.Location = new System.Drawing.Point(27, 118);
            this.maskedTextBox_CardNum.Mask = "000000";
            this.maskedTextBox_CardNum.Name = "maskedTextBox_CardNum";
            this.maskedTextBox_CardNum.Size = new System.Drawing.Size(422, 23);
            this.maskedTextBox_CardNum.TabIndex = 1;
            this.maskedTextBox_CardNum.ValidatingType = typeof(int);
            // 
            // panel_Address
            // 
            this.panel_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Address.Location = new System.Drawing.Point(27, 603);
            this.panel_Address.Name = "panel_Address";
            this.panel_Address.Size = new System.Drawing.Size(422, 1);
            this.panel_Address.TabIndex = 52;
            // 
            // textBox_Address
            // 
            this.textBox_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Address.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_Address.ForeColor = System.Drawing.Color.White;
            this.textBox_Address.Location = new System.Drawing.Point(27, 574);
            this.textBox_Address.MaxLength = 50;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(422, 23);
            this.textBox_Address.TabIndex = 7;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Address.ForeColor = System.Drawing.Color.White;
            this.label_Address.Location = new System.Drawing.Point(23, 548);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(166, 23);
            this.label_Address.TabIndex = 51;
            this.label_Address.Text = "Адрес проживания:";
            // 
            // panel_Phone
            // 
            this.panel_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Phone.Location = new System.Drawing.Point(27, 526);
            this.panel_Phone.Name = "panel_Phone";
            this.panel_Phone.Size = new System.Drawing.Size(422, 1);
            this.panel_Phone.TabIndex = 50;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Phone.ForeColor = System.Drawing.Color.White;
            this.label_Phone.Location = new System.Drawing.Point(23, 471);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(147, 23);
            this.label_Phone.TabIndex = 49;
            this.label_Phone.Text = "Номер телефона:";
            // 
            // panel_Birth
            // 
            this.panel_Birth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Birth.Location = new System.Drawing.Point(27, 450);
            this.panel_Birth.Name = "panel_Birth";
            this.panel_Birth.Size = new System.Drawing.Size(422, 1);
            this.panel_Birth.TabIndex = 48;
            // 
            // label_Birth
            // 
            this.label_Birth.AutoSize = true;
            this.label_Birth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Birth.ForeColor = System.Drawing.Color.White;
            this.label_Birth.Location = new System.Drawing.Point(23, 395);
            this.label_Birth.Name = "label_Birth";
            this.label_Birth.Size = new System.Drawing.Size(136, 23);
            this.label_Birth.TabIndex = 47;
            this.label_Birth.Text = "Дата рождения:";
            // 
            // panel_Gender
            // 
            this.panel_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Gender.Location = new System.Drawing.Point(27, 375);
            this.panel_Gender.Name = "panel_Gender";
            this.panel_Gender.Size = new System.Drawing.Size(422, 1);
            this.panel_Gender.TabIndex = 46;
            // 
            // panel_Name
            // 
            this.panel_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Name.Location = new System.Drawing.Point(27, 296);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Size = new System.Drawing.Size(422, 1);
            this.panel_Name.TabIndex = 44;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_Name.ForeColor = System.Drawing.Color.White;
            this.textBox_Name.Location = new System.Drawing.Point(27, 267);
            this.textBox_Name.MaxLength = 50;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(422, 23);
            this.textBox_Name.TabIndex = 3;
            // 
            // panel_PassportID
            // 
            this.panel_PassportID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_PassportID.Location = new System.Drawing.Point(27, 221);
            this.panel_PassportID.Name = "panel_PassportID";
            this.panel_PassportID.Size = new System.Drawing.Size(422, 1);
            this.panel_PassportID.TabIndex = 42;
            // 
            // label_PassportID
            // 
            this.label_PassportID.AutoSize = true;
            this.label_PassportID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_PassportID.ForeColor = System.Drawing.Color.White;
            this.label_PassportID.Location = new System.Drawing.Point(23, 166);
            this.label_PassportID.Name = "label_PassportID";
            this.label_PassportID.Size = new System.Drawing.Size(212, 23);
            this.label_PassportID.TabIndex = 41;
            this.label_PassportID.Text = "Серия и номер паспорта:";
            // 
            // panel_CardNum
            // 
            this.panel_CardNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_CardNum.Location = new System.Drawing.Point(27, 147);
            this.panel_CardNum.Name = "panel_CardNum";
            this.panel_CardNum.Size = new System.Drawing.Size(422, 1);
            this.panel_CardNum.TabIndex = 38;
            // 
            // label_CardNum
            // 
            this.label_CardNum.AutoSize = true;
            this.label_CardNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_CardNum.ForeColor = System.Drawing.Color.White;
            this.label_CardNum.Location = new System.Drawing.Point(23, 92);
            this.label_CardNum.Name = "label_CardNum";
            this.label_CardNum.Size = new System.Drawing.Size(229, 23);
            this.label_CardNum.TabIndex = 36;
            this.label_CardNum.Text = "Номер медицинской карты:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(23, 241);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 23);
            this.label_Name.TabIndex = 43;
            this.label_Name.Text = "ФИО:";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Gender.ForeColor = System.Drawing.Color.White;
            this.label_Gender.Location = new System.Drawing.Point(23, 316);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(45, 23);
            this.label_Gender.TabIndex = 45;
            this.label_Gender.Text = "Пол:";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(27, 622);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(205, 70);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // CorrectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(475, 710);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.maskedTextBox_Phone);
            this.Controls.Add(this.maskedTextBox_Birth);
            this.Controls.Add(this.maskedTextBox_PassportID);
            this.Controls.Add(this.maskedTextBox_CardNum);
            this.Controls.Add(this.panel_Address);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.panel_Phone);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.panel_Birth);
            this.Controls.Add(this.label_Birth);
            this.Controls.Add(this.panel_Gender);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.panel_Name);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.panel_PassportID);
            this.Controls.Add(this.label_PassportID);
            this.Controls.Add(this.panel_CardNum);
            this.Controls.Add(this.label_CardNum);
            this.Controls.Add(this.label_CorrectProf);
            this.Controls.Add(this.button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CorrectProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CorrectProfile";
            this.Load += new System.EventHandler(this.CorrectProfile_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CorrectProfile_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CorrectProf;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Phone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Birth;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PassportID;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CardNum;
        private System.Windows.Forms.Panel panel_Address;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Panel panel_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Panel panel_Birth;
        private System.Windows.Forms.Label label_Birth;
        private System.Windows.Forms.Panel panel_Gender;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Panel panel_PassportID;
        private System.Windows.Forms.Label label_PassportID;
        private System.Windows.Forms.Panel panel_CardNum;
        private System.Windows.Forms.Label label_CardNum;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Button button_Save;
    }
}