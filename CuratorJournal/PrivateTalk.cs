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
    
    public partial class PrivateTalk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrivateTalk()
        {
            this.PrivTalkStudent = new HashSet<PrivTalkStudent>();
        }
    
        public int idPrTalk { get; set; }
        public int idJournal { get; set; }
        public System.DateTime datePrTalk { get; set; }
        public string topicPrTalk { get; set; }
    
        public virtual Journal Journal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrivTalkStudent> PrivTalkStudent { get; set; }
    }
}