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
    
    public partial class TalkParents
    {
        public int idTalkPar { get; set; }
        public int idKin { get; set; }
        public int idTopTPar { get; set; }
        public int idJournal { get; set; }
        public System.DateTime dateTalkPar { get; set; }
    
        public virtual Journal Journal { get; set; }
        public virtual Kin Kin { get; set; }
        public virtual TopicTalkParents TopicTalkParents { get; set; }
    }
}
