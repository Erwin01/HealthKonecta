namespace Health32Meucci.Front
{
    partial class FrmCrearPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Paciente = new System.Windows.Forms.TabPage();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.picPaciente = new System.Windows.Forms.PictureBox();
            this.dTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txtNumReferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ObraSocial = new System.Windows.Forms.TabPage();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.gvMutualesPaciente = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMutualDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numReferenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMutualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroAfiliadoMutualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mutualPacienteBEListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gvMutuales = new System.Windows.Forms.DataGridView();
            this.idMutualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exigeCoseguroDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutualBEListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.Paciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaciente)).BeginInit();
            this.ObraSocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMutualesPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualPacienteBEListBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMutuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualBEListBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(323, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alta de Paciente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Paciente);
            this.tabControl1.Controls.Add(this.ObraSocial);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(23, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 404);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Paciente
            // 
            this.Paciente.Controls.Add(this.lblEstado);
            this.Paciente.Controls.Add(this.label9);
            this.Paciente.Controls.Add(this.label8);
            this.Paciente.Controls.Add(this.cboSexo);
            this.Paciente.Controls.Add(this.picPaciente);
            this.Paciente.Controls.Add(this.dTPFechaNac);
            this.Paciente.Controls.Add(this.cmbEstadoCivil);
            this.Paciente.Controls.Add(this.label7);
            this.Paciente.Controls.Add(this.label6);
            this.Paciente.Controls.Add(this.txtNumDoc);
            this.Paciente.Controls.Add(this.cmbTipoDoc);
            this.Paciente.Controls.Add(this.label5);
            this.Paciente.Controls.Add(this.txtApellido);
            this.Paciente.Controls.Add(this.label4);
            this.Paciente.Controls.Add(this.txtNombre);
            this.Paciente.Controls.Add(this.label3);
            this.Paciente.Controls.Add(this.btnBuscarPaciente);
            this.Paciente.Controls.Add(this.txtNumReferencia);
            this.Paciente.Controls.Add(this.label2);
            this.Paciente.Location = new System.Drawing.Point(4, 22);
            this.Paciente.Name = "Paciente";
            this.Paciente.Padding = new System.Windows.Forms.Padding(3);
            this.Paciente.Size = new System.Drawing.Size(902, 378);
            this.Paciente.TabIndex = 0;
            this.Paciente.Text = "Paciente";
            this.Paciente.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(92, 295);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 13);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "label11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tipo Documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(252, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sexo:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(428, 288);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(244, 21);
            this.cboSexo.TabIndex = 19;
            // 
            // picPaciente
            // 
            this.picPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPaciente.Image = global::Health32Meucci.Front.Properties.Resources.none;
            this.picPaciente.InitialImage = global::Health32Meucci.Front.Properties.Resources.none;
            this.picPaciente.Location = new System.Drawing.Point(51, 182);
            this.picPaciente.Name = "picPaciente";
            this.picPaciente.Size = new System.Drawing.Size(131, 106);
            this.picPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaciente.TabIndex = 15;
            this.picPaciente.TabStop = false;
            this.picPaciente.Click += new System.EventHandler(this.picPaciente_Click);
            // 
            // dTPFechaNac
            // 
            this.dTPFechaNac.Location = new System.Drawing.Point(428, 219);
            this.dTPFechaNac.Name = "dTPFechaNac";
            this.dTPFechaNac.Size = new System.Drawing.Size(244, 20);
            this.dTPFechaNac.TabIndex = 14;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(428, 256);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(244, 21);
            this.cmbEstadoCivil.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado Civil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(428, 186);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(244, 20);
            this.txtNumDoc.TabIndex = 9;
            this.txtNumDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDoc_KeyPress);
            this.txtNumDoc.Leave += new System.EventHandler(this.txtNumDoc_Leave);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(428, 156);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(244, 21);
            this.cmbTipoDoc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Documento:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(428, 122);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(244, 20);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(428, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres:";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.Image = global::Health32Meucci.Front.Properties.Resources._001_38;
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(50, 101);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(140, 41);
            this.btnBuscarPaciente.TabIndex = 2;
            this.btnBuscarPaciente.Text = "Buscar Existente";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtNumReferencia
            // 
            this.txtNumReferencia.Enabled = false;
            this.txtNumReferencia.Location = new System.Drawing.Point(300, 39);
            this.txtNumReferencia.Name = "txtNumReferencia";
            this.txtNumReferencia.Size = new System.Drawing.Size(304, 20);
            this.txtNumReferencia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de Referencia Obligatoriamente Único";
            // 
            // ObraSocial
            // 
            this.ObraSocial.Controls.Add(this.lblPaciente);
            this.ObraSocial.Controls.Add(this.gvMutualesPaciente);
            this.ObraSocial.Controls.Add(this.btnAgregar);
            this.ObraSocial.Controls.Add(this.panel1);
            this.ObraSocial.Controls.Add(this.gvMutuales);
            this.ObraSocial.Location = new System.Drawing.Point(4, 22);
            this.ObraSocial.Name = "ObraSocial";
            this.ObraSocial.Padding = new System.Windows.Forms.Padding(3);
            this.ObraSocial.Size = new System.Drawing.Size(902, 378);
            this.ObraSocial.TabIndex = 1;
            this.ObraSocial.Text = "Obra Social";
            this.ObraSocial.UseVisualStyleBackColor = true;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(477, 49);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(134, 13);
            this.lblPaciente.TabIndex = 5;
            this.lblPaciente.Text = "Mutuales por Paciente";
            // 
            // gvMutualesPaciente
            // 
            this.gvMutualesPaciente.AutoGenerateColumns = false;
            this.gvMutualesPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMutualesPaciente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvMutualesPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvMutualesPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMutualesPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idMutualDataGridViewTextBoxColumn1,
            this.numReferenciaDataGridViewTextBoxColumn,
            this.nombreMutualDataGridViewTextBoxColumn,
            this.nroAfiliadoMutualDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.gvMutualesPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gvMutualesPaciente.DataSource = this.mutualPacienteBEListBindingSource;
            this.gvMutualesPaciente.Location = new System.Drawing.Point(459, 67);
            this.gvMutualesPaciente.Name = "gvMutualesPaciente";
            this.gvMutualesPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMutualesPaciente.Size = new System.Drawing.Size(434, 308);
            this.gvMutualesPaciente.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMutualDataGridViewTextBoxColumn1
            // 
            this.idMutualDataGridViewTextBoxColumn1.DataPropertyName = "Id_Mutual";
            this.idMutualDataGridViewTextBoxColumn1.HeaderText = "Id_Mutual";
            this.idMutualDataGridViewTextBoxColumn1.Name = "idMutualDataGridViewTextBoxColumn1";
            this.idMutualDataGridViewTextBoxColumn1.Visible = false;
            // 
            // numReferenciaDataGridViewTextBoxColumn
            // 
            this.numReferenciaDataGridViewTextBoxColumn.DataPropertyName = "NumReferencia";
            this.numReferenciaDataGridViewTextBoxColumn.HeaderText = "NumReferencia";
            this.numReferenciaDataGridViewTextBoxColumn.Name = "numReferenciaDataGridViewTextBoxColumn";
            this.numReferenciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreMutualDataGridViewTextBoxColumn
            // 
            this.nombreMutualDataGridViewTextBoxColumn.DataPropertyName = "NombreMutual";
            this.nombreMutualDataGridViewTextBoxColumn.HeaderText = "Mutual";
            this.nombreMutualDataGridViewTextBoxColumn.Name = "nombreMutualDataGridViewTextBoxColumn";
            // 
            // nroAfiliadoMutualDataGridViewTextBoxColumn
            // 
            this.nroAfiliadoMutualDataGridViewTextBoxColumn.DataPropertyName = "NroAfiliadoMutual";
            this.nroAfiliadoMutualDataGridViewTextBoxColumn.HeaderText = "Id Afiliado Mutual";
            this.nroAfiliadoMutualDataGridViewTextBoxColumn.Name = "nroAfiliadoMutualDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // mutualPacienteBEListBindingSource
            // 
            this.mutualPacienteBEListBindingSource.DataSource = typeof(Health32Meucci.Common.MutualPacienteBEList);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Health32Meucci.Front.Properties.Resources._001_59;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(370, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 33);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVaciar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnVaciar
            // 
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Location = new System.Drawing.Point(267, 11);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(71, 21);
            this.btnVaciar.TabIndex = 2;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(189, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 21);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 0;
            // 
            // gvMutuales
            // 
            this.gvMutuales.AutoGenerateColumns = false;
            this.gvMutuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMutuales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvMutuales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvMutuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMutuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMutualDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.exigeCoseguroDataGridViewCheckBoxColumn,
            this.cUITDataGridViewTextBoxColumn});
            this.gvMutuales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gvMutuales.DataSource = this.mutualBEListBindingSource;
            this.gvMutuales.Location = new System.Drawing.Point(7, 67);
            this.gvMutuales.Name = "gvMutuales";
            this.gvMutuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMutuales.Size = new System.Drawing.Size(356, 308);
            this.gvMutuales.TabIndex = 0;
            // 
            // idMutualDataGridViewTextBoxColumn
            // 
            this.idMutualDataGridViewTextBoxColumn.DataPropertyName = "IdMutual";
            this.idMutualDataGridViewTextBoxColumn.HeaderText = "Mutual";
            this.idMutualDataGridViewTextBoxColumn.Name = "idMutualDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // exigeCoseguroDataGridViewCheckBoxColumn
            // 
            this.exigeCoseguroDataGridViewCheckBoxColumn.DataPropertyName = "ExigeCoseguro";
            this.exigeCoseguroDataGridViewCheckBoxColumn.HeaderText = "ExigeCoseguro";
            this.exigeCoseguroDataGridViewCheckBoxColumn.Name = "exigeCoseguroDataGridViewCheckBoxColumn";
            this.exigeCoseguroDataGridViewCheckBoxColumn.Visible = false;
            // 
            // cUITDataGridViewTextBoxColumn
            // 
            this.cUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT";
            this.cUITDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cUITDataGridViewTextBoxColumn.Name = "cUITDataGridViewTextBoxColumn";
            this.cUITDataGridViewTextBoxColumn.Visible = false;
            // 
            // mutualBEListBindingSource
            // 
            this.mutualBEListBindingSource.DataSource = typeof(Health32Meucci.Common.MutualBEList);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(902, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Medio de Contacto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Health32Meucci.Front.Properties.Resources._001_59;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(677, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 29);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Health32Meucci.Front.Properties.Resources._001_43;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(744, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nueva OS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(28, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 34);
            this.panel2.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Health32Meucci.Front.Properties.Resources._001_05;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(802, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 29);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCrearPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(946, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FrmCrearPaciente";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Crear Paciente";
            this.Load += new System.EventHandler(this.crearPaciente_Load);
            this.tabControl1.ResumeLayout(false);
            this.Paciente.ResumeLayout(false);
            this.Paciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaciente)).EndInit();
            this.ObraSocial.ResumeLayout(false);
            this.ObraSocial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMutualesPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualPacienteBEListBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMutuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualBEListBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Paciente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox picPaciente;
        private System.Windows.Forms.DateTimePicker dTPFechaNac;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.TextBox txtNumReferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ObraSocial;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.DataGridView gvMutualesPaciente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gvMutuales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource mutualBEListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMutualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exigeCoseguroDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMutualDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numReferenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMutualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroAfiliadoMutualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource mutualPacienteBEListBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}