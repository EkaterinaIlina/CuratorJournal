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
    
    public partial class StructParentsTalc
    {
        public int idStructParentsTalc { get; set; }
        public int idKin { get; set; }
        public int idTalkParents { get; set; }
    
        public virtual Kin Kin { get; set; }
        public virtual TalkParents TalkParents { get; set; }
    }
}
