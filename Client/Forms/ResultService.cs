using System;
using System.Data;
using System.Windows.Forms;
using DB_project.Classes;

namespace DB_project.Forms
{
    public partial class ResultService : Form
    {
        public Model Model;

        public ResultService(Model md)
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

        private void ResultService_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void ResultService_Load(object sender, EventArgs e)
        {
            GetAllService();
        }

        private void button_ExitR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            textBox_Search.Clear();
            GetAllService();

            textBox_Search.Select();
        }

        private void GetAllService()
        {
            /*-----------------------------------------------------------------------------------*/
            DataSet ds = new DataSet();
            ds = Model.SharedHTTP.GetAllService();
            /*-----------------------------------------------------------------------------------*/

            dataGridView_Result.DataSource = ds.Tables[0];
            dataGridView_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Search()
        {
            string search = textBox_Search.Text;
            /*-----------------------------------------------------------------------------------*/
            DataSet ds = new DataSet();
            ds = Model.SharedHTTP.searchService(search);
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
    }
}