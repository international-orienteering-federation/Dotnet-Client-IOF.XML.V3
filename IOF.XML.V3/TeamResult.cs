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
  public partial class TeamResult {
    public Id EntryId { get; set; }
    public string Name { get; set; }
    [XmlElement("Organisation")]
    public Organisation[] Organisation { get; set; }
    public string BibNumber { get; set; }
    [XmlElement("TeamMemberResult")]
    public TeamMemberResult[] TeamMemberResult { get; set; }
    [XmlElement("AssignedFee")]
    public AssignedFee[] AssignedFee { get; set; }
    [XmlElement("ServiceRequest")]
    public ServiceRequest[] ServiceRequest { get; set; }
    public Extensions Extensions { get; set; }
  }
}