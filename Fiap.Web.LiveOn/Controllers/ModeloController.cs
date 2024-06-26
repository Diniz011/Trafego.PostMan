using Fiap.Web.LiveOn.Data.Contexts;
using Fiap.Web.LiveOn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Web.LiveOn.Controllers
{
    public class ModeloController : Controller
    {

        private List<Congestionamento> congestionamento;


        private readonly DatabaseContext _databaseContext;


        public ModeloController(DatabaseContext databaseContext) {

            _databaseContext = databaseContext; // new DatabaseContext();

            congestionamento = databaseContext.Congestionamento.ToList();

        }


        public IActionResult Index()
        {

            // SELECT * FROM TB_CONGESTIONAMENTOS
            //var listaModelos = repository.GetAll();
            var listaModelos = _databaseContext.Congestionamento.ToList();

            return View(listaModelos);
        }


        [HttpGet]
        public IActionResult GetDetailsByName([FromQuery] String nome)
        {

            var paramNome = nome;

            // SELECT * FROM TB_CONGESTIONAMENTOS
            //var listaModelos = repository.GetAll();
            var listaModelos = _databaseContext.Congestionamento.ToList();

            return View(listaModelos);
        }



        [HttpGet]
        public IActionResult Create()
        {
            var selectListCongestionamento =
                new SelectList(congestionamento,
                                nameof(Congestionamento.CongestionamentoId),
                                nameof(Congestionamento.Nome));

            ViewBag.Congestionamento = selectListCongestionamento;

            return View();
        }


        [HttpPost]
        public IActionResult Create(congestionamento congestionamento)
        {
            // INSERT INTO TB_CONGESTIONAMENTOS

            _databaseContext.congestionamento.Add(congestionamento);
            _databaseContext.SaveChanges();

            var mensagem = "Congestionamento inserido com sucesso";
            return RedirectToAction("Index");   
        }



    }

    internal class Congestionamento
    {
        internal static object CongestionamentoId()
        {
            throw new NotImplementedException();
        }

        internal static object Nome()
        {
            throw new NotImplementedException();
        }
    }
}
