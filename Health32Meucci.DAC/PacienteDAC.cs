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
    public class PacienteDAC
    {

        static PacienteDAC()
        {
        }

        #region [BUSCAR PACIENTE]
        public static PacienteBEList BuscarPaciente(String Nombre, String Apellido, String numDoc)
        {
            PacienteBEList listFiltrada = new PacienteBEList();
            try
            {

                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Paciente_Konecta_s", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@NumDoc", numDoc);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PacienteBE itemPaciente = new PacienteBE();
                                itemPaciente.NumReferencia = Guid.Parse(reader["NumReferencia"].ToString());
                                itemPaciente.Nombre = Convert.ToString(reader["Nombre"]);
                                itemPaciente.Apellido = Convert.ToString(reader["Apellido"]);
                                itemPaciente.TipoDoc = reader["TipoDoc"].ToString();
                                if (reader["NumDoc"] != DBNull.Value)
                                    itemPaciente.NumDoc = Convert.ToString(reader["NumDoc"]);
                                itemPaciente.EstadoCivil = Convert.ToString(reader["EstadoCivil"]);
                                itemPaciente.FechaNac = Convert.ToDateTime(reader["FechaNac"].ToString());
                                itemPaciente.Sexo = Convert.ToString(reader["Sexo"]);
                                if (reader["Foto"] != DBNull.Value)
                                    itemPaciente.Foto = (byte[])reader["Foto"];
                                itemPaciente.Activo = Convert.ToBoolean(reader["Activo"]);
                                listFiltrada.Add(itemPaciente);

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

        #region [OBTENER PACIENTE]
        public static PacienteBE ObtenerPaciente(string NumDoc)
        {

            PacienteBE pacienteFiltrada = new PacienteBE();
            try
            {

                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Paciente_Konecta_g", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NumDoc", NumDoc);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pacienteFiltrada.NumReferencia = Guid.Parse(reader["NumReferencia"].ToString());
                                pacienteFiltrada.TipoDoc = reader["TipoDoc"].ToString();
                                pacienteFiltrada.Nombre = Convert.ToString(reader["Nombre"]);
                                pacienteFiltrada.Apellido = Convert.ToString(reader["Apellido"]);
                                if (reader["NumDoc"] != DBNull.Value)
                                    pacienteFiltrada.NumDoc = Convert.ToString(reader["NumDoc"]);
                                pacienteFiltrada.EstadoCivil = Convert.ToString(reader["EstadoCivil"]);
                                pacienteFiltrada.FechaNac = Convert.ToDateTime(reader["FechaNac"].ToString());
                                pacienteFiltrada.Sexo = Convert.ToString(reader["Sexo"]);
                                if (reader["Foto"] != DBNull.Value)
                                    pacienteFiltrada.Foto = (byte[])reader["Foto"];
                                pacienteFiltrada.Activo = Convert.ToBoolean(reader["Activo"]);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

            return pacienteFiltrada;
        }

        #endregion


        #region [CREAR PACIENTE]
        public static void CrearPaciente(PacienteBE pacienteBE)
        {

            try
            {
                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Paciente_Konecta_i", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", pacienteBE.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", pacienteBE.Apellido);
                        cmd.Parameters.AddWithValue("@TipoDoc", pacienteBE.TipoDoc);
                        cmd.Parameters.AddWithValue("@NumDoc", pacienteBE.NumDoc);
                        cmd.Parameters.AddWithValue("@FechaNac", pacienteBE.FechaNac);
                        cmd.Parameters.AddWithValue("@EstadoCivil", pacienteBE.EstadoCivil);
                        cmd.Parameters.AddWithValue("@Sexo", pacienteBE.Sexo);
                        cmd.Parameters.AddWithValue("@Foto", pacienteBE.Foto);
                        cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Activo", pacienteBE.Activo);


                        cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@NumReferencia",
                            SqlDbType = SqlDbType.UniqueIdentifier,
                            Direction = ParameterDirection.Output
                        });

                        var i = cmd.ExecuteNonQuery();

                        //inserted.Id
                        pacienteBE.NumDoc = cmd.Parameters["@NumDoc"].SqlValue.ToString();



                    }

                }



            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }
        }
        #endregion

        #region [ACTUALIZAR PACIENTE]

        public static void ActualizarPaciente(PacienteBE pacienteUpdate)
        {

            try
            {
                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Paciente_Konecta_u", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NumReferencia", pacienteUpdate.NumReferencia);
                        cmd.Parameters.AddWithValue("@Apellido", pacienteUpdate.Apellido);
                        cmd.Parameters.AddWithValue("@TipoDoc", pacienteUpdate.TipoDoc);
                        cmd.Parameters.AddWithValue("@Nombre", pacienteUpdate.Nombre);
                        cmd.Parameters.AddWithValue("@EstadoCivil", pacienteUpdate.EstadoCivil);
                        cmd.Parameters.AddWithValue("@FechaNac", pacienteUpdate.FechaNac);
                        cmd.Parameters.AddWithValue("@NumDoc", pacienteUpdate.NumDoc);
                        cmd.Parameters.AddWithValue("@Sexo", pacienteUpdate.Sexo);
                        cmd.Parameters.AddWithValue("@Foto", pacienteUpdate.Foto);
                        cmd.Parameters.AddWithValue("@Activo", pacienteUpdate.Activo);
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

        #region [VALIDAR DNI]

        public static string ValidarDocumento(string NumDoc)
        {
            string Encontrado = string.Empty;
            try
            {
                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.ValidarDNI_Konecta", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NumDoc", NumDoc);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Encontrado = reader["NumDoc"].ToString();

                            }

                        }
                    }

                }
                return Encontrado;
            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }


        }

        #endregion

        #region [Actualizar Estado Paciente]
        public static void ActualizarEstadoPaciente(PacienteBE pacienteUpdate)
        {

            try
            {
                using (SqlConnection cnn = new SqlConnection(Common.Common.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Paciente_Konecta_u", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NumReferencia", pacienteUpdate.NumReferencia);
                        cmd.Parameters.AddWithValue("@Apellido", pacienteUpdate.Apellido);
                        cmd.Parameters.AddWithValue("@TipoDoc", pacienteUpdate.TipoDoc);
                        cmd.Parameters.AddWithValue("@Nombre", pacienteUpdate.Nombre);
                        cmd.Parameters.AddWithValue("@EstadoCivil", pacienteUpdate.EstadoCivil);
                        cmd.Parameters.AddWithValue("@FechaNac", Convert.ToDateTime(pacienteUpdate.FechaNac));
                        cmd.Parameters.AddWithValue("@NumDoc", pacienteUpdate.NumDoc);
                        cmd.Parameters.AddWithValue("@Sexo", pacienteUpdate.Sexo);
                        cmd.Parameters.AddWithValue("@Foto", pacienteUpdate.Foto);
                        cmd.Parameters.AddWithValue("@Activo", pacienteUpdate.Activo);

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
