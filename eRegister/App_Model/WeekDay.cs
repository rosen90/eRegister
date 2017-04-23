namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeekDay")]
    public partial class WeekDay
    {
        private ICollection<Schedule> schedules;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WeekDay()
        {
            this.schedules = new HashSet<Schedule>();
        }

        public byte WeekDayID { get; set; }

        [Column("WeekDay")]
        [Required]
        [StringLength(20)]
        public string WeekDay1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules {
            get { return this.schedules;  }
            set { this.schedules = value; }
        }
    }
}
