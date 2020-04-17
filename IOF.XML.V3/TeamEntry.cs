using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [Serializable()]
  [DebuggerStepThrough()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.orienteering.org/datastandard/3.0")]
  public partial class TeamEntry {
    public Id Id { get; set; }
    public string Name { get; set; }
    [XmlElement("Organisation")]
    public Organisation[] Organisation { get; set; }
    [XmlElement("TeamEntryPerson")]
    public TeamEntryPerson[] TeamEntryPerson { get; set; }
    [XmlElement("Class")]
    public Class[] Class { get; set; }
    [XmlElement("Race", DataType = "integer")]
    public string[] Race { get; set; }
    [XmlElement("AssignedFee")]
    public AssignedFee[] AssignedFee { get; set; }
    [XmlElement("ServiceRequest")]
    public ServiceRequest[] ServiceRequest { get; set; }
    public StartTimeAllocationRequest StartTimeAllocationRequest { get; set; }
    public string ContactInformation { get; set; }
    public DateTime EntryTime { get; set; }
    [XmlIgnore()]
    public bool EntryTimeSpecified { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}