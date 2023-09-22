using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLWebAPI.Controllers
{
    public class EmpleadoController : ApiController
    {
        [Route("api/empleado/add")] //se le asigna la ruta de la api, la creamos
        [HttpPost] //como es un add, es de tipo post
        public IHttpActionResult Add (ML.Empleado empleado) //es de tipo IHttpActionResult porque regresaremos un resultado de HTTP
        {
            ML.Result result = BL.Empleado.Add (empleado); //ejecutamos la logica

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result); //regresamos el estado HTTP OK, indicando que todo salio bien, y regresamos el result para que se pueda ver en el resultado del JSON
            } else
            {
                return Content(HttpStatusCode.BadRequest, result); //si algo salio mal, regresamos el error 400, que es parte del Cliente, pudo haber enviado un valor erroneo
            }


        }
    }
}
