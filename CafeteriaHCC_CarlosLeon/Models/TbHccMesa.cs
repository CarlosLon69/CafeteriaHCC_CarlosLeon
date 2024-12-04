using System;
using System.Collections.Generic;

namespace CafeteriaHCC_CarlosLeon.Models
{
    public partial class TbHccMesa
    {
        public TbHccMesa()
        {
            TbHccOrdenes = new HashSet<TbHccOrdene>();
        }

        public int MesId { get; set; }
        public short MesLugares { get; set; }
        public byte MesDisponible { get; set; }
        public byte MesEstatus { get; set; }

        public virtual ICollection<TbHccOrdene> TbHccOrdenes { get; set; }
    }
}
