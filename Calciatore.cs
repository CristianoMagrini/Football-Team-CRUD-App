using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Squadra
{
    public class Calciatore
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

        private string _Cognome;
        public string Cognome
        {
            get
            {
                return _Cognome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Cognome = value;
                }
                else
                {
                    throw new Exception("Cognome non valido");
                }
            }
        }

        private int _Nascita;
        public int Nascita
        {
            get
            {
                return _Nascita;
            }
            set
            {
                if (value.ToString() != "" && value < DateTime.Now.Year && value >= 0)
                {
                    _Nascita = value;
                }
                else
                {
                    throw new Exception("Anno di nascita non valido");
                }
            }
        }

        private string _Ruolo;
        public string Ruolo
        {
            get
            {
                return _Ruolo;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value=="Portiere" || value == "Difensore" || value == "Centrocampista" || value == "Attaccante")
                    {
                        _Ruolo = value;
                    }
                    else
                    {
                        throw new Exception("Ruolo non valido");
                    }
                }
                else
                {
                    throw new Exception("Ruolo non valido");
                }
            }
        }

        private int _Valore;
        public int Valore
        {
            get
            {
                return _Valore;
            }
            set
            {
                if (value.ToString() != "" && value > 0)
                {
                    _Valore = value;
                }
                else
                {
                    throw new Exception("Valore di mercato non valido");
                }
            }
        }

        private bool _Infortunio;
        public bool Infortunio
        {
            get
            {
                return _Infortunio;
            }
            set
            {
                _Infortunio = value;                  
            }
        }

        [JsonConstructor]
        public Calciatore(string Nome, string Cognome, int Nascita, string Ruolo, int Valore, bool Infortunio)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Nascita = Nascita;
            this.Ruolo = Ruolo;
            this.Valore = Valore;
            this.Infortunio = Infortunio;
        }

        public int Eta()
        {
            int annoCorrente = DateTime.Now.Year;
            int eta = annoCorrente - _Nascita;
            return eta;
        }

        public string Stato()
        {
            if (_Infortunio)
            {
                return "Infortunato";
            }
            else
            {
                return "Non infortunato";
            }
        }

        public override string ToString()
        {
            return this.Nome + " " + this.Cognome;
        }
    }
}
