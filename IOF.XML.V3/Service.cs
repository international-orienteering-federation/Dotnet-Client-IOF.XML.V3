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
  public partial class Service {
    public Id Id { get; set; }
    [XmlElement("Name")]
    public LanguageString[] Name { get; set; }
    [XmlElement("Fee")]
    public Fee[] Fee { get; set; }
    [XmlElement("Description")]
    public LanguageString[] Description { get; set; }
    public double MaxNumber { get; set; }
    [XmlIgnore()]
    public bool MaxNumberSpecified { get; set; }
    public double RequestedNumber { get; set; }
    [XmlIgnore()]
    public bool RequestedNumberSpecified { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("type")]
    public string Type { get; set; }
    [XmlAttribute()]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}