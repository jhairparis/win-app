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
    public partial class P_Empleados : Form
    {
        public P_Empleados()
        {
            InitializeComponent();
        }

        N_Empleados objNegocio = new N_Empleados();

        private void P_Empleados_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        void loadTable()
        {
            DataTable dataTable = objNegocio.EmployeesTable();
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create CreateForm = new Create();
            if (CreateForm.ShowDialog() == DialogResult.OK)
            {
                loadTable();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            if (val == null || val.Length == 0) return;

            int employeeId = int.Parse(val);

            var employee = objNegocio.seletOne(employeeId);

            if (employee == null) return;

            Create createForm = new Create();
            createForm.EditEmployee(employee);
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                loadTable();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int employeeId = int.Parse(val);

            DialogResult confirm = MessageBox.Show("Are you sure want to delete this employee?", "Delete employee", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                return;
            }


            objNegocio.deleteEmployee(employeeId);

            loadTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // exit button clicked
            this.Close();
        }
    }
}
