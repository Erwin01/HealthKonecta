using Fwk.Exceptions;
using Fwk.Params.BE;
using Health32Meucci.Common;
using Health32Meucci.ISVC;
using Health32Meucci.ISVC.ActualizarMutualPaciente;
using Health32Meucci.ISVC.BuscarPaciente;
using Health32Meucci.ISVC.BuscarParam;
using Health32Meucci.ISVC.CambiarEstadoPaciente;
using Health32Meucci.ISVC.CrearPaciente;
using Health32Meucci.ISVC.InsertarMutualPaciente;
using Health32Meucci.ISVC.ObtenerPaciente;
using Health32Meucci.ISVC.ValidarDocumento;
using Health32Meucci.SVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.Front
{
    internal class ServiceCall
    {
        #region[Busqueda de Pacientes]
        /// <summary>
        /// Busqueda de los pacientes por parametros especificos (Nombre, Apellido o NumDoc)
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="NumDoc"></param>
        /// <returns></returns>
        internal static PacienteBEList BuscarPaciente(String Nombre, String Apellido, String NumDoc)
        {            
            var req = new BuscarPacienteReq();
            req.BusinessData.Apellido = Apellido;
            req.BusinessData.Nombre = Nombre;
            req.BusinessData.NumDoc = NumDoc;
            var res = req.ExecuteService<BuscarPacienteReq, BuscarPacienteRes>(req);

            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

            return res.BusinessData; 
        }
        #endregion

        #region [Creación de Pacientes]
        /// <summary>
        /// Creación de pacientes
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        internal static int CrearPaciente(PacienteBE paciente)
        {
            CrearPacienteReq req = new CrearPacienteReq();

            req.BusinessData = paciente;


            CrearPacienteRes res = req.ExecuteService<CrearPacienteReq, CrearPacienteRes>(req);


            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

            return res.BusinessData.NumReferencia;
        }
        #endregion

        #region [Busqueda de Parametros]
        /// <summary>
        /// Busqueda de Parametros como: Tipo de Documento, Estado Civil y Sexo
        /// </summary>
        /// <returns></returns>
        internal static ParamBEList BuscarParam()
        {
            var req = new BuscarParamReq();

            var res = req.ExecuteService<BuscarParamReq, BuscarParamRes>(req);


            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

            return res.BusinessData;
        }
        #endregion

        #region [Obtener Paciente]
        /// <summary>
        /// Obtener Pacientes y Mutuales Por Parametro de Numdoc
        /// </summary>
        /// <param name="NumDoc"></param>
        /// <returns></returns>
        public static Health32Meucci.ISVC.ObtenerPaciente.Result ObtenerPaciente(String NumDoc)
        {
            var req = new ObtenerPacienteReq();
            req.BusinessData.NumDoc = NumDoc;

            var res = req.ExecuteService<ObtenerPacienteReq, ObtenerPacienteRes>(req);

            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

            return res.BusinessData;
        }
        #endregion

        #region [Actualizar Datos Pacientes]
        /// <summary>
        /// Actualiza Los Datos De Pacientes
        /// </summary>
        /// <param name="CurrentPacienteBE"></param>
        public static void ActualizarPaciente(PacienteBE CurrentPacienteBE) 
        {
            var req = new ActualizarPacienteReq();
            req.BusinessData = CurrentPacienteBE;

            var res = req.ExecuteService<ActualizarPacienteReq, ActualizarPacienteRes>(req);
            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

        }
        #endregion

        #region [Validación de Documento Paciente]
        /// <summary>
        /// Validar Documento Del Paciente Si Existe o No por Parametro de NumDoc
        /// </summary>
        /// <param name="NumDoc"></param>
        /// <returns></returns>
        public static string ValidarDocumento(string NumDoc)
        {
            var req = new ValidarDocumentoReq();
            req.BusinessData.NumDoc = NumDoc;

            var res = req.ExecuteService<ValidarDocumentoReq, ValidarDocumentoRes>(req);
            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

            return res.BusinessData.NumDoc;

        }
        #endregion

        #region [Cambio el Estado del Paciente -- Activo o Inactivo -- ]
        /// <summary>
        /// Cambio Del Estado Paciente En Activo o Inactivo En La BD
        /// </summary>
        /// <param name="pacienteEstado"></param>
        public static void CambiarEstadoPaciente(PacienteBE pacienteEstado)
        {
            var req = new CambiarEstadoPacienteReq();
            req.BusinessData = pacienteEstado;

            var res = req.ExecuteService<CambiarEstadoPacienteReq, CambiarEstadoPacienteRes>(req);
            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }
        }
        #endregion

        #region [Busqueda de Mutuales]
        /// <summary>
        /// Busqueda de Todos los Mutuales
        /// </summary>
        /// <returns></returns>
        internal static MutualBEList BuscarMutual()
        {
            var req = new BuscarMutualReq();           

            var res = req.ExecuteService<BuscarMutualReq, BuscarMutualRes>(req);

            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

            return res.BusinessData;
        }
        #endregion

        #region [Insertar Mutual por Paciente]
        /// <summary>
        /// Inserta la Mutual por Paciente Existente 
        /// </summary>
        /// <param name="mutualInsertado"></param>
        internal static void InsertarMutualPaciente(MutualPacienteBE mutualInsertado)
        {
            var req = new InsertarMutualPacienteReq();
            req.BusinessData.Id_Mutual = mutualInsertado.Id_Mutual;
            req.BusinessData.NumReferencia = mutualInsertado.NumReferencia;
            req.BusinessData.NroAfiliadoMutual = mutualInsertado.NroAfiliadoMutual;
            req.BusinessData.IsActive = mutualInsertado.IsActive;
            var res = req.ExecuteService<InsertarMutualPacienteReq, InsertarMutualPacienteRes>(req);

            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }
        }
        #endregion

        #region [Actualizar Mutual Por Paciente]
        /// <summary>
        /// Actualiza la Mutual por Paciente
        /// </summary>
        /// <param name="mutualInsertado"></param>
        internal static void ActualizarMutualPaciente(MutualPacienteBE mutualInsertado)
        {
            var req = new ActualizarMutualPacienteReq();
            req.BusinessData.Id = mutualInsertado.Id;            
            req.BusinessData.IsActive = mutualInsertado.IsActive;
            var res = req.ExecuteService<ActualizarMutualPacienteReq, ActualizarMutualPacienteRes>(req);

            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }
        }
        #endregion
    }
}
