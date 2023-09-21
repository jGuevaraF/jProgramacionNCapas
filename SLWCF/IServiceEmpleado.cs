using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceEmpleado" in both code and config file together.
    [ServiceContract]
    public interface IServiceEmpleado
    {
        [OperationContract]
        SLWCF.Result Add(ML.Empleado empleado); // se hace el result en SLWCF para que pueda hacer la serializacion y la deserealizacion

        [OperationContract]
        SLWCF.Result Update(ML.Empleado empleado);

        [OperationContract]
        SLWCF.Result Delete(string numeroEmpleado);
    }
}
