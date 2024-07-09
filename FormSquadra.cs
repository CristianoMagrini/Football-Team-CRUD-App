using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Squadra
{
    public partial class FormSquadra : Form
    {
        private Squadra squadra;
        private string file;
        private bool dati;
        private BindingSource bsCalciatori = new BindingSource();

        public FormSquadra()
        {
            InitializeComponent();
        }

        private void FormSquadra_Load(object sender, EventArgs e)
        {
            dati = false;
            file = @".\Squadra.json";
            bsCalciatori = new BindingSource();
            lbCalciatori.DataSource = bsCalciatori;
            if (MessageBox.Show("Vuoi caricare i dati della squadra?", "Benvenuto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(file))
                {
                    try
                    {
                        squadra = Squadra.CaricaSquadra(file);
                        MostraSquadra();
                        MostraCalciatori();
                        bsCalciatori.DataSource = squadra.Calciatori;
                        MessageBox.Show("Dati caricati correttamente");
                        txtNomeS.ReadOnly = true;
                        txtCitta.ReadOnly = true;
                        txtAllenatore.ReadOnly = true;
                        txtFondazione.ReadOnly = true;
                        btnCreaS.Visible = false;
                        btnSalva.Visible = false;
                        btnEliminaS.Visible = true; 
                        btnValoreS.Visible = true;
                        btnEtaMedia.Visible = true;
                        pnlCalciatori.Visible = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Caricamento non andato a buon fine", "Errore");
                        txtNomeS.ReadOnly = false;
                        txtCitta.ReadOnly = false;
                        txtAllenatore.ReadOnly = false;
                        txtFondazione.ReadOnly = false;
                        btnCreaS.Visible = true;
                        btnSalva.Visible = false;
                        btnEliminaS.Visible = false;
                        btnValoreS.Visible = false;
                        btnEtaMedia.Visible = false;
                        pnlCalciatori.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("File salvataggio non presente", "Errore");
                    MessageBox.Show("Crea una nuova squadra");
                    btnSalva.Visible = false;
                    btnEliminaS.Visible = false;
                    btnValoreS.Visible = false;
                    btnEtaMedia.Visible = false;
                    pnlCalciatori.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Crea una nuova squadra");
                btnSalva.Visible = false;
                btnEliminaS.Visible = false;
                btnValoreS.Visible = false;
                btnEtaMedia.Visible = false;
                pnlCalciatori.Visible = false;
            }

            txtNomeC.ReadOnly = true;
            txtCognomeC.ReadOnly = true;
            txtEtaC.ReadOnly = true;
            txtRuoloC.ReadOnly = true;
            txtValoreC.ReadOnly = true;
            txtInfortunioC.ReadOnly = true;
            txtCalciatori.ReadOnly = true;
            txtPortieri.ReadOnly = true;
            txtDifensori.ReadOnly = true;
            txtCentrocampisti.ReadOnly = true;
            txtAttaccanti.ReadOnly = true;
        }

        private void MostraSquadra()
        {
            txtNomeS.Text = squadra.Nome;
            txtCitta.Text = squadra.Citta;
            txtAllenatore.Text = squadra.Allenatore;
            txtFondazione.Text = squadra.Fondazione.ToString();
        }

        private void MostraCalciatori()
        {
            txtCalciatori.Text = squadra.Calciatori.Count.ToString();
            txtPortieri.Text = squadra.Portieri().ToString();
            txtDifensori.Text = squadra.Difensori().ToString();
            txtCentrocampisti.Text = squadra.Centrocampisti().ToString();
            txtAttaccanti.Text = squadra.Attaccanti().ToString();
        }

        private void btnCreaS_Click(object sender, EventArgs e)
        {
            int fondazione;
            if(string.IsNullOrEmpty(txtNomeS.Text) || string.IsNullOrWhiteSpace(txtNomeS.Text) ||
               string.IsNullOrEmpty(txtCitta.Text) || string.IsNullOrWhiteSpace(txtCitta.Text) ||
               string.IsNullOrEmpty(txtAllenatore.Text) || string.IsNullOrWhiteSpace(txtAllenatore.Text) ||
               string.IsNullOrEmpty(txtFondazione.Text) || string.IsNullOrWhiteSpace(txtFondazione.Text))
            {
                MessageBox.Show("Dati non completi", "Errore");
            }
            else if(!int.TryParse(txtFondazione.Text, out fondazione) || fondazione < 0 || fondazione > DateTime.Now.Year)
            {
                MessageBox.Show("Anno di fondazione non valido", "Errore");
            }
            else
            {
                squadra = new Squadra(txtNomeS.Text, txtCitta.Text, txtAllenatore.Text, fondazione);
                MessageBox.Show("Squadra creata");
                txtNomeS.ReadOnly = true;
                txtCitta.ReadOnly = true;
                txtAllenatore.ReadOnly = true;
                txtFondazione.ReadOnly = true;
                btnCreaS.Visible = false;
                btnSalva.Visible = true;
                btnEliminaS.Visible = true;
                btnValoreS.Visible = true;
                btnEtaMedia.Visible = true;
                pnlCalciatori.Visible = true;
                MostraCalciatori();
                bsCalciatori.DataSource = squadra.Calciatori;
                dati = true;
            }
        }

        private void btnEliminaS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi eliminare la squadra?", "Eliminazione squadra", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                squadra = null;
                txtNomeS.Clear();
                txtCitta.Clear();
                txtAllenatore.Clear();
                txtFondazione.Clear();
                txtNomeS.ReadOnly = false;
                txtCitta.ReadOnly = false;
                txtAllenatore.ReadOnly = false;
                txtFondazione.ReadOnly = false;
                btnCreaS.Visible = true;
                btnSalva.Visible = true;
                btnEliminaS.Visible = false;
                btnValoreS.Visible = false;
                btnEtaMedia.Visible = false;
                pnlCalciatori.Visible = false;
                bsCalciatori.DataSource = null;
                MessageBox.Show("Squadra eliminata");
                dati = true;
            }
        }

        private void btnValoreS_Click(object sender, EventArgs e)
        {
            if(squadra.Calciatori.Count > 0)
            {
                MessageBox.Show($"Il valore della squadra è di {squadra.ValoreSquadra()} milioni");
            }
            else
            {
                MessageBox.Show($"Non ci sono calciatori nella squadra");
            }
        }

        private void btnEtaMedia_Click(object sender, EventArgs e)
        {
            if (squadra.Calciatori.Count > 0)
            {
                MessageBox.Show($"L'età media della squadra è {squadra.EtaMedia()} anni");
            }
            else
            {
                MessageBox.Show($"Non ci sono calciatori nella squadra");
            }
        }

        private void btnAggiungiC_Click(object sender, EventArgs e)
        {
            if(squadra != null)
            {
                using (FormCalciatore formC = new FormCalciatore())
                {
                    formC.ShowDialog(this);
                    if (formC.DialogResult == DialogResult.OK)
                    {
                        squadra.AggiungiCalciatore(formC.calciatore);
                        bsCalciatori.ResetBindings(false);
                        lbCalciatori.SelectedItem = null;
                        dati = true;
                        btnSalva.Visible = true;
                        btnEliminaS.Visible = true;
                        btnValoreS.Visible = true;
                        btnEtaMedia.Visible = true;
                        pnlCalciatori.Visible = true;
                        MostraCalciatori();                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Prima crea la squadra", "Errore");
            }
        }

        private void btnModificaC_Click(object sender, EventArgs e)
        {
            if (squadra != null)
            {
                if (lbCalciatori.SelectedIndex >= 0)
                {
                    Calciatore calciatore = (Calciatore)lbCalciatori.SelectedItem;
                    using (FormCalciatore formC = new FormCalciatore())
                    {
                        formC.calciatore = calciatore;
                        formC.ShowDialog(this);
                        if (formC.DialogResult == DialogResult.OK)
                        {
                            bsCalciatori.ResetCurrentItem();
                            lbCalciatori.SelectedItem = null;
                            dati = true;
                            btnSalva.Visible = true;
                            btnEliminaS.Visible = true;
                            btnValoreS.Visible = true;
                            btnEtaMedia.Visible = true;
                            pnlCalciatori.Visible = true;
                            MostraCalciatori();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleziona un calciatore");
                }
            }
            else
            {
                MessageBox.Show("Prima crea la squadra", "Errore");
            }
        }

        private void btnEliminaC_Click(object sender, EventArgs e)
        {
            if (squadra != null)
            {
                if (lbCalciatori.SelectedIndex >= 0)
                {
                    if (MessageBox.Show("Vuoi eliminare il calciatore?", "Eliminazione calciatore", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Calciatore calciatore = (Calciatore)lbCalciatori.SelectedItem;
                        squadra.Calciatori.Remove(calciatore);
                        bsCalciatori.ResetBindings(false);
                        MessageBox.Show("Calciatore eliminato");
                        lbCalciatori.SelectedItem = null;
                        dati = true;
                        btnSalva.Visible = true;
                        btnEliminaS.Visible = true;
                        btnValoreS.Visible = true;
                        btnEtaMedia.Visible = true;
                        pnlCalciatori.Visible = true;
                        MostraCalciatori();
                    }
                }
                else
                {
                    MessageBox.Show("Seleziona un calciatore");
                }
            }
            else
            {
                MessageBox.Show("Prima crea la squadra", "Errore");
            }
        }

        private void lbCalciatori_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbCalciatori.SelectedItem != null)
            {
                Calciatore calciatore = (Calciatore)lbCalciatori.SelectedItem;
                txtNomeC.Text = calciatore.Nome;
                txtCognomeC.Text = calciatore.Cognome;
                txtEtaC.Text = calciatore.Eta().ToString() + " anni";
                txtRuoloC.Text = calciatore.Ruolo;
                txtValoreC.Text = calciatore.Valore.ToString() + " milioni";
                txtInfortunioC.Text = calciatore.Stato();
            }
            else
            {
                txtNomeC.Clear();
                txtCognomeC.Clear();
                txtEtaC.Clear();
                txtRuoloC.Clear();
                txtValoreC.Clear();
                txtInfortunioC.Clear();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare la squadra?", "Salvataggio", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Squadra.SalvaSquadra(squadra, file);
                MessageBox.Show("Squadra salvata");
                btnSalva.Visible = false;
                dati = false;
            }
        }

        private void FormSqudra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dati)
            {
                if (MessageBox.Show("Vuoi uscire senza salvare?", "Chiusura applicazione", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else if (MessageBox.Show("Vuoi uscire?", "Chiusura applicazione", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
