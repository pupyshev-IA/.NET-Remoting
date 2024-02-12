using System;
using System.Data;
using DataBaseConnection;
using System.Data.OleDb;

namespace RemoteSharedHTTP
{
    public class SharedHTTP : MarshalByRefObject, ISharedHTTP
    {
        DataBase dataBase = new DataBase();

        public SharedHTTP()
        {
            Console.WriteLine("\n-----SharedHTTP was created-----");
        }
        ~SharedHTTP() 
        {
            Console.WriteLine("\n-----SharedHTTP was destroyed-----");
        }

        public DataTable Check(string maskedTextBox_CardNum)
        {
            string check = $"SELECT [Medical Card No] FROM Пациент WHERE [Medical Card No] = {maskedTextBox_CardNum}";

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable table = new DataTable();

            OleDbCommand command = new OleDbCommand(check, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public void makeRegistration(string maskedTextBox_CardNum, string maskedTextBox_PassportID, string textBox_Name, string comboBox_Gender, string maskedTextBox_Birth, string maskedTextBox_Phone, string textBox_Address)
        {
            string patientSQL = string.Empty;
            patientSQL += "INSERT INTO Пациент ([Medical Card No], [Passport ID], [Patient Name], Gender, [Date of Birth], [Phone number], [Residence Address]) ";
            patientSQL += $"VALUES ({maskedTextBox_CardNum}, '{maskedTextBox_PassportID}', '{textBox_Name}', '{comboBox_Gender}', '{maskedTextBox_Birth}', '{maskedTextBox_Phone}', '{textBox_Address}')";

            dataBase.openConnection();
            OleDbCommand commandNewPatient = new OleDbCommand(patientSQL, dataBase.getConnection());
            commandNewPatient.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public void makeAccount(string maskedTextBox_CardNum, string textBox_NewPassword)
        {
            string accountSQL = string.Empty;
            accountSQL += $"INSERT INTO Аккаунт ([login], [password]) VALUES ({maskedTextBox_CardNum}, '{textBox_NewPassword}')";

            dataBase.openConnection();
            OleDbCommand commandAccount = new OleDbCommand(accountSQL, dataBase.getConnection());
            commandAccount.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public DataSet GetAllService()
        {
            string getAllServiceSQL = $"SELECT [Service Name], Price, Deadline, Note FROM Услуга";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getAllServiceSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }

        public DataSet searchService(string textBox_Search)
        {
            string getCertainServiceSQL = string.Empty;
            string search = textBox_Search;

            getCertainServiceSQL += "SELECT [Service Name], Price, Note, Deadline FROM Услуга ";
            getCertainServiceSQL += $"WHERE [Service Name] Like '%{search}%'";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getCertainServiceSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }

        public DataSet GetAllDoctors()
        {
            string getAllServiceSQL = $"SELECT * FROM Персонал";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getAllServiceSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }

        public DataSet GetCertainDoctor(string search)
        {
            string getCertainDoctorSQL = string.Empty;

            getCertainDoctorSQL += "SELECT * FROM Персонал ";
            getCertainDoctorSQL += $"WHERE [Doctor Name] Like '%{search}%'";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getCertainDoctorSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }

        public DataSet GetSchedule(int PersonnelNumber)
        {
            string getScheduleSQL = string.Empty;

            getScheduleSQL += $"SELECT [Doctor Name], Speciality, Cabinet, [Specialist Category], [Day], [End Time] " +
                           $"FROM Персонал INNER JOIN Приём ON Персонал.[Personnel Number] = Приём.[Personnel Number] " +
                           $"WHERE Приём.[Personnel Number] = {PersonnelNumber}";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getScheduleSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }
    }
}