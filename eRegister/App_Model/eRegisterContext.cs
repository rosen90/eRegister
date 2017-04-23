namespace eRegister.App_Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class eRegisterContext : DbContext
    {
        public eRegisterContext()
            : base("name=eRegisterContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Absence> Absences { get; set; }
        public virtual DbSet<AbsenceType> AbsenceTypes { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<CityVillage> CityVillages { get; set; }
        public virtual DbSet<ClassDevisionDetail> ClassDevisionDetails { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassStudent> ClassStudents { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageStatu> MessageStatus { get; set; }
        public virtual DbSet<MessageType> MessageTypes { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Profil> Profils { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<ScoreType> ScoreTypes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StudyYear> StudyYears { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<WeekDay> WeekDays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbsenceType>()
                .Property(e => e.Absence)
                .IsUnicode(false);

            modelBuilder.Entity<AbsenceType>()
                .HasMany(e => e.Absences)
                .WithRequired(e => e.AbsenceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.EGN)
                .IsFixedLength();

            modelBuilder.Entity<Actor>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<Actor>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.Absences)
                .WithRequired(e => e.Actor)
                .HasForeignKey(e => e.StudentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.Actors1)
                .WithOptional(e => e.Actor1)
                .HasForeignKey(e => e.ParentlID);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.ClassDevisionDetails)
                .WithOptional(e => e.Actor)
                .HasForeignKey(e => e.TeacherID);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.ClassStudents)
                .WithRequired(e => e.Actor)
                .HasForeignKey(e => e.StudentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Actor)
                .HasForeignKey(e => e.MessageFromID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.Messages1)
                .WithRequired(e => e.Actor1)
                .HasForeignKey(e => e.MessageToID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.Registers)
                .WithRequired(e => e.Actor)
                .HasForeignKey(e => e.TeacherID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.TeacherSubjects)
                .WithRequired(e => e.Actor)
                .HasForeignKey(e => e.TeacherID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CityVillage>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CityVillage>()
                .Property(e => e.Municipality)
                .IsUnicode(false);

            modelBuilder.Entity<CityVillage>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<CityVillage>()
                .HasMany(e => e.Schools)
                .WithRequired(e => e.CityVillage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClassDevisionDetail>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.ClassDevisionDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.ClassDevisionDetails)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Division>()
                .Property(e => e.Division1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.ClassDevisionDetails)
                .WithRequired(e => e.Division)
                .HasForeignKey(e => e.DivID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gallery>()
                .Property(e => e.GalleryName)
                .IsUnicode(false);

            modelBuilder.Entity<Gallery>()
                .HasMany(e => e.Pictures)
                .WithRequired(e => e.Gallery)
                .HasForeignKey(e => e.IDGallery)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.AttachmentPath)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .HasMany(e => e.ReplyMessagesId)
                .WithOptional(e => e.ReplyMessage)
                .HasForeignKey(e => e.ReplyMessageID);

            modelBuilder.Entity<Message>()
                .HasMany(e => e.MessageStatus)
                .WithRequired(e => e.Message)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MessageType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<MessageType>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.MessageType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profil>()
                .Property(e => e.Profil1)
                .IsUnicode(false);

            modelBuilder.Entity<Profil>()
                .HasMany(e => e.ClassDevisionDetails)
                .WithRequired(e => e.Profil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<School>()
                .Property(e => e.SchooName)
                .IsUnicode(false);

            modelBuilder.Entity<School>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<ScoreType>()
                .Property(e => e.ScoreType1)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Status1)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.MessageStatus)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudyYear>()
                .Property(e => e.StudyYear1)
                .IsUnicode(false);

            modelBuilder.Entity<StudyYear>()
                .HasMany(e => e.ClassDevisionDetails)
                .WithRequired(e => e.StudyYear)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudyYear>()
                .HasMany(e => e.Registers)
                .WithRequired(e => e.StudyYear)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudyYear>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.StudyYear)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Registers)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.TeacherSubjects)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Galleries)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<UserType>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WeekDay>()
                .Property(e => e.WeekDay1)
                .IsUnicode(false);

            modelBuilder.Entity<WeekDay>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.WeekDay)
                .WillCascadeOnDelete(false);
        }
    }
}
