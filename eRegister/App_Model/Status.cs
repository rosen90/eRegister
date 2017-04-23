namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        private ICollection<Message> messages;
        private ICollection<MessageStatu> messageStatus;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Status()
        {
            this.messages = new HashSet<Message>();
            this.messageStatus = new HashSet<MessageStatu>();
        }

        public int StatusID { get; set; }

        [Column("Status")]
        [Required]
        [StringLength(50)]
        public string Status1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages {
            get { return this.messages;  }
            set { this.messages = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageStatu> MessageStatus {
            get { return this.messageStatus;  }
            set { this.messageStatus = value; }
        }
    }
}
