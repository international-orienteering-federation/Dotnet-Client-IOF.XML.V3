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
  public partial class RaceCourseData {
    [XmlElement("Map")]
    public Map[] Map { get; set; }
    [XmlElement("Control")]
    public Control[] Control { get; set; }
    [XmlElement("Course")]
    public Course[] Course { get; set; }
    [XmlElement("ClassCourseAssignment")]
    public ClassCourseAssignment[] ClassCourseAssignment { get; set; }
    [XmlElement("PersonCourseAssignment")]
    public PersonCourseAssignment[] PersonCourseAssignment { get; set; }
    [XmlElement("TeamCourseAssignment")]
    public TeamCourseAssignment[] TeamCourseAssignment { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "raceNumber")]
    public string RaceNumber { get; set; }
  }
}