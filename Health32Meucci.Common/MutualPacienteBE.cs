using Fwk.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.Common
{
    public partial class MutualPacienteBEList : BaseEntities<MutualPacienteBE> { }

    public partial class MutualPacienteBE : BaseEntity
    {
        public int Id { get; set; }
        public int Id_Mutual { get; set; }
        public Guid NumReferencia { get; set; }
        public String NroAfiliadoMutual { get; set; }
        public String NombreMutual { get; set; }
        public Boolean IsActive { get; set; }
    }
}
