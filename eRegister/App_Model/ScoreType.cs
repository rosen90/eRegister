namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScoreType")]
    public partial class ScoreType
    {
        private ICollection<Register> registers;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScoreType()
        {
            this.registers = new HashSet<Register>();
        }

        public byte ScoreTypeID { get; set; }

        [Column("ScoreType")]
        [Required]
        [StringLength(50)]
        public string ScoreType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Register> Registers {
            get { return this.registers;  }
            set { this.registers = value; }
        }
    }
}
