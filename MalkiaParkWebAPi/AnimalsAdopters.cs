namespace MalkiaParkWebAPi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AnimalsAdopters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdoptionId { get; set; }

        public int OId { get; set; }

        public int AId { get; set; }

        public DateTime Date { get; set; }
    }
}
