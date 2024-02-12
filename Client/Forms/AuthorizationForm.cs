using System;
using System.Data;
using System.Windows.Forms;
using DB_project.Classes;

namespace DB_project
{
    public partial class Authorization : Form
    {
        public Model Model;

        public Authorization(Model md)
        {
            Model= md;
            InitializeComponent();
        }

        /*_________________________________________________________________________________________*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        
        public static extern bool ReleaseCapture();

        private void Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    /*_________________________________________________________________________________________*/

        private void Authorization_Load(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
            maskedTextBox_Login.Select();
        }

        private void button_exitA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked == true)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel_registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration formReg = new Registration(Model);
            formReg.ShowDialog();
        }

        private void button_entry_Click(object sender, EventArgs e)
        {
            tryAuthorization();
        }

        private void tryAuthorization()
        {
            if (!string.IsNullOrEmpty(maskedTextBox_Login.Text) && !string.IsNullOrEmpty(textBox_Password.Text))
            {
                /*-----------------------------------------------------------------------------------*/
                DataTable table;
                table = Model.SharedTCP.tryAuthorization(maskedTextBox_Login.Text, textBox_Password.Text);
                /*-----------------------------------------------------------------------------------*/

                if (table.Rows.Count > 0)
                {
                    maskedTextBox_Login.Clear();
                    textBox_Password.Clear();
                    checkBox_ShowPassword.Checked = false;
                    maskedTextBox_Login.Select();
                    Hide();

                    MainForm formMain = new MainForm(Model);
                    formMain.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    maskedTextBox_Login.Focus();
                    maskedTextBox_Login.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox_Login.Select();
            }
        }
    }
}