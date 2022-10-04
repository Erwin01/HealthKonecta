using Fwk.Bases;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.ISVC.CrearPaciente
{
    public class CrearPacienteReq : Request<PacienteBE>
    {
        public CrearPacienteReq()
        {
            this.ServiceName = "CrearPacienteSVC";
        }
    }


    public class CrearPacienteRes : Response<Result>
    {
    }

    public class Result : BaseEntity
    {
        public int NumReferencia { get; set; }
    }
}
