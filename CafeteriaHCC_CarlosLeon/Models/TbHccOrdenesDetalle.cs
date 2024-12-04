using System;
using System.Collections.Generic;

namespace CafeteriaHCC_CarlosLeon.Models
{
    public partial class TbHccOrdenesDetalle
    {
        public int OrddetId { get; set; }
        public int OrdId { get; set; }
        public int ProId { get; set; }
        public short OrddetCantidad { get; set; }
        public byte OrddetEstatus { get; set; }

        public virtual TbHccOrdene Ord { get; set; } = null!;
        public virtual TbHccProducto Pro { get; set; } = null!;
    }
}
