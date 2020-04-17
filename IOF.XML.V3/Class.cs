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
  public partial class Class {
    public Id Id { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    [XmlElement("ClassType")]
    public ClassType[] ClassType { get; set; }
    [XmlElement("Leg")]
    public Leg[] Leg { get; set; }
    [XmlElement("TeamFee")]
    public Fee[] TeamFee { get; set; }
    [XmlElement("Fee")]
    public Fee[] Fee { get; set; }
    [DefaultValue(EventClassStatus.Normal)]
    public EventClassStatus Status { get; set; } = EventClassStatus.Normal;
    [XmlElement("RaceClass")]
    public RaceClass[] RaceClass { get; set; }
    public Class TooFewEntriesSubstituteClass { get; set; }
    public Class TooManyEntriesSubstituteClass { get; set; }
    public Extensions Extensions { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "minAge")]
    public string MinAge { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "maxAge")]
    public string MaxAge { get; set; }
    [XmlAttribute("sex")]
    [DefaultValue(ClassSex.B)]
    public ClassSex Sex { get; set; } = ClassSex.B;
    [XmlAttribute(DataType = "integer", AttributeName = "minNumberOfTeamMembers")]
    [DefaultValue("1")]
    public string MinNumberOfTeamMembers { get; set; } = "1";
    [XmlAttribute(DataType = "integer", AttributeName = "maxNumberOfTeamMembers")]
    [DefaultValue("1")]
    public string MaxNumberOfTeamMembers { get; set; } = "1";
    [XmlAttribute(DataType = "integer", AttributeName = "minTeamAge")]
    public string MinTeamAge { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "maxTeamAge")]
    public string MaxTeamAge { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "numberOfCompetitors")]
    public string NumberOfCompetitors { get; set; }
    [XmlAttribute(DataType = "integer", AttributeName = "maxNumberOfCompetitors")]
    public string MaxNumberOfCompetitors { get; set; }
    [XmlAttribute("resultListMode")]
    [DefaultValue(ClassResultListMode.Default)]
    public ClassResultListMode ResultListMode { get; set; } = ClassResultListMode.Default;
    [XmlAttribute("modifyTime")]
    public DateTime ModifyTime { get; set; }
    [XmlIgnore()]
    public bool ModifyTimeSpecified { get; set; }
  }
}