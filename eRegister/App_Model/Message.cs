namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        private ICollection<Message> replyMessagesId;
        private ICollection<MessageStatu> messageStatus;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Message()
        {
            this.replyMessagesId = new HashSet<Message>();
            this.messageStatus = new HashSet<MessageStatu>();
        }

        public long MessageID { get; set; }

        public int MessageTypeID { get; set; }

        public int MessageFromID { get; set; }

        public int MessageToID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }

        public long? ReplyMessageID { get; set; }

        public int? StatusID { get; set; }

        public string AttachmentPath { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Actor Actor1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> ReplyMessagesId {
            get { return this.replyMessagesId;  }
            set { this.replyMessagesId = value; }
        }

        public virtual Message ReplyMessage { get; set; }

        public virtual MessageType MessageType { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageStatu> MessageStatus {
            get { return this.messageStatus;  }
            set { this.messageStatus = value; }
        }
    }
}
