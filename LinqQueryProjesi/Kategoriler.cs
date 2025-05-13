using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueryProjesi
{
    public class Kategoriler
    {
        public int KategoriId { get; set; }

        public string KategoriAdi { get; set; }

        public List<Urun> Urunler { get; set; } = new();
    }
}