using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fwk.Bases;
using Health32Meucci.ISVC.BuscarParam;
using Health32Meucci.DAC;

namespace Health32Meucci.SVC
{
    public class BuscarParamSVC : BusinessService<BuscarParamReq, BuscarParamRes>
    {

        public override BuscarParamRes Execute(BuscarParamReq pServiceRequest)
        {

            var res = new BuscarParamRes();

            res.BusinessData = ParamDAC.BuscarParam();

            return res;
        }
    }
}
