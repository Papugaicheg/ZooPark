namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заболевание
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заболевание()
        {
            Животное = new HashSet<Животное>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [StringLength(250)]
        public string Симптомы { get; set; }

        [StringLength(250)]
        public string Описание { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Животное> Животное { get; set; }
    }
}
