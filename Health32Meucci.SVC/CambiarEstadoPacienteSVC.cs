using Fwk.Bases;
using Health32Meucci.DAC;
using Health32Meucci.ISVC.CambiarEstadoPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.SVC
{
    public class CambiarEstadoPacienteSVC : BusinessService<CambiarEstadoPacienteReq, CambiarEstadoPacienteRes>
    {

        public override CambiarEstadoPacienteRes Execute(CambiarEstadoPacienteReq pServiceRequest)
        {
            CambiarEstadoPacienteRes res = new CambiarEstadoPacienteRes();

            PacienteDAC.ActualizarEstadoPaciente(pServiceRequest.BusinessData);
            return res;
        }
    }
}
