namespace Squadra
{
    partial class FormSquadra
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSquadra = new System.Windows.Forms.TabControl();
            this.tabDatiS = new System.Windows.Forms.TabPage();
            this.btnEliminaS = new System.Windows.Forms.Button();
            this.btnCreaS = new System.Windows.Forms.Button();
            this.lblNomeS = new System.Windows.Forms.Label();
            this.txtFondazione = new System.Windows.Forms.TextBox();
            this.txtAllenatore = new System.Windows.Forms.TextBox();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.txtNomeS = new System.Windows.Forms.TextBox();
            this.lblFondazione = new System.Windows.Forms.Label();
            this.lblAllenatore = new System.Windows.Forms.Label();
            this.lblCitta = new System.Windows.Forms.Label();
            this.tabDatiC = new System.Windows.Forms.TabPage();
            this.lblInfortunioC = new System.Windows.Forms.Label();
            this.txtInfortunioC = new System.Windows.Forms.TextBox();
            this.lblValoreC = new System.Windows.Forms.Label();
            this.txtValoreC = new System.Windows.Forms.TextBox();
            this.lblRuoloC = new System.Windows.Forms.Label();
            this.txtRuoloC = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.txtEtaC = new System.Windows.Forms.TextBox();
            this.lblCognomeC = new System.Windows.Forms.Label();
            this.txtCognomeC = new System.Windows.Forms.TextBox();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.btnEliminaC = new System.Windows.Forms.Button();
            this.btnModificaC = new System.Windows.Forms.Button();
            this.btnAggiungiC = new System.Windows.Forms.Button();
            this.lbCalciatori = new System.Windows.Forms.ListBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnValoreS = new System.Windows.Forms.Button();
            this.btnEtaMedia = new System.Windows.Forms.Button();
            this.lblCalciatori = new System.Windows.Forms.Label();
            this.txtCalciatori = new System.Windows.Forms.TextBox();
            this.lblPortieri = new System.Windows.Forms.Label();
            this.txtPortieri = new System.Windows.Forms.TextBox();
            this.lblDifensori = new System.Windows.Forms.Label();
            this.txtDifensori = new System.Windows.Forms.TextBox();
            this.lblCentrocampisti = new System.Windows.Forms.Label();
            this.txtCentrocampisti = new System.Windows.Forms.TextBox();
            this.lblAttaccanti = new System.Windows.Forms.Label();
            this.txtAttaccanti = new System.Windows.Forms.TextBox();
            this.pnlCalciatori = new System.Windows.Forms.Panel();
            this.tabSquadra.SuspendLayout();
            this.tabDatiS.SuspendLayout();
            this.tabDatiC.SuspendLayout();
            this.pnlCalciatori.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSquadra
            // 
            this.tabSquadra.Controls.Add(this.tabDatiS);
            this.tabSquadra.Controls.Add(this.tabDatiC);
            this.tabSquadra.Location = new System.Drawing.Point(19, 17);
            this.tabSquadra.Margin = new System.Windows.Forms.Padding(4);
            this.tabSquadra.Name = "tabSquadra";
            this.tabSquadra.SelectedIndex = 0;
            this.tabSquadra.Size = new System.Drawing.Size(614, 396);
            this.tabSquadra.TabIndex = 0;
            // 
            // tabDatiS
            // 
            this.tabDatiS.Controls.Add(this.pnlCalciatori);
            this.tabDatiS.Controls.Add(this.btnEtaMedia);
            this.tabDatiS.Controls.Add(this.btnValoreS);
            this.tabDatiS.Controls.Add(this.btnCreaS);
            this.tabDatiS.Controls.Add(this.btnEliminaS);
            this.tabDatiS.Controls.Add(this.lblNomeS);
            this.tabDatiS.Controls.Add(this.txtFondazione);
            this.tabDatiS.Controls.Add(this.txtAllenatore);
            this.tabDatiS.Controls.Add(this.txtCitta);
            this.tabDatiS.Controls.Add(this.txtNomeS);
            this.tabDatiS.Controls.Add(this.lblFondazione);
            this.tabDatiS.Controls.Add(this.lblAllenatore);
            this.tabDatiS.Controls.Add(this.lblCitta);
            this.tabDatiS.Location = new System.Drawing.Point(4, 25);
            this.tabDatiS.Margin = new System.Windows.Forms.Padding(4);
            this.tabDatiS.Name = "tabDatiS";
            this.tabDatiS.Padding = new System.Windows.Forms.Padding(4);
            this.tabDatiS.Size = new System.Drawing.Size(606, 367);
            this.tabDatiS.TabIndex = 0;
            this.tabDatiS.Text = "Dati squadra";
            this.tabDatiS.UseVisualStyleBackColor = true;
            // 
            // btnEliminaS
            // 
            this.btnEliminaS.Location = new System.Drawing.Point(170, 287);
            this.btnEliminaS.Name = "btnEliminaS";
            this.btnEliminaS.Size = new System.Drawing.Size(118, 50);
            this.btnEliminaS.TabIndex = 12;
            this.btnEliminaS.Text = "Elimina squadra";
            this.btnEliminaS.UseVisualStyleBackColor = true;
            this.btnEliminaS.Click += new System.EventHandler(this.btnEliminaS_Click);
            // 
            // btnCreaS
            // 
            this.btnCreaS.Location = new System.Drawing.Point(30, 287);
            this.btnCreaS.Name = "btnCreaS";
            this.btnCreaS.Size = new System.Drawing.Size(118, 50);
            this.btnCreaS.TabIndex = 11;
            this.btnCreaS.Text = "Crea squadra";
            this.btnCreaS.UseVisualStyleBackColor = true;
            this.btnCreaS.Click += new System.EventHandler(this.btnCreaS_Click);
            // 
            // lblNomeS
            // 
            this.lblNomeS.AutoSize = true;
            this.lblNomeS.Location = new System.Drawing.Point(27, 38);
            this.lblNomeS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeS.Name = "lblNomeS";
            this.lblNomeS.Size = new System.Drawing.Size(44, 16);
            this.lblNomeS.TabIndex = 10;
            this.lblNomeS.Text = "Nome";
            // 
            // txtFondazione
            // 
            this.txtFondazione.Location = new System.Drawing.Point(156, 220);
            this.txtFondazione.Margin = new System.Windows.Forms.Padding(4);
            this.txtFondazione.Name = "txtFondazione";
            this.txtFondazione.Size = new System.Drawing.Size(132, 22);
            this.txtFondazione.TabIndex = 9;
            // 
            // txtAllenatore
            // 
            this.txtAllenatore.Location = new System.Drawing.Point(103, 155);
            this.txtAllenatore.Margin = new System.Windows.Forms.Padding(4);
            this.txtAllenatore.Name = "txtAllenatore";
            this.txtAllenatore.Size = new System.Drawing.Size(132, 22);
            this.txtAllenatore.TabIndex = 8;
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(68, 93);
            this.txtCitta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(132, 22);
            this.txtCitta.TabIndex = 7;
            // 
            // txtNomeS
            // 
            this.txtNomeS.Location = new System.Drawing.Point(79, 35);
            this.txtNomeS.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeS.Name = "txtNomeS";
            this.txtNomeS.Size = new System.Drawing.Size(132, 22);
            this.txtNomeS.TabIndex = 6;
            // 
            // lblFondazione
            // 
            this.lblFondazione.AutoSize = true;
            this.lblFondazione.Location = new System.Drawing.Point(27, 223);
            this.lblFondazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFondazione.Name = "lblFondazione";
            this.lblFondazione.Size = new System.Drawing.Size(121, 16);
            this.lblFondazione.TabIndex = 3;
            this.lblFondazione.Text = "Anno di fondazione";
            // 
            // lblAllenatore
            // 
            this.lblAllenatore.AutoSize = true;
            this.lblAllenatore.Location = new System.Drawing.Point(27, 158);
            this.lblAllenatore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllenatore.Name = "lblAllenatore";
            this.lblAllenatore.Size = new System.Drawing.Size(68, 16);
            this.lblAllenatore.TabIndex = 2;
            this.lblAllenatore.Text = "Allenatore";
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(27, 96);
            this.lblCitta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(33, 16);
            this.lblCitta.TabIndex = 1;
            this.lblCitta.Text = "Città";
            // 
            // tabDatiC
            // 
            this.tabDatiC.Controls.Add(this.lblInfortunioC);
            this.tabDatiC.Controls.Add(this.txtInfortunioC);
            this.tabDatiC.Controls.Add(this.lblValoreC);
            this.tabDatiC.Controls.Add(this.txtValoreC);
            this.tabDatiC.Controls.Add(this.lblRuoloC);
            this.tabDatiC.Controls.Add(this.txtRuoloC);
            this.tabDatiC.Controls.Add(this.lblEta);
            this.tabDatiC.Controls.Add(this.txtEtaC);
            this.tabDatiC.Controls.Add(this.lblCognomeC);
            this.tabDatiC.Controls.Add(this.txtCognomeC);
            this.tabDatiC.Controls.Add(this.lblNomeC);
            this.tabDatiC.Controls.Add(this.txtNomeC);
            this.tabDatiC.Controls.Add(this.btnEliminaC);
            this.tabDatiC.Controls.Add(this.btnModificaC);
            this.tabDatiC.Controls.Add(this.btnAggiungiC);
            this.tabDatiC.Controls.Add(this.lbCalciatori);
            this.tabDatiC.Location = new System.Drawing.Point(4, 25);
            this.tabDatiC.Name = "tabDatiC";
            this.tabDatiC.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatiC.Size = new System.Drawing.Size(606, 367);
            this.tabDatiC.TabIndex = 1;
            this.tabDatiC.Text = "Dati calciatori";
            this.tabDatiC.UseVisualStyleBackColor = true;
            // 
            // lblInfortunioC
            // 
            this.lblInfortunioC.AutoSize = true;
            this.lblInfortunioC.Location = new System.Drawing.Point(355, 324);
            this.lblInfortunioC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfortunioC.Name = "lblInfortunioC";
            this.lblInfortunioC.Size = new System.Drawing.Size(81, 16);
            this.lblInfortunioC.TabIndex = 26;
            this.lblInfortunioC.Text = "Stato attuale";
            // 
            // txtInfortunioC
            // 
            this.txtInfortunioC.Location = new System.Drawing.Point(444, 321);
            this.txtInfortunioC.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfortunioC.Name = "txtInfortunioC";
            this.txtInfortunioC.Size = new System.Drawing.Size(132, 22);
            this.txtInfortunioC.TabIndex = 25;
            // 
            // lblValoreC
            // 
            this.lblValoreC.AutoSize = true;
            this.lblValoreC.Location = new System.Drawing.Point(355, 270);
            this.lblValoreC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValoreC.Name = "lblValoreC";
            this.lblValoreC.Size = new System.Drawing.Size(47, 16);
            this.lblValoreC.TabIndex = 24;
            this.lblValoreC.Text = "Valore";
            // 
            // txtValoreC
            // 
            this.txtValoreC.Location = new System.Drawing.Point(410, 267);
            this.txtValoreC.Margin = new System.Windows.Forms.Padding(4);
            this.txtValoreC.Name = "txtValoreC";
            this.txtValoreC.Size = new System.Drawing.Size(132, 22);
            this.txtValoreC.TabIndex = 23;
            // 
            // lblRuoloC
            // 
            this.lblRuoloC.AutoSize = true;
            this.lblRuoloC.Location = new System.Drawing.Point(355, 211);
            this.lblRuoloC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuoloC.Name = "lblRuoloC";
            this.lblRuoloC.Size = new System.Drawing.Size(43, 16);
            this.lblRuoloC.TabIndex = 22;
            this.lblRuoloC.Text = "Ruolo";
            // 
            // txtRuoloC
            // 
            this.txtRuoloC.Location = new System.Drawing.Point(406, 208);
            this.txtRuoloC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuoloC.Name = "txtRuoloC";
            this.txtRuoloC.Size = new System.Drawing.Size(132, 22);
            this.txtRuoloC.TabIndex = 21;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(355, 148);
            this.lblEta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(27, 16);
            this.lblEta.TabIndex = 20;
            this.lblEta.Text = "Età";
            // 
            // txtEtaC
            // 
            this.txtEtaC.Location = new System.Drawing.Point(390, 145);
            this.txtEtaC.Margin = new System.Windows.Forms.Padding(4);
            this.txtEtaC.Name = "txtEtaC";
            this.txtEtaC.Size = new System.Drawing.Size(132, 22);
            this.txtEtaC.TabIndex = 19;
            // 
            // lblCognomeC
            // 
            this.lblCognomeC.AutoSize = true;
            this.lblCognomeC.Location = new System.Drawing.Point(355, 85);
            this.lblCognomeC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCognomeC.Name = "lblCognomeC";
            this.lblCognomeC.Size = new System.Drawing.Size(66, 16);
            this.lblCognomeC.TabIndex = 18;
            this.lblCognomeC.Text = "Cognome";
            // 
            // txtCognomeC
            // 
            this.txtCognomeC.Location = new System.Drawing.Point(429, 82);
            this.txtCognomeC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCognomeC.Name = "txtCognomeC";
            this.txtCognomeC.Size = new System.Drawing.Size(132, 22);
            this.txtCognomeC.TabIndex = 17;
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Location = new System.Drawing.Point(355, 26);
            this.lblNomeC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(44, 16);
            this.lblNomeC.TabIndex = 16;
            this.lblNomeC.Text = "Nome";
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(407, 23);
            this.txtNomeC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(132, 22);
            this.txtNomeC.TabIndex = 15;
            // 
            // btnEliminaC
            // 
            this.btnEliminaC.Location = new System.Drawing.Point(223, 292);
            this.btnEliminaC.Name = "btnEliminaC";
            this.btnEliminaC.Size = new System.Drawing.Size(90, 51);
            this.btnEliminaC.TabIndex = 14;
            this.btnEliminaC.Text = "Elimina calciatore";
            this.btnEliminaC.UseVisualStyleBackColor = true;
            this.btnEliminaC.Click += new System.EventHandler(this.btnEliminaC_Click);
            // 
            // btnModificaC
            // 
            this.btnModificaC.Location = new System.Drawing.Point(127, 292);
            this.btnModificaC.Name = "btnModificaC";
            this.btnModificaC.Size = new System.Drawing.Size(90, 51);
            this.btnModificaC.TabIndex = 13;
            this.btnModificaC.Text = "Modifica calciatore";
            this.btnModificaC.UseVisualStyleBackColor = true;
            this.btnModificaC.Click += new System.EventHandler(this.btnModificaC_Click);
            // 
            // btnAggiungiC
            // 
            this.btnAggiungiC.Location = new System.Drawing.Point(31, 292);
            this.btnAggiungiC.Name = "btnAggiungiC";
            this.btnAggiungiC.Size = new System.Drawing.Size(90, 51);
            this.btnAggiungiC.TabIndex = 12;
            this.btnAggiungiC.Text = "Aggiungi calciatore";
            this.btnAggiungiC.UseVisualStyleBackColor = true;
            this.btnAggiungiC.Click += new System.EventHandler(this.btnAggiungiC_Click);
            // 
            // lbCalciatori
            // 
            this.lbCalciatori.FormattingEnabled = true;
            this.lbCalciatori.ItemHeight = 16;
            this.lbCalciatori.Location = new System.Drawing.Point(31, 26);
            this.lbCalciatori.Name = "lbCalciatori";
            this.lbCalciatori.Size = new System.Drawing.Size(282, 260);
            this.lbCalciatori.TabIndex = 0;
            this.lbCalciatori.SelectedValueChanged += new System.EventHandler(this.lbCalciatori_SelectedValueChanged);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(349, 420);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(111, 30);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(487, 420);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(111, 30);
            this.btnEsci.TabIndex = 14;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnValoreS
            // 
            this.btnValoreS.Location = new System.Drawing.Point(326, 287);
            this.btnValoreS.Name = "btnValoreS";
            this.btnValoreS.Size = new System.Drawing.Size(111, 50);
            this.btnValoreS.TabIndex = 13;
            this.btnValoreS.Text = "Valore";
            this.btnValoreS.UseVisualStyleBackColor = true;
            this.btnValoreS.Click += new System.EventHandler(this.btnValoreS_Click);
            // 
            // btnEtaMedia
            // 
            this.btnEtaMedia.Location = new System.Drawing.Point(464, 287);
            this.btnEtaMedia.Name = "btnEtaMedia";
            this.btnEtaMedia.Size = new System.Drawing.Size(111, 50);
            this.btnEtaMedia.TabIndex = 14;
            this.btnEtaMedia.Text = "Età media";
            this.btnEtaMedia.UseVisualStyleBackColor = true;
            this.btnEtaMedia.Click += new System.EventHandler(this.btnEtaMedia_Click);
            // 
            // lblCalciatori
            // 
            this.lblCalciatori.AutoSize = true;
            this.lblCalciatori.Location = new System.Drawing.Point(4, 32);
            this.lblCalciatori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalciatori.Name = "lblCalciatori";
            this.lblCalciatori.Size = new System.Drawing.Size(63, 16);
            this.lblCalciatori.TabIndex = 16;
            this.lblCalciatori.Text = "Calciatori";
            // 
            // txtCalciatori
            // 
            this.txtCalciatori.Location = new System.Drawing.Point(75, 29);
            this.txtCalciatori.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalciatori.Name = "txtCalciatori";
            this.txtCalciatori.Size = new System.Drawing.Size(132, 22);
            this.txtCalciatori.TabIndex = 15;
            // 
            // lblPortieri
            // 
            this.lblPortieri.AutoSize = true;
            this.lblPortieri.Location = new System.Drawing.Point(4, 83);
            this.lblPortieri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortieri.Name = "lblPortieri";
            this.lblPortieri.Size = new System.Drawing.Size(49, 16);
            this.lblPortieri.TabIndex = 18;
            this.lblPortieri.Text = "Portieri";
            // 
            // txtPortieri
            // 
            this.txtPortieri.Location = new System.Drawing.Point(61, 80);
            this.txtPortieri.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortieri.Name = "txtPortieri";
            this.txtPortieri.Size = new System.Drawing.Size(132, 22);
            this.txtPortieri.TabIndex = 17;
            // 
            // lblDifensori
            // 
            this.lblDifensori.AutoSize = true;
            this.lblDifensori.Location = new System.Drawing.Point(4, 127);
            this.lblDifensori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifensori.Name = "lblDifensori";
            this.lblDifensori.Size = new System.Drawing.Size(60, 16);
            this.lblDifensori.TabIndex = 20;
            this.lblDifensori.Text = "Difensori";
            // 
            // txtDifensori
            // 
            this.txtDifensori.Location = new System.Drawing.Point(72, 124);
            this.txtDifensori.Margin = new System.Windows.Forms.Padding(4);
            this.txtDifensori.Name = "txtDifensori";
            this.txtDifensori.Size = new System.Drawing.Size(132, 22);
            this.txtDifensori.TabIndex = 19;
            // 
            // lblCentrocampisti
            // 
            this.lblCentrocampisti.AutoSize = true;
            this.lblCentrocampisti.Location = new System.Drawing.Point(4, 173);
            this.lblCentrocampisti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCentrocampisti.Name = "lblCentrocampisti";
            this.lblCentrocampisti.Size = new System.Drawing.Size(96, 16);
            this.lblCentrocampisti.TabIndex = 22;
            this.lblCentrocampisti.Text = "Centrocampisti";
            // 
            // txtCentrocampisti
            // 
            this.txtCentrocampisti.Location = new System.Drawing.Point(108, 170);
            this.txtCentrocampisti.Margin = new System.Windows.Forms.Padding(4);
            this.txtCentrocampisti.Name = "txtCentrocampisti";
            this.txtCentrocampisti.Size = new System.Drawing.Size(132, 22);
            this.txtCentrocampisti.TabIndex = 21;
            // 
            // lblAttaccanti
            // 
            this.lblAttaccanti.AutoSize = true;
            this.lblAttaccanti.Location = new System.Drawing.Point(4, 217);
            this.lblAttaccanti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttaccanti.Name = "lblAttaccanti";
            this.lblAttaccanti.Size = new System.Drawing.Size(65, 16);
            this.lblAttaccanti.TabIndex = 24;
            this.lblAttaccanti.Text = "Attaccanti";
            // 
            // txtAttaccanti
            // 
            this.txtAttaccanti.Location = new System.Drawing.Point(77, 214);
            this.txtAttaccanti.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttaccanti.Name = "txtAttaccanti";
            this.txtAttaccanti.Size = new System.Drawing.Size(132, 22);
            this.txtAttaccanti.TabIndex = 23;
            // 
            // pnlCalciatori
            // 
            this.pnlCalciatori.Controls.Add(this.lblAttaccanti);
            this.pnlCalciatori.Controls.Add(this.txtAttaccanti);
            this.pnlCalciatori.Controls.Add(this.lblCentrocampisti);
            this.pnlCalciatori.Controls.Add(this.txtCentrocampisti);
            this.pnlCalciatori.Controls.Add(this.lblDifensori);
            this.pnlCalciatori.Controls.Add(this.txtDifensori);
            this.pnlCalciatori.Controls.Add(this.lblPortieri);
            this.pnlCalciatori.Controls.Add(this.txtPortieri);
            this.pnlCalciatori.Controls.Add(this.lblCalciatori);
            this.pnlCalciatori.Controls.Add(this.txtCalciatori);
            this.pnlCalciatori.Location = new System.Drawing.Point(326, 6);
            this.pnlCalciatori.Name = "pnlCalciatori";
            this.pnlCalciatori.Size = new System.Drawing.Size(249, 258);
            this.pnlCalciatori.TabIndex = 25;
            // 
            // FormSquadra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 462);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.tabSquadra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSquadra";
            this.Text = "Squadra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSqudra_FormClosing);
            this.Load += new System.EventHandler(this.FormSquadra_Load);
            this.tabSquadra.ResumeLayout(false);
            this.tabDatiS.ResumeLayout(false);
            this.tabDatiS.PerformLayout();
            this.tabDatiC.ResumeLayout(false);
            this.tabDatiC.PerformLayout();
            this.pnlCalciatori.ResumeLayout(false);
            this.pnlCalciatori.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSquadra;
        private System.Windows.Forms.TabPage tabDatiS;
        private System.Windows.Forms.Button btnCreaS;
        private System.Windows.Forms.Label lblNomeS;
        private System.Windows.Forms.TextBox txtFondazione;
        private System.Windows.Forms.TextBox txtAllenatore;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.TextBox txtNomeS;
        private System.Windows.Forms.Label lblFondazione;
        private System.Windows.Forms.Label lblAllenatore;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.Button btnEliminaS;
        private System.Windows.Forms.TabPage tabDatiC;
        private System.Windows.Forms.ListBox lbCalciatori;
        private System.Windows.Forms.Button btnAggiungiC;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnModificaC;
        private System.Windows.Forms.Button btnEliminaC;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.TextBox txtEtaC;
        private System.Windows.Forms.Label lblCognomeC;
        private System.Windows.Forms.TextBox txtCognomeC;
        private System.Windows.Forms.Label lblInfortunioC;
        private System.Windows.Forms.TextBox txtInfortunioC;
        private System.Windows.Forms.Label lblValoreC;
        private System.Windows.Forms.TextBox txtValoreC;
        private System.Windows.Forms.Label lblRuoloC;
        private System.Windows.Forms.TextBox txtRuoloC;
        private System.Windows.Forms.Button btnEtaMedia;
        private System.Windows.Forms.Button btnValoreS;
        private System.Windows.Forms.Label lblAttaccanti;
        private System.Windows.Forms.TextBox txtAttaccanti;
        private System.Windows.Forms.Label lblCentrocampisti;
        private System.Windows.Forms.TextBox txtCentrocampisti;
        private System.Windows.Forms.Label lblDifensori;
        private System.Windows.Forms.TextBox txtDifensori;
        private System.Windows.Forms.Label lblPortieri;
        private System.Windows.Forms.TextBox txtPortieri;
        private System.Windows.Forms.Label lblCalciatori;
        private System.Windows.Forms.TextBox txtCalciatori;
        private System.Windows.Forms.Panel pnlCalciatori;
    }
}

