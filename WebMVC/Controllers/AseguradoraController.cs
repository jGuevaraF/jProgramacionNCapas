using ML;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        [HttpGet]
        public ActionResult GetAllWCF()
        {
            //ML.Result result = BL.Aseguradora.GetAll();
            ServiceReferenceAseguradora.ServiceAseguradoraClient getAll = new ServiceReferenceAseguradora.ServiceAseguradoraClient();

            var result = getAll.GetAll();

            ML.Aseguradora aseguradora = new ML.Aseguradora();

            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects.ToList();
                return View(aseguradora);
            }
            return View();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
           
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            using (var client = new HttpClient())
            {
                string URLapi = ConfigurationManager.AppSettings["URLapi"];
                client.BaseAddress = new Uri(URLapi);

                var responseTask = client.GetAsync("aseguradora");
                responseTask.Wait();

                var resultServicio = responseTask.Result;

                if (resultServicio.IsSuccessStatusCode)
                {
                    aseguradora.Aseguradoras = new List<object>();
                    var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();

                    foreach (var resultAseguradora in readTask.Result.Objects)
                    {
                        ML.Aseguradora resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Aseguradora>(resultAseguradora.ToString());
                        aseguradora.Aseguradoras.Add(resultItemList);
                    }

                    return View(aseguradora);
                }
            }

            return View();
        } //REST


        [HttpGet]
        public ActionResult FormWCF (int? idUsuario) {

            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Usuario = new ML.Usuario();

            ML.Usuario usuario = new ML.Usuario();

            //ML.Result todosUsuarios = BL.Usuario.GetAllEF(usuario);
            ServiceReferenceUsuario.ServiceUsuarioClient getAll = new ServiceReferenceUsuario.ServiceUsuarioClient();
            var todosUsuarios = getAll.GetAll(usuario);

            if (idUsuario == null)//agregar
            {
                aseguradora.Usuario.Usuarios = todosUsuarios.Objects.ToList();
                

            } else //actualizar
            {
                //ML.Result resultUpdate = BL.Aseguradora.GetById(idUsuario.Value);
                ServiceReferenceAseguradora.ServiceAseguradoraClient getById = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
                var resultGetById = getById.GetById(idUsuario.Value);

                aseguradora = (ML.Aseguradora)resultGetById.Object;
                aseguradora.Usuario.Usuarios = todosUsuarios.Objects.ToList();
            }
            return View(aseguradora);
        }


        [HttpGet]
        public ActionResult Form(int? idUsuario)
        {

            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Usuario = new ML.Usuario();

            ML.Usuario usuario = new ML.Usuario();

            //ML.Result todosUsuarios = BL.Usuario.GetAllEF(usuario);
            ServiceReferenceUsuario.ServiceUsuarioClient getAll = new ServiceReferenceUsuario.ServiceUsuarioClient();
            var todosUsuarios = getAll.GetAll(usuario);

            if (idUsuario == null)//agregar
            {
                aseguradora.Usuario.Usuarios = todosUsuarios.Objects.ToList();


            }
            else //actualizar
            {
                //ML.Result resultUpdate = BL.Aseguradora.GetById(idUsuario.Value);
                ServiceReferenceAseguradora.ServiceAseguradoraClient getById = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
                var resultGetById = getById.GetById(idUsuario.Value);

                aseguradora = (ML.Aseguradora)resultGetById.Object;
                aseguradora.Usuario.Usuarios = todosUsuarios.Objects.ToList();
            }
            return View(aseguradora);
        }


        [HttpPost]
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
            ServiceReferenceAseguradora.ServiceAseguradoraClient aseguradoraWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();

            if (aseguradora.IdAseguradora == 0)
            {
                //ML.Result resultAdd = BL.Aseguradora.Add(aseguradora);
                
                var resultAdd = aseguradoraWCF.Add(aseguradora);

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
                //ML.Result resultUpdate = BL.Aseguradora.Update(aseguradora);
                var resultUpdate = aseguradoraWCF.Update(aseguradora);
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
            ServiceReferenceAseguradora.ServiceAseguradoraClient delete = new ServiceReferenceAseguradora.ServiceAseguradoraClient();

            //ML.Result resultDelete = BL.Aseguradora.Delete(idAseguradora);
            var resultDelete = delete.Delete(idAseguradora);

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