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
            components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
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
            panel3 = new Panel();
            panel4 = new Panel();
            txtTelefono = new MaskedTextBox();
            chkTelevisor = new CheckBox();
            chkCocina = new CheckBox();
            chkHeladera = new CheckBox();
            lblAdicionales = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            cmbTarjeta = new ComboBox();
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)numDias).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            guna2Transition1.SetDecoration(lblDias, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblPersonas, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblTipo, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblTipoCabaña, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblFormasPago, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblNombre, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblTitular, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblTelefono, Guna.UI2.AnimatorNS.DecorationType.None);
            lblTelefono.Font = new Font("Nirmala UI Semilight", 12F);
            lblTelefono.Location = new Point(43, 393);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.BurlyWood;
            guna2Transition1.SetDecoration(txtNombre, Guna.UI2.AnimatorNS.DecorationType.None);
            txtNombre.Location = new Point(127, 355);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 23);
            txtNombre.TabIndex = 10;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Tan;
            guna2Transition1.SetDecoration(btnAceptar, Guna.UI2.AnimatorNS.DecorationType.None);
            btnAceptar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(611, 479);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 47);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            guna2Transition1.SetDecoration(optEfectivo, Guna.UI2.AnimatorNS.DecorationType.None);
            optEfectivo.Font = new Font("Nirmala UI", 12F);
            optEfectivo.Location = new Point(258, 219);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(82, 25);
            optEfectivo.TabIndex = 16;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            guna2Transition1.SetDecoration(optTarjeta, Guna.UI2.AnimatorNS.DecorationType.None);
            optTarjeta.Font = new Font("Nirmala UI", 12F);
            optTarjeta.Location = new Point(258, 244);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(73, 25);
            optTarjeta.TabIndex = 17;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.BurlyWood;
            guna2Transition1.SetDecoration(cmbTipo, Guna.UI2.AnimatorNS.DecorationType.None);
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
            cmbPersonas.BackColor = Color.BurlyWood;
            guna2Transition1.SetDecoration(cmbPersonas, Guna.UI2.AnimatorNS.DecorationType.None);
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbPersonas.Location = new Point(369, 100);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(121, 23);
            cmbPersonas.TabIndex = 19;
            // 
            // numDias
            // 
            numDias.BackColor = Color.BurlyWood;
            guna2Transition1.SetDecoration(numDias, Guna.UI2.AnimatorNS.DecorationType.None);
            numDias.Location = new Point(575, 100);
            numDias.Name = "numDias";
            numDias.Size = new Size(120, 23);
            numDias.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.BlanchedAlmond;
            guna2Transition1.SetDecoration(panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            panel3.Location = new Point(32, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 117);
            panel3.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.BlanchedAlmond;
            panel4.Controls.Add(txtTelefono);
            guna2Transition1.SetDecoration(panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            panel4.Location = new Point(32, 334);
            panel4.Name = "panel4";
            panel4.Size = new Size(690, 117);
            panel4.TabIndex = 23;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.BurlyWood;
            guna2Transition1.SetDecoration(txtTelefono, Guna.UI2.AnimatorNS.DecorationType.None);
            txtTelefono.Location = new Point(95, 57);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(139, 23);
            txtTelefono.TabIndex = 0;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            guna2Transition1.SetDecoration(chkTelevisor, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(chkCocina, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(chkHeladera, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblAdicionales, Guna.UI2.AnimatorNS.DecorationType.None);
            lblAdicionales.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            lblAdicionales.Location = new Point(47, 183);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(113, 25);
            lblAdicionales.TabIndex = 5;
            lblAdicionales.Text = "Adicionales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            guna2Transition1.SetDecoration(panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            panel1.Location = new Point(32, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 120);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlanchedAlmond;
            panel2.Controls.Add(cmbTarjeta);
            guna2Transition1.SetDecoration(panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            panel2.Location = new Point(246, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 120);
            panel2.TabIndex = 1;
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.BackColor = Color.BurlyWood;
            guna2Transition1.SetDecoration(cmbTarjeta, Guna.UI2.AnimatorNS.DecorationType.None);
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Items.AddRange(new object[] { "Card Red", "Card Green", "Card Blue" });
            cmbTarjeta.Location = new Point(12, 78);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(121, 23);
            cmbTarjeta.TabIndex = 24;
            // 
            // guna2Transition1
            // 
            guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = (PointF)resources.GetObject("animation2.BlindCoeff");
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = (PointF)resources.GetObject("animation2.MosaicCoeff");
            animation2.MosaicShift = (PointF)resources.GetObject("animation2.MosaicShift");
            animation2.MosaicSize = 0;
            animation2.Padding = new Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = (PointF)resources.GetObject("animation2.ScaleCoeff");
            animation2.SlideCoeff = (PointF)resources.GetObject("animation2.SlideCoeff");
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            guna2Transition1.DefaultAnimation = animation2;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(760, 580);
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
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reserva cabañas";
            Load += frmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)numDias).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel3;
        private Panel panel4;
        private CheckBox chkTelevisor;
        private CheckBox chkCocina;
        private CheckBox chkHeladera;
        private Label lblAdicionales;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private MaskedTextBox txtTelefono;
        private ComboBox cmbTarjeta;
    }
}