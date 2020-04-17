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
  public partial class CourseControl {
    [XmlElement("Control")]
    public string[] Control { get; set; }
    public string MapText { get; set; }
    public MapPosition MapTextPosition { get; set; }
    public double LegLength { get; set; }
    [XmlIgnore()]
    public bool LegLengthSpecified { get; set; }
    public double Score { get; set; }
    [XmlIgnore()]
    public bool ScoreSpecified { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("type")]
    public ControlType Type { get; set; }
    [XmlIgnore()]
    public bool TypeSpecified { get; set; }
    [XmlAttribute("randomOrder")]
    [DefaultValue(false)]
    public bool RandomOrder { get; set; } = false;
    [XmlAttribute("specialInstruction")]
    [DefaultValue(CourseControlSpecialInstruction.None)]
    public CourseControlSpecialInstruction SpecialInstruction { get; set; } = CourseControlSpecialInstruction.None;
    [XmlAttribute("tapedRouteLength")]
    public double TapedRouteLength { get; set; }
    [XmlIgnore()]
    public bool TapedRouteLengthSpecified { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}