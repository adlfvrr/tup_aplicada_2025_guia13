using GeometriaRestAPIWeb.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeometriaRestAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Geometria2Controller : ControllerBase
    {
        static List<FiguraDTO> lista = new List<FiguraDTO> { new FiguraDTO { Id = 1, Tipo = 1, Area = 3 }, new FiguraDTO { Id = 2, Tipo = 2, Area = 3.3 } };

        // GET: api/<Geometria2Controller>
        [HttpGet]
        public ActionResult<List<FiguraDTO>> Get()
        {
            if (lista.Any() == false) return NotFound("No se encontraron figuras");
            return Ok(lista);
        }

        // GET api/<Geometria2Controller>/5
        [HttpGet("{id}")]
        public ActionResult<FiguraDTO> Get(int id)
        {
            var figura = (from f in lista where f.Id == id select f).FirstOrDefault();
            if (lista.Any() == null) return NotFound("Figura no encontrada");
            return Ok(figura);
        }

        // POST api/<Geometria2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Geometria2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Geometria2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
