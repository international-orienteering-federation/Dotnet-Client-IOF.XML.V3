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
  public partial class Fee {
    public Id Id { get; set; }
    [XmlElement("Name")]
    public LanguageString[] Name { get; set; }
    public Amount Amount { get; set; }
    public Amount TaxableAmount { get; set; }
    public double Percentage { get; set; }
    [XmlIgnore()]
    public bool PercentageSpecified { get; set; }
    public double TaxablePercentage { get; set; }
    [XmlIgnore()]
    public bool TaxablePercentageSpecified { get; set; }
    public DateTime ValidFromTime { get; set; }
    [XmlIgnore()]
    public bool ValidFromTimeSpecified { get; set; }
    public DateTime ValidToTime { get; set; }
    [XmlIgnore()]
    public bool ValidToTimeSpecified { get; set; }
    [XmlElement(DataType = "date")]
    public DateTime FromDateOfBirth { get; set; }
    [XmlIgnore()]
    public bool FromDateOfBirthSpecified { get; set; }
    [XmlElement(DataType = "date")]
    public DateTime ToDateOfBirth { get; set; }
    [XmlIgnore()]
    public bool ToDateOfBirthSpecified { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute("type")]
    [DefaultValue(FeeType.Normal)]
    public FeeType Type { get; set; } = FeeType.Normal;
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}