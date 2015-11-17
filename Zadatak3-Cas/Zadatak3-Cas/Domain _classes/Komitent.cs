using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadatak3_Cas.Domain__classes
{
    public class Komitent
    {
        #region Fields
        public string Ime;
        public string Prezime;
        public string JMBG;
        public string Telefon;
        #endregion

        #region Constructors
        public Komitent()
        {
            this.Ime = "N/A";
            this.Prezime = "N/A";
            this.JMBG = "N/A";
            this.Telefon = "N/A";
        }
        public Komitent(string ime, string prezime, string jmbg, string telefon)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.JMBG = jmbg;
            this.Telefon = telefon;
        }
        
        #endregion

        #region Methods
        public string GetIme()
        {
            return Ime;
        }
        public string GetPrezime()
        {
            return Prezime;
        }

        public string GetJMBG()
        {
            return JMBG;
        }
        public string GetTelefon()
        {
            return Telefon;
        }
        #endregion


    }
}
