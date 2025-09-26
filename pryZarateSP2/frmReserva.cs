using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateSP2
{
    public partial class frmReserva : Form
    {
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;



        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            {
                cmbTipo.Items.Clear();
                cmbTipo.Items.Add("Tipo A");
                cmbTipo.Items.Add("Tipo B");
                cmbTipo.SelectedIndex = 0;
                numDias.Value= 1;
                chkCocina.Checked = false;
                chkHeladera.Checked = false;
                chkTelevisor.Checked = false;
                optEfectivo.Checked = true;
                txtNombre.Text = "";
                txtTelefono.Text = "";
                cmbTarjeta.Items.Clear();
                cmbTarjeta.Items.Add("Card Red");
                cmbTarjeta.Items.Add("Card Green");
                cmbTarjeta.Items.Add("Card Blue");
                btnAceptar.Enabled = false;
            }

        }

        private void txtDiastxtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                //lblNumero.Text = "soy un numero";
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //lblNumero.Text = "otra cosa...";
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

