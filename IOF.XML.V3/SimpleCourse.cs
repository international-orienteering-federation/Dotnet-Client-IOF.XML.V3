using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [XmlInclude(typeof(SimpleRaceCourse))]
  [Serializable()]
  [DebuggerStepThrough()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.orienteering.org/datastandard/3.0")]
  public partial class SimpleCourse {
    public Id Id { get; set; }
    public string Name { get; set; }
    public string CourseFamily { get; set; }
    public double Length { get; set; }
    [XmlIgnore()]
    public bool LengthSpecified { get; set; }
    public double Climb { get; set; }
    [XmlIgnore()]
    public bool ClimbSpecified { get; set; }
    [XmlElement(DataType = "integer")]
    public string NumberOfControls { get; set; }
  }
}