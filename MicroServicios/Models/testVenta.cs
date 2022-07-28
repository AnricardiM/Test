namespace MicroServicios.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testVenta")]
    public partial class testVenta
    {
        [Key]
        public int idVenta { get; set; }

        public int? idAuto { get; set; }

        public int? idCentro { get; set; }

        [StringLength(50)]
        public string descripcionVenta { get; set; }
    }
}
