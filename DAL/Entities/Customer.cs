namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(16)]
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime RegDate { get; set; }

        public double? MoneySpent { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
