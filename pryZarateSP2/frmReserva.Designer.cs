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
            txtDiastxtDias = new TextBox();
            lblDias = new Label();
            lblPersonas = new Label();
            lblTipo = new Label();
            lblTipoCabaña = new Label();
            lblAdicionales = new Label();
            lblFormasPago = new Label();
            lblNombre = new Label();
            lblTitular = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            btnAceptar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // txtDiastxtDias
            // 
            txtDiastxtDias.BackColor = Color.BurlyWood;
            txtDiastxtDias.Location = new Point(575, 98);
            txtDiastxtDias.Name = "txtDiastxtDias";
            txtDiastxtDias.Size = new Size(100, 23);
            txtDiastxtDias.TabIndex = 0;
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
            lblPersonas.Location = new Point(283, 98);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(71, 21);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Nirmala UI Semilight", 12F);
            lblTipo.Location = new Point(43, 98);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 21);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            // 
            // lblTipoCabaña
            // 
            lblTipoCabaña.AutoSize = true;
            lblTipoCabaña.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            lblTipoCabaña.Location = new Point(43, 35);
            lblTipoCabaña.Name = "lblTipoCabaña";
            lblTipoCabaña.Size = new Size(147, 25);
            lblTipoCabaña.TabIndex = 4;
            lblTipoCabaña.Text = "Tipo de cabaña";
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Font = new Font("Nirmala UI Semilight", 12F);
            lblAdicionales.Location = new Point(43, 164);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(89, 21);
            lblAdicionales.TabIndex = 5;
            lblAdicionales.Text = "Adicionales";
            // 
            // lblFormasPago
            // 
            lblFormasPago.AutoSize = true;
            lblFormasPago.Font = new Font("Nirmala UI Semilight", 12F);
            lblFormasPago.Location = new Point(234, 164);
            lblFormasPago.Name = "lblFormasPago";
            lblFormasPago.Size = new Size(120, 21);
            lblFormasPago.TabIndex = 6;
            lblFormasPago.Text = "Formas de pago";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Nirmala UI Semilight", 12F);
            lblNombre.Location = new Point(43, 302);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 21);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            lblTitular.Location = new Point(43, 267);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(187, 25);
            lblTitular.TabIndex = 8;
            lblTitular.Text = "Titular de la reserva";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Nirmala UI Semilight", 12F);
            lblTelefono.Location = new Point(43, 340);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.BurlyWood;
            txtNombre.Location = new Point(127, 302);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.BurlyWood;
            txtTelefono.Location = new Point(127, 340);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(295, 23);
            txtTelefono.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Peru;
            btnAceptar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(564, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 47);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 519);
            Controls.Add(btnAceptar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblTitular);
            Controls.Add(lblNombre);
            Controls.Add(lblFormasPago);
            Controls.Add(lblAdicionales);
            Controls.Add(lblTipoCabaña);
            Controls.Add(lblTipo);
            Controls.Add(lblPersonas);
            Controls.Add(lblDias);
            Controls.Add(txtDiastxtDias);
            Name = "frmReserva";
            Text = "frmReserva";
            Load += frmReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiastxtDias;
        private Label lblDias;
        private Label lblPersonas;
        private Label lblTipo;
        private Label lblTipoCabaña;
        private Label lblAdicionales;
        private Label lblFormasPago;
        private Label lblNombre;
        private Label lblTitular;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Button btnAceptar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}