using Fwk.Bases;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.ISVC.ActualizarMutualPaciente
{
    public class ActualizarMutualPacienteReq : Request<MutualPacienteBE>
    {
        public ActualizarMutualPacienteReq()
        {
            this.ServiceName = "ActualizarMutualPacienteSVC";
        }
    }

    public class ActualizarMutualPacienteRes : Response<DummyContract>
    {

    }
}
