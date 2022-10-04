using Fwk.Bases;
using Health32Meucci.DAC;
using Health32Meucci.ISVC;
using Health32Meucci.ISVC.CrearPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.SVC
{
    public class CrearPacienteSVC : BusinessService<CrearPacienteReq,CrearPacienteRes>
    {
        public override CrearPacienteRes Execute(CrearPacienteReq pServiceRequest)
        {
            CrearPacienteRes res = new CrearPacienteRes();

            
            PacienteDAC.CrearPaciente(pServiceRequest.BusinessData);

            return res;
             
        }
    }
}
