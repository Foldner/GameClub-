namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Device")]
    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DeviceName { get; set; }

        public DateTime? ReleaseTime { get; set; }

        public int DeviceTypeId { get; set; }

        public int? StatusTypeId { get; set; }

        public virtual DeviceType DeviceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
