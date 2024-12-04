using System;
using System.Collections.Generic;

namespace CafeteriaHCC_CarlosLeon.Models
{
    public partial class TbHccAlmacen
    {
        public TbHccAlmacen()
        {
            TbHccProductos = new HashSet<TbHccProducto>();
        }

        public int AlmId { get; set; }
        public int AlmCantidad { get; set; }
        public DateTime AlmFechaActualizacion { get; set; }
        public byte AlmEstatus { get; set; }

        public virtual ICollection<TbHccProducto> TbHccProductos { get; set; }
    }
}
