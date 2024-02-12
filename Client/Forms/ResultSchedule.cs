using System;
using System.Data;
using System.Windows.Forms;
using DB_project.Classes;

namespace DB_project.Forms
{
    public partial class ResultSchedule : Form
    {
        public Model Model;

        public ResultSchedule(Model md)
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

        private void ResultSchedule_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void ResultSchedule_Load(object sender, EventArgs e)
        {
            GetAllDoctors();
            textBox_Search.Select();
        }

        private void button_ExitRS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            GetCertainDoctor();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            GetAllDoctors();

            textBox_Search.Clear();
            textBox_Search.Select();
        }

        private void button_getSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                GetSchedule();
            }
            catch
            {
                MessageBox.Show("Расписание врача уже открыто!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetAllDoctors()
        {
            /*-----------------------------------------------------------------------------------*/
            DataSet ds;
            ds = Model.SharedHTTP.GetAllDoctors();
            /*-----------------------------------------------------------------------------------*/

            dataGridView_Result.DataSource = ds.Tables[0];
            dataGridView_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void GetCertainDoctor()
        {
            /*-----------------------------------------------------------------------------------*/
            DataSet ds;
            ds = Model.SharedHTTP.GetCertainDoctor(textBox_Search.Text);
            /*-----------------------------------------------------------------------------------*/

            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView_Result.DataSource = ds.Tables[0];
                dataGridView_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                MessageBox.Show("По вашему запросу ничего не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_Search.Focus();
                textBox_Search.SelectAll();
            }
        }

        private void GetSchedule()
        {
            if (dataGridView_Result.SelectedRows.Count > 0)
            {
                /*-----------------------------------------------------------------------------------*/
                DataSet ds;
                int PersonnelNumber = Convert.ToInt32(dataGridView_Result.SelectedRows[0].Cells[0].Value.ToString());
                ds = Model.SharedHTTP.GetSchedule(PersonnelNumber);
                /*-----------------------------------------------------------------------------------*/

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView_Result.DataSource = ds.Tables[0];
                    dataGridView_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                else
                {
                    MessageBox.Show("К сожалению, у данного врача нет своего расписания", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox_Search.Focus();
                    textBox_Search.SelectAll();
                }
            }
            else
                MessageBox.Show("Выберите врача, расписание которого вы хотите уточнить.\nДля этого необходимо выделить всю строку.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}