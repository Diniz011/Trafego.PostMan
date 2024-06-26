using Fiap.Web.LiveOn.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.LiveOn.Controllers
{
    public class TrafegoController : Controller
    {

        private readonly ITrafegoRepository _trafegoRepository;

        public TrafegoController(ITrafegoRepository trafegoRepository)
        {
            _trafegoRepository = trafegoRepository;
        }


        public IActionResult Index()
        {
            var lista = _TrafegoRepository.FindAll();
            return View(lista);
        }

        public IActionResult Cadastrar()
        {
            var lista = _TrafegoRepository.FindAll();
            return View(lista);
        }

    }
}
