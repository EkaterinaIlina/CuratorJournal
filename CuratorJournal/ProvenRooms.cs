//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ProvenRooms
    {
        public int idProvenRooms { get; set; }
        public int idStudent { get; set; }
        public int idVisitHostel { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual VisitHostel VisitHostel { get; set; }
    }
}