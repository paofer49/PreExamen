using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PreExamen.Controller;

namespace PreExamen
{
    public partial class Form1 : Form
    {
        ControllerAlumno controller = new ControllerAlumno();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (controller.InsertarAlumnos(txtNombre.Text, txtApellido.Text, txtFechaNac.Text,txtCorreo.Text))
            {
                MessageBox.Show("Se ha agregado con exito");
            }
            else
            {
                MessageBox.Show("Hubo un error al agrega el alumno");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (controller.MostrarAlumnos().Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = controller.MostrarAlumnos();
            }
            else
            {
                MessageBox.Show("No existen registros aun");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (controller.ActualizarAlumno(Convert.ToInt32(txtId.Text),txtNombre.Text, txtApellido.Text,txtFechaNac.Text,txtCorreo.Text))
            {
                MessageBox.Show("Se ha actualizado con exito el alumno");
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el alumno");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (controller.EliminarAlumno(Convert.ToInt32(txtId.Text)))
            {
                MessageBox.Show("Se ha elminado con exito el alumno");
            }
            else
            {
                MessageBox.Show("hubo un error al eliminar el alumno");
            }
        }
    }
}
