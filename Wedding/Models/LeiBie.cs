namespace Wedding.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeiBie")]
    public partial class LeiBie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeiBie()
        {
            ShangPin = new HashSet<Prouduct>();
        }

        public int LeiBieId { get; set; }

        [StringLength(120)]
        public string Name { get; set; }

        [StringLength(20)]
        public int TypeId { get; set; }


        [StringLength(4000)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prouduct> ShangPin { get; set; }
    }
}
