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
  public partial class ClassStart {
    public Class Class { get; set; }
    [XmlElement("Course")]
    public SimpleRaceCourse[] Course { get; set; }
    [XmlElement("StartName")]
    public StartName[] StartName { get; set; }
    [XmlElement("PersonStart")]
    public PersonStart[] PersonStart { get; set; }
    [XmlElement("TeamStart")]
    public TeamStart[] TeamStart { get; set; }
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