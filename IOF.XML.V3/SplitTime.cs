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
  public partial class SplitTime {
    public string ControlCode { get; set; }
    public double Time { get; set; }
    [XmlIgnore()]
    public bool TimeSpecified { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("status")]
    [DefaultValue(SplitTimeStatus.OK)]
    public SplitTimeStatus Status { get; set; } = SplitTimeStatus.OK;
  }
}