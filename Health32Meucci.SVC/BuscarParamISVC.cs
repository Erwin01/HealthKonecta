using Fwk.Bases;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.ISVC.BuscarParam
{
    public class BuscarParamReq : Request<DummyContract>
    {
        public BuscarParamReq()
        {
            this.ServiceName = "BuscarParamSVC";
        }
    }
    
    public class BuscarParamRes : Response<ParamBEList>
    {
       
    }
}
