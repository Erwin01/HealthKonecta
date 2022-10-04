using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fwk.Bases;

namespace Health32Meucci.Common
{
    public class ParamBEList : BaseEntities<ParamBE> { }
    public class ParamBE : BaseEntity
    {
        public Int32 Id_Params { get; set; }
        public String  Nombre{ get; set; }
        public String Descripcion { get; set; }
        public Int32 Tipo_Param { get; set; }
    }
}
