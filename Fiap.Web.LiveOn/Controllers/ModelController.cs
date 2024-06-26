using Fiap.Web.LiveOn.Data.Contexts;
using Fiap.Web.LiveOn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.LiveOn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {

        private readonly DatabaseContext _databaseContext;

        public ModelController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;    

        }


        [HttpGet]
        public ActionResult<List<NomedaAvenida>> Get()
        {
            var lista = _databaseContext.NomedaAvenida.ToList();
            return Ok(lista);
        }


        [HttpGet("{id}")]
        public ActionResult<NomedaAvenida> Get([FromRoute] int id)
        {

            var m = _databaseContext.NomedaAvenida.Find(id);

            if ( m  == null )
            {
                return NotFound();
            }

            return Ok(m);
        }

        [HttpPost]
        public ActionResult Post([FromBody] NomedaAvenida nomedaAvenida)
        {
            _databaseContext.NomedaAvenida.Add(nomedaAvenida);
            _databaseContext.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = nomedaAvenida.AvenidaId }, nomedaAvenida);
        }



        [HttpPut("{id}")]
        public ActionResult Put([FromRoute] int id, [FromBody] NomedaAvenida nomedaAvenida)
        {
            // Primeiro, encontre a entidade atual no banco de dados
            var existingAvenida = _databaseContext.NomedaAvenida.Find(id);
            if (existingAvenida == null)
            {
                // Se não encontrar uma entidade correspondente, retorna NotFound
                return NotFound();
            }

            // Atualize os campos necessários da entidade encontrada com os valores da entidade recebida
            _databaseContext.Entry(existingAvenida).CurrentValues.SetValues(nomedaAvenida);

            // Salva as mudanças no banco de dados
            _databaseContext.SaveChanges();

            // Retorna uma resposta de sucesso, sem conteúdo
            return NoContent();
        }


    }

    public class NomedaAvenida
    {
        public object AvenidaId { get; internal set; }
    }
}
