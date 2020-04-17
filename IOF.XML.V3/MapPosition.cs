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
  public partial class MapPosition {
    [XmlAttribute("x")]
    public double X { get; set; }
    [XmlAttribute("y")]
    public double Y { get; set; }
    [XmlAttribute("unit")]
    [DefaultValue(MapPositionUnit.mm)]
    public MapPositionUnit Unit { get; set; } = MapPositionUnit.mm;
  }
}