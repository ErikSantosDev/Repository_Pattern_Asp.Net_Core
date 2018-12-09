using DAL.Entities;
using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Estoque.Web.Controllers
{
    public class CidadeController : Controller
    {
        //private readonly _repo = Repository(Cidade);
        public IActionResult Index()
        {
            return View();
        }
    }
}
