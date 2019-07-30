using Australia_Scanner.HomeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Australia_Scanner.Event
{
    public class LoadInfoToGridEventArgs
    {
        public List<InfoDisplayOnGridView> Info { get; set; }
    }
}
