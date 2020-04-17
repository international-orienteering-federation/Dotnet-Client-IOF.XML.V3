using System;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [Serializable()]
  [XmlType(AnonymousType = true, Namespace = "http://www.orienteering.org/datastandard/3.0")]
  public enum StartTimeAllocationRequestType {
    Normal,
    EarlyStart,
    LateStart,
    SeparatedFrom,
    GroupedWith,
  }
}