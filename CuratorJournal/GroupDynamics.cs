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
    
    public partial class GroupDynamics
    {
        public int idGrDin { get; set; }
        public int idJournal { get; set; }
        public int idCoreInd { get; set; }
        public double semesterOneDyn { get; set; }
        public Nullable<double> semesterTwoDyn { get; set; }
        public string note { get; set; }
    
        public virtual CoreIndicator CoreIndicator { get; set; }
        public virtual Journal Journal { get; set; }
    }
}
