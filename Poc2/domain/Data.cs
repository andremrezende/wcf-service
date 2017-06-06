using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc2.domain
{
    public class Data
    {
        public int TotalCount { get; set; }
        public string SoftwareVersion { get; set; }
        public long ComTick { get; set; }
        public bool IsInit { get; set; }
        public List<string> NameList { get; set; }
        public ObservableCollection<PartData> CompositeData { get; set; }
        public byte[] File { get; set; }
    }
}
