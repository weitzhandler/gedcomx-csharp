// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Gx.Types {

  /// <remarks>
  ///  Enumeration of standard identifier types.
  /// </remarks>
  /// <summary>
  ///  Enumeration of standard identifier types.
  /// </summary>
  public enum IdentifierType {

    /// <summary>
    ///  Unspecified enum value.
    /// </summary>
    [System.Xml.Serialization.XmlEnumAttribute(Name="__NULL__")]
    NULL,

    /// <summary>
    ///   The primary identifier for the resource.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Primary")]
    Primary,

    /// <summary>
    ///   An identifier for the evidence that supports the resource. For example, when a conclusion
    ///   about a person is extracted, analyzed and evaluated atomically within the context of a
    ///   single source, it takes the form of a (extracted) person conclusion, and the extracted conclusion
    ///   may supply an identifier for the person. As all evidence for the person is gathered, the
    ///   (working) person conclusion identifies the evidence used to support the conclusion by including
    ///   each evidence identifier in the list of identifiers for the person.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Evidence")]
    Evidence,

    /// <summary>
    ///   An identifier that has been relegated, deprecated, or otherwise downgraded. This
    ///   identifier is commonly used as the result of a merge when what was once a primary
    ///   identifier for a person is no longer primary.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Deprecated")]
    Deprecated,

    /// <summary>
    ///   An identifier that is considered to be a long-term persistent identifier. Applications
    ///   that provide persistent identifiers are claiming that links to the resource using the identifier
    ///   won't break.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Persistent")]
    Persistent,

    /// <summary>
    ///  (no documentation provided)
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/OTHER")]
    OTHER
  }
}
