using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DB_project.Classes;

namespace DB_project
{
    public partial class Registration : Form
    {
        public Model Model;

        public Registration(Model md)
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

        private void Registration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void Registration_Load(object sender, EventArgs e)
        {
            textBox_NewPassword.UseSystemPasswordChar = true;
            textBox_PasswordAgain.UseSystemPasswordChar = true;
            maskedTextBox_CardNum.Select();
        }

        private void button_exitR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearControls();
            maskedTextBox_CardNum.Select();
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked == true)
            {
                textBox_NewPassword.UseSystemPasswordChar = false;
                textBox_PasswordAgain.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_NewPassword.UseSystemPasswordChar = true;
                textBox_PasswordAgain.UseSystemPasswordChar = true;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            saveAll();
        }

        private void clearControls()
        {
            foreach (MaskedTextBox MaskedtextBox in Controls.OfType<MaskedTextBox>())
            {
                MaskedtextBox.Clear();
            }

            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }

            foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.SelectedItem = null;
            }
        }

        private void saveAll()
        {
            string title = "Ошибка";
            MessageBoxButtons ok = MessageBoxButtons.OK;
            MessageBoxIcon inf = MessageBoxIcon.Information;

            if (!Regex.IsMatch(maskedTextBox_CardNum.Text, "[0-9]+$"))
            {
                MessageBox.Show("Введите номер мед. карты повторно", title, ok, inf);
                maskedTextBox_CardNum.Select();
                return;
            }
            if (!Regex.IsMatch(maskedTextBox_PassportID.Text, "[0-9]+$"))
            {
                MessageBox.Show("Введите паспортные данные повторно", title, ok, inf);
                maskedTextBox_PassportID.Select();
                return;
            }
            if (!Regex.IsMatch(textBox_Name.Text, "[А-Я а-я.]+$"))
            {
                MessageBox.Show("Введите ФИО повторно", title, ok, inf);
                textBox_Name.Select();
                return;
            }
            if (string.IsNullOrEmpty(comboBox_Gender.SelectedItem.ToString()))
            {
                MessageBox.Show("Выберите пол", title, ok, inf);
                comboBox_Gender.Select();
                return;
            }
            if (!Regex.IsMatch(maskedTextBox_Phone.Text, "[0-9]+$"))
            {
                MessageBox.Show("Введите номер телефона повторно", title, ok, inf);
                maskedTextBox_Phone.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_NewPassword.Text) || string.IsNullOrEmpty(textBox_PasswordAgain.Text))
            {
                MessageBox.Show("Введите пароль", title, ok, inf);
                textBox_NewPassword.Select();
                return;
            }

            if (textBox_NewPassword.Text == textBox_PasswordAgain.Text)
            {
                /*-----------------------------------------------------------------------------------*/
                DataTable table;
                table = Model.SharedHTTP.Check(maskedTextBox_CardNum.Text);
                /*-----------------------------------------------------------------------------------*/

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Клиент с таким номеров мед. карты уже существует", title, ok, inf);
                    maskedTextBox_CardNum.SelectAll();
                    return;
                }

                DialogResult result;
                result = MessageBox.Show("Хотите сохранить данные?", "Сохранение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    /*-----------------------------------------------------------------------------------*/
                    Model.SharedHTTP.makeRegistration(maskedTextBox_CardNum.Text, maskedTextBox_PassportID.Text, textBox_Name.Text,
                        comboBox_Gender.SelectedItem.ToString(), maskedTextBox_Birth.Text, maskedTextBox_Phone.Text, textBox_Address.Text);

                    Model.SharedHTTP.makeAccount(maskedTextBox_CardNum.Text, textBox_NewPassword.Text);
                    /*-----------------------------------------------------------------------------------*/

                    MessageBox.Show("Данные успешно сохранены", "Сообщение", ok, inf);

                    clearControls();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!", title, ok, inf);
                textBox_NewPassword.Select();
                return;
            }
        }
    }
}