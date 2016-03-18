using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.Entidad;
using Model;

namespace PruebaWeb6.Controllers
{
    public class ContactoController : Controller
    {
        ContactoDAOSql contactoDAOSql = new ContactoDAOSql();
        public ActionResult Index()
        {
            return View(contactoDAOSql.buscarMensajes());
        }
    }
}