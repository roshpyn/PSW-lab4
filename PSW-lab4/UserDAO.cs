using System;
using MySql.Data.MySqlClient;
namespace PSW_lab4
{
    class UserDAO
    {
        public UserDAO() { }
        public UserDAO(string id, string name, string surname, string login, string password, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Login = login;
            this.Password = password;
            this.Email = email;
        }
        public UserDAO(string name, string surname, string login, string password, string email)
        { 
            this.Name = name;
            this.Surname = surname;
            this.Login = login;
            this.Password = password;
            this.Email = email;
        }

        private string id;
        private string name;
        private string surname;
        private string login;
        private string password;
        private string email;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }



        private static string server = "localhost";
        private static string database = "psw_lab4";
        private static string user = "admin";
        private static string passwd = "admin";

        
        private string connectionString = String.Format("server={0}; userid={1}; password={2}; database={3}", server, user, passwd, database);

        public void AddToDataBase()
        {
            string cmdText = String.Format(
            @"INSERT INTO psw_lab4.users 
            (name,surname,login,password, email, permissions) 
            VALUES 
            ('{0}','{1}','{2}','{3}','{4}','USER');",
            Name, Surname, Login,Password, Email);
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(cmdText, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Clone();
            }
        }
    }
}
