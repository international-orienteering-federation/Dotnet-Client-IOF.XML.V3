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
  public partial class Course {
    public Id Id { get; set; }
    public string Name { get; set; }
    public string CourseFamily { get; set; }
    public double Length { get; set; }
    [XmlIgnore()]
    public bool LengthSpecified { get; set; }
    public double Climb { get; set; }
    [XmlIgnore()]
    public bool ClimbSpecified { get; set; }
    [XmlElement("CourseControl")]
    public CourseControl[] CourseControl { get; set; }
    [XmlElement(DataType = "integer")]
    public string MapId { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "numberOfCompetitors")]
    public string NumberOfCompetitors { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}