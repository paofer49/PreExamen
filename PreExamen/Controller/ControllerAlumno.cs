using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PreExamen.Model.DataSet1TableAdapters;

namespace PreExamen.Controller
{
    class ControllerAlumno : IAlumno
    {
        List<Alumno> listaalumno = new List<Alumno>();
        Alumno a = new Alumno();
        public bool ActualizarAlumno(int idalumno, string nombre, string apellido, string fechanac, string correo)
        {
            try
            {
                using (alumnosTableAdapter alumnos = new alumnosTableAdapter())
                {
                    alumnos.UpdateAlumno(nombre, apellido, fechanac, correo, idalumno);
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarAlumno(int idalumno)
        {
            try
            {
                using (alumnosTableAdapter alumnos = new alumnosTableAdapter())
                {
                    alumnos.DeleteAlumno(idalumno);
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool InsertarAlumnos(string nombre, string apellido, string fechanac, string correo)
        {
            try
            {
                using (alumnosTableAdapter alumnos = new alumnosTableAdapter())
                {
                    alumnos.InsertAlumno(nombre, apellido, fechanac, correo);
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Alumno> MostrarAlumnos()
        {
            try
            {
                using (alumnosTableAdapter alumnos = new alumnosTableAdapter())
                {
                    var datos = alumnos.GetData();
                    foreach (DataRow row in datos)
                    {
                        a.idAlumno = Convert.ToInt32(row["AlumnoID"]);
                        a.NombreAlumno = Convert.ToString(row["Nombre"]);
                        a.ApellidoAlumno = Convert.ToString(row["Apellido"]);
                        a.FechaNacimiento = Convert.ToString(row["FechaNacimiento"]);
                        a.Correo = Convert.ToString(row["Correo"]);
                        listaalumno.Add(new Alumno(a.idAlumno, a.NombreAlumno, a.ApellidoAlumno, a.FechaNacimiento, a.Correo));
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaalumno;
        }
    }
}
