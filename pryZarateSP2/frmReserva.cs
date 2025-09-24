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
        const int addedValue = 1;

        enum Precios
        {
            A = 20,
            B = 34,
            DailyValue = 1,
            TvValue = 2,
            KitchenValue = 1,
        };
        const float fridgevalue = 1.50f;



        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            lstTipo.Items.Clear();
            lstTipo.Items.Add("Tipo A");
            lstTipo.Items.Add("Tipo B");
            lstTipo.SelectedIndex = 0;
            numDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtNumero.Text = "";
            btnAceptar.Enabled = false;
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
        }
    }

