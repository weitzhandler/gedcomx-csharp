// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gx.Fs.Tree
{

    /// <remarks>
    ///  The way a match was resolved.
    /// </remarks>
    /// <summary>
    ///  The way a match was resolved.
    /// </summary>
    public enum MatchResolution
    {

        /// <summary>
        ///  Unspecified enum value.
        /// </summary>
        [XmlEnumAttribute(Name = "__NULL__")]
        NULL,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Unset")]
        Unset,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Positive")]
        Positive,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Negative")]
        Negative
    }
}
