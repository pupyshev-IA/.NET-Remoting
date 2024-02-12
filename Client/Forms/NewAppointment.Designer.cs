namespace DB_project.Forms
{
    partial class NewAppointment
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
            this.label_NewApp = new System.Windows.Forms.Label();
            this.button_ExitNA = new System.Windows.Forms.Button();
            this.comboBox_Service = new System.Windows.Forms.ComboBox();
            this.panel_Service = new System.Windows.Forms.Panel();
            this.panel_Time = new System.Windows.Forms.Panel();
            this.maskedTextBox_dateStart = new System.Windows.Forms.MaskedTextBox();
            this.panel_dateStart = new System.Windows.Forms.Panel();
            this.panel_Reason = new System.Windows.Forms.Panel();
            this.textBox_Reason = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.maskedTextBox_Time = new System.Windows.Forms.MaskedTextBox();
            this.label_Service = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Reason = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_NewApp
            // 
            this.label_NewApp.AutoSize = true;
            this.label_NewApp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_NewApp.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label_NewApp.ForeColor = System.Drawing.Color.White;
            this.label_NewApp.Location = new System.Drawing.Point(190, 12);
            this.label_NewApp.Name = "label_NewApp";
            this.label_NewApp.Size = new System.Drawing.Size(257, 50);
            this.label_NewApp.TabIndex = 15;
            this.label_NewApp.Text = "Новая запись";
            this.label_NewApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ExitNA
            // 
            this.button_ExitNA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_ExitNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ExitNA.FlatAppearance.BorderSize = 0;
            this.button_ExitNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExitNA.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.button_ExitNA.ForeColor = System.Drawing.Color.White;
            this.button_ExitNA.Location = new System.Drawing.Point(427, 423);
            this.button_ExitNA.Name = "button_ExitNA";
            this.button_ExitNA.Size = new System.Drawing.Size(190, 70);
            this.button_ExitNA.TabIndex = 7;
            this.button_ExitNA.Text = "Отмена";
            this.button_ExitNA.UseVisualStyleBackColor = false;
            this.button_ExitNA.Click += new System.EventHandler(this.button_ExitNA_Click);
            // 
            // comboBox_Service
            // 
            this.comboBox_Service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Service.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox_Service.ForeColor = System.Drawing.Color.White;
            this.comboBox_Service.FormattingEnabled = true;
            this.comboBox_Service.Items.AddRange(new object[] {
            "Анализ крови биохимический",
            "Анализ крови на маркеры гепатита B и C",
            "Исследование крови на сифилис",
            "Исследование крови на ВИЧ",
            "Исследование крови на RW",
            "Взятие крови из периферической вены",
            "Флюорография легких",
            "Рентгенография легких",
            "Ультразвуковое исследование органов брюшной полости",
            "Ультразвуковое исследование печени",
            "Ультразвуковое исследование почек и надпочечников",
            "Электрокардиография с физической нагрузкой",
            "Общий (клинический) анализ мочи",
            "Общий массаж медицинский",
            "Внутривенное введение лекарственных препаратов",
            "Массаж грудной клетки медицинский",
            "Прием (осмотр, консультация) врача-хирурга",
            "Прием (осмотр, консультация) врача-терапевта",
            "Прием (осмотр, консультация) врача-психиатра",
            "Прием (осмотр, консультация) врача-офтальмолога",
            "Прием (осмотр, консультация) врача-невролога",
            "Рентгенография крестца и копчика",
            "Рентгенография ключицы",
            "Рентгенография верхней конечности",
            "Парацентез",
            "Биопсия кожи",
            "Компьютерная томография сустава",
            "Компьютерная томография позвоночника",
            "Эхокардиография",
            "Уретроскопия",
            "Колоноскопия"});
            this.comboBox_Service.Location = new System.Drawing.Point(17, 118);
            this.comboBox_Service.Name = "comboBox_Service";
            this.comboBox_Service.Size = new System.Drawing.Size(600, 36);
            this.comboBox_Service.TabIndex = 1;
            // 
            // panel_Service
            // 
            this.panel_Service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Service.Location = new System.Drawing.Point(17, 160);
            this.panel_Service.Name = "panel_Service";
            this.panel_Service.Size = new System.Drawing.Size(600, 1);
            this.panel_Service.TabIndex = 18;
            // 
            // panel_Time
            // 
            this.panel_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Time.Location = new System.Drawing.Point(17, 399);
            this.panel_Time.Name = "panel_Time";
            this.panel_Time.Size = new System.Drawing.Size(600, 1);
            this.panel_Time.TabIndex = 18;
            // 
            // maskedTextBox_dateStart
            // 
            this.maskedTextBox_dateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maskedTextBox_dateStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_dateStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBox_dateStart.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_dateStart.Location = new System.Drawing.Point(17, 206);
            this.maskedTextBox_dateStart.Mask = "00/00/0000";
            this.maskedTextBox_dateStart.Name = "maskedTextBox_dateStart";
            this.maskedTextBox_dateStart.Size = new System.Drawing.Size(600, 27);
            this.maskedTextBox_dateStart.TabIndex = 2;
            this.maskedTextBox_dateStart.ValidatingType = typeof(System.DateTime);
            // 
            // panel_dateStart
            // 
            this.panel_dateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_dateStart.Location = new System.Drawing.Point(17, 239);
            this.panel_dateStart.Name = "panel_dateStart";
            this.panel_dateStart.Size = new System.Drawing.Size(600, 1);
            this.panel_dateStart.TabIndex = 20;
            // 
            // panel_Reason
            // 
            this.panel_Reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Reason.Location = new System.Drawing.Point(17, 319);
            this.panel_Reason.Name = "panel_Reason";
            this.panel_Reason.Size = new System.Drawing.Size(600, 1);
            this.panel_Reason.TabIndex = 22;
            // 
            // textBox_Reason
            // 
            this.textBox_Reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_Reason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Reason.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox_Reason.ForeColor = System.Drawing.Color.White;
            this.textBox_Reason.Location = new System.Drawing.Point(17, 286);
            this.textBox_Reason.MaxLength = 150;
            this.textBox_Reason.Name = "textBox_Reason";
            this.textBox_Reason.Size = new System.Drawing.Size(600, 25);
            this.textBox_Reason.TabIndex = 3;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(221, 423);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(190, 70);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(17, 423);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(190, 70);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // panel_Name
            // 
            this.panel_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Name.Location = new System.Drawing.Point(13, -141);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Size = new System.Drawing.Size(422, 1);
            this.panel_Name.TabIndex = 26;
            // 
            // maskedTextBox_Time
            // 
            this.maskedTextBox_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maskedTextBox_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_Time.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBox_Time.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_Time.Location = new System.Drawing.Point(17, 366);
            this.maskedTextBox_Time.Mask = "00:00";
            this.maskedTextBox_Time.Name = "maskedTextBox_Time";
            this.maskedTextBox_Time.Size = new System.Drawing.Size(600, 27);
            this.maskedTextBox_Time.TabIndex = 4;
            this.maskedTextBox_Time.ValidatingType = typeof(System.DateTime);
            // 
            // label_Service
            // 
            this.label_Service.AutoSize = true;
            this.label_Service.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Service.ForeColor = System.Drawing.Color.White;
            this.label_Service.Location = new System.Drawing.Point(13, 92);
            this.label_Service.Name = "label_Service";
            this.label_Service.Size = new System.Drawing.Size(232, 23);
            this.label_Service.TabIndex = 27;
            this.label_Service.Text = "Выберите желаемую услугу:";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(13, 180);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(118, 23);
            this.label_Date.TabIndex = 27;
            this.label_Date.Text = "Укажите дату:";
            // 
            // label_Reason
            // 
            this.label_Reason.AutoSize = true;
            this.label_Reason.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Reason.ForeColor = System.Drawing.Color.White;
            this.label_Reason.Location = new System.Drawing.Point(13, 260);
            this.label_Reason.Name = "label_Reason";
            this.label_Reason.Size = new System.Drawing.Size(309, 23);
            this.label_Reason.TabIndex = 27;
            this.label_Reason.Text = "Укажите причину записи (симптомы):";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Time.ForeColor = System.Drawing.Color.White;
            this.label_Time.Location = new System.Drawing.Point(13, 340);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(269, 23);
            this.label_Time.TabIndex = 27;
            this.label_Time.Text = "Укажите удобное для Вас время:";
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(635, 510);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Reason);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Service);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel_Name);
            this.Controls.Add(this.panel_Reason);
            this.Controls.Add(this.textBox_Reason);
            this.Controls.Add(this.panel_dateStart);
            this.Controls.Add(this.maskedTextBox_Time);
            this.Controls.Add(this.maskedTextBox_dateStart);
            this.Controls.Add(this.panel_Time);
            this.Controls.Add(this.panel_Service);
            this.Controls.Add(this.comboBox_Service);
            this.Controls.Add(this.label_NewApp);
            this.Controls.Add(this.button_ExitNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewAppointment";
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewAppointment_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NewApp;
        private System.Windows.Forms.Button button_ExitNA;
        private System.Windows.Forms.ComboBox comboBox_Service;
        private System.Windows.Forms.Panel panel_Service;
        private System.Windows.Forms.Panel panel_Time;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dateStart;
        private System.Windows.Forms.Panel panel_dateStart;
        private System.Windows.Forms.Panel panel_Reason;
        private System.Windows.Forms.TextBox textBox_Reason;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Time;
        private System.Windows.Forms.Label label_Service;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Reason;
        private System.Windows.Forms.Label label_Time;
    }
}