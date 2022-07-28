namespace MicroServicios.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testCentro")]
    public partial class testCentro
    {
        [Key]
        public int idCentro { get; set; }

        [StringLength(50)]
        public string descripcionCentro { get; set; }
    }
}
