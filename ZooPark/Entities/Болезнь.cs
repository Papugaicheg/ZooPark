namespace ZooPark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Болезнь
    {
        public int ID { get; set; }

        public int Животное { get; set; }

        public int Заболевания { get; set; }

        public virtual Животное Животное1 { get; set; }

        public virtual Заболевание Заболевание { get; set; }
    }
}
