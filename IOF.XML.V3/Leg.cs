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
  public partial class Leg {
    public string Name { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "minNumberOfCompetitors")]
    [DefaultValue("1")]
    public string MinNumberOfCompetitors { get; set; } = "1";
    [XmlAttribute(DataType = "integer", AttributeName = "maxNumberOfCompetitors")]
    [DefaultValue("1")]
    public string MaxNumberOfCompetitors { get; set; } = "1";
  }
}