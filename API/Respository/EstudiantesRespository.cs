using API.Models;

namespace API.Respository
{
    public class EstudiantesRespository
    {
        public List<Estudiante> DevuelveListdoEstudiantes()
        {
            List<Estudiante> listado = new List<Estudiante>();
            Estudiante estudiante1 = new Estudiante
            {

                Id = 1,
                Nombre = "Santiago",
                Edad = 20,
                TieneBeca = true
            };
            Estudiante estudiante2 = new Estudiante
            {
                Id = 2,
                Nombre = "Paula",
                Edad = 19,
                TieneBeca = false


            };

            listado.Add(estudiante1);
            listado.Add(estudiante2);
            return listado;
        }
    }
}
