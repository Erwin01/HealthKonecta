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
    public class BuscarMutualReq : Request<Parametro>
    {
        public BuscarMutualReq()
        {
            this.ServiceName = "BuscarMutualSVC";
        }
    }

    public class Parametro : BaseEntity
    {
        public String NumDoc { get; set; }
    }

    public class BuscarMutualRes : Response<MutualBEList>
    {

    }
}
