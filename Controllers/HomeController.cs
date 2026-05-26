using System.Diagnostics;
using CongeladosHolandaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CongeladosHolandaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Mockar dados dos produtos em estoque
            var produtos = new List<ProdutoViewModel>
            {
                new ProdutoViewModel { Nome = "Coxinha", Quantidade = 40, ValorUnitario = 2.50m },
                new ProdutoViewModel { Nome = "Risoles", Quantidade = 35, ValorUnitario = 2.80m },
                new ProdutoViewModel { Nome = "Kibe", Quantidade = 25, ValorUnitario = 3.00m },
                new ProdutoViewModel { Nome = "Bolinha de queijo", Quantidade = 20, ValorUnitario = 2.20m }
            };

            // Mockar dados financeiros
            var model = new FinanceiroViewModel
            {
                TotalVendas = 8450.00m,
                Despesas = 3200.00m,
                Lucro = 5250.00m,
                EstoqueTotal = 120,
                Produtos = produtos
            };

            return View(model);
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
