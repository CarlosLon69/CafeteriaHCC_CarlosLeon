using System;
using System.Collections.Generic;

namespace CafeteriaHCC_CarlosLeon.Models
{
    public partial class TbHccOrdene
    {
        public TbHccOrdene()
        {
            TbHccOrdenesDetalles = new HashSet<TbHccOrdenesDetalle>();
        }

        public int OrdId { get; set; }
        public int MesId { get; set; }
        public int CatordId { get; set; }
        public DateTime OrdFechaInicio { get; set; }
        public byte OrdEstatus { get; set; }

        public virtual TbHccEstatusOrden Catord { get; set; } = null!;
        public virtual TbHccMesa Mes { get; set; } = null!;
        public virtual ICollection<TbHccOrdenesDetalle> TbHccOrdenesDetalles { get; set; }
    }
}
