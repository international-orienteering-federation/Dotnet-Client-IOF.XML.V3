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
  public partial class Schedule {
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    [XmlIgnore()]
    public bool EndTimeSpecified { get; set; }
    public string Name { get; set; }
    public string Venue { get; set; }
    public GeoPosition Position { get; set; }
    public string Details { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}