using System;
using System.Collections.Generic;

namespace CafeteriaHCC_CarlosLeon.Models
{
    public partial class TbHccEstatusOrden
    {
        public TbHccEstatusOrden()
        {
            TbHccOrdenes = new HashSet<TbHccOrdene>();
        }

        public int CatordId { get; set; }
        public string CatordNombre { get; set; } = null!;
        public byte CatordEstatus { get; set; }

        public virtual ICollection<TbHccOrdene> TbHccOrdenes { get; set; }
    }
}
