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
  public partial class ServiceRequest {
    public Id Id { get; set; }
    public Service Service { get; set; }
    public double RequestedQuantity { get; set; }
    public double DeliveredQuantity { get; set; }
    [XmlIgnore()]
    public bool DeliveredQuantitySpecified { get; set; }
    public string Comment { get; set; }
    [XmlElement("AssignedFee")]
    public AssignedFee[] AssignedFee { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}