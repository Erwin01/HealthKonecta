using Fwk.Bases;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.ISVC.InsertarMutualPaciente
{
    public class InsertarMutualPacienteReq : Request<MutualPacienteBE>
    {
        public InsertarMutualPacienteReq()
        {
            this.ServiceName = "InsertarMutualPacienteSVC";
        }
    }


    public class InsertarMutualPacienteRes : Response<DummyContract>
    {
    }

    //public class Result : BaseEntity
    //{
       
    //}
}
