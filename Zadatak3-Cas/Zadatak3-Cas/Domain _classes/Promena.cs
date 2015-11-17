using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zadatak3_Cas.Enum_classes;

namespace Zadatak3_Cas.Domain__classes
{
    class Promena : IComparable
    {

        #region Fields
        private DateTime DatumKnjizenja;
        private DateTime DatumValute;
        private TValuta Valuta;
        private float Potrazuje;
        private float Duguje;
        #endregion

        #region Constructors
        public Promena(DateTime datumKnjizenja, DateTime datumValute, float duguje = 0, float potrazuje = 0, TValuta valuta = 0)
        {
            DatumKnjizenja = datumKnjizenja;
            DatumValute = datumValute;
            Valuta = valuta;
            Duguje = duguje;
            Potrazuje = potrazuje;
        }
        

        #endregion

        #region Methods
        public DateTime GetDatumKnjizenja()
        {
            return DatumKnjizenja;
        }
        public DateTime GetDatumValute()
        {
            return DatumValute;
        }
        public double GetDuguje()
        {
            return Duguje;
        }
        public double GetPotrazuje()
        {
            return Potrazuje;
        }

        //implementacija interfejsa

        public int Compare(object lhs, object rhs)
        {
            if (((Promena)lhs).DatumKnjizenja < ((Promena)rhs).DatumKnjizenja)
            {
                return -1;
            }
            else if (((Promena)lhs).DatumKnjizenja > ((Promena)rhs).DatumKnjizenja)
            {
                return 1;
            }
            else
            { 
                return 0;
            }
        }

        //public int CompateTo(object rhs)
        //{
        //    return Compare(this, rhs);
        //}

        public int CompareTo(object obj)
        {
            return Compare(this, obj);
        }
        #endregion
    }
}
