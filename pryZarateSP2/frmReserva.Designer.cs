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
            txtTelefono = new TextBox();
            btnAceptar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chkEfectivo = new RadioButton();
            chkTarjeta = new RadioButton();
            lstTipo = new ComboBox();
            lstPersonas = new ComboBox();
            numDias = new NumericUpDown();
            panel3 = new Panel();
            panel4 = new Panel();
            chkTelevisor = new CheckBox();
            chkCocina = new CheckBox();
            chkHeladera = new CheckBox();
            lblAdicionales = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numDias).BeginInit();
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
            lblFormasPago.Location = new Point(256, 194);
            lblFormasPago.Name = "lblFormasPago";
            lblFormasPago.Size = new Size(155, 25);
            lblFormasPago.TabIndex = 6;
            lblFormasPago.Text = "Formas de pago";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Nirmala UI Semilight", 12F);
            lblNombre.Location = new Point(43, 366);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 21);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            lblTitular.Location = new Point(43, 331);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(187, 25);
            lblTitular.TabIndex = 8;
            lblTitular.Text = "Titular de la reserva";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Nirmala UI Semilight", 12F);
            lblTelefono.Location = new Point(43, 404);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.BurlyWood;
            txtNombre.Location = new Point(127, 366);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.BurlyWood;
            txtTelefono.Location = new Point(127, 404);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(295, 23);
            txtTelefono.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.SandyBrown;
            btnAceptar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(611, 479);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 47);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Font = new Font("Nirmala UI", 12F);
            chkEfectivo.Location = new Point(258, 230);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(82, 25);
            chkEfectivo.TabIndex = 16;
            chkEfectivo.TabStop = true;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkTarjeta
            // 
            chkTarjeta.AutoSize = true;
            chkTarjeta.Font = new Font("Nirmala UI", 12F);
            chkTarjeta.Location = new Point(258, 255);
            chkTarjeta.Name = "chkTarjeta";
            chkTarjeta.Size = new Size(73, 25);
            chkTarjeta.TabIndex = 17;
            chkTarjeta.TabStop = true;
            chkTarjeta.Text = "Tarjeta";
            chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // lstTipo
            // 
            lstTipo.BackColor = Color.BurlyWood;
            lstTipo.FormattingEnabled = true;
            lstTipo.Items.AddRange(new object[] { "A", "B" });
            lstTipo.Location = new Point(109, 100);
            lstTipo.Name = "lstTipo";
            lstTipo.Size = new Size(121, 23);
            lstTipo.TabIndex = 18;
            // 
            // lstPersonas
            // 
            lstPersonas.BackColor = Color.BurlyWood;
            lstPersonas.FormattingEnabled = true;
            lstPersonas.Location = new Point(369, 100);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(121, 23);
            lstPersonas.TabIndex = 19;
            // 
            // numDias
            // 
            numDias.BackColor = Color.BurlyWood;
            numDias.Location = new Point(575, 100);
            numDias.Name = "numDias";
            numDias.Size = new Size(120, 23);
            numDias.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Location = new Point(32, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 117);
            panel3.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.Location = new Point(32, 345);
            panel4.Name = "panel4";
            panel4.Size = new Size(690, 117);
            panel4.TabIndex = 23;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTelevisor.Location = new Point(47, 286);
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
            chkCocina.Location = new Point(47, 224);
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
            chkHeladera.Location = new Point(47, 255);
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
            lblAdicionales.Location = new Point(47, 194);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(113, 25);
            lblAdicionales.TabIndex = 5;
            lblAdicionales.Text = "Adicionales";
            // 
            // panel1
            // 
            panel1.Location = new Point(32, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 120);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(246, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 120);
            panel2.TabIndex = 1;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(760, 580);
            Controls.Add(lblAdicionales);
            Controls.Add(chkHeladera);
            Controls.Add(chkCocina);
            Controls.Add(numDias);
            Controls.Add(chkTelevisor);
            Controls.Add(lstPersonas);
            Controls.Add(lstTipo);
            Controls.Add(chkTarjeta);
            Controls.Add(chkEfectivo);
            Controls.Add(btnAceptar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblTitular);
            Controls.Add(lblNombre);
            Controls.Add(lblFormasPago);
            Controls.Add(lblTipoCabaña);
            Controls.Add(lblTipo);
            Controls.Add(lblPersonas);
            Controls.Add(lblDias);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reserva cabañas";
            Load += frmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)numDias).EndInit();
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
        private TextBox txtTelefono;
        private Button btnAceptar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton chkEfectivo;
        private RadioButton chkTarjeta;
        private ComboBox lstTipo;
        private ComboBox lstPersonas;
        private NumericUpDown numDias;
        private Panel panel3;
        private Panel panel4;
        private CheckBox chkTelevisor;
        private CheckBox chkCocina;
        private CheckBox chkHeladera;
        private Label lblAdicionales;
        private Panel panel1;
        private Panel panel2;
    }
}