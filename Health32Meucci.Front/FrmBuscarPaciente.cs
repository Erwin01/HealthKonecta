using Fwk.Exceptions;
using Health32Meucci.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health32Meucci.Front
{
    public partial class FrmBuscarPaciente : MetroFramework.Forms.MetroForm
    {
        public FrmBuscarPaciente()
        {
            InitializeComponent();
        }

        PacienteBE currentPaciente;

        #region [Botón Buscar Paciente /// estan los 2 buscar search]
        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumDoc.Text != "")
                {
                    var PacienteBE = ServiceCall.ObtenerPaciente(txtNumDoc.Text);
                    pacienteBEBindingSource.DataSource = PacienteBE;

                }
                else
                {
                    var ListaFiltrada = ServiceCall.BuscarPaciente(txtNombre.Text, "", txtNumDoc.Text);
                    pacienteBEBindingSource.DataSource = ListaFiltrada;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!Convert.ToBoolean(row.Cells[8].Value))
                        {
                            row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        }
                        else
                        {

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string strError = ExceptionHelper.GetAllMessageException(ex);

                MessageBox.Show(strError);
            }
        }

        #endregion

        //#region [Botón Crear Paciente, Actualizar Paciente Y Editar Mutual Por Paciente]
        //private void btnCrearPaciente_Click(object sender, EventArgs e)
        //{

        //    currentPaciente = (PacienteBE)pacienteBEBindingSource.Current;
        //    if (currentPaciente.Activo)
        //    {

        //        DialogResult result = MessageBox.Show("Desea Eliminar el Paciente?", "Información de Cambios", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
        //        EliminarPaciente(result);
        //    }
        //    else
        //    {
        //        DialogResult result = MessageBox.Show("Desea Activar el Paciente?", "Información de Cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        //        ActivarPaciente(result);
        //    }

        //}
        //#endregion

        #region [Activar Paciente]
        private void ActivarPaciente(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {

                if (pacienteBEBindingSource.Current.ToString() != "")
                {
                    currentPaciente = (PacienteBE)pacienteBEBindingSource.Current;

                    try
                    {
                        currentPaciente.Activo = true;   
                        ServiceCall.CambiarEstadoPaciente(currentPaciente);
                        MessageBox.Show("El paciente " + currentPaciente.Nombre + " " + currentPaciente.Apellido + " ha sido Activado");
                        var PacienteBE = ServiceCall.BuscarPaciente("", "", "");
                        pacienteBEBindingSource.DataSource = PacienteBE;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!Convert.ToBoolean(row.Cells["Activo"].Value))
                            {
                                row.DefaultCellStyle.BackColor = Color.LimeGreen;
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        string strError = ExceptionHelper.GetAllMessageException(ex);

                        MessageBox.Show(strError);
                    }
                }
                else
                {
                    this.Visible = false;
                    FrmCrearPaciente frm = new FrmCrearPaciente();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            else if (result == DialogResult.No)
            {

            }
            else
            {

            }
        }
        #endregion


        #region [Eliminar Paciente]
        private void EliminarPaciente(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {

                if (pacienteBEBindingSource.Current.ToString() != "")
                {
                    currentPaciente = (PacienteBE)pacienteBEBindingSource.Current;

                    try
                    {
                        currentPaciente.Activo = false;
                        ServiceCall.CambiarEstadoPaciente(currentPaciente);
                        MessageBox.Show("El paciente " + currentPaciente.Nombre + " " + currentPaciente.Apellido + " ha sido deshabilitado");

                        var PacienteBE = ServiceCall.BuscarPaciente("", "", "");
                        pacienteBEBindingSource.DataSource = PacienteBE;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!Convert.ToBoolean(row.Cells["Activo"].Value))
                            {
                                row.DefaultCellStyle.BackColor = Color.OrangeRed;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string strError = ExceptionHelper.GetAllMessageException(ex);
                        MessageBox.Show(strError);
                    }
                }
                else
                {
                    this.Visible = false;
                    FrmCrearPaciente frm = new FrmCrearPaciente();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            else if (result == DialogResult.No)
            {

            }
            else
            {

            }
        }
        #endregion
      

        #region [Datos Paciente en Grilla]
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmCrearPaciente crearForm = new FrmCrearPaciente();
            currentPaciente = (PacienteBE)pacienteBEBindingSource.Current;
            crearForm.CurrenPacienteBE = ServiceCall.ObtenerPaciente(currentPaciente.NumDoc).PacienteBE;
            crearForm.MutualesPacienteBEList = ServiceCall.ObtenerPaciente(currentPaciente.NumDoc).MutualPacienteBEList;
            crearForm.MdiParent = this.MdiParent;
            crearForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentPaciente = (PacienteBE)pacienteBEBindingSource.Current;
            if (currentPaciente.Activo)
            {
                btnCrearPaciente.Width = 120;
                btnCrearPaciente.Text = "Eliminar Paciente";
                
            }
            else
            {
                btnCrearPaciente.Width = 120;
                btnCrearPaciente.Text = "Activar Paciente";

            }
        }
        #endregion

        private void PintarEstadoColumnas(object sender, MouseEventArgs e)
        {
            if (btnCrearPaciente.Text == "Eliminar Paciente")
            {
                EliminarPaciente(DialogResult.Yes);

            }
            else
            {
                ActivarPaciente(DialogResult.Yes);
            }

        }
    }
}
