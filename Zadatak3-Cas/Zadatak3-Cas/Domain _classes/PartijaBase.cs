using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Zadatak3_Cas.Enum_classes;

namespace Zadatak3_Cas.Domain__classes
{
    public class PartijaBase
    {
        #region Fields
        public string BrojPartije;
        ArrayList Promene = new ArrayList();
        public Komitent Vlasnik = new Komitent();
        #endregion

        #region Constructors

        public PartijaBase()
        {
            BrojPartije = "N/A";
            Vlasnik = null;
        }

        public PartijaBase(string brojPartije, Komitent vlasnik, int tipPartije)
        { 
            BrojPartije = brojPartije;
            Vlasnik = vlasnik;
        }
        #endregion


        #region Methods
        public string GetBrojPartije()
        {
            return BrojPartije;
        }

        public Komitent GetKomitent()
        {
            return Vlasnik;
        }

       public ArrayList GetPromenePoDatumuKnjizenja(DateTime DatumOd, DateTime DatumDo)
       {
           ArrayList rezultat = new ArrayList();
           Promene.Sort();

           foreach(Promena item in Promene)
           {
                if(item.GetDatumKnjizenja() >= DatumOd.AddDays(-1) && item.GetDatumKnjizenja() <= DatumDo.AddDays(+1) )
                {
                    rezultat.Add(item);
                }
           }

           return rezultat;
       }

       public ArrayList GetPromenePoDatumuValute(DateTime DatumOd, DateTime DatumDo)
       {
           ArrayList rezultat = new ArrayList();
           Promene.Sort();
           foreach (Promena item in Promene)
           {
               if (item.GetDatumValute() >= DatumOd && item.GetDatumValute() <= DatumDo)
               {
                   rezultat.Add(item);
               }
           }

           return rezultat;
       }

       public virtual void Uplata(float iznos, DateTime datumKnjizenja, DateTime datumValute, TValuta valuta)
       {
           Promena uplata = new Promena(datumKnjizenja, datumValute, iznos, 0, valuta);
           Promene.Add(uplata);
       }
       public virtual void Isplata(float iznos, DateTime datumKnjizenja, DateTime datumValute, TValuta valuta)
       {
           Promena isplata = new Promena(datumKnjizenja, datumValute, 0, iznos, valuta);
           Promene.Add(isplata);
       }
        #endregion

    }
}
