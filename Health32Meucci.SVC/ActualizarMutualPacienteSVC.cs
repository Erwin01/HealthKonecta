using Fwk.Bases;
using Health32Meucci.DAC;
using Health32Meucci.ISVC.ActualizarMutualPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.SVC
{
    public class ActualizarMutualPacienteSVC : BusinessService<ActualizarMutualPacienteReq, ActualizarMutualPacienteRes>
    {

        public override ActualizarMutualPacienteRes Execute(ActualizarMutualPacienteReq pServiceRequest)
        {
            ActualizarMutualPacienteRes res = new ActualizarMutualPacienteRes();    

            MutualesDAC.ActualizarMutualPaciente(pServiceRequest.BusinessData);
            return res;
        }
    }
}
