using Fwk.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.ISVC.ValidarDocumento
{
    public class ValidarDocumentoReq : Request<Params>
    {
        public ValidarDocumentoReq()
        {
            this.ServiceName = "ValidarDocumentoSVC";
        }
    }

    public class Params : BaseEntity
    {
        public String NumDoc { get; set; }
    }

    public class ValidarDocumentoRes : Response<Result>
    {

    }

    public class Result : BaseEntity
    {
        public String NumDoc { get; set; }
    }
}
