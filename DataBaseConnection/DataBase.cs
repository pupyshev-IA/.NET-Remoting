using System.Data.OleDb;

namespace DataBaseConnection
{
    public class DataBase
    {
        //Указать путь до файла Database.mdb
        OleDbConnection sqlConnection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Visual Studio_projects\Course work\My\git_version\CourseWork\.NET Remoting\Database.mdb; Persist Security Info = False;");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public OleDbConnection getConnection()
        {
            return sqlConnection;
        }
    }
}