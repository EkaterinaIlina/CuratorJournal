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
    
    public partial class Offense
    {
        public int idOffense { get; set; }
        public int idJournal { get; set; }
        public System.DateTime dateOffense { get; set; }
        public string numberProt { get; set; }
        public string causeOffense { get; set; }
        public string decisionOffense { get; set; }
    
        public virtual Journal Journal { get; set; }
    }
}
