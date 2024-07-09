using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squadra
{
    public partial class FormCalciatore : Form
    {
        public Calciatore calciatore;
        private bool ca;

        public FormCalciatore()
        {
            InitializeComponent();
        }

        private void FormCalciatore_Load(object sender, EventArgs e)
        {
            if(calciatore == null)
            {
                ca = true;
                txtNomeC.Clear();
                txtCognome.Clear();
                txtNascita.Clear();
                rbtnPortiere.Checked = false;
                rbtnDifensore.Checked = false;
                rbtnCentrocampista.Checked = false;
                rbtnAttaccante.Checked = false;
                txtValore.Clear();
                chkInfortunio.Checked = false;
            }
            else
            {
                ca = false;
                txtNomeC.Text = calciatore.Nome;
                txtCognome.Text = calciatore.Cognome;
                txtNascita.Text = calciatore.Nascita.ToString();
                if(calciatore.Ruolo == "Portiere")
                {
                    rbtnPortiere.Checked = true;
                    rbtnDifensore.Checked = false;
                    rbtnCentrocampista.Checked = false;
                    rbtnAttaccante.Checked = false;
                }
                else if(calciatore.Ruolo == "Difensore")
                {
                    rbtnPortiere.Checked = false;
                    rbtnDifensore.Checked = true;
                    rbtnCentrocampista.Checked = false;
                    rbtnAttaccante.Checked = false;
                }
                else if (calciatore.Ruolo == "Centrocampista")
                {
                    rbtnPortiere.Checked = false;
                    rbtnDifensore.Checked = false;
                    rbtnCentrocampista.Checked = true;
                    rbtnAttaccante.Checked = false;
                }
                else
                {
                    rbtnPortiere.Checked = false;
                    rbtnDifensore.Checked = false;
                    rbtnCentrocampista.Checked = false;
                    rbtnAttaccante.Checked = true;
                }
                txtValore.Text = calciatore.Valore.ToString();
                if (calciatore.Infortunio)
                {
                    chkInfortunio.Checked = true;
                }
                else
                {
                    chkInfortunio.Checked = false;
                }
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            int conta = 0;
            int nascita;
            string ruolo = "";
            int valore;
            bool infortunio = false;
            if (rbtnPortiere.Checked)
            {
                conta++;
                ruolo = "Portiere";
            }
            if (rbtnDifensore.Checked)
            {
                conta++;
                ruolo = "Difensore";
            }
            if (rbtnCentrocampista.Checked)
            {
                conta++;
                ruolo = "Centrocampista";
            }
            if (rbtnAttaccante.Checked)
            {
                conta++;
                ruolo = "Attaccante";
            }
            if (chkInfortunio.Checked)
            {
                infortunio = true;
            }
            else
            {
                infortunio = false;
            }
            if (string.IsNullOrEmpty(txtNomeC.Text) || string.IsNullOrWhiteSpace(txtNomeC.Text) ||
               string.IsNullOrEmpty(txtCognome.Text) || string.IsNullOrWhiteSpace(txtCognome.Text) ||
               string.IsNullOrEmpty(txtNascita.Text) || string.IsNullOrWhiteSpace(txtNascita.Text) ||
               string.IsNullOrEmpty(txtValore.Text) || string.IsNullOrWhiteSpace(txtValore.Text))
            {
                MessageBox.Show("Dati non completi", "Errore");
            }
            else if (conta != 1)
            {
                MessageBox.Show("Dati non completi", "Errore");
            }
            else if (!int.TryParse(txtNascita.Text, out nascita) || nascita < 0 || nascita >= DateTime.Now.Year)
            {
                MessageBox.Show("Anno di nascita non valido", "Errore");
            }
            else if (!int.TryParse(txtValore.Text, out valore) || valore <= 0)
            {
                MessageBox.Show("Valore di mercato non valido", "Errore");
            }
            else if (ca)
            {
                calciatore = new Calciatore(txtNomeC.Text, txtCognome.Text, nascita, ruolo, valore, infortunio);
                MessageBox.Show("Calciatore aggiunto");
                this.DialogResult = DialogResult.OK;
            }
            else if (!ca)
            {
                calciatore.Nome = txtNomeC.Text;
                calciatore.Cognome = txtCognome.Text;
                calciatore.Nascita = nascita;
                calciatore.Ruolo = ruolo;
                calciatore.Valore = valore;
                calciatore.Infortunio = infortunio;
                MessageBox.Show("Calciatore modificato");
                this.DialogResult = DialogResult.OK;
            }           
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
