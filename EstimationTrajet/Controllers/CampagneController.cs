using EstimationTrajet.Models;
using EstimationTrajet.Models.Dev;
using Microsoft.AspNetCore.Mvc;

namespace EstimationTrajet.Controllers
{
    public class CampagneController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Form() { return View(); }

        [HttpPost]
        public IActionResult Form(CampagneViewModel campagne)
        {
            Trajet trajet = new Trajet();
            trajet.AdressEntreprise = campagne.AdressEntreprise;
            trajet.CleApi = campagne.CleApi;

            return View();
        }
    }
}
 
