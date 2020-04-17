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
  public partial class Competitor {
    public Person Person { get; set; }
    [XmlElement("Organisation")]
    public Organisation[] Organisation { get; set; }
    [XmlElement("ControlCard")]
    public ControlCard[] ControlCard { get; set; }
    [XmlElement("Class")]
    public Class[] Class { get; set; }
    [XmlElement("Score")]
    public Score[] Score { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}