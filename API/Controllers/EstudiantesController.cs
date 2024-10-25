using API.Models;
using API.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
        [HttpGet]
        [Route("InfromacionEudiante/{id}")]
        public Action DevuelveInformacionEstudiante(int id)
        {
            try
            {
                EstudiantesRespository repo = new EstudiantesRespository();
                var listado = repo.DevuelveListdoEstudiantes();
                    if (listado.Any(x => x.Id == id))
                    {
                    var estudiante = listado.Find(x => x.Id == id);
                    return Ok(estudiante);

                    }
                    else
                    {
                    return NotFound();
                    }
    
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
        [HttpPost]
        public ActionResult GuardaEstudiante([FromBody]Estudiante estudiante)
        {
            return Ok();

        }



        }
    }
    
