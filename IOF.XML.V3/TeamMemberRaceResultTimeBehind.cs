using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [Serializable()]
  [DebuggerStepThrough()]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.orienteering.org/datastandard/3.0")]
  public partial class TeamMemberRaceResultTimeBehind {
    [XmlAttribute("type")]
    public TeamMemberRaceResultTimeBehindType Type { get; set; }
    [XmlText()]
    public double Value { get; set; }
  }
}