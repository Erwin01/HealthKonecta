using Fwk.Bases;
using Health32Meucci.DAC;
using Health32Meucci.ISVC.ObtenerPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.SVC
{
   public class ObtenerPacienteSVC: BusinessService<ObtenerPacienteReq, ObtenerPacienteRes>
    {

        public override ObtenerPacienteRes Execute(ObtenerPacienteReq pServiceRequest)
        {
            ObtenerPacienteRes res = new ObtenerPacienteRes();
            res.BusinessData.PacienteBE = PacienteDAC.ObtenerPaciente(pServiceRequest.BusinessData.NumDoc);
            res.BusinessData.MutualPacienteBEList = MutualesDAC.BuscarMutualPorPaciente(pServiceRequest.BusinessData.NumDoc);
            return res;
        }
    }
}
