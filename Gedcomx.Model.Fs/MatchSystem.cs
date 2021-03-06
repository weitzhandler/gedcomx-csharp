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
    ///  Identifiers for a system that might contain match results.
    /// </remarks>
    /// <summary>
    ///  Identifiers for a system that might contain match results.
    /// </summary>
    public enum MatchSystem
    {

        /// <summary>
        ///  Unspecified enum value.
        /// </summary>
        [XmlEnumAttribute(Name = "__NULL__")]
        NULL,

        /// <summary>
        ///   The FamilySearch Family Tree.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/tree")]
        tree,

        /// <summary>
        ///   The FamilySearch Record Set.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/records")]
        records,

        /// <summary>
        ///   The FamilySearch User-Submitted Trees.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/trees")]
        lls,

        /// <summary>
        ///   The FamilySearch Temple System.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/temple")]
        tss,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://gedcomx.org/OTHER")]
        OTHER
    }
}
