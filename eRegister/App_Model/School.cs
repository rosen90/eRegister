namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class School
    {
        private ICollection<Actor> actors;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School()
        {
            this.actors = new HashSet<Actor>();
        }

        public int SchoolID { get; set; }

        [Required]
        [StringLength(100)]
        public string SchooName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        public int CityVillageID { get; set; }

        public string Mission { get; set; }

        public string Strategy { get; set; }

        public string Vision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor> Actors {
            get { return this.actors;  }
            set { this.actors = value; }
        }

        public virtual CityVillage CityVillage { get; set; }
    }
}
