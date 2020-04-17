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
  public partial class EntryReceiver {
    [XmlElement("Address")]
    public Address[] Address { get; set; }
    [XmlElement("Contact")]
    public Contact[] Contact { get; set; }
  }
}