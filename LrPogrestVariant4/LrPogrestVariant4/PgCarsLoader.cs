using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LrPogrestVariant4
{
    public class PgCarsLoader
    {
        private const string connectSetting = "Host=192.168.1.48;Username=st53-4;Password=534;Database=cardealership";
        private BindingList<Car> allCars_ = new BindingList<Car>();
        public BindingList<Car> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT mark, model, year, price From cars";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car cars = new Car
                    {
                       Mark = reader.GetString(0),
                       Model = reader.GetString(1),
                        Year = reader.GetInt32(2),
                       Price = reader.GetInt32(3),
                    };
                    allCars_.Add(cars);
                }
                return allCars_;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }

        public bool DeleteSelectedUser(string Model)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM cars Where model = @model";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@model", Model);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                }
                for (int i = 0; i < allCars_.Count; i++)
                {
                    if (allCars_[i].Model == Model)
                    {
                        allCars_.RemoveAt(i);
                        i--;
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

        public bool ClearUser()
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                var sql = "DELETE FROM cars";
                con.Open();
                var cmd = new NpgsqlCommand(sql, con);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                }
                allCars_.Clear();
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }

        }

        public bool AddCar(Car car)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO cars(mark, model, year, price) VALUES(@mark, @model, @year, @price)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mark", car.Mark);
                cmd.Parameters.AddWithValue("@model", car.Model);
                cmd.Parameters.AddWithValue("@year", car.Year);
                cmd.Parameters.AddWithValue("@price", car.Price);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    allCars_.Add(car);
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool EditCar(Car car)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "UPDATE cars SET mark = @mark, year = @year, price = @price WHERE model = @model";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mark", car.Mark);
                cmd.Parameters.AddWithValue("@model", car.Model);
                cmd.Parameters.AddWithValue("@year", car.Year);
                cmd.Parameters.AddWithValue("@price", car.Price);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < allCars_.Count; i++)
                    {
                        if (allCars_[i].Model == car.Model)
                        {
                            allCars_[i] = car;
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
