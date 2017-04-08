namespace ERegisterSystem.Models
{
    using System;
    class Schedules
    {
        public Guid ScheduleID { get; set; }

        public int TermID { get; set; }

        public int PeriodNum { get; set; }

        public int TeacherID { get; set; }
    }
}
