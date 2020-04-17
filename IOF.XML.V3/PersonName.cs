using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [Serializable()]
  [DebuggerStepThrough()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.orienteering.org/datastandard/3.0")]
  public partial class PersonName {
    public string Family { get; set; }
    public string Given { get; set; }
  }
}