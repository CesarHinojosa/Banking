using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;

namespace CH.Banking.PL
{
    public static class DataAccess
    {

        private static SqlConnection? connection = null;

        public static string XMLFilePath { get; set; } = "";
      
        //need this for SQL
        public static string ConnectionString { get; set; } = "";

        //need this for SQL
        //methods
        //works for customers and not vehicles yet 
        private static void Connect()
        {
            if (ConnectionString == null || ConnectionString == "")
            {
                throw new Exception("Connection string was not set");
            }
            if (connection == null)
            {
                connection = new SqlConnection(ConnectionString);
            }
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        //need this for SQL
        public static void CloseConnection()
        {
            connection?.Close();
        }
        //need this for SQL
        public static DataTable SelectFromDB(string sql, List<SqlParameter>? parameters = null, bool closeConnection = true)
        {
            Connect();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                if (parameters != null && parameters.Count > 0)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (closeConnection)
                    {
                        CloseConnection();
                    }
                    return table;
                }
            }
        }

        public static int ExecuteSql(string sql, List<SqlParameter>? parameters = null, bool closeConnection = true)
        {
            Connect();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                if (parameters != null && parameters.Count > 0)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                int result = Convert.ToInt32(command.ExecuteScalar());
                if (closeConnection)
                {
                    CloseConnection();
                }

                return result;
            }
        }



















        //writes the data to the XML File
        public static void SaveXML (Type type, object obj)
        {
            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
            }
        }
        //reads the data on the XML file
        public static object LoadXML(Type type)
        {
            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                return serializer.Deserialize(reader);
            }
        }
    }
}