using System.Data;

namespace RemoteSharedTCP
{
    public interface ISharedTCP
    {
        /*---AuthorizationForm---*/
        DataTable tryAuthorization(string maskedTextBox_Login, string textBox_Password);


        /*---ProfileForm---*/
        DataSet getProfile();


        /*---MainForm---*/
        DataSet Greetings();


        /*---ResultAppointment---*/
        DataSet GetAllAppointment();
        void deleteAppointment(int ID_Record);


        /*---NewAppointment---*/
        int getIDService(string comboBox_Service);
        int getPersonnelNumber(int ID_Service);
        void saveNewAppointment(int ID_Service, int PersonnelNumber, string maskedTextBox_dateStart,
            string textBox_Reason, string maskedTextBox_Time);


        /*---CorrectProfile---*/
        void updateProfile(string maskedTextBox_CardNum, string maskedTextBox_PassportID, string textBox_Name,
            string comboBox_Gender, string maskedTextBox_Birth, string maskedTextBox_Phone, string textBox_Address);
        DataSet getCurrentProfile();
    }
}