using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Zadatak3_Cas.Enum_classes;

namespace Zadatak3_Cas.Domain__classes
{
    class TekuciRacun : PartijaBase
    {


        public override void Uplata(float iznos,  DateTime datumKnjizenja, DateTime datumValute, TValuta valuta )
        {
            base.Uplata(iznos, datumKnjizenja, datumValute, 0);
        }
    }
}
