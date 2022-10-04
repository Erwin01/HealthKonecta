using Fwk.Bases;
using Health32Meucci.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Health32Meucci.SVC
{
    public class ActualizarPacienteSVC : BusinessService<ActualizarPacienteReq, ActualizarPacienteRes>
    {
        public override ActualizarPacienteRes Execute(ActualizarPacienteReq pServiceRequest)
        {
            ActualizarPacienteRes res = new ActualizarPacienteRes();

            PacienteDAC.ActualizarPaciente(pServiceRequest.BusinessData);
            return res;
        }
    }
}
