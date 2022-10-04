namespace Health32Meucci.Front
{
    partial class FrmBuscarPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarPaciente));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NumReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(283, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de Documento";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(283, 116);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(233, 20);
            this.txtNumDoc.TabIndex = 4;
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPaciente.Image = global::Health32Meucci.Front.Properties.Resources._001_55;
            this.btnCrearPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPaciente.Location = new System.Drawing.Point(735, 90);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(131, 37);
            this.btnCrearPaciente.TabIndex = 6;
            this.btnCrearPaciente.Text = "Crear Paciente";
            this.btnCrearPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PintarEstadoColumnas);
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPaciente.Image = global::Health32Meucci.Front.Properties.Resources._001_38;
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(607, 90);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(104, 37);
            this.btnBuscarPaciente.TabIndex = 5;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.numDocDataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn,
            this.TipoDoc,
            this.EstadoCivil,
            this.Sexo,
            this.Foto,
            this.Activo,
            this.NumReferencia});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.pacienteBEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 169);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 220);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // numDocDataGridViewTextBoxColumn
            // 
            this.numDocDataGridViewTextBoxColumn.DataPropertyName = "NumDoc";
            this.numDocDataGridViewTextBoxColumn.HeaderText = "NumDoc";
            this.numDocDataGridViewTextBoxColumn.Name = "numDocDataGridViewTextBoxColumn";
            // 
            // fechaNacDataGridViewTextBoxColumn
            // 
            this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac";
            this.fechaNacDataGridViewTextBoxColumn.HeaderText = "FechaNac";
            this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
            // 
            // TipoDoc
            // 
            this.TipoDoc.DataPropertyName = "TipoDoc";
            this.TipoDoc.HeaderText = "TipoDoc";
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.Visible = false;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.HeaderText = "EstadoCivil";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Visible = false;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.Visible = false;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.Visible = false;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.Visible = false;
            // 
            // NumReferencia
            // 
            this.NumReferencia.DataPropertyName = "NumReferencia";
            this.NumReferencia.HeaderText = "NumReferencia";
            this.NumReferencia.Name = "NumReferencia";
            this.NumReferencia.Visible = false;
            // 
            // pacienteBEBindingSource
            // 
            this.pacienteBEBindingSource.DataSource = typeof(Health32Meucci.Common.PacienteBE);
            // 
            // FrmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmBuscarPaciente";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Buscar Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pacienteBEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumReferencia;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}