using ApplicationCore.Services;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class FamiliaController : Controller
    {
        private IServiceFamilia _service = new ServiceFamilia();
        // GET: Producto
        public ActionResult Index()
        {

            List<IN05> lista = new List<IN05>();
            try
            {
                lista = _service.List();
                return View(lista);
            }
            catch (Exception ex)
            {
                @TempData["Message"] = ex.Message;
                TempData.Keep();
                return RedirectToAction("Index");
            }

        }


        public ActionResult Create()
        {
       
            return View();
        }

        [HttpPost]
        public ActionResult Save(IN05 p)
        {
            try
            {

               

                if (ModelState.IsValid)
                {


                    if (!_service.VerificarId(p.IDFamilia))
                    {
                        @TempData["Repetido"] = "Lo sentimos, este código ya está en uso.";
                        TempData.Keep();
                        return View("Create");
                    }


                    IN05 producto = _service.Save(p);
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
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                @TempData["Message"] = ex.Message;
                TempData.Keep();
                return RedirectToAction("Index");
            }
        }
    }
}