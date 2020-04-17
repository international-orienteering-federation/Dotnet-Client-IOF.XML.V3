using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [Serializable()]
  [DebuggerStepThrough()]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.orienteering.org/datastandard/3.0")]
  [XmlRoot(Namespace = "http://www.orienteering.org/datastandard/3.0", IsNullable = false)]
  public partial class ResultList : BaseMessageElement {
    public Event Event { get; set; }
    [XmlElement("ClassResult")]
    public ClassResult[] ClassResult { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("status")]
    [DefaultValue(ResultListStatus.Complete)]
    public ResultListStatus Status { get; set; } = ResultListStatus.Complete;
  }
}