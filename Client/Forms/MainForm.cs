using System;
using System.Drawing;
using System.Windows.Forms;
using DB_project.Forms;
using DB_project.Classes;
using System.Data;

namespace DB_project
{
    public partial class MainForm : Form
    {
        public Model Model;
        private string before = string.Empty;

        public MainForm(Model md)
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

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void MainForm_Load(object sender, EventArgs e)
        {
            before = label_Greetings.Text;
            Greetings();
        }

        private void button_ExitM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_profile_MouseClick(object sender, MouseEventArgs e)
        {
            ProfileForm profile = new ProfileForm(Model);
            profile.StartPosition = FormStartPosition.Manual;
            profile.Location = new Point(this.Location.X, this.Location.Y);
            profile.ShowDialog();
        }

        private void pictureBox_Exit_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы уверены что хотите выйти?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Hide();

                Authorization formAuth = new Authorization(Model);
                formAuth.ShowDialog();
                Show();
            }
        }

        private void button_AllService_Click(object sender, EventArgs e)
        {
            ResultService resServ = new ResultService(Model);
            resServ.ShowDialog();
        }

        private void button_MyAppointment_Click(object sender, EventArgs e)
        {
            ResultAppointment resApp = new ResultAppointment(Model);
            resApp.ShowDialog();
        }

        private void button_DoctorSchedule_Click(object sender, EventArgs e)
        {
            ResultSchedule resSched = new ResultSchedule(Model);
            resSched.ShowDialog();
        }

        private void button_Correct_Click(object sender, EventArgs e)
        {
            CorrectProfile corProf = new CorrectProfile(Model);
            corProf.ShowDialog();

            Greetings();
        }

        private void Greetings()
        {
            /*-----------------------------------------------------------------------------------*/
            DataSet ds;
            ds = Model.SharedTCP.Greetings();
            /*-----------------------------------------------------------------------------------*/

            label_Greetings.Text = before;
            label_Greetings.Text += ds.Tables[0].Rows[0][0].ToString();
        }
    }
}