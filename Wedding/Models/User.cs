namespace Wedding.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Cart = new HashSet<Cart>();
        }

        public int UserID { get; set; }

        [Required(ErrorMessage = "请输入账号！")]
        [StringLength(50, ErrorMessage = "请勿输入超过50个字！")]
        
        public string UserName { get; set; }

        [Required(ErrorMessage = "请输入密码！")]
        [StringLength(20)]
        public string UserPwd { get; set; }

        [Required(ErrorMessage = "请输入邮箱！")]
        [StringLength(255, ErrorMessage = "请勿输入超过255个字！")]
        [RegularExpression(@"^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+((\.[a-zA-Z0-9_-]{2,3}){1,2})$", ErrorMessage = "请输入正确的邮箱！")]
        public string Email { get; set; }

        public DateTime RegTime { get; set; }

        [StringLength(2)]
        public string Sex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }
    }
}
