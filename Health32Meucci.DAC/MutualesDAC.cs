using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.DAC
{
    public class MutualesDAC
    {
        //#region [BUSCAR MUTUAL]
        //public static MutualBEList BuscarMutual(String NumDoc)
        //{
        //    MutualBEList obtenerListaMutual = new MutualBEList();
        //    try
        //    {

        //        using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
        //        {
        //            cnn.Open();
        //            using (SqlCommand cmd = new SqlCommand("dbo.ObraSocial_Konecta_s", cnn))
        //            {
 
        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        MutualBE itemMutual = new MutualBE();
        //                        itemMutual.IdMutual = Convert.ToInt32(reader["id_Mutual"]);
        //                        itemMutual.Nombre = reader["Nombre"].ToString();                               
        //                        obtenerListaMutual.Add(itemMutual);

        //                    }

        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
        //    }

        //    return obtenerListaMutual;
        //}

        //#endregion

        #region [BUSCAR MUTUAL PACIENTE]
        public static MutualPacienteBEList BuscarMutualPorPaciente(String NumDoc)
        {
            MutualPacienteBEList obtenerListaMutual = new MutualPacienteBEList();
            try
            {

                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.ObraSocialPorPaciente_Konecta_g", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NumDoc", NumDoc);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MutualPacienteBE itemMutual = new MutualPacienteBE();
                                itemMutual.Id = Convert.ToInt32(reader["id"]);
                                itemMutual.Id_Mutual = Convert.ToInt32(reader["id_Mutual"]);
                                itemMutual.NombreMutual = reader["Nombre"].ToString();
                                itemMutual.NroAfiliadoMutual = reader["NroAfiliadoMutal"].ToString();
                                itemMutual.IsActive = Convert.ToBoolean(reader["IsActive"]);

                                obtenerListaMutual.Add(itemMutual);

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

            return obtenerListaMutual;
        }

        #endregion

        #region [Insertar Mutual Paciente]
        public static void InsertarMutualPaciente(MutualPacienteBE nuevoMutual)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.ObraSocialPorPaciente_Konecta_i", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Mutual", nuevoMutual.Id_Mutual);
                        //cmd.Parameters.Add(new SqlParameter
                        //{
                        //    ParameterName = "@NumReferencia",
                        //    SqlDbType = SqlDbType.UniqueIdentifier
                            
                        //});
                        cmd.Parameters.AddWithValue("@NumReferencia", nuevoMutual.NumReferencia);
                        cmd.Parameters.AddWithValue("@NroAfiliadoMutal", nuevoMutual.NroAfiliadoMutual);
                        //cmd.Parameters.Add(new SqlParameter
                        //{
                        //    ParameterName = "@IsActive",
                        //    SqlDbType = SqlDbType.Bit                         
                        //});
                        cmd.Parameters.AddWithValue("@IsActive", nuevoMutual.IsActive);
                        var i = cmd.ExecuteNonQuery();

                    }

                }



            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

        }
        #endregion

        #region [Actualizar Mutual Paciente]
        public static void ActualizarMutualPaciente(MutualPacienteBE nuevoMutual)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.ObraSocialPorPaciente_Konecta_u", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", nuevoMutual.Id);              
                        cmd.Parameters.AddWithValue("@IsActive", nuevoMutual.IsActive);
                        var i = cmd.ExecuteNonQuery();

                    }

                }
            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

        }
        #endregion

    }

    


}
