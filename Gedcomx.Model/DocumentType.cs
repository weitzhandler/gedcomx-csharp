// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gx.Types
{

    /// <remarks>
    ///  Enumeration of document types.
    /// </remarks>
    /// <summary>
    ///  Enumeration of document types.
    /// </summary>
    public enum DocumentType
    {

        /// <summary>
        ///  Unspecified enum value.
        /// </summary>
        [XmlEnumAttribute(Name = "__NULL__")]
        NULL,

        /// <summary>
        ///   The document is an abstract of a record or document.
        /// </summary>
        [XmlEnum("http://gedcomx.org/Abstract")]
        Abstract,

        /// <summary>
        ///   The document is a translation of a record or document.
        /// </summary>
        [XmlEnum("http://gedcomx.org/Translation")]
        Translation,

        /// <summary>
        ///   The document is a transcription (full or partial) of a record or document.
        /// </summary>
        [XmlEnum("http://gedcomx.org/Transcription")]
        Transcription,

        /// <summary>
        ///   The document is an analysis done by a researcher, often used as a genealogical proof statement.
        /// </summary>
        [XmlEnum("http://gedcomx.org/Analysis")]
        Analysis,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://gedcomx.org/OTHER")]
        OTHER
    }
}
