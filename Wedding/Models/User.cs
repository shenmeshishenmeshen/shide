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

        public int UserID { get; set; }

        [Required(ErrorMessage = "�������˺ţ�")]
        [StringLength(50, ErrorMessage = "�������볬��50���֣�")]
        
        public string UserName { get; set; }

        [Required(ErrorMessage = "���������룡")]
        [StringLength(20)]
        public string UserPwd { get; set; }

        [Required(ErrorMessage = "���������䣡")]
        [StringLength(255, ErrorMessage = "�������볬��255���֣�")]
        [RegularExpression(@"^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+((\.[a-zA-Z0-9_-]{2,3}){1,2})$", ErrorMessage = "��������ȷ�����䣡")]
        public string Email { get; set; }

        public DateTime RegTime { get; set; }

        [StringLength(2)]
        public string Sex { get; set; }
    }
}
