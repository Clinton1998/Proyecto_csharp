using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejemplo_del.Models;


namespace Ejemplo_del.Controllers
{
    public class GoleadoresController : Controller
    {
        JugadoresModelo JugadoresModelo;
       
        public GoleadoresController()
        {
            JugadoresModelo = new JugadoresModelo();
        }
        [ChildActionOnly]
        public ActionResult _Goleadores()
        {
            List<JugadoresModelo.GOLEADORES> lista = this.JugadoresModelo.GetGoleadores();
            return PartialView(lista);

        }

        public ActionResult Index()
        {
            return View();
        }

    }


}