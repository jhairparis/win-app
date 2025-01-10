using System.Collections.Generic;
using System.Data;
using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public class N_Empleados
    {
        EmployeeData objDato = new EmployeeData();

        public DataTable EmployeesTable()
        {
            List<EmployeeModel> Employess = objDato.GetEmployees();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Sex");
            dataTable.Columns.Add("Salary");

            foreach (var item in Employess)
            {
                var row = dataTable.NewRow();
                row["Id"] = item.id;
                row["Name"] = item.name;
                row["Age"] = item.age;
                row["Sex"] = item.sex;
                row["Salary"] = item.salary;

                dataTable.Rows.Add(row);
            }

            //return objDato.GetAllEmployees();
            return dataTable;
        }
        public void creteEmployee(string name, int age, char sex, double salary)
        {
            EmployeeModel employee_new = new EmployeeModel();

            employee_new.name = name;
            employee_new.age = age;
            employee_new.sex = sex;
            employee_new.salary = salary;

            objDato.CreateEmployee(employee_new);
        }

        public void updateEmployee(int id, string name, int age, char sex, double salary)
        {
            EmployeeModel employee_new = new EmployeeModel();

            employee_new.id = id;
            employee_new.name = name;
            employee_new.age = age;
            employee_new.sex = sex;
            employee_new.salary = salary;


            objDato.UpdateEmployee(employee_new);
        }

        public EmployeeModel seletOne(int id)
        {
            return objDato.GetEmployee(id);
        }

        public void deleteEmployee(int id)
        {
            objDato.DeteleEmployee(id);
        }
    }
}
