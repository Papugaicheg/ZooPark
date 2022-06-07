namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Тип
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Тип()
        {
            Журнал_прививок = new HashSet<Журнал_прививок>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Код { get; set; }

        [Required]
        [StringLength(30)]
        public string Название { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Журнал_прививок> Журнал_прививок { get; set; }
    }
}
