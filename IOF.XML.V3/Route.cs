﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace IOF.XML.V3 {
  [Serializable()]
  [DebuggerStepThrough()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.orienteering.org/datastandard/3.0")]
  public partial class Route {
    [XmlTextAttribute(DataType = "base64Binary")]
    public byte[] Value { get; set; }
  }
}