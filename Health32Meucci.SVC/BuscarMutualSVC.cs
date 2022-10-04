using Fwk.Bases;
using Health32Meucci.Common;
using Health32Meucci.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.SVC
{
  
    public class BuscarMutualSVC : BusinessService<BuscarMutualReq, BuscarMutualRes>
    {
        public override BuscarMutualRes Execute(BuscarMutualReq pServiceRequest)
        {
            BuscarMutualRes res = new BuscarMutualRes();

            //res.BusinessData = MutualesDAC.BuscarMutual(pServiceRequest.BusinessData.NumDoc);

            return res;
        }
    }
}
