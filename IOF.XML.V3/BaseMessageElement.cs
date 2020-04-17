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
  public abstract partial class BaseMessageElement {
    [XmlAttribute("iofVersion")]
    public string IofVersion { get; set; } = "3.0";
    [XmlAttribute("createTime")]
    public DateTime CreateTime { get; set; }
    [XmlIgnore()]
    public bool CreateTimeSpecified { get; set; }
    [XmlAttribute("creator")]
    public string Creator { get; set; }
  }
}