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
  public partial class Control {
    public Id Id { get; set; }
    [XmlElement("PunchingUnitId")]
    public Id[] PunchingUnitId { get; set; }
    [XmlElement("Name")]
    public LanguageString[] Name { get; set; }
    public GeoPosition Position { get; set; }
    public MapPosition MapPosition { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("type")]
    [DefaultValue(ControlType.Control)]
    public ControlType Type { get; set; } = ControlType.Control;
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}