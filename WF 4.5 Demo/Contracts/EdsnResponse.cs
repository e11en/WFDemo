using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class EdsnResponse
    {
        [DataMember]
        public int ItemIdentifier { get; set; }

        [DataMember]
        public bool Approved { get; set; }
    }
}
