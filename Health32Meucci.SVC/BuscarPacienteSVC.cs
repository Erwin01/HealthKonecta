using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fwk.Bases;
using Health32Meucci.ISVC.BuscarPaciente;
using Health32Meucci.DAC;

namespace Health32Meucci.SVC
{
    public class BuscarPacienteSVC : BusinessService<BuscarPacienteReq, BuscarPacienteRes>
    {

        public override BuscarPacienteRes Execute(BuscarPacienteReq pServiceRequest)
        {

            var res = new BuscarPacienteRes();

            res.BusinessData = PacienteDAC.BuscarPaciente(pServiceRequest.BusinessData.Nombre, pServiceRequest.BusinessData.Apellido, pServiceRequest.BusinessData.NumDoc);

            return res;
        }
    }
}
