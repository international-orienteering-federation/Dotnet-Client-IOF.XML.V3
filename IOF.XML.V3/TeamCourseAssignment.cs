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
  public partial class TeamCourseAssignment {
    public string BibNumber { get; set; }
    public string TeamName { get; set; }
    public string ClassName { get; set; }
    [XmlElement("TeamMemberCourseAssignment")]
    public TeamMemberCourseAssignment[] TeamMemberCourseAssignment { get; set; }
    public Extensions Extensions { get; set; }
  }
}