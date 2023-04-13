using System.Linq;
using System.Web.Mvc;
using Destino.Models;

namespace TuProyecto.Controllers
{
    public class DestinoTuristicoController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var destinos = db.DestinosTuristicos.ToList();
            return View(destinos);
        }

        // Otras acciones del controlador aquí...
    }
}
