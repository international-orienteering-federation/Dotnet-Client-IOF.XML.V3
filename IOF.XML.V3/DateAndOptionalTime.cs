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
  public partial class DateAndOptionalTime {
    [XmlElement(DataType = "date")]
    public DateTime Date { get; set; }
    [XmlElement(DataType = "time")]
    public DateTime Time { get; set; }
    [XmlIgnore()]
    public bool TimeSpecified { get; set; }
  }
}