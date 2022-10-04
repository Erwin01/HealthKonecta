using Fwk.Bases;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.SVC
{
    public class ActualizarPacienteReq : Request<PacienteBE>
    {
        public ActualizarPacienteReq()
        {
            this.ServiceName = "ActualizarPacienteSVC";
        }
    }

    public class ActualizarPacienteRes : Response<DummyContract>
    {
        
    }
}
