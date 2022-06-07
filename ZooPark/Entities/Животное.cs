namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Животное
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Животное()
        {
            Болезнь = new HashSet<Болезнь>();
            Журнал_осмотров = new HashSet<Журнал_осмотров>();
            Журнал_прививок = new HashSet<Журнал_прививок>();
        }

        public int ID { get; set; }

        public int Вольер { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        public int Возраст { get; set; }

        public double Вес { get; set; }

        public int Рост { get; set; }

        [Column("Тип среды обитания")]
        [Required]
        [StringLength(50)]
        public string Тип_среды_обитания { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Болезнь> Болезнь { get; set; }

        public virtual Вольер Вольер1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Журнал_осмотров> Журнал_осмотров { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Журнал_прививок> Журнал_прививок { get; set; }
    }
}
