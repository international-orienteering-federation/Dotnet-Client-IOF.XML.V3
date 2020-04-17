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
  public partial class Image {
    [XmlAttribute("url")]
    public string Url { get; set; }
    [XmlAttribute("mediaType")]
    public string MediaType { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "width")]
    public string Width { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "height")]
    public string Height { get; set; }
    [XmlAttribute("resolution")]
    public double Resolution { get; set; }
    [XmlIgnore()]
    public bool ResolutionSpecified { get; set; }
    [XmlText(DataType = "base64Binary")]
    public byte[] Value { get; set; }
  }
}