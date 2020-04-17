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
  public partial class TeamEntryPerson {
    public Person Person { get; set; }
    public Organisation Organisation { get; set; }
    [XmlElement(DataType = "integer")]
    public string Leg { get; set; }
    [XmlElement(DataType = "integer")]
    public string LegOrder { get; set; }
    [XmlElement("ControlCard")]
    public ControlCard[] ControlCard { get; set; }
    [XmlElement("Score")]
    public Score[] Score { get; set; }
    [XmlElement("AssignedFee")]
    public AssignedFee[] AssignedFee { get; set; }
    public Extensions Extensions { get; set; }
  }
}