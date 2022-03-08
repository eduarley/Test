using ApplicationCore.Services;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ProductoController : Controller
    {
        private IServiceProducto _service = new ServiceProducto();
        // GET: Producto
        public ActionResult Index()
        {
            
            List<IN04> lista = new List<IN04>();
            try
            {
                lista = _service.List();
                return View(lista);
            }
            catch (Exception ex)
            {
                @TempData["Message"] = ex.Message;
                TempData.Keep();
                return RedirectToAction("Default", "Error");
            }

        }


        public ActionResult Create()
        {
            IServiceFamilia serviceFamilia = new ServiceFamilia();
            try
            {
                ViewBag.Familia = serviceFamilia.GetActivos();

            }
            catch (Exception ex)
            {
                @TempData["Message"] = ex.Message;
                TempData.Keep();
                return RedirectToAction("Default", "Error");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Save(IN04 p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IN04 producto = _service.Save(p);
                    if (producto != null)
                    {
                        @TempData["Exito"] = "Éxito al guardar";
                        TempData.Keep();

                    }
                    else
                    {
                        @TempData["Message"] = "Error al guardar";
                        TempData.Keep();

                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    @TempData["Message"] = "Error al procesar los datos";
                    TempData.Keep();
                    return RedirectToAction("Default", "Error");
                }
            }
            catch (Exception ex)
            {
                @TempData["Message"] = ex.Message;
                TempData.Keep();
                return RedirectToAction("Default", "Error");
            }
        }
    }
}