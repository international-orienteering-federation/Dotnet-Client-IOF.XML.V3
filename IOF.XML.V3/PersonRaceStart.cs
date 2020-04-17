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
  public partial class PersonRaceStart {
    public string BibNumber { get; set; }
    public DateTime StartTime { get; set; }
    [XmlIgnore()]
    public bool StartTimeSpecified { get; set; }
    public SimpleCourse Course { get; set; }
    [XmlElement("ControlCard")]
    public ControlCard[] ControlCard { get; set; }
    [XmlElement("AssignedFee")]
    public AssignedFee[] AssignedFee { get; set; }
    [XmlElement("ServiceRequest")]
    public ServiceRequest[] ServiceRequest { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "raceNumber")]
    public string RaceNumber { get; set; }
  }
}