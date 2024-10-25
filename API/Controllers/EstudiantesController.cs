using API.Models;
using API.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        [HttpGet]
        [Route("listado")]
        public List<Estudiante> DevuelveListadoEstudiantes() {
            EstudiantesRespository repo = new EstudiantesRespository();
            var listado = repo.DevuelveListdoEstudiantes();
            return listado;
            }
    }
}
