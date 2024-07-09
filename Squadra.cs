using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Squadra
{
    public class Squadra
    {
        private string _Nome;
        public string Nome
        {
            get 
            { 
                return _Nome; 
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Nome = value;
                }
                else
                {
                    throw new Exception("Nome non valido");
                }
            }
        }

        private string _Citta;
        public string Citta
        {
            get 
            { 
                return _Citta; 
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Citta = value;
                }
                else
                {
                    throw new Exception("Città non valida");
                }
            }
        }

        private string _Allenatore;
        public string Allenatore
        {
            get 
            { 
                return _Allenatore; 
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Allenatore = value;
                }
                else
                {
                    throw new Exception("Allenatore non valido");
                }
            }
        }

        private int _Fondazione;
        public int Fondazione
        {
            get 
            { 
                return _Fondazione; 
            }
            set
            {
                if (value.ToString()!="" && value <= DateTime.Now.Year && value >= 0 )
                {
                    _Fondazione = value;
                }
                else
                {
                    throw new Exception("Anno di fondazione non valido");
                }
            }
        }

        private List<Calciatore> _Calciatori;
        public List<Calciatore> Calciatori
        {
            get
            {
                return _Calciatori; 
            }
            set
            {
                _Calciatori = value;
            }
        }

        [JsonConstructor]
        public Squadra(string Nome, string Citta, string Allenatore, int Fondazione, List<Calciatore> Calciatori) 
        {
            this.Nome = Nome;
            this.Citta = Citta;
            this.Allenatore = Allenatore;
            this.Fondazione = Fondazione;
            this.Calciatori = Calciatori;
        }

        public Squadra(string Nome, string Citta, string Allenatore, int Fondazione) : this(Nome, Citta, Allenatore, Fondazione, new List<Calciatore>()) { }

        public void AggiungiCalciatore(Calciatore ca)
        {
            _Calciatori.Add(ca);
        }

        public int ValoreSquadra()
        {
            int totale = 0;
            if(Calciatori.Count > 0)
            {
                foreach (Calciatore ca in Calciatori)
                {
                    totale += ca.Valore;
                }
            }           
            return totale;
        }

        public double EtaMedia()
        {
            int totale = 0;
            if (Calciatori.Count > 0)
            {
                foreach (Calciatore ca in Calciatori)
                {
                    totale += ca.Eta();
                }
                return totale / Calciatori.Count;
            }
            return totale;
        }

        public int Portieri()
        {
            int totale = 0;
            if (Calciatori.Count > 0)
            {
                foreach (Calciatore ca in Calciatori)
                {
                    if(ca.Ruolo == "Portiere")
                    {
                        totale++;
                    }
                }
            }
            return totale;
        }

        public int Difensori()
        {
            int totale = 0;
            if (Calciatori.Count > 0)
            {
                foreach (Calciatore ca in Calciatori)
                {
                    if (ca.Ruolo == "Difensore")
                    {
                        totale++;
                    }
                }
            }
            return totale;
        }

        public int Centrocampisti()
        {
            int totale = 0;
            if (Calciatori.Count > 0)
            {
                foreach (Calciatore ca in Calciatori)
                {
                    if (ca.Ruolo == "Centrocampista")
                    {
                        totale++;
                    }
                }
            }
            return totale;
        }

        public int Attaccanti()
        {
            int totale = 0;
            if (Calciatori.Count > 0)
            {
                foreach (Calciatore ca in Calciatori)
                {
                    if (ca.Ruolo == "Attaccante")
                    {
                        totale++;
                    }
                }
            }
            return totale;
        }

        public static Squadra CaricaSquadra(string file)
        {
            try
            {
                if (File.Exists(file))
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };
                    string dati = File.ReadAllText(file);
                    Squadra nuovaSquadra;
                    nuovaSquadra = JsonSerializer.Deserialize<Squadra>(dati, options);
                    return nuovaSquadra;
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossibile caricare dati da file", ex);
            }
        }

        public static void SalvaSquadra(Squadra squadra, string file)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                if(squadra == null)
                {
                    File.Delete(file);
                }
                else
                {
                    string dati = JsonSerializer.Serialize<Squadra>(squadra, options);
                    File.WriteAllText(file, dati);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Impossibile salvare dati su file", ex);
            }
        }
    }
}
