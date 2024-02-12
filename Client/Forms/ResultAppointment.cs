using System;
using System.Data;
using System.Windows.Forms;
using DB_project.Classes;

namespace DB_project.Forms
{
    public partial class ResultAppointment : Form
    {
        public Model Model;

        public ResultAppointment(Model md)
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

        private void ResultAppointment_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void ResultAppointment_Load(object sender, EventArgs e)
        {
            GetAllAppointment();
        }

        private void button_ExitRA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            NewAppointment newAppoint = new NewAppointment(Model);
            newAppoint.ShowDialog();

            GetAllAppointment();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            deleteAppointment();
        }

        private void GetAllAppointment()
        {
            /*-----------------------------------------------------------------------------------*/
            DataSet ds;
            ds = Model.SharedTCP.GetAllAppointment();
            /*-----------------------------------------------------------------------------------*/

            dataGridView_Result.DataSource = ds.Tables[0];
            dataGridView_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void deleteAppointment()
        {
            if (dataGridView_Result.SelectedRows.Count > 0)
            {
                int ID_Record = Convert.ToInt32(dataGridView_Result.SelectedRows[0].Cells[0].Value.ToString());

                DialogResult result;
                result = MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    /*-----------------------------------------------------------------------------------*/
                    Model.SharedTCP.deleteAppointment(ID_Record);
                    /*-----------------------------------------------------------------------------------*/

                    MessageBox.Show("Запись была успешно удалена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllAppointment();
                }
            }
            else
                MessageBox.Show("Выберите запись, которую хотите удалить.\nДля этого необходимо выделить всю строку.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}