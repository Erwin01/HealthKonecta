using Fwk.Bases;
using Fwk.Configuration.ISVC;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.ISVC.ObtenerPaciente
{
    public class ObtenerPacienteReq : Request<Obtener>    
   {
       public ObtenerPacienteReq()
       {
           this.ServiceName = "ObtenerPacienteSVC";
       }
   }

    public class Obtener : BaseEntity
    {
        public String NumDoc { get; set; }
    }

    public class ObtenerPacienteRes : Response<Result>
    { 
    
    }
    /// <summary>
    /// Se crea este result para poder retornar 2 entidades al mismo tiempo
    /// 
    /// Adicional a esto, se puede borrar el servicio que buscaba las mutuales por paciente BuscarMutualPacienteISVC.cs y BuscarMutualPacienteSVC.cs
    /// </summary>
    public class Result : BaseEntity
    {
        public PacienteBE PacienteBE { get; set; }
        public MutualPacienteBEList MutualPacienteBEList { get; set; }
    }
}
