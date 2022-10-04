using Fwk.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.Common
{
    public partial class PacienteBEList : BaseEntities<PacienteBE> { }

    public partial class PacienteBE : BaseEntity
    {
        public Guid NumReferencia { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String TipoDoc { get; set; }
        public String NumDoc { get; set; }        
        public DateTime FechaNac { get; set; }
        public String EstadoCivil { get; set; }
        public String Sexo { get; set; }
        public byte[] Foto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
    }
}
