using System.Runtime.Serialization;

[DataContract]
public class Data
{
    [DataMember]
    public int team1goals { get; set; }
    [DataMember]
    public int team2goals { get; set; }
}
