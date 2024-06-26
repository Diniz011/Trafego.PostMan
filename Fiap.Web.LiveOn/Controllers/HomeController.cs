using Fiap.Web.LiveOn.Data.Contexts;
using Fiap.Web.LiveOn.Models;
using Fiap.Web.LiveOn.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fiap.Web.LiveOn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _context;


        public HomeController(ILogger<HomeController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // SELECT * FROM TRAFEGO
            //var lista = _context.Trafego.ToList();


            //var mont = new Trafego
            //{
            //    NomedaAvenida = "Av. Paulista",
            //    Congestionamento = "Não",
            //    Acidentes = "Nenhum",
            //    FarolQuebrado = "5 sem funcionar"
            //};

            //_context.Trafego.Add(trafego);
            //_context.SaveChanges();




            var vm = new DashboardViewModel();
            vm.TotalFaroisQuebrados = 10;
            vm.TotalCongestionamentos = 99;
            vm.TotalCamerasdaAvenida = 109;
            vm.TotalAcidentes = 1000;
            vm.TotalVeiculos = 56;


            return View(vm);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
