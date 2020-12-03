using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class ccomptes
    {
        public static List<clientc> aClients = new List<clientc>();
        public static List<VirementsComptes> aVirements = new List<VirementsComptes>();
        private int code;
        private static int nbcompte;
        private double solde;

        public ccomptes()
        {
            nbcompte++;
            code = nbcompte;
        }
        public ccomptes(double solde)
        {
            nbcompte++;
            this.code = nbcompte;
            this.solde = solde;

        }
        public virtual void deposee(double somme)
        {
            solde += somme;
        }
        public virtual void retrait(double somme)
        {
            solde -= somme;
        }
        public override string ToString()
        {
            return ("Code_:" + code + "solde" + solde);
        }
    }
}
