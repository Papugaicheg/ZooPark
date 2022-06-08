namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Учетные записи")]
    public partial class Учетные_записи
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int Employee { get; set; }

        public virtual Сотрудник Сотрудник { get; set; }
    }
}
