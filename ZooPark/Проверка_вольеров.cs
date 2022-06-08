namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Проверка вольеров")]
    public partial class Проверка_вольеров
    {
        public int ID { get; set; }

        public int Сотрудник { get; set; }

        public int Вольер { get; set; }

        [Column("Дата проверки", TypeName = "date")]
        public DateTime Дата_проверки { get; set; }

        [StringLength(250)]
        public string Комментарий { get; set; }

        public virtual Вольер Вольер1 { get; set; }

        public virtual Сотрудник Сотрудник1 { get; set; }
    }
}
