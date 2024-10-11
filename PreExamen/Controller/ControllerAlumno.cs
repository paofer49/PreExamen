using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                var actualoizarobj = listaalumno.FirstOrDefault(x => x.idAlumno == idalumno);
                if (actualoizarobj != null)
                {
                    actualoizarobj.NombreAlumno = nombre;
                    actualoizarobj.ApellidoAlumno = apellido;
                    actualoizarobj.FechaNacimiento = fechanac;
                    actualoizarobj.Correo = correo;
                }
                return true;
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
                var eliminarobj = listaalumno.FirstOrDefault(x => x.idAlumno == idalumno);
                if (eliminarobj != null)
                {
                    listaalumno.Remove(eliminarobj);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool InsertarAlumnos(int id,string nombre, string apellido, string fechanac, string correo)
        {
            try
            {
                a.NombreAlumno = nombre;
                a.ApellidoAlumno = apellido;
                a.FechaNacimiento = fechanac;
                a.Correo = correo;
                a.idAlumno = id;
                listaalumno.Add(new Alumno(a.idAlumno,a.NombreAlumno, a.ApellidoAlumno, a.FechaNacimiento, a.Correo));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Alumno> MostrarAlumnos()
        {
            throw new NotImplementedException();
        }
    }
}
