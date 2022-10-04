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
    public class ParamDAC
    {

        #region [BUSCAR Param]
        public static ParamBEList BuscarParam()
        {
            ParamBEList listFiltrada = new ParamBEList();
            try
            {

                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Param_Konecta_s", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ParamBE itemParam = new ParamBE();

                                itemParam.Id_Params = int.Parse(reader["Id_Params"].ToString());
                                itemParam.Nombre = Convert.ToString(reader["Nombre"]);
                                itemParam.Descripcion = Convert.ToString(reader["Descripcion"]);
                                itemParam.Tipo_Param = int.Parse(reader["Tipo_Param"].ToString());
                                listFiltrada.Add(itemParam);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

            return listFiltrada;
        }

        #endregion

        #region [OBTENER Param (Pendiente No se encuentra en uso)]
        //public static ParamBE ObtenerParam(string NumDoc)
        //{

        //    ParamBE ParamFiltrada = new ParamBE();
        //    try
        //    {

        //        using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
        //        {
        //            cnn.Open();
        //            using (SqlCommand cmd = new SqlCommand("dbo.Param_Konecta_g", cnn))
        //            {

        //                cmd.CommandType = CommandType.StoredProcedure;
        //                //cmd.Parameters.AddWithValue("@Apellido", apellido);
        //                //cmd.Parameters.AddWithValue("@Nombre", name);
        //                //cmd.Parameters.AddWithValue("@NumDoc", cedula);
        //                cmd.Parameters.AddWithValue("@NumDoc", NumDoc);
        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        //ParamBE itemParam = new ParamBE();

        //                        //itemParam.NumReferencia = Guid.Parse(reader["Id"].ToString());
        //                        //itemParam.Nombre = Convert.ToString(reader["Nombre"]);
        //                        //itemParam.Apellido = Convert.ToString(reader["apellido"]);
        //                        //if (reader["cedula"] != DBNull.Value)
        //                        //    itemParam.NumDoc = Convert.ToString(reader["cedula"]);
        //                        //if (reader["Foto"] != DBNull.Value)
        //                        //    itemParam.Foto = (byte[])reader["Foto"];
        //                        ParamFiltrada.NumReferencia = Convert.ToInt32(reader["NumReferencia"].ToString());
        //                        ParamFiltrada.Nombre = Convert.ToString(reader["Nombre"]);
        //                        ParamFiltrada.Apellido = Convert.ToString(reader["Apellido"]);
        //                        if (reader["NumDoc"] != DBNull.Value)
        //                            ParamFiltrada.NumDoc = Convert.ToString(reader["NumDoc"]);
        //                        ParamFiltrada.EstadoCivil = Convert.ToString(reader["EstadoCivil"]);
        //                        ParamFiltrada.Sexo = Convert.ToString(reader["Sexo"]);
        //                        if (reader["Foto"] != DBNull.Value)
        //                            ParamFiltrada.Foto = (byte[])reader["Foto"];
        //                    }

        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
        //    }

        //    return ParamFiltrada;
        //}

        //#endregion

        //#region [CREAR Param]
        //public static void CrearParam(ParamBE ParamBE)
        //{

        //    try
        //    {
        //        using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
        //        {
        //            cnn.Open();
        //            using (SqlCommand cmd = new SqlCommand("dbo.Param_Konecta_i", cnn))
        //            {

        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@Nombre", ParamBE.Nombre);
        //                cmd.Parameters.AddWithValue("@Apellido", ParamBE.Apellido);
        //                cmd.Parameters.AddWithValue("@TipoDoc", ParamBE.TipoDoc);
        //                cmd.Parameters.AddWithValue("@NumDoc", ParamBE.NumDoc);
        //                cmd.Parameters.AddWithValue("@FechaNac", ParamBE.FechaNac);
        //                cmd.Parameters.AddWithValue("@EstadoCivil", ParamBE.EstadoCivil);
        //                cmd.Parameters.AddWithValue("@Sexo", ParamBE.Sexo);
        //                cmd.Parameters.AddWithValue("@Foto", ParamBE.Foto);

        //                cmd.Parameters.Add(new SqlParameter
        //                {
        //                    ParameterName = "@NumReferencia",
        //                    SqlDbType = SqlDbType.UniqueIdentifier,
        //                    Direction = ParameterDirection.Output
        //                });

        //                var i = cmd.ExecuteNonQuery();

        //                //inserted.Id
        //                ParamBE.NumReferencia = int.Parse(cmd.Parameters["@NumReferencia"].SqlValue.ToString());



        //            }

        //        }



        //    }
        //    catch (Exception ex)
        //    {

        //        throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
        //    }
        //}
        //#endregion

        //#region [ACTUALIZAR Param]

        //public static void ActualizarParam(ParamBE ParamUpdate)
        //{

        //    try
        //    {
        //        using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
        //        {
        //            cnn.Open();
        //            using (SqlCommand cmd = new SqlCommand("dbo.Param_Konecta_u", cnn))
        //            {

        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@NumReferencia", ParamUpdate.NumReferencia);
        //                cmd.Parameters.AddWithValue("@Apellido", ParamUpdate.Apellido);
        //                cmd.Parameters.AddWithValue("@Nombre", ParamUpdate.Nombre);
        //                cmd.Parameters.AddWithValue("@NumDoc", ParamUpdate.NumDoc);
        //                cmd.Parameters.AddWithValue("@Foto", ParamUpdate.Foto);

        //                var i = cmd.ExecuteNonQuery();

        //            }

        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
        //    }


        //}

        #endregion
    }
}
