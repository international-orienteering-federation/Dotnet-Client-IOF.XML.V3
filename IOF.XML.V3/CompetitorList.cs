﻿using System;
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
  public partial class CompetitorList : BaseMessageElement {
    [XmlElement("Competitor")]
    public Competitor[] Competitor { get; set; }
    public Extensions Extensions { get; set; }
  }
}