namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Журнал прививок")]
    public partial class Журнал_прививок
    {
        public int ID { get; set; }

        public int Сотрудник { get; set; }

        public int Животное { get; set; }

        [Column("Дата прививки", TypeName = "date")]
        public DateTime Дата_прививки { get; set; }

        public int Прививка { get; set; }

        public virtual Животное Животное1 { get; set; }

        public virtual Прививка Прививка1 { get; set; }

        public virtual Сотрудник Сотрудник1 { get; set; }
    }
}
