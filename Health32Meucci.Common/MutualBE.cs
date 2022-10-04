using Fwk.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.Common
{
    public partial class MutualBEList : BaseEntities<MutualBE> { }

    public partial class MutualBE : BaseEntity
    {
        public int IdMutual { get; set; }
        public String Nombre { get; set; }
        public Boolean ExigeCoseguro { get; set; }
        public String CUIT { get; set; }
        
    }
}
