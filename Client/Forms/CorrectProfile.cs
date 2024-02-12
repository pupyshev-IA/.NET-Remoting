using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DB_project.Classes;

namespace DB_project.Forms
{
    public partial class CorrectProfile : Form
    {
        public Model Model;

        public CorrectProfile(Model md)
        {
            Model = md;
            InitializeComponent();
        }

        /*_________________________________________________________________________________________*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void CorrectProfile_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void CorrectProfile_Load(object sender, EventArgs e)
        {
            getCurrentProfile();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            updateProfile();
        }

        private void getCurrentProfile()
        {
            /*-----------------------------------------------------------------------------------*/
            DataSet ds;
            ds = Model.SharedTCP.getCurrentProfile();
            /*-----------------------------------------------------------------------------------*/

            maskedTextBox_CardNum.Text = ds.Tables[0].Rows[0][0].ToString();
            maskedTextBox_PassportID.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox_Name.Text = ds.Tables[0].Rows[0][2].ToString();
            if (ds.Tables[0].Rows[0][3].ToString() == "М")
                comboBox_Gender.SelectedIndex = 0;
            else
                comboBox_Gender.SelectedIndex = 1;
            maskedTextBox_Birth.Text = ds.Tables[0].Rows[0][4].ToString();
            maskedTextBox_Phone.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox_Address.Text = ds.Tables[0].Rows[0][6].ToString();

            maskedTextBox_CardNum.Select();
        }

        private void updateProfile()
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

            DialogResult result;
            result = MessageBox.Show("Хотите внести изменения?", "Сохранение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                /*-----------------------------------------------------------------------------------*/
                Model.SharedTCP.updateProfile(maskedTextBox_CardNum.Text, maskedTextBox_PassportID.Text, textBox_Name.Text,
                        comboBox_Gender.SelectedItem.ToString(), maskedTextBox_Birth.Text, maskedTextBox_Phone.Text, textBox_Address.Text);
                /*-----------------------------------------------------------------------------------*/

                MessageBox.Show("Изменения были успешно сохранены", "Сообщение", ok, inf);
                Close();
            }
        }
    }
}