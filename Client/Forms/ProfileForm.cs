using System;
using System.Data;
using System.Windows.Forms;
using DB_project.Classes;

namespace DB_project
{
    public partial class ProfileForm : Form
    {
        public Model Model;

        public ProfileForm(Model md)
        {
            Model = md;
            InitializeComponent();
        }

        private void pictureBox_profile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            getProfile();
        }

        private void getProfile()
        {
            /*-----------------------------------------------------------------------------------*/
            DataSet ds;
            ds = Model.SharedTCP.getProfile();
            /*-----------------------------------------------------------------------------------*/

            CardNumLabel.Text = ds.Tables[0].Rows[0][0].ToString();
            PassportIDLabel.Text = ds.Tables[0].Rows[0][1].ToString();
            NameLabel.Text = ds.Tables[0].Rows[0][2].ToString();
            GenderLabel.Text = ds.Tables[0].Rows[0][3].ToString();
            BirthLabel.Text = ds.Tables[0].Rows[0][4].ToString();
            PhoneLabel.Text = ds.Tables[0].Rows[0][5].ToString();
            AddressLabel.Text = ds.Tables[0].Rows[0][6].ToString();
        }
    }
}