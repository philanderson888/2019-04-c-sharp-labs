namespace lab_82_entity_from_code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        public int TaskID { get; set; }

        [StringLength(50)]
        public string TaskDescription { get; set; }

        public bool? Done { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStarted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCompleted { get; set; }

        public int? Category { get; set; }

        public int? UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Deadline { get; set; }

        public virtual Category Category1 { get; set; }

        public virtual User User { get; set; }
    }
}
