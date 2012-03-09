using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FicheEngagementDepense.Controllers
{
    public class FicheEngDepController : Controller
    {
        public ActionResult Create()
        {
            ViewBag.Titre = "Demande d'engagement de dépense";
            ViewBag.PetitTitre = "Création";

            return View();
        }
    }
}
