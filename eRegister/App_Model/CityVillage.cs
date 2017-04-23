namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CityVillage")]
    public partial class CityVillage
    {
        private ICollection<Actor> actors;
        private ICollection<School> schools;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CityVillage()
        {
            this.actors = new HashSet<Actor>();
            this.schools = new HashSet<School>();
        }

        public int CityVillageID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Municipality { get; set; }

        [Required]
        [StringLength(50)]
        public string Region { get; set; }

        public int? PostCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor> Actors {
            get { return this.actors;  }
            set { this.actors = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<School> Schools {
            get { return this.schools;  }
            set { this.schools = value; }
        }
    }
}
