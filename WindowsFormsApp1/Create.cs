using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;

namespace WindowsFormsApp1
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        N_Empleados objNegocio = new N_Empleados();
        private void Create_Load(object sender, EventArgs e)
        {

        }

        private int employeeId = 0;

        public void EditEmployee(EmployeeModel employee)
        {
            this.lb_title.Text = "Edit";

            this.tb_name.Text = employee.name;
            this.tb_age.Text = employee.age.ToString();
            this.tb_sex.Text = employee.sex.ToString();
            this.tb_salary.Text = employee.salary.ToString();

            this.employeeId = employee.id;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var name = Convert.ToString(this.tb_name.Text);
            var age = Convert.ToInt32(this.tb_age.Text); 
            var sex = Convert.ToChar(this.tb_sex.Text);
            var salary = Convert.ToDouble(this.tb_salary.Text);

            if (this.employeeId == 0)
            {
                objNegocio.creteEmployee(name, age, sex, salary);
            }
            else
            {
                objNegocio.updateEmployee(this.employeeId, name, age, sex, salary);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
