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
  public partial class ClassCourseAssignment {
    public Id ClassId { get; set; }
    public string ClassName { get; set; }
    [XmlElement("AllowedOnLeg", DataType = "integer")]
    public string[] AllowedOnLeg { get; set; }
    public string CourseName { get; set; }
    public string CourseFamily { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "numberOfCompetitors")]
    public string NumberOfCompetitors { get; set; }
  }
}