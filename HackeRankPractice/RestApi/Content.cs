using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class Content
{
    [DataMember]
    public int page { get; set; }
    [DataMember]
    public int per_page { get; set; }
    [DataMember]
    public int total { get; set; }
    [DataMember]
    public int total_pages { get; set; }
    [DataMember]
    public List<Data> data { get; set; }
}
