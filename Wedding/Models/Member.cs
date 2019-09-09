namespace Wedding.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            News = new HashSet<News>();
        }

        [Key]
        public int ManrID { get; set; }

        [Required]
        [StringLength(15)]
        public string ManrName { get; set; }

        [Required]
        [StringLength(20)]
        public string ManPwd { get; set; }

        [Required]
        [StringLength(50)]
        public string rEmail { get; set; }

        public DateTime RegisterTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }

    }
}
