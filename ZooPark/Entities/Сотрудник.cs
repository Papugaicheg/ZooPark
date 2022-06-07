namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудник
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудник()
        {
            Журнал_осмотров = new HashSet<Журнал_осмотров>();
            Журнал_прививок = new HashSet<Журнал_прививок>();
            Проверка_вольеров = new HashSet<Проверка_вольеров>();
            Учетные_записи = new HashSet<Учетные_записи>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(20)]
        public string Имя { get; set; }

        [StringLength(20)]
        public string Отчество { get; set; }

        [Required]
        [StringLength(7)]
        public string Пол { get; set; }

        [Column("Дата рождения", TypeName = "date")]
        public DateTime Дата_рождения { get; set; }

        [StringLength(11)]
        public string Телефон { get; set; }

        [Required]
        [StringLength(50)]
        public string Адрес { get; set; }

        public byte Стаж { get; set; }

        public int Должность { get; set; }

        [Column("Дата приема", TypeName = "date")]
        public DateTime Дата_приема { get; set; }

        [Column("Дата увольнения", TypeName = "date")]
        public DateTime? Дата_увольнения { get; set; }

        [Required]
        [StringLength(50)]
        public string Паспорт { get; set; }

        public virtual Должность Должность1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Журнал_осмотров> Журнал_осмотров { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Журнал_прививок> Журнал_прививок { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Проверка_вольеров> Проверка_вольеров { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Учетные_записи> Учетные_записи { get; set; }
    }
}
