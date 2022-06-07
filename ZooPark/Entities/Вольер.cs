namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Вольер
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Вольер()
        {
            Животное = new HashSet<Животное>();
            Проверка_вольеров = new HashSet<Проверка_вольеров>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Тип { get; set; }

        public int Площадь { get; set; }

        [Required]
        [StringLength(20)]
        public string Статус { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Животное> Животное { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Проверка_вольеров> Проверка_вольеров { get; set; }
    }
}
