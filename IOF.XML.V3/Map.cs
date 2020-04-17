using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [Serializable()]
  [DebuggerStepThrough()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.orienteering.org/datastandard/3.0")]
  public partial class Map {
    public Id Id { get; set; }
    public Image Image { get; set; }
    public double Scale { get; set; }
    public MapPosition MapPositionTopLeft { get; set; }
    public MapPosition MapPositionBottomRight { get; set; }
    public Extensions Extensions { get; set; }
  }
}