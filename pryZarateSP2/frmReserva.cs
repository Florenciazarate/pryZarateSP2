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
                numDias.Value = 1;
                chkCocina.Checked = false;
                chkHeladera.Checked = false;
                chkTelevisor.Checked = false;
                optEfectivo.Checked = true;
                cmbTarjeta.Enabled = false;
                txtNombre.Text = "";
                mskTelefono.Text = "";
                cmbTarjeta.Items.Clear();
                cmbTarjeta.Items.Add("Card Red");
                cmbTarjeta.Items.Add("Card Green");
                cmbTarjeta.Items.Add("Card Blue");
                btnAceptar.Enabled = false;
            }

        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int I = 0;
                cmbPersonas.Items.Clear();
                if (cmbTipo.SelectedIndex == 0)
                {
                    for (I = 1; I <= 4; I++)
                    {
                        cmbPersonas.Items.Add(I);
                    }
                }
                else
                {
                    for (I = 1; I <= 8; I++)
                    {
                        cmbPersonas.Items.Add(I);
                    }
                }
                cmbPersonas.SelectedIndex = 0;
            }

        }
        private void optEfectivo_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbTarjeta.Enabled = false;
            cmbTarjeta.SelectedIndex = -1;
        }

        private void optTarjeta_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbTarjeta.Enabled = true;
            cmbTarjeta.SelectedIndex = 0;
        }

        private void numDias_ValueChanged(object sender, EventArgs e)
        {
            {
                if (numDias.Value != 0 &&
                txtNombre.Text != "" && mskTelefono.Text != "")
                {
                    btnAceptar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            {
                if (numDias.Value != 0 &&
                txtNombre.Text != "" && mskTelefono.Text != "")
                {
                    btnAceptar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                }
            }
        }

        private void mskTelefono_TextChanged(object sender, EventArgs e)
        {
            {
                if (numDias.Value != 0 &&
                txtNombre.Text != "" && mskTelefono.Text != "")
                {
                    btnAceptar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            float Total;
            if (cmbTipo.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase = TIPOB;
            }
            int Dias = (int)numDias.Value;            
            int Personas = int.Parse(cmbPersonas.Text);
            PrecioBase += PORPERSONA * Personas;
            Opcionales = 0;
            {
                Opcionales = Opcionales + COCINA;
            }
            if (chkHeladera.Checked == true)
            {
                Opcionales = Opcionales + HELADERA;
            }
            if (chkTelevisor.Checked == true)
            {
                Opcionales = Opcionales + TELEVISOR;
            }
            Total = (PrecioBase + Opcionales) * Dias;
            if (optTarjeta.Checked == true)
            {
                if (cmbTarjeta.SelectedIndex == 0)
                {
                    Recargo = Total * 10 / 100;
                }
                else
                {
                    Recargo = Total * 20 / 100;
                }
                Total = Total + Recargo;
            }
            MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbTipo.SelectedIndex = 0;
            numDias.Value = 1;
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            mskTelefono.Text = "";
        }

    }
}


