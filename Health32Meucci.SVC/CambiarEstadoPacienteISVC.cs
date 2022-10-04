using Fwk.Bases;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.ISVC.CambiarEstadoPaciente
{
    public class CambiarEstadoPacienteReq : Request<PacienteBE>
    {
        public CambiarEstadoPacienteReq()
        {
            this.ServiceName = "CambiarEstadoPacienteSVC";
        }
    }

    public class CambiarEstadoPacienteRes : Response<DummyContract>
    {

    }
}
