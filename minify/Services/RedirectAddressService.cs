using System;
using MySql.Data.MySqlClient;

namespace minify.Services{
    public class RedirectAddressService{

        private MySqlConnection sqlConnection;

        public RedirectAddressService(MySqlConnection _sqlConnection){
            sqlConnection = _sqlConnection;
        }

        public ~RedirectAddressService(){
            sqlConnection.close();
        }

        public string getRedirectAddress(string minify){
            return "https://www.google.com/";
        }
    }
}