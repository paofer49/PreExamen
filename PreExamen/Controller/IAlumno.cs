using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamen.Controller
{
    interface IAlumno
    {
        List<Alumno> MostrarAlumnos();
        bool InsertarAlumnos(string nombre, string apellido, string fechanac, string correo);
        bool ActualizarAlumno(int idalumno, string nombre, string apellido, string fechanac, string correo);
        bool EliminarAlumno(int idalumno);
    }
}
