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
  public partial class PersonEntry {
    public Id Id { get; set; }
    public Person Person { get; set; }
    public Organisation Organisation { get; set; }
    [XmlElement("ControlCard")]
    public ControlCard[] ControlCard { get; set; }
    [XmlElement("Score")]
    public Score[] Score { get; set; }
    [XmlElement("Class")]
    public Class[] Class { get; set; }
    [XmlElement("RaceNumber", DataType = "integer")]
    public string[] RaceNumber { get; set; }
    [XmlElement("AssignedFee")]
    public AssignedFee[] AssignedFee { get; set; }
    [XmlElement("ServiceRequest")]
    public ServiceRequest[] ServiceRequest { get; set; }
    public StartTimeAllocationRequest StartTimeAllocationRequest { get; set; }
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