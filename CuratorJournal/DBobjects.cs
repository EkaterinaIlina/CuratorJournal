using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuratorJournal
{
    class DBobjects
    {
        public static CuratorJournalEntities Entities { get; } = new CuratorJournalEntities();
    }
}
