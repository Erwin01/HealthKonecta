using Fwk.Bases;
using Fwk.Exceptions;
using Fwk.HelperFunctions;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health32Meucci.Front
{
    public partial class FrmCrearPaciente : MetroFramework.Forms.MetroForm
    {
        public FrmCrearPaciente()
        {
            InitializeComponent();
            GetParams();
            CargarParametros();
            getMutualesList();
        }

        #region [Metodo para LLenar Campos]
        void Llenar()
        {
            if (CurrenPacienteBE != null)
            {
                txtNumReferencia.Text = CurrenPacienteBE.NumReferencia.ToString();
                txtNombre.Text = CurrenPacienteBE.Nombre.ToString();
                txtApellido.Text = CurrenPacienteBE.Apellido.ToString();
                cmbTipoDoc.SelectedValue = Convert.ToInt32(CurrenPacienteBE.TipoDoc);
                txtNumDoc.Text = CurrenPacienteBE.NumDoc.ToString();
                //dTPFechaNac = CurrenPacienteBE.FechaNac.ToString();
                cmbEstadoCivil.SelectedValue = Convert.ToInt32(CurrenPacienteBE.EstadoCivil);
                cboSexo.SelectedValue = Convert.ToInt32(CurrenPacienteBE.Sexo);
                picPaciente.Image = TypeFunctions.ConvertByteArrayToImage(CurrenPacienteBE.Foto);
                if (CurrenPacienteBE.Activo)
                    lblEstado.Text = "Activo";
                else
                {
                    lblEstado.Text = "Inactivo";
                    lblEstado.ForeColor = Color.Red;
                }
                btnGuardar.Text = "Actualizar";
                //MutualesPacienteBEList = ServiceCall.BuscarMutualPaciente(CurrenPacienteBE.NumDoc.ToString());

            }
            else
            {
                lblEstado.Visible = false;
                txtNumReferencia.Enabled = false;
                btnGuardar.Text = "Guardar";
            }
        }
        #endregion

        private static ParamBEList paramList;

        #region [Cargar Los Parametros]
        public void CargarParametros()
        {


            cmbEstadoCivil.DataSource = paramList.Where(p => p.Tipo_Param == Convert.ToInt32(TipoParametrosEnum.EstadoCivil)).OrderBy(p => p.Nombre).ToList();
            cmbEstadoCivil.DisplayMember = "Nombre";
            cmbEstadoCivil.ValueMember = "Id_Params";

            cmbTipoDoc.DataSource = paramList.Where(p => p.Tipo_Param == Convert.ToInt32(TipoParametrosEnum.TipoDoc)).OrderBy(p => p.Nombre).ToList();
            cmbTipoDoc.DisplayMember = "Nombre";
            cmbTipoDoc.ValueMember = "Id_Params";

            cboSexo.DataSource = paramList.Where(p => p.Tipo_Param == Convert.ToInt32(TipoParametrosEnum.Sexo)).OrderBy(p => p.Nombre).ToList();
            cboSexo.DisplayMember = "Nombre";
            cboSexo.ValueMember = "Id_Params";

        }

        #endregion

        #region [Boton Busqueda de Paciente]
        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            FrmBuscarPaciente buscarFrm = new FrmBuscarPaciente();
            buscarFrm.MdiParent = this.MdiParent;
            this.Hide();
            buscarFrm.Show();
        }
        #endregion

        #region [Método Buscar Parámetros]
        private ParamBEList GetParams()
        {
            try
            {
                paramList = ServiceCall.BuscarParam();

            }
            catch (Exception ex)
            {
                string strError = ExceptionHelper.GetAllMessageException(ex);

                MessageBox.Show(strError);
            }
            return paramList;
        }
        #endregion

        public PacienteBE CurrenPacienteBE;

        private static MutualBEList MutualesBEList;

        public MutualPacienteBEList MutualesPacienteBEList;

        #region [Método Buscar Mutuales]
        private MutualBEList getMutualesList()
        {
            try
            {
                MutualesBEList = ServiceCall.BuscarMutual();

            }
            catch (Exception ex)
            {
                string strError = ExceptionHelper.GetAllMessageException(ex);

                MessageBox.Show(strError);
            }
            return MutualesBEList;

        }
        #endregion

       

        #region [BOTÓN GUARDAR]
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validaciones())
                {
                    //Retornar o Devolver un mensaje
                    return;
                }
                if (CurrenPacienteBE != null)
                {
                    MapFromControls();
                    Actualizar();
                }
                else
                {
                    if (Validaciones())
                    {
                        PacienteBE pacienteNuevo = CrearPaciente();
                    }
                }

            }
            catch (Exception ex)
            {
                string strError = ExceptionHelper.GetAllMessageException(ex);

                MessageBox.Show(strError);
            }
        }
        #region Creacion Paciente
        /// <summary>
        /// Metodo de creacion de Pacientes
        /// </summary>
        /// <returns></returns>
        private PacienteBE CrearPaciente()
        {
            PacienteBE pacienteNuevo = new PacienteBE
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                EstadoCivil = cmbEstadoCivil.SelectedValue.ToString(),
                NumDoc = txtNumDoc.Text,
                Sexo = cboSexo.SelectedValue.ToString(),
                TipoDoc = cmbTipoDoc.SelectedValue.ToString(),
                Foto = TypeFunctions.ConvertImageToByteArray(picPaciente.Image, ImageFormat.Png),
                FechaNac = Convert.ToDateTime(dTPFechaNac.Value.ToString("yyyy-MM-dd")),

            };
            lblEstado.Visible = false;
            btnGuardar.Enabled = true;
            ServiceCall.CrearPaciente(pacienteNuevo);
            MessageBox.Show("Se creó el Paciente " + txtNombre.Text);
            limpiarCampos();

            return pacienteNuevo;
        }
        #endregion

        #region Actualizacion Paciente
        /// <summary>
        /// Actualiza paciente
        /// </summary>
        private void Actualizar()
        {
            try
            {
               ServiceCall.ActualizarPaciente(CurrenPacienteBE);
               if (MutualesPacienteBEList.Count > 0)
                    {
                        MutualPacienteBE nuevoMutual = new MutualPacienteBE();
                        if (mutualPacienteBEListBindingSource.Current != null)
                        {
                            nuevoMutual = (MutualPacienteBE)mutualPacienteBEListBindingSource.Current;
                            ServiceCall.ActualizarMutualPaciente(nuevoMutual);
                            //MessageBox.Show("Mutual Actualizado Correctamente");
                        }
                    }
                MessageBox.Show("Paciente Actualizado");
            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }
            
        }
        #endregion
        void MapFromControls()
        {
            CurrenPacienteBE.Nombre = txtNombre.Text;
            CurrenPacienteBE.Apellido = txtApellido.Text;
            CurrenPacienteBE.TipoDoc = cmbTipoDoc.SelectedValue.ToString();
            CurrenPacienteBE.NumDoc = txtNumDoc.Text;
            CurrenPacienteBE.FechaNac = Convert.ToDateTime(dTPFechaNac.Value.ToString("yyyy-MM-dd"));
            CurrenPacienteBE.EstadoCivil = cmbEstadoCivil.SelectedValue.ToString();
            CurrenPacienteBE.Sexo = cboSexo.SelectedValue.ToString();
            CurrenPacienteBE.Foto = TypeFunctions.ConvertImageToByteArray(picPaciente.Image, ImageFormat.Png);
        }
        #endregion

        #region [Cargar Imagen]
        private void picPaciente_Click(object sender, EventArgs e)
        {
            string imgFileName = FileFunctions.OpenFileDialog_Open(FileFunctions.OpenFilterEnums.OpenImageFilter);
            if (String.IsNullOrEmpty(imgFileName))
                return;
            Image intermedialImage = Image.FromFile(imgFileName);
            if (intermedialImage == null) return;
            picPaciente.Image = Helper.ImageChangeSize(intermedialImage, 200, 250);
        }
        #endregion

        #region [LIMPIAR CAMPOS]
        public void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumDoc.Clear();
            txtNumReferencia.Clear();
            cmbTipoDoc.SelectedIndex = 0;
            cmbEstadoCivil.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
            picPaciente.Image = Properties.Resources.none;
        }
        #endregion

        private void crearPaciente_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        #region [Método para Validar Campos]
        //public bool validarCampos()
        //{
        //    var validar = (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
        //            || cmbTipoDoc.SelectedIndex == 0 || string.IsNullOrEmpty(txtNumDoc.Text)
        //            || cmbEstadoCivil.SelectedIndex == 0 || cboSexo.SelectedIndex == 0);
        //    return validar;
        //}
        #endregion

        #region [Validar Campos Textbox]
        private void txtNumDoc_Leave(object sender, EventArgs e)
        {
            string NumDoc;

            NumDoc = ServiceCall.ValidarDocumento(txtNumDoc.Text);

            if (NumDoc != string.Empty)
            {
                MessageBox.Show("Este paciente ya existe en la base de datos");
                txtNumDoc.Clear();
                txtNumDoc.Focus();
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsSeparator(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsSeparator(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion


        #region [Método Para el TAB]
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != Paciente)
            {
                if (CurrenPacienteBE != null)
                {
                    if (tabControl1.SelectedTab == ObraSocial)
                    {
                        mutualBEListBindingSource.DataSource = MutualesBEList;
                        mutualPacienteBEListBindingSource.DataSource = MutualesPacienteBEList;
                        lblPaciente.Text = "Mutuales del Paciente " + CurrenPacienteBE.Nombre + " " + CurrenPacienteBE.Apellido;
                    }
                }
                else
                {
                    ObraSocial.Enabled = false;
                    MessageBox.Show("Debe de llenar la informacion del Paciente primero");
                    tabControl1.SelectedTab = Paciente;
                }
            }
        }
        #endregion

        #region [Botón Agregar Lista Mutual Por Pacientes]
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CurrenPacienteBE != null)
            {
                MutualBE mutualActual = new MutualBE();
                MutualPacienteBE nuevoMutual = new MutualPacienteBE();
                if (mutualBEListBindingSource.Current != null)
                {
                    Random rdn = new Random();
                    mutualActual = (MutualBE)mutualBEListBindingSource.Current;
                    nuevoMutual.Id_Mutual = mutualActual.IdMutual;
                    nuevoMutual.NumReferencia = CurrenPacienteBE.NumReferencia;
                    nuevoMutual.IsActive = true;
                    nuevoMutual.NroAfiliadoMutual = Convert.ToString(rdn.Next());
                    ServiceCall.InsertarMutualPaciente(nuevoMutual);
                    MutualesPacienteBEList = ServiceCall.ObtenerPaciente(CurrenPacienteBE.NumDoc.ToString()).MutualPacienteBEList;
                    mutualPacienteBEListBindingSource.DataSource = MutualesPacienteBEList;
                }
            }
            

        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region [Validaciones de Texto]
        private bool Validaciones()
        {
            errorProvider1.Clear();
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "El nombre no ha sido digitado");
                txtNombre.Focus();
                return false;
            }

            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "El apellido no ha sido digitado");
                txtApellido.Focus();
                return false;
            }

            if (cmbTipoDoc.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbTipoDoc, "El tipo de documento no se ha digitado");
                cmbTipoDoc.Focus();
                return false;
            }

            if (txtNumDoc.Text == "")
            {
                errorProvider1.SetError(txtNumDoc, "La cedula no ha sido digitado");
                txtNumDoc.Focus();
                return false;
            }

            if (cboSexo.SelectedIndex == 0)
            {
                errorProvider1.SetError(cboSexo, "El sexo no se ha digitado");
                cboSexo.Focus();
                return false;
            }

            if (cmbEstadoCivil.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbEstadoCivil, "El estado civil no se ha digitado");
                cmbEstadoCivil.Focus();
                return false;
            }         

            return true;
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsSeparator(e.KeyChar)) && !(e.KeyChar == '-') && (e.KeyChar != (char)Keys.Back) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion

    }
}
