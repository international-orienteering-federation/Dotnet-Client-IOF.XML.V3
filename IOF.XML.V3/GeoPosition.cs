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
  public partial class GeoPosition {
    [XmlAttribute("lng")]
    public double Lng { get; set; }
    [XmlAttribute("lat")]
    public double Lat { get; set; }
    [XmlAttribute("alt")]
    public double Alt { get; set; }
    [XmlIgnore()]
    public bool AltSpecified { get; set; }
  }
}