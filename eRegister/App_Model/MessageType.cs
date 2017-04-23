namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MessageType
    {
        private ICollection<Message> messages;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MessageType()
        {
            this.messages = new HashSet<Message>();
        }

        public int MessageTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public string TextTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages {
            get { return this.messages;  }
            set { this.messages = value; }
        }
    }
}
