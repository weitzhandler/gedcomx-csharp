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
    ///  Enumeration of standard event roles.
    /// </remarks>
    /// <summary>
    ///  Enumeration of standard event roles.
    /// </summary>
    public enum EventRoleType
    {

        /// <summary>
        ///  Unspecified enum value.
        /// </summary>
        [XmlEnumAttribute(Name = "__NULL__")]
        NULL,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://gedcomx.org/Principal")]
        Principal,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://gedcomx.org/Participant")]
        Participant,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://gedcomx.org/Official")]
        Official,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://gedcomx.org/Witness")]
        Witness,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [XmlEnum("http://gedcomx.org/OTHER")]
        OTHER
    }
}
