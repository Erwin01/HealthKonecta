using Fwk.Bases;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.ISVC.BuscarPaciente
{
    public class BuscarPacienteReq : Request<Params>
    {
        public BuscarPacienteReq()
        {
            this.ServiceName = "BuscarPacienteSVC";
        }
    }

    public class Params : BaseEntity
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String NumDoc { get; set; }
    }

    public class BuscarPacienteRes : Response<PacienteBEList>
    {
       
    }
}
