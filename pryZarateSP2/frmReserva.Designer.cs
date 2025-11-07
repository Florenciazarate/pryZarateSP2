namespace pryZarateSP2
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            lblDias = new Label();
            lblPersonas = new Label();
            lblTipo = new Label();
            lblTipoCabaña = new Label();
            lblFormasPago = new Label();
            lblNombre = new Label();
            lblTitular = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            optEfectivo = new RadioButton();
            optTarjeta = new RadioButton();
            cmbTipo = new ComboBox();
            cmbPersonas = new ComboBox();
            numDias = new NumericUpDown();
            chkTelevisor = new CheckBox();
            chkCocina = new CheckBox();
            chkHeladera = new CheckBox();
            lblAdicionales = new Label();
            cmbTarjeta = new ComboBox();
            mskTelefono = new MaskedTextBox();
            dgvDatos = new DataGridView();
            colTipoCabaña = new DataGridViewTextBoxColumn();
            colPersonas = new DataGridViewTextBoxColumn();
            colDias = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numDias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Nirmala UI Semilight", 12F);
            lblDias.Location = new Point(529, 101);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(40, 21);
            lblDias.TabIndex = 1;
            lblDias.Text = "Dias";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Font = new Font("Nirmala UI Semilight", 12F);
            lblPersonas.Location = new Point(283, 100);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(71, 21);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Nirmala UI Semilight", 12F);
            lblTipo.Location = new Point(43, 100);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 21);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            // 
            // lblTipoCabaña
            // 
            lblTipoCabaña.AutoSize = true;
            lblTipoCabaña.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoCabaña.Location = new Point(41, 39);
            lblTipoCabaña.Name = "lblTipoCabaña";
            lblTipoCabaña.Size = new Size(188, 32);
            lblTipoCabaña.TabIndex = 4;
            lblTipoCabaña.Text = "Tipo de cabaña";
            // 
            // lblFormasPago
            // 
            lblFormasPago.AutoSize = true;
            lblFormasPago.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            lblFormasPago.Location = new Point(256, 183);
            lblFormasPago.Name = "lblFormasPago";
            lblFormasPago.Size = new Size(155, 25);
            lblFormasPago.TabIndex = 6;
            lblFormasPago.Text = "Formas de pago";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Nirmala UI Semilight", 12F);
            lblNombre.Location = new Point(43, 355);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 21);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            lblTitular.Location = new Point(43, 320);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(187, 25);
            lblTitular.TabIndex = 8;
            lblTitular.Text = "Titular de la reserva";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Nirmala UI Semilight", 12F);
            lblTelefono.Location = new Point(43, 393);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Bisque;
            txtNombre.Location = new Point(127, 355);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 23);
            txtNombre.TabIndex = 10;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Orange;
            btnAceptar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(584, 475);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 47);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Font = new Font("Nirmala UI", 12F);
            optEfectivo.Location = new Point(258, 219);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(82, 25);
            optEfectivo.TabIndex = 16;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged_1;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Font = new Font("Nirmala UI", 12F);
            optTarjeta.Location = new Point(258, 244);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(73, 25);
            optTarjeta.TabIndex = 17;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged_1;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.Bisque;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "A", "B" });
            cmbTipo.Location = new Point(109, 100);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 18;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // cmbPersonas
            // 
            cmbPersonas.BackColor = Color.Bisque;
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbPersonas.Location = new Point(369, 100);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(121, 23);
            cmbPersonas.TabIndex = 19;
            // 
            // numDias
            // 
            numDias.BackColor = Color.Bisque;
            numDias.Location = new Point(575, 100);
            numDias.Name = "numDias";
            numDias.Size = new Size(120, 23);
            numDias.TabIndex = 20;
            numDias.ValueChanged += numDias_ValueChanged;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTelevisor.Location = new Point(47, 275);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(89, 25);
            chkTelevisor.TabIndex = 15;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkCocina.Location = new Point(47, 213);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(76, 25);
            chkCocina.TabIndex = 13;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHeladera.Location = new Point(47, 244);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(91, 25);
            chkHeladera.TabIndex = 14;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            lblAdicionales.Location = new Point(47, 183);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(113, 25);
            lblAdicionales.TabIndex = 5;
            lblAdicionales.Text = "Adicionales";
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.BackColor = Color.Bisque;
            cmbTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Items.AddRange(new object[] { "Card Red", "Card Green", "Card Blue" });
            cmbTarjeta.Location = new Point(258, 278);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(121, 23);
            cmbTarjeta.TabIndex = 24;
            // 
            // mskTelefono
            // 
            mskTelefono.BackColor = Color.Bisque;
            mskTelefono.Location = new Point(130, 395);
            mskTelefono.Mask = "000-000-0000";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(100, 23);
            mskTelefono.TabIndex = 25;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colTipoCabaña, colPersonas, colDias });
            dgvDatos.Location = new Point(719, 101);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(308, 421);
            dgvDatos.TabIndex = 26;
            // 
            // colTipoCabaña
            // 
            colTipoCabaña.HeaderText = "Tipo cabaña";
            colTipoCabaña.Name = "colTipoCabaña";
            colTipoCabaña.ReadOnly = true;
            // 
            // colPersonas
            // 
            colPersonas.HeaderText = "Personas";
            colPersonas.Name = "colPersonas";
            colPersonas.ReadOnly = true;
            // 
            // colDias
            // 
            colDias.HeaderText = "Dias";
            colDias.Name = "colDias";
            colDias.ReadOnly = true;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1039, 580);
            Controls.Add(dgvDatos);
            Controls.Add(mskTelefono);
            Controls.Add(cmbTarjeta);
            Controls.Add(lblAdicionales);
            Controls.Add(chkHeladera);
            Controls.Add(chkCocina);
            Controls.Add(numDias);
            Controls.Add(chkTelevisor);
            Controls.Add(cmbPersonas);
            Controls.Add(cmbTipo);
            Controls.Add(optTarjeta);
            Controls.Add(optEfectivo);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblTitular);
            Controls.Add(lblNombre);
            Controls.Add(lblFormasPago);
            Controls.Add(lblTipoCabaña);
            Controls.Add(lblTipo);
            Controls.Add(lblPersonas);
            Controls.Add(lblDias);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reserva cabañas";
            Load += frmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)numDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDias;
        private Label lblPersonas;
        private Label lblTipo;
        private Label lblTipoCabaña;
        private Label lblFormasPago;
        private Label lblNombre;
        private Label lblTitular;
        private Label lblTelefono;
        private TextBox txtNombre;
        private Button btnAceptar;
        private RadioButton optEfectivo;
        private RadioButton optTarjeta;
        private ComboBox cmbTipo;
        private ComboBox cmbPersonas;
        private NumericUpDown numDias;
        private CheckBox chkTelevisor;
        private CheckBox chkCocina;
        private CheckBox chkHeladera;
        private Label lblAdicionales;
        private ComboBox cmbTarjeta;
        private MaskedTextBox mskTelefono;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colTipoCabaña;
        private DataGridViewTextBoxColumn colPersonas;
        private DataGridViewTextBoxColumn colDias;
    }
}