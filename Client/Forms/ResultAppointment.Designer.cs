namespace DB_project.Forms
{
    partial class ResultAppointment
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
            this.button_ExitRA = new System.Windows.Forms.Button();
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ExitRA
            // 
            this.button_ExitRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_ExitRA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ExitRA.FlatAppearance.BorderSize = 0;
            this.button_ExitRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExitRA.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.button_ExitRA.ForeColor = System.Drawing.Color.White;
            this.button_ExitRA.Location = new System.Drawing.Point(873, 434);
            this.button_ExitRA.Name = "button_ExitRA";
            this.button_ExitRA.Size = new System.Drawing.Size(115, 50);
            this.button_ExitRA.TabIndex = 4;
            this.button_ExitRA.Text = "Выйти";
            this.button_ExitRA.UseVisualStyleBackColor = false;
            this.button_ExitRA.Click += new System.EventHandler(this.button_ExitRA_Click);
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.AllowUserToAddRows = false;
            this.dataGridView_Result.AllowUserToDeleteRows = false;
            this.dataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Result.MultiSelect = false;
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.ReadOnly = true;
            this.dataGridView_Result.RowHeadersWidth = 51;
            this.dataGridView_Result.RowTemplate.Height = 24;
            this.dataGridView_Result.Size = new System.Drawing.Size(1000, 425);
            this.dataGridView_Result.TabIndex = 5;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(150, 434);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(130, 50);
            this.button_Delete.TabIndex = 13;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(12, 434);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(130, 50);
            this.button_Add.TabIndex = 13;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // ResultAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.dataGridView_Result);
            this.Controls.Add(this.button_ExitRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResultAppointment";
            this.Load += new System.EventHandler(this.ResultAppointment_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultAppointment_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ExitRA;
        private System.Windows.Forms.DataGridView dataGridView_Result;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
    }
}