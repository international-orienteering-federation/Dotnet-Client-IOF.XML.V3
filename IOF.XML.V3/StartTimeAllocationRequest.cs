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
  public partial class StartTimeAllocationRequest {
    public Organisation Organisation { get; set; }
    public Person Person { get; set; }
    [XmlAttribute("type")]
    [DefaultValue(StartTimeAllocationRequestType.Normal)]
    public StartTimeAllocationRequestType Type { get; set; } = StartTimeAllocationRequestType.Normal;
  }
}