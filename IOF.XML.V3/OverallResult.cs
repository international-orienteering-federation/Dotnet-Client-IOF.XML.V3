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
  public partial class OverallResult {
    public double Time { get; set; }
    [XmlIgnore()]
    public bool TimeSpecified { get; set; }
    public double TimeBehind { get; set; }
    [XmlIgnore()]
    public bool TimeBehindSpecified { get; set; }
    [XmlElement(DataType = "integer")]
    public string Position { get; set; }
    public ResultStatus Status { get; set; }
    [XmlElement("Score")]
    public Score[] Score { get; set; }
    public Extensions Extensions { get; set; }
  }
}