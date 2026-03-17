using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB
{
    class PGUsersLoader
    {
        public List<User> Load()
        {
            List<User> allUsers = new List<User>();
            var cs = "Host=192.168.1.48;Username=st50-5;Password=505;Database=ProbTestt";
            var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT login,password,name,lastname,age FROM myusers";

            var cmd = new NpgsqlCommand(sql, con);


            var reader = cmd.ExecuteReader();

            List<string> alllogin = new List<string>();

            while (reader.Read())
            {
                allUsers.Add(new User { Login = reader.GetString(0),
                    Password = reader.GetString(1),
                    Name = reader.GetString(2), 
                    LastName = reader.GetString(3),
                    Age = reader.GetInt32(4) });

            }
            con.Close();
            return allUsers;
        }
    }
}
