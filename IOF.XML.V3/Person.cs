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
  public partial class Person {
    [XmlElement("Id")]
    public Id[] Id { get; set; }
    public PersonName Name { get; set; }
    [XmlElement(DataType = "date")]
    public DateTime BirthDate { get; set; }
    [XmlIgnore()]
    public bool BirthDateSpecified { get; set; }
    public Country Nationality { get; set; }
    [XmlElement("Address")]
    public Address[] Address { get; set; }
    [XmlElement("Contact")]
    public Contact[] Contact { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("sex")]
    public PersonSex Sex { get; set; }
    [XmlIgnore()]
    public bool SexSpecified { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}