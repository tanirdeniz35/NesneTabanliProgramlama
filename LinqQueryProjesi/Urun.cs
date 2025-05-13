using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueryProjesi
{
    public class Urun
    {
        public int KategoriId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal SatisFiyati { get; set; }
    }
}