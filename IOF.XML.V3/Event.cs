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
  public partial class Event {
    public Id Id { get; set; }
    public string Name { get; set; }
    public DateAndOptionalTime StartTime { get; set; }
    public DateAndOptionalTime EndTime { get; set; }
    public EventStatus Status { get; set; }
    [XmlIgnore()]
    public bool StatusSpecified { get; set; }
    public EventClassification Classification { get; set; }
    [XmlIgnore()]
    public bool ClassificationSpecified { get; set; }
    [XmlElement("Form")]
    public EventForm[] Form { get; set; }
    [XmlElement("Organiser")]
    public Organisation[] Organiser { get; set; }
    [XmlElement("Official")]
    public Role[] Official { get; set; }
    [XmlElement("Class")]
    public Class[] Class { get; set; }
    [XmlElement("Race")]
    public Race[] Race { get; set; }
    public EntryReceiver EntryReceiver { get; set; }
    [XmlElement("Service")]
    public Service[] Service { get; set; }
    [XmlElement("Account")]
    public Account[] Account { get; set; }
    [XmlElement("URL")]
    public EventURL[] URL { get; set; }
    [XmlElement("Information")]
    public InformationItem[] Information { get; set; }
    [XmlElement("Schedule")]
    public Schedule[] Schedule { get; set; }
    [XmlElement("News")]
    public InformationItem[] News { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}