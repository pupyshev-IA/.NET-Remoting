using System.Data;

namespace RemoteSharedHTTP
{
    public interface ISharedHTTP
    {
        /*---RegistrationForm---*/
        DataTable Check(string maskedTextBox_CardNum);
        void makeRegistration(string maskedTextBox_CardNum, string maskedTextBox_PassportID, string textBox_Name,
            string comboBox_Gender, string maskedTextBox_Birth, string maskedTextBox_Phone, string textBox_Address);
        void makeAccount(string maskedTextBox_CardNum, string textBox_NewPassword);


        /*---ResultService---*/
        DataSet GetAllService();
        DataSet searchService(string textBox_Search);


        /*---ResultSchedule---*/
        DataSet GetAllDoctors();
        DataSet GetCertainDoctor(string textBox_Search);
        DataSet GetSchedule(int PersonnelNumber);
    }
}