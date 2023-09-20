using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Result result = BL.Aseguradora.GetAll();

            ML.Aseguradora aseguradora = new ML.Aseguradora();

            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects;
                return View(aseguradora);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Form (int? idUsuario) {

            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Usuario = new ML.Usuario();

            ML.Usuario usuario = new ML.Usuario();

            ML.Result todosUsuarios = BL.Usuario.GetAllEF(usuario);

            if(idUsuario == null)//agregar
            {
                aseguradora.Usuario.Usuarios = todosUsuarios.Objects;
                

            } else //actualizar
            {
                ML.Result resultUpdate = BL.Aseguradora.GetById(idUsuario.Value);
                aseguradora = (ML.Aseguradora)resultUpdate.Object;
                aseguradora.Usuario.Usuarios = todosUsuarios.Objects;
            }
            return View(aseguradora);
        }

        [HttpPost]
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
            if(aseguradora.IdAseguradora == 0)
            {
                ML.Result resultAdd = BL.Aseguradora.Add(aseguradora);
                if (resultAdd.Correct)
                {
                    ViewBag.Message = "EL usuario se dio de alta correctamente";
                }
                else
                {
                    ViewBag.Message = "ERROR" + resultAdd.ErrorMessage;
                }
            } else
            {
                ML.Result resultUpdate = BL.Aseguradora.Update(aseguradora);
                if (resultUpdate.Correct)
                {
                    ViewBag.Message = "EL usuario se actualizó correctamente";
                }
                else
                {
                    ViewBag.Message = "ERROR" + resultUpdate.ErrorMessage;
                }
            }
            return PartialView("Modal");
        }

        [HttpGet]
        public ActionResult Delete(int idAseguradora) {
            ML.Result resultDelete = BL.Aseguradora.Delete(idAseguradora);
            if (resultDelete.Correct)
            {
                ViewBag.Message = "El usuario se eliminó correctamente";
            }
            else
            {
                ViewBag.Message = "ERROR";
            }
            return PartialView("Modal");
        }

    }
}