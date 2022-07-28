namespace MicroServicios.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testAuto")]
    public partial class testAuto
    {
        [Key]
        public int idAuto { get; set; }

        [StringLength(50)]
        public string descripcionAuto { get; set; }

        public decimal? costoAuto { get; set; }
    }
}
