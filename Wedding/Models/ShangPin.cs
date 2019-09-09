namespace Wedding.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prouduct")]
    public partial class Prouduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prouduct()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProuductId { get; set; }

        public int LeiBieId { get; set; }

        public string Varieties{ get; set; }


        public string  IsNew { get; set; }
        [Required]
        [StringLength(160)]
        public string Title { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        [StringLength(1024)]
        public string TuPian { get; set; }


        public virtual LeiBie LeiBie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
