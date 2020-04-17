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
  public partial class Organisation {
    public Id Id { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string MediaName { get; set; }
    [XmlElement(DataType = "integer")]
    public string ParentOrganisationId { get; set; }
    public Country Country { get; set; }
    [XmlElement("Address")]
    public Address[] Address { get; set; }
    [XmlElement("Contact")]
    public Contact[] Contact { get; set; }
    public GeoPosition Position { get; set; }
    [XmlElement("Account")]
    public Account[] Account { get; set; }
    [XmlElement("Role")]
    public Role[] Role { get; set; }
    [XmlElement("Logotype")]
    public Image[] Logotype { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("type")]
    public OrganisationType Type { get; set; }
    [XmlIgnore()]
    public bool TypeSpecified { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}