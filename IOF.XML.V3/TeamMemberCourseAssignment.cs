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
  public partial class TeamMemberCourseAssignment {
    public Id EntryId { get; set; }
    public string BibNumber { get; set; }
    [XmlElement(DataType = "integer")]
    public string Leg { get; set; }
    [XmlElement(DataType = "integer")]
    public string LegOrder { get; set; }
    public string TeamMemberName { get; set; }
    public string CourseName { get; set; }
    public string CourseFamily { get; set; }
    public Extensions Extensions { get; set; }
  }
}