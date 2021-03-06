// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gx.Types {

  /// <remarks>
  ///  Enumeration of high-level genealogical resource types.
  /// </remarks>
  /// <summary>
  ///  Enumeration of high-level genealogical resource types.
  /// </summary>
  public enum ResourceType {

    /// <summary>
    ///  Unspecified enum value.
    /// </summary>
    [XmlEnumAttribute(Name="__NULL__")]
    NULL,

    /// <summary>
    ///   A historical record.
    /// </summary>
    [XmlEnum("http://gedcomx.org/Record")]
    Record,

    /// <summary>
    ///   A collection.
    /// </summary>
    [XmlEnum("http://gedcomx.org/Collection")]
    Collection,

    /// <summary>
    ///   A digital artifact, such as a digital image or video.
    /// </summary>
    [XmlEnum("http://gedcomx.org/DigitalArtifact")]
    DigitalArtifact,

    /// <summary>
    ///   A physical artifact.
    /// </summary>
    [XmlEnum("http://gedcomx.org/PhysicalArtifact")]
    PhysicalArtifact,

    /// <summary>
    ///   A person.
    /// </summary>
    [XmlEnum("http://gedcomx.org/Person")]
    Person,

    /// <summary>
    ///  (no documentation provided)
    /// </summary>
    [XmlEnum("http://gedcomx.org/OTHER")]
    OTHER
  }
}
