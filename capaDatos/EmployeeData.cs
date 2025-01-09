using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Input;
using capaEntidad;

namespace capaDatos
{
    public class EmployeeData
    {
        string safeConnectionString = ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString;
        public DataTable GetAllEmployees()
        {
            SqlConnection cn = new SqlConnection(safeConnectionString);
            SqlCommand cmd = new SqlCommand("sp_listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public List<EmployeeModel> GetEmployees()
        {
            var employees = new List<EmployeeModel>();

            try
            {
                using (SqlConnection cn = new SqlConnection(safeConnectionString))
                {
                    cn.Open();
                    string sql = "SELECT * FROM empleados";

                    using (SqlCommand command = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()){
                                EmployeeModel employee = new EmployeeModel();
                                employee.id = Convert.ToInt32(reader[0]);
                                employee.name = reader[1].ToString();
                                employee.age = Convert.ToInt32(reader[2]);
                                employee.sex = Convert.ToChar(reader[3]);
                                employee.salary = Convert.ToDouble(reader[4]);

                                employees.Add(employee);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return employees;
        }

        public EmployeeModel GetEmployee(int id)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(safeConnectionString))
                {
                    cn.Open();
                    string sql = "SELECT * FROM empleados WHERE codEmp=@id";

                    using(SqlCommand command = new SqlCommand(sql, cn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                EmployeeModel employee = new EmployeeModel();
                                employee.id = Convert.ToInt32(reader[0]);
                                employee.name = reader[1].ToString();
                                employee.age = Convert.ToInt32(reader[2]);
                                employee.sex = Convert.ToChar(reader[3]);
                                employee.salary = Convert.ToDouble(reader[4]);
                                return employee;

                            }
                        }
                    }

                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            return null;
        }
    
        public void CreateEmployee(EmployeeModel employee)
        {
            try
            {
               using(SqlConnection connection = new SqlConnection(safeConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO empleados(nameEmp, edadEmp, sexoEmp, sueldoEmp) VALUES (@name, @edad, @sexo, @sueldo);";
                    using (SqlCommand command = new SqlCommand(sql,connection)) {
                        command.Parameters.AddWithValue("@name", employee.name);
                        command.Parameters.AddWithValue("@edad", employee.age);
                        command.Parameters.AddWithValue("@sexo", employee.sex);
                        command.Parameters.AddWithValue("@sueldo", employee.salary);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating employ: "+ ex.Message);
            }
        }
        public void UpdateEmployee(EmployeeModel employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(safeConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE empleados " + "SET nameEmp=@name, edadEmp=@edad, sexoEmp=@sexo, sueldoEmp=@sueldo WHERE codEmp=@id;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", employee.name);
                        command.Parameters.AddWithValue("@edad", employee.age);
                        command.Parameters.AddWithValue("@sexo", employee.sex);
                        command.Parameters.AddWithValue("@sueldo", employee.salary);

                        command.Parameters.AddWithValue("@id", employee.id);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch
            {
                Console.WriteLine("Error creating employ");
            }

        }

        public void DeteleEmployee(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(safeConnectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM empleados WHERE codEmp=@id;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch
            {
                Console.WriteLine("Error creating employ");
            }
        }
    }
}
