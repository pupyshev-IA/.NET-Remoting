using System;
using System.Data;
using DataBaseConnection;
using System.Runtime.Remoting.Lifetime;
using System.Data.OleDb;

namespace RemoteSharedTCP
{
    public class SharedTCP : MarshalByRefObject, ISharedTCP
    {
        public static string idClient;
        DataBase dataBase = new DataBase();

        public SharedTCP() 
        {
            Console.WriteLine("\n-----SharedTCP was created-----");
        }
        ~SharedTCP()
        {
            Console.WriteLine("\n-----SharedTCP was destroyed-----");
        }


        public override Object InitializeLifetimeService()
        {
            ILease lease = (ILease)base.InitializeLifetimeService();

            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(40);
                lease.SponsorshipTimeout = TimeSpan.FromSeconds(110);
                lease.RenewOnCallTime = TimeSpan.FromSeconds(30);
            }

            return lease;
        }


        public DataTable tryAuthorization(string loginUser, string passwordUser)
        {
            var querySelectClient = $"SELECT * FROM Аккаунт WHERE login = {loginUser} AND password = '{passwordUser}'";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable table = new DataTable();

            OleDbCommand command = new OleDbCommand(querySelectClient, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            idClient = table.Rows[0][1].ToString();
            dataBase.closeConnection();

            return table;
        }

        public DataSet getProfile()
        {
            string getAllSQL = $"SELECT * FROM [Пациент] WHERE [Medical Card No] = {idClient}";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getAllSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }

        public DataSet Greetings()
        {
            string getNameSQL = $"SELECT [Patient Name] FROM Пациент WHERE [Medical Card No] = {idClient}";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getNameSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }

        public DataSet GetAllAppointment()
        {
            string getAllAppointmentSQL = string.Empty;

            getAllAppointmentSQL +=
                $"SELECT Запись.ID_Record, Услуга.[Service Name], Персонал.[Doctor Name], " +
                $"Запись.Date_start, Запись.[Reason for Appeal] FROM Услуга, Персонал, Запись " +
                $"WHERE (Запись.[Medical Card No] = {idClient}) and (Запись.ID_Service = Услуга.ID) and " +
                $"(Персонал.[Personnel Number] = Запись.[Personnel Number])";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getAllAppointmentSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }

        public void deleteAppointment(int ID_Record)
        {
            string deleteAppointmenSQL = $"DELETE FROM Запись WHERE ID_Record = {ID_Record}";
            dataBase.openConnection();
            OleDbCommand commandDelete = new OleDbCommand(deleteAppointmenSQL, dataBase.getConnection());
            commandDelete.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public int getIDService(string service)
        {
            int ID_Service;
            string IdSQL = $"SELECT ID FROM Услуга WHERE Услуга.[Service Name] = '{service}'";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(IdSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            ID_Service = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            dataBase.closeConnection();

            return ID_Service;
        }

        public int getPersonnelNumber(int ID_Service)
        {
            int PersonnelNumber;
            string PersonnelNumberSQL = $"SELECT [Personnel Number] FROM Услуга WHERE Услуга.ID = {ID_Service}";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(PersonnelNumberSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            PersonnelNumber = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            dataBase.closeConnection();

            return PersonnelNumber;
        }

        public void saveNewAppointment(int ID_Service, int PersonnelNumber, string maskedTextBox_dateStart, string textBox_Reason, string maskedTextBox_Time)
        {
            string appointmaentSQL = string.Empty;
            appointmaentSQL += $"INSERT INTO Запись (ID_Service, [Medical Card No], [Personnel Number], Date_start, " +
                               $"[Reason for Appeal], [Start])";
            appointmaentSQL += $"VALUES ('{ID_Service}', {idClient}, '{PersonnelNumber}', " +
                               $"'{maskedTextBox_dateStart}', '{textBox_Reason}', '{maskedTextBox_Time}')";

            dataBase.openConnection();
            OleDbCommand commandAppointment = new OleDbCommand(appointmaentSQL, dataBase.getConnection());
            commandAppointment.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public void updateProfile(string maskedTextBox_CardNum, string maskedTextBox_PassportID, string textBox_Name, string comboBox_Gender, string maskedTextBox_Birth, string maskedTextBox_Phone, string textBox_Address)
        {
            string patientSQL = string.Empty;
            patientSQL += $"UPDATE Пациент SET [Medical Card No] = '{maskedTextBox_CardNum}', " +
                          $"[Passport ID] = '{maskedTextBox_PassportID}', [Patient Name] = '{textBox_Name}', Gender = '{comboBox_Gender}', " +
                          $"[Date of Birth] = '{maskedTextBox_Birth}', [Phone number] = '{maskedTextBox_Phone}', " +
                          $"[Residence Address] = '{textBox_Address}' WHERE [Medical Card No] = {idClient}";

            dataBase.openConnection();
            OleDbCommand commandNewPatient = new OleDbCommand(patientSQL, dataBase.getConnection());
            commandNewPatient.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public DataSet getCurrentProfile()
        {
            string getAllSQL = $"SELECT * FROM [Пациент] WHERE [Medical Card No] = {idClient}";

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter(getAllSQL, dataBase.getConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataBase.closeConnection();

            return ds;
        }
    }
}