using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace WebMVC.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        //sin WCF
        //public ActionResult GetAll()
        //{
        //    ML.Empleado empleado = new ML.Empleado();
        //    empleado.Empresa = new ML.Empresa();
        //    ML.Result resultGetAll = BL.Empleado.GetAll(empleado);
        //    ML.Result resultGetAllEmpresas = BL.Empresa.GetAll();

        //    if (resultGetAll.Correct)
        //    {
        //        empleado.Empleados = resultGetAll.Objects;
        //        //empleado.Empresa = new ML.Empresa();
        //        empleado.Empresa.Empresas = resultGetAllEmpresas.Objects;
        //        return View(empleado);
        //    } else
        //    {
        //        return View();
        //    }

        //}

        [HttpGet]
        public ActionResult GetAll()//WCF
        {
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empresa = new ML.Empresa();
            //ML.Result resultGetAll = BL.Empleado.GetAll(empleado);
            ServiceReferenceEmpleado.ServiceEmpleadoClient resultGetAll = new ServiceReferenceEmpleado.ServiceEmpleadoClient(); //creamos un objeto hacia nuestro servicio web, ahora en vez de tener un BL tenemos un servicio web

            var resultadoGetAll = resultGetAll.GetAll(empleado);//guardamos el resultado del return que tiene el servicio

            ML.Result resultGetAllEmpresas = BL.Empresa.GetAll(); //pasamos la lista de las empresas

            if (resultadoGetAll.Correct)
            {
                empleado.Empleados = resultadoGetAll.Objects.ToList(); //le pasamos los resultados obtenidos en el servicio, hacia la lista de Empleados
                //empleado.Empresa = new ML.Empresa();
                empleado.Empresa.Empresas = resultGetAllEmpresas.Objects;
                return View(empleado);
            }
            else
            {
                return View();
            }

}

        [HttpPost]
        public ActionResult GetAll(ML.Empleado buscarEmp)
        {
            //ML.Result resultGetAll = BL.Empleado.GetAll(buscarEmp);

            //WCF
            ServiceReferenceEmpleado.ServiceEmpleadoClient resultBusqueda = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
            var resultados = resultBusqueda.GetAll(buscarEmp);


            ML.Result resultGetAllEmpresas = BL.Empresa.GetAll();
            buscarEmp = new ML.Empleado();
            buscarEmp.Empresa = new ML.Empresa();

            buscarEmp.Empleados = resultados.Objects.ToList();
            buscarEmp.Empresa.Empresas = resultGetAllEmpresas.Objects;
            return View(buscarEmp) ;
        }

        [HttpGet]
        public ActionResult Form(string numeroEmpleado) 
        {
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empresa = new ML.Empresa();

            ML.Result resultEmpresa = BL.Empresa.GetAll();
            

            if (numeroEmpleado != null) //update
            {
                //    ML.Result resultById = BL.Empleado.GetById(numeroEmpleado);
                //    empleado = (ML.Empleado)resultById.Object;
                //    empleado.Empresa.Empresas = resultEmpresa.Objects;
                //    empleado.Accion = "Update";

                ServiceReferenceEmpleado.ServiceEmpleadoClient getById = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
                var result = getById.GetById(numeroEmpleado);
                empleado = (ML.Empleado)result.Object;
                empleado.Empresa.Empresas = resultEmpresa.Objects;
                empleado.Accion = "Update";

            } else //ADD
            {
                empleado.Empresa.Empresas = resultEmpresa.Objects;
                empleado.Accion = "Add";
            }

            return View(empleado);
        }

        [HttpPost]
        public ActionResult Form(ML.Empleado empleado)
        {
            if(ModelState.IsValid)
            {
                HttpPostedFileBase file = Request.Files["Imagen"];

                if (file.ContentLength > 0)
                {
                    empleado.Foto = ConvertirABase64(file);
                }

                //ML.Result buscarNumeroEmpleado = BL.Empleado.GetById(empleado.NumeroEmpleado); no es lo optimo, pues ocupamos recursos innecesarios
                //en este caso, como sabemos en que momento se hace un ADD o un Update, podemos manejar una bandera que controle la situacion

                if(empleado.Accion.Equals("Add")) //agregar
                {
                    //ML.Result resultAdd = BL.Empleado.Add(empleado); BL
                    ServiceReferenceEmpleado.ServiceEmpleadoClient addEmpleado = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
                    var resultAdd = addEmpleado.Add(empleado);

                    if (resultAdd.Correct)
                    {
                        ViewBag.Message = "El empleado se dio de alta correctamente";
                    }
                    else
                    {
                        ViewBag.Message = "ERROR " + resultAdd.ErrorMessage;
                    }
                } 
                else //actualizar
                {
                    //ML.Result resultUpdate = BL.Empleado.Update(empleado);
                    ServiceReferenceEmpleado.ServiceEmpleadoClient updateEmpleado = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
                    var resultUpdate = updateEmpleado.Update(empleado);

                    if (resultUpdate.Correct)
                    {
                        ViewBag.Message = "El empleado se actualizó correctamente";
                    }
                }
                return PartialView("Modal");

            } else //ModelState false
            {
                ML.Result resultEmpresa = BL.Empresa.GetAll();
                empleado.Empresa.Empresas = resultEmpresa.Objects;
                return View(empleado);
            }

        }

        public ActionResult Delete(string numeroEmpleado)
        {
            //ML.Result resultDelete = BL.Empleado.Delete(numeroEmpleado);
            ServiceReferenceEmpleado.ServiceEmpleadoClient deleteEmpleado = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
            var resultDelete = deleteEmpleado.Delete(numeroEmpleado);

            if (resultDelete.Correct)
            {
                ViewBag.Message = "El Empleado se ha borrado correctamente.";
            } else
            {
                ViewBag.Message = resultDelete.ErrorMessage;
            }

            return PartialView("Modal");
        }


        public string ConvertirABase64(HttpPostedFileBase Foto)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Foto.InputStream);
            byte[] data = reader.ReadBytes((int)Foto.ContentLength);
            string imagen = Convert.ToBase64String(data);
            return imagen;
        }
    }
}