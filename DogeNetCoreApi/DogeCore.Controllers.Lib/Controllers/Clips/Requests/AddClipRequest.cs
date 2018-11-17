using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DogeNetCore.Controllers.lib.Controllers.Clips.Requests
{
    [DataContract]
    public class AddClipRequest
    {
        [DataMember, Required]
        public string Name { get; set; }
        [DataMember, Required]
        public string Uri { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string SourceType { get; set; }
        [DataMember]
        public int StartTime { get; set; }
        [DataMember]
        public int EndTime { get; set; }
    }
}
