using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>(); 


        public ControlAlumnos()
        {
            carreras.Add(new Carrera {IdCarrera = 1, Nombre = "Ingenieria de Software"});
            carreras.Add(new Carrera { IdCarrera = 2, Nombre = "Redes y servicios de Computo" });

            alumnos.Add(new Alumno { IdAlumno = 1, Nombre = "Juan Perez Sanchez", Matricula = "S20015696", Promedio = 8.9, IdCarrera = 1 });
            alumnos.Add(new Alumno { IdAlumno = 2, Nombre = "Jose Trelles Jimenez", Matricula = "S20014839", Promedio = 6.5, IdCarrera = 2 });
            alumnos.Add(new Alumno { IdAlumno = 3, Nombre = "Maria Rodriguez Martinez", Matricula = "S20014493", Promedio = 9.2, IdCarrera = 2 });

            /*
            Alumno alumno1 = new Alumno { IdCarrera = 3, Nombre = "Juan" };
            */

        }
        public void obtenerAlumnosPorCarreras(int IdCarrera)
        {
            IEnumerable<Alumno> resultado = from alumno in alumnos where alumno.IdCarrera == IdCarrera select alumno;

            foreach (Alumno alumno in resultado)
            {
                alumno.getDatosAlumno();
            }
        }

        public void obtenerAlumnosConCarrera(int idCarrera)
        {
            var resultado = from alumno in alumnos join carrera in carreras on alumno.IdCarrera equals carrera.IdCarrera where alumno.IdCarrera == idCarrera select new { Alumno = alumno, NombreCarrera = carrera.Nombre };

            foreach (var resultadoAlumno in resultado)
            {
                resultadoAlumno.Alumno.getDatosAlumno();
                Console.WriteLine("Carrera - {0}", resultadoAlumno.NombreCarrera);
            }
        }
    }
}
