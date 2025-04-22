using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstProjesi.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public int Yas { get; set; }

        public string EgitimDurumu { get; set; }

    }
}