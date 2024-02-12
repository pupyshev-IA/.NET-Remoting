namespace DB_project.Forms
{
    partial class ResultService
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
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.button_ExitRS = new System.Windows.Forms.Button();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.AllowUserToAddRows = false;
            this.dataGridView_Result.AllowUserToDeleteRows = false;
            this.dataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.ReadOnly = true;
            this.dataGridView_Result.RowHeadersWidth = 51;
            this.dataGridView_Result.RowTemplate.Height = 24;
            this.dataGridView_Result.Size = new System.Drawing.Size(1547, 600);
            this.dataGridView_Result.TabIndex = 1;
            // 
            // button_ExitRS
            // 
            this.button_ExitRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_ExitRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ExitRS.FlatAppearance.BorderSize = 0;
            this.button_ExitRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExitRS.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.button_ExitRS.ForeColor = System.Drawing.Color.White;
            this.button_ExitRS.Location = new System.Drawing.Point(1435, 620);
            this.button_ExitRS.Name = "button_ExitRS";
            this.button_ExitRS.Size = new System.Drawing.Size(100, 50);
            this.button_ExitRS.TabIndex = 3;
            this.button_ExitRS.Text = "Выйти";
            this.button_ExitRS.UseVisualStyleBackColor = false;
            this.button_ExitRS.Click += new System.EventHandler(this.button_ExitR_Click);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Segoe UI", 18.2F);
            this.label_Search.ForeColor = System.Drawing.Color.White;
            this.label_Search.Location = new System.Drawing.Point(2, 619);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(112, 42);
            this.label_Search.TabIndex = 7;
            this.label_Search.Text = "Поиск:";
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Search.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox_Search.ForeColor = System.Drawing.Color.White;
            this.textBox_Search.Location = new System.Drawing.Point(125, 629);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(400, 32);
            this.textBox_Search.TabIndex = 1;
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel_Search.Location = new System.Drawing.Point(125, 660);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(400, 1);
            this.panel_Search.TabIndex = 11;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(531, 629);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(70, 35);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.button_Back.ForeColor = System.Drawing.Color.White;
            this.button_Back.Location = new System.Drawing.Point(607, 629);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(70, 35);
            this.button_Back.TabIndex = 3;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // ResultService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1547, 690);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.button_ExitRS);
            this.Controls.Add(this.dataGridView_Result);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResultService";
            this.Load += new System.EventHandler(this.ResultService_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultService_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Result;
        private System.Windows.Forms.Button button_ExitRS;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Back;
    }
}