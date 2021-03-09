using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace minify.Services
{
    public class RedirectAddressService
    {
        private const string fetch = "getMapping";
        private const string add = "addMapping";
        private const string miniVar = "@mini";
        private const string fullVar = "@full";
        private const string fullVarOut = "full_url";
        private MySqlConnection sqlConnection;

        public RedirectAddressService(MySqlConnection _sqlConnection)
        {
            sqlConnection = _sqlConnection;
        }

        ~RedirectAddressService()
        {
            sqlConnection.Dispose();
        }

        public string getRedirectAddress(string minify)
        {
            string fullUrl = "https://www.google.com";
            sqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(fetch, sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(miniVar, minify);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                fullUrl = reader[fullVarOut].ToString();
            }
            reader.Close();
            sqlConnection.Close();
            return fullUrl;
        }

        public string addRedirectAddress(string fullUrl)
        {
            string mini = Guid.NewGuid().ToString();
            sqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(add, sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(miniVar, mini);
            cmd.Parameters.AddWithValue(fullVar, fullUrl);
            int affected = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (affected > 0)
            {
                return mini;
            }
            return null;
        }
    }
}