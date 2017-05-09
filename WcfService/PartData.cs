using System;

namespace WcfService
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