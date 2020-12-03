using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class clientc
    {

        static int cid = 1;
        private string id;
        private string cnom;
        private String cprenom;
        private string cgenre;
        private DateTime cdatenaiss;
        private string cnumcin;
        private string ctelephone;
        private string cmail;
        private string cassurence;
        // Constructeur par défaut

        public clientc()
        {
        }

        // Constructeur surchargé d'initialisation

        public clientc(string nom, string prenom, string genre, DateTime datenaiss, string numcin, string telephone, string mail, string assurence)
        {


            this.Id = Cid++.ToString();
            this.Cnom = nom;
            this.Cprenom = prenom;
            this.Cgenre = genre;
            this.Cdatenaiss = datenaiss;
            this.Cnumcin = numcin;
            this.Cmail = mail;
            this.Cassurence = assurence;
        }

        public static int Cid { get => cid; set => cid = value; }
        public string Id { get => id; set => id = value; }
        public string Cnom { get => cnom; set => cnom = value; }
        public string Cprenom { get => cprenom; set => cprenom = value; }
        public string Cgenre { get => cgenre; set => cgenre = value; }
        public DateTime Cdatenaiss { get => cdatenaiss; set => cdatenaiss = value; }
        public string Cnumcin { get => cnumcin; set => cnumcin = value; }
        public string Ctelephone { get => ctelephone; set => ctelephone = value; }
        public string Cmail { get => cmail; set => cmail = value; }
        public string Cassurence { get => cassurence; set => cassurence = value; }
  
    
    
    
    }

}
