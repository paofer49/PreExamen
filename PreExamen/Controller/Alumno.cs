using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamen.Controller
{
    class Alumno
    {
        public Alumno() {}
        public Alumno(int idAlumno, string nombreAlumno, string apellidoAlumno, string fechaNacimiento, string correo)
        {
            this.idAlumno = idAlumno;
            NombreAlumno = nombreAlumno;
            ApellidoAlumno = apellidoAlumno;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
        }

        public int idAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public string FechaNacimiento { get; set; }
        public string Correo { get; set; }
    }
}
