﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuratorJournal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CuratorJournalEntities : DbContext
    {
        public CuratorJournalEntities()
            : base("name=CuratorJournalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AchivementStudent> AchivementStudent { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<CoreIndicator> CoreIndicator { get; set; }
        public virtual DbSet<Curator> Curator { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Family> Family { get; set; }
        public virtual DbSet<FinalGrade> FinalGrade { get; set; }
        public virtual DbSet<FormOfControl> FormOfControl { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupDynamics> GroupDynamics { get; set; }
        public virtual DbSet<Hostel> Hostel { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<JournalStudent> JournalStudent { get; set; }
        public virtual DbSet<Kin> Kin { get; set; }
        public virtual DbSet<LackAttendance> LackAttendance { get; set; }
        public virtual DbSet<LackMeeting> LackMeeting { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<ListMarkStud> ListMarkStud { get; set; }
        public virtual DbSet<Meeting> Meeting { get; set; }
        public virtual DbSet<OccupationStatus> OccupationStatus { get; set; }
        public virtual DbSet<Offense> Offense { get; set; }
        public virtual DbSet<PrivateTalk> PrivateTalk { get; set; }
        public virtual DbSet<PrivTalkStudent> PrivTalkStudent { get; set; }
        public virtual DbSet<ProvenRooms> ProvenRooms { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<RatingMark> RatingMark { get; set; }
        public virtual DbSet<Residence> Residence { get; set; }
        public virtual DbSet<StatusStudent> StatusStudent { get; set; }
        public virtual DbSet<StructParentsTalc> StructParentsTalc { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudyingProcess> StudyingProcess { get; set; }
        public virtual DbSet<TalkParents> TalkParents { get; set; }
        public virtual DbSet<TopicTalkParents> TopicTalkParents { get; set; }
        public virtual DbSet<TypeOfEvent> TypeOfEvent { get; set; }
        public virtual DbSet<VisitHostel> VisitHostel { get; set; }
        public virtual DbSet<Semestr> Semestr { get; set; }
    }
}
