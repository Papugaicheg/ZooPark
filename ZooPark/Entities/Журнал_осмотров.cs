namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Журнал осмотров")]
    public partial class Журнал_осмотров
    {
        public int ID { get; set; }

        public int Сотрудник { get; set; }

        public int Животное { get; set; }

        [Column("Дата проверки", TypeName = "date")]
        public DateTime Дата_проверки { get; set; }

        [StringLength(250)]
        public string Комментарий { get; set; }

        public virtual Животное Животное1 { get; set; }

        public virtual Сотрудник Сотрудник1 { get; set; }
    }
}
