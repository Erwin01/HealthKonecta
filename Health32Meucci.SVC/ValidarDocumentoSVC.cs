using Fwk.Bases;
using Health32Meucci.DAC;
using Health32Meucci.ISVC.ValidarDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.SVC
{
    public class ValidarDocumentoSVC : BusinessService<ValidarDocumentoReq, ValidarDocumentoRes>
    {


        public override ValidarDocumentoRes Execute(ValidarDocumentoReq pServiceRequest)
        {
            ValidarDocumentoRes res = new ValidarDocumentoRes();

            res.BusinessData.NumDoc= PacienteDAC.ValidarDocumento(pServiceRequest.BusinessData.NumDoc);
            return res;
        }
    }

}
