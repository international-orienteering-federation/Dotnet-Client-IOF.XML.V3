﻿using System;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [Serializable()]
  [XmlType(Namespace = "http://www.orienteering.org/datastandard/3.0")]
  public enum EventClassification {
    International,
    National,
    Regional,
    Local,
    Club,
  }
}