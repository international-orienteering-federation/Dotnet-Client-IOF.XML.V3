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
  public partial class Race {
    [XmlElement(DataType = "integer")]
    public string RaceNumber { get; set; }
    public string Name { get; set; }
    public DateAndOptionalTime StartTime { get; set; }
    public DateAndOptionalTime EndTime { get; set; }
    public EventStatus Status { get; set; }
    [XmlIgnore()]
    public bool StatusSpecified { get; set; }
    public EventClassification Classification { get; set; }
    [XmlIgnore()]
    public bool ClassificationSpecified { get; set; }
    public GeoPosition Position { get; set; }
    [XmlElement("Discipline")]
    public RaceDiscipline[] Discipline { get; set; }
    [XmlElement("Organiser")]
    public Organisation[] Organiser { get; set; }
    [XmlElement("Official")]
    public Role[] Official { get; set; }
    [XmlElement("Service")]
    public Service[] Service { get; set; }
    [XmlElement("URL")]
    public EventURL[] URL { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}