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
  public partial class ClassResult {
    public Class Class { get; set; }
    [XmlElement("Course")]
    public SimpleRaceCourse[] Course { get; set; }
    [XmlElement("PersonResult")]
    public PersonResult[] PersonResult { get; set; }
    [XmlElement("TeamResult")]
    public TeamResult[] TeamResult { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("timeResolution")]
    [DefaultValue(1D)]
    public double TimeResolution { get; set; } = 1D;
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}