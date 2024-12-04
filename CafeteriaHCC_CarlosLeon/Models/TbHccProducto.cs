using System;
using System.Collections.Generic;

namespace CafeteriaHCC_CarlosLeon.Models
{
    public partial class TbHccProducto
    {
        public TbHccProducto()
        {
            TbHccOrdenesDetalles = new HashSet<TbHccOrdenesDetalle>();
        }

        public int ProId { get; set; }
        public int AlmId { get; set; }
        public string ProNombre { get; set; } = null!;
        public string ProDescripcion { get; set; } = null!;
        public decimal? ProPrecio { get; set; }
        public byte ProEstatus { get; set; }

        public virtual TbHccAlmacen Alm { get; set; } = null!;
        public virtual ICollection<TbHccOrdenesDetalle> TbHccOrdenesDetalles { get; set; }
    }
}
