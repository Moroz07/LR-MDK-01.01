using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public class PgUsersLoader
    {
         private const string connectSetting = "Host=192.168.1.48;Username=st56-11;Password=5611;Database=ProbTestt";
        private BindingList<User> allUsers_ = new BindingList<User>();
        public BindingList<User> Load() 
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password, age, name From myusers";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Age = reader.GetInt32(2),
                        Name = reader.GetString(3),
                    };
                    allUsers_.Add(user);
                }
                return allUsers_;
            }
            catch(NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        } 
        
        public bool DeleteSelectedUser(string Login)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM myusers Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", Login);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                }
                for (int i = 0; i < allUsers_.Count; i++)
                {
                    if (allUsers_[i].Login == Login)
                    {
                        allUsers_.RemoveAt(i);
                        i--;
                    }
                }
                return result;
            }
            catch(NpgsqlException exception) 
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool ClearUser()
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                var sql = "DELETE FROM myusers";
                con.Open();
                var cmd = new NpgsqlCommand(sql, con);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                }
                allUsers_.Clear();
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }

        }
        public bool AddUser(User user)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO myusers(login, password, name, age) VALUES(@login, @password, @name, @age)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@age", user.Age);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    allUsers_.Add(user);
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool EditUser(User user)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "UPDATE myusers SET password = @password, name = @name, age = @age WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@age", user.Age);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                   for (int i = 0; i < allUsers_.Count; i++)
                    {
                        if (allUsers_[i].Login == user.Login)
                        {
                            allUsers_[i] = user;
                        }
                    }
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
    }
}
