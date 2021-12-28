namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusType")]
    public partial class StatusType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }
    }
}
