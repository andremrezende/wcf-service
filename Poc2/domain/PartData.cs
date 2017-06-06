using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc2.domain
{
    public class PartData
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public bool Status { get; set; }
        public TimeSpan ProcTime { get; set; }
    }
}
