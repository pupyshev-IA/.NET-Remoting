using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DB_project.Classes;

namespace DB_project.Forms
{
    public partial class NewAppointment : Form
    {
        public Model Model;

        public NewAppointment(Model md)
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

        private void NewAppointment_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            comboBox_Service.Select();
        }

        private void button_ExitNA_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearControls();
            comboBox_Service.Select();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            saveNewAppointment();
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

        private void saveNewAppointment()
        {
            string title = "Ошибка";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            if (string.IsNullOrEmpty(comboBox_Service.SelectedItem.ToString()))
            {
                MessageBox.Show("Выберите услугу", title, button, icon);
                comboBox_Service.Select();
                return;
            }

            if (!Regex.IsMatch(maskedTextBox_dateStart.Text, "[0-9]+$"))
            {
                MessageBox.Show("Выберите дату приёма", title, button, icon);
                maskedTextBox_dateStart.Select();
                return;
            }

            if (!Regex.IsMatch(maskedTextBox_Time.Text, "[0-9]+$"))
            {
                MessageBox.Show("Выберите время приёма", title, button, icon);
                maskedTextBox_Time.Select();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Вы уверены что хотите создать новую запись?", "Новая запись", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                /*-----------------------------------------------------------------------------------*/
                int ID_Service = Model.SharedTCP.getIDService(comboBox_Service.SelectedItem.ToString());
                int PersonnelNumber = Model.SharedTCP.getPersonnelNumber(ID_Service);

                Model.SharedTCP.saveNewAppointment(ID_Service, PersonnelNumber, maskedTextBox_dateStart.Text, textBox_Reason.Text, maskedTextBox_Time.Text);
                /*-----------------------------------------------------------------------------------*/

                MessageBox.Show("Запись была успешно сохранена", "Уведомление", button, icon);

                clearControls();

                Close();
            }
        }
    }
}