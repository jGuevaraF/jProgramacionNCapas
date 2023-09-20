using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pais
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.ProgramacionNCapasEntities context = new DL_EF.ProgramacionNCapasEntities())
                {
                    //ejecutamos el query
                    var query = context.PaisGetAll().ToList();
                    //verificamos si viene con informacion
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query) { 
                            //usamos el constructor para asignar los valores a las propiedades
                            ML.Pais pais = new ML.Pais(obj.IdPais, obj.Nombre);
                            result.Objects.Add(pais);
                        }

                        result.Correct = true;
                    }

                }

            } catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }
    }
}
