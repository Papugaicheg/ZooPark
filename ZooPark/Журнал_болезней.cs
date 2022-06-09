namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Журнал болезней")]
    public partial class Журнал_болезней
    {
        public int ID { get; set; }

        public int Животное { get; set; }

        public int Заболевание { get; set; }

        public virtual Животное Животное1 { get; set; }

        public virtual Заболевание Заболевание1 { get; set; }
    }
}
