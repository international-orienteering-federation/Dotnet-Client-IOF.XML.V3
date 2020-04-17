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
  public partial class PersonRaceResult {
    public string BibNumber { get; set; }
    public DateTime StartTime { get; set; }
    [XmlIgnore()]
    public bool StartTimeSpecified { get; set; }
    public DateTime FinishTime { get; set; }
    [XmlIgnore()]
    public bool FinishTimeSpecified { get; set; }
    public double Time { get; set; }
    [XmlIgnore()]
    public bool TimeSpecified { get; set; }
    public double TimeBehind { get; set; }
    [XmlIgnore()]
    public bool TimeBehindSpecified { get; set; }
    [XmlElement(DataType = "integer")]
    public string Position { get; set; }
    public ResultStatus Status { get; set; }
    [XmlElement("Score")]
    public Score[] Score { get; set; }
    public OverallResult OverallResult { get; set; }
    public SimpleCourse Course { get; set; }
    [XmlElement("SplitTime")]
    public SplitTime[] SplitTime { get; set; }
    [XmlElement("ControlAnswer")]
    public ControlAnswer[] ControlAnswer { get; set; }
    public Route Route { get; set; }
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