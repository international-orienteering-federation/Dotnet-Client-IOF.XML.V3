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
  public partial class RaceClass {
    [XmlElement("PunchingSystem")]
    public string[] PunchingSystem { get; set; }
    [XmlElement("TeamFee")]
    public Fee[] TeamFee { get; set; }
    [XmlElement("Fee")]
    public Fee[] Fee { get; set; }
    public DateTime FirstStart { get; set; }
    [XmlIgnore()]
    public bool FirstStartSpecified { get; set; }
    public RaceClassStatus Status { get; set; }
    [XmlIgnore()]
    public bool StatusSpecified { get; set; }
    [XmlElement("Course")]
    public SimpleCourse[] Course { get; set; }
    [XmlElement("OnlineControl")]
    public Control[] OnlineControl { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "raceNumber")]
    public string RaceNumber { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "maxNumberOfCompetitors")]
    public string MaxNumberOfCompetitors { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}