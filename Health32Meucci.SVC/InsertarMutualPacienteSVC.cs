using Fwk.Bases;
using Health32Meucci.DAC;
using Health32Meucci.ISVC.InsertarMutualPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.SVC
{
    public class InsertarMutualPacienteSVC : BusinessService<InsertarMutualPacienteReq, InsertarMutualPacienteRes>
    {

        public override InsertarMutualPacienteRes Execute(InsertarMutualPacienteReq pServiceRequest)
        {
            InsertarMutualPacienteRes res = new InsertarMutualPacienteRes();

            MutualesDAC.InsertarMutualPaciente(pServiceRequest.BusinessData);

            return res;

        }
    }
}
