namespace DB_project
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Birth = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_PassportID = new System.Windows.Forms.Label();
            this.label_CardNum = new System.Windows.Forms.Label();
            this.panel_Address = new System.Windows.Forms.Panel();
            this.panel_Phone = new System.Windows.Forms.Panel();
            this.panel_Birth = new System.Windows.Forms.Panel();
            this.panel_Gender = new System.Windows.Forms.Panel();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.panel_PassportID = new System.Windows.Forms.Panel();
            this.panel_CardNum = new System.Windows.Forms.Panel();
            this.CardNumLabel = new System.Windows.Forms.Label();
            this.PassportIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel_Top.Controls.Add(this.pictureBox_profile);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(400, 50);
            this.panel_Top.TabIndex = 18;
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_profile.Image")));
            this.pictureBox_profile.Location = new System.Drawing.Point(12, 7);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_profile.TabIndex = 39;
            this.pictureBox_profile.TabStop = false;
            this.pictureBox_profile.Click += new System.EventHandler(this.pictureBox_profile_Click);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_Address.ForeColor = System.Drawing.Color.White;
            this.label_Address.Location = new System.Drawing.Point(8, 498);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(147, 20);
            this.label_Address.TabIndex = 38;
            this.label_Address.Text = "Адрес проживания:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_Phone.ForeColor = System.Drawing.Color.White;
            this.label_Phone.Location = new System.Drawing.Point(8, 426);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(130, 20);
            this.label_Phone.TabIndex = 37;
            this.label_Phone.Text = "Номер телефона:";
            // 
            // label_Birth
            // 
            this.label_Birth.AutoSize = true;
            this.label_Birth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_Birth.ForeColor = System.Drawing.Color.White;
            this.label_Birth.Location = new System.Drawing.Point(8, 354);
            this.label_Birth.Name = "label_Birth";
            this.label_Birth.Size = new System.Drawing.Size(119, 20);
            this.label_Birth.TabIndex = 36;
            this.label_Birth.Text = "Дата рождения:";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_Gender.ForeColor = System.Drawing.Color.White;
            this.label_Gender.Location = new System.Drawing.Point(8, 283);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(40, 20);
            this.label_Gender.TabIndex = 35;
            this.label_Gender.Text = "Пол:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(8, 210);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(45, 20);
            this.label_Name.TabIndex = 34;
            this.label_Name.Text = "ФИО:";
            // 
            // label_PassportID
            // 
            this.label_PassportID.AutoSize = true;
            this.label_PassportID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_PassportID.ForeColor = System.Drawing.Color.White;
            this.label_PassportID.Location = new System.Drawing.Point(8, 141);
            this.label_PassportID.Name = "label_PassportID";
            this.label_PassportID.Size = new System.Drawing.Size(187, 20);
            this.label_PassportID.TabIndex = 33;
            this.label_PassportID.Text = "Серия и номер паспорта:";
            // 
            // label_CardNum
            // 
            this.label_CardNum.AutoSize = true;
            this.label_CardNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_CardNum.ForeColor = System.Drawing.Color.White;
            this.label_CardNum.Location = new System.Drawing.Point(8, 73);
            this.label_CardNum.Name = "label_CardNum";
            this.label_CardNum.Size = new System.Drawing.Size(204, 20);
            this.label_CardNum.TabIndex = 31;
            this.label_CardNum.Text = "Номер медицинской карты:";
            // 
            // panel_Address
            // 
            this.panel_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Address.Location = new System.Drawing.Point(12, 550);
            this.panel_Address.Name = "panel_Address";
            this.panel_Address.Size = new System.Drawing.Size(366, 1);
            this.panel_Address.TabIndex = 39;
            // 
            // panel_Phone
            // 
            this.panel_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Phone.Location = new System.Drawing.Point(12, 478);
            this.panel_Phone.Name = "panel_Phone";
            this.panel_Phone.Size = new System.Drawing.Size(366, 1);
            this.panel_Phone.TabIndex = 39;
            // 
            // panel_Birth
            // 
            this.panel_Birth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Birth.Location = new System.Drawing.Point(12, 406);
            this.panel_Birth.Name = "panel_Birth";
            this.panel_Birth.Size = new System.Drawing.Size(366, 1);
            this.panel_Birth.TabIndex = 39;
            // 
            // panel_Gender
            // 
            this.panel_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Gender.Location = new System.Drawing.Point(12, 335);
            this.panel_Gender.Name = "panel_Gender";
            this.panel_Gender.Size = new System.Drawing.Size(366, 1);
            this.panel_Gender.TabIndex = 39;
            // 
            // panel_Name
            // 
            this.panel_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Name.Location = new System.Drawing.Point(12, 262);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Size = new System.Drawing.Size(366, 1);
            this.panel_Name.TabIndex = 39;
            // 
            // panel_PassportID
            // 
            this.panel_PassportID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_PassportID.Location = new System.Drawing.Point(12, 193);
            this.panel_PassportID.Name = "panel_PassportID";
            this.panel_PassportID.Size = new System.Drawing.Size(366, 1);
            this.panel_PassportID.TabIndex = 39;
            // 
            // panel_CardNum
            // 
            this.panel_CardNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_CardNum.Location = new System.Drawing.Point(12, 125);
            this.panel_CardNum.Name = "panel_CardNum";
            this.panel_CardNum.Size = new System.Drawing.Size(366, 1);
            this.panel_CardNum.TabIndex = 39;
            // 
            // CardNumLabel
            // 
            this.CardNumLabel.AutoSize = true;
            this.CardNumLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CardNumLabel.ForeColor = System.Drawing.Color.White;
            this.CardNumLabel.Location = new System.Drawing.Point(12, 96);
            this.CardNumLabel.Name = "CardNumLabel";
            this.CardNumLabel.Size = new System.Drawing.Size(92, 28);
            this.CardNumLabel.TabIndex = 40;
            this.CardNumLabel.Text = "----------";
            // 
            // PassportIDLabel
            // 
            this.PassportIDLabel.AutoSize = true;
            this.PassportIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PassportIDLabel.ForeColor = System.Drawing.Color.White;
            this.PassportIDLabel.Location = new System.Drawing.Point(12, 164);
            this.PassportIDLabel.Name = "PassportIDLabel";
            this.PassportIDLabel.Size = new System.Drawing.Size(92, 28);
            this.PassportIDLabel.TabIndex = 40;
            this.PassportIDLabel.Text = "----------";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(12, 233);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(92, 28);
            this.NameLabel.TabIndex = 40;
            this.NameLabel.Text = "----------";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GenderLabel.ForeColor = System.Drawing.Color.White;
            this.GenderLabel.Location = new System.Drawing.Point(12, 306);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(92, 28);
            this.GenderLabel.TabIndex = 40;
            this.GenderLabel.Text = "----------";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BirthLabel.ForeColor = System.Drawing.Color.White;
            this.BirthLabel.Location = new System.Drawing.Point(12, 377);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(92, 28);
            this.BirthLabel.TabIndex = 40;
            this.BirthLabel.Text = "----------";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PhoneLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneLabel.Location = new System.Drawing.Point(12, 449);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(92, 28);
            this.PhoneLabel.TabIndex = 40;
            this.PhoneLabel.Text = "----------";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressLabel.ForeColor = System.Drawing.Color.White;
            this.AddressLabel.Location = new System.Drawing.Point(12, 521);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(69, 20);
            this.AddressLabel.TabIndex = 40;
            this.AddressLabel.Text = "----------";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(400, 575);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PassportIDLabel);
            this.Controls.Add(this.CardNumLabel);
            this.Controls.Add(this.panel_CardNum);
            this.Controls.Add(this.panel_PassportID);
            this.Controls.Add(this.panel_Name);
            this.Controls.Add(this.panel_Gender);
            this.Controls.Add(this.panel_Birth);
            this.Controls.Add(this.panel_Phone);
            this.Controls.Add(this.panel_Address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Birth);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_PassportID);
            this.Controls.Add(this.label_CardNum);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Birth;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_PassportID;
        private System.Windows.Forms.Label label_CardNum;
        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.Panel panel_Address;
        private System.Windows.Forms.Panel panel_Phone;
        private System.Windows.Forms.Panel panel_Birth;
        private System.Windows.Forms.Panel panel_Gender;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.Panel panel_PassportID;
        private System.Windows.Forms.Panel panel_CardNum;
        private System.Windows.Forms.Label CardNumLabel;
        private System.Windows.Forms.Label PassportIDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AddressLabel;
    }
}