using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemParkir.Model.Entity
{
    public class Kendaraan
    {
        public string PlatNomer { get; set; }
        public string IdPetugas { get; set; }
        public string KarcisParkir { get; set; }
        public string Nominal { get; set;}
        public string AreaParkir { get; set; }
    }
}
