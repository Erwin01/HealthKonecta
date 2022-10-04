using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fwk.Transaction;
using Health32Meucci.ISVC.ActualizarMutualPaciente;
using Health32Meucci.SVC;

namespace TestMeucci
{
    [TestClass]
    public class UnitTest1
    {
        TransactionScopeHandler _Tx;

        [TestMethod]
        public void ActualizarMutualPaciente()
        {
            string strErrorResult = string.Empty;
            _Tx = new TransactionScopeHandler(TransactionalBehaviour.RequiresNew, IsolationLevel.ReadCommitted,
                new TimeSpan(0, 0, 15));
            _Tx.InitScope();
            try
            {
                //Arrange
                ActualizarMutualPacienteReq req = new ActualizarMutualPacienteReq();
                ActualizarMutualPacienteSVC svc = new ActualizarMutualPacienteSVC();
                req.BusinessData.Id = 100000;
                req.BusinessData.Id_Mutual = 200;
                req.BusinessData.NumReferencia = new Guid();
                req.BusinessData.NroAfiliadoMutual = "1037618424";
                req.BusinessData.NombreMutual = "";
                req.BusinessData.IsActive = true;
                var res = svc.Execute(req);


            }
            catch (Exception e)
            {
                strErrorResult = Fwk.Exceptions.ExceptionHelper.GetAllMessageException(e);
            }
            _Tx.Abort();
            //Assert
            Assert.AreEqual<String>(strErrorResult, String.Empty, strErrorResult);


        }

        [TestMethod]
        public void ActualizarPaciente()
        {
            string strErrorResult = string.Empty;
            _Tx = new TransactionScopeHandler(TransactionalBehaviour.RequiresNew, IsolationLevel.ReadCommitted,
                new TimeSpan(0, 0, 15));
            _Tx.InitScope();


            try
            {
                //Arrange
                ActualizarPacienteReq req = new ActualizarPacienteReq();
                ActualizarPacienteSVC svc = new ActualizarPacienteSVC();
                req.BusinessData.NumReferencia = new Guid();
                req.BusinessData.Nombre = "Prueba";
                req.BusinessData.Apellido = "Prueba";
                req.BusinessData.EstadoCivil = "Casado";
                req.BusinessData.FechaNac = DateTime.Now;
                req.BusinessData.TipoDoc = "CC";
                req.BusinessData.NumDoc = "1037615";
                req.BusinessData.Sexo = "Masculino";
                req.BusinessData.Activo = true;
                byte[] foto = new Byte[1];
                req.BusinessData.Foto = foto;
                var res = svc.Execute(req);


            }
            catch (Exception e)
            {
                strErrorResult = Fwk.Exceptions.ExceptionHelper.GetAllMessageException(e);
            }
            _Tx.Abort();
            //Assert
            Assert.AreEqual<String>(strErrorResult, String.Empty, strErrorResult);


        }
    }
}
