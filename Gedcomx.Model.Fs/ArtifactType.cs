// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gx.Fs.Artifacts
{

    /// <remarks>
    ///  Enumeration of known artifact types.
    /// </remarks>
    /// <summary>
    ///  Enumeration of known artifact types.
    /// </summary>
    public enum ArtifactType
    {

        /// <summary>
        ///  Unspecified enum value.
        /// </summary>
        [XmlEnumAttribute(Name = "__NULL__")]
        NULL,

        /// <summary>
        ///   The artifact is an audio.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Audio")]
        Audio,

        /// <summary>
        ///   The artifact is an image of a document.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Document")]
        Document,

        /// <summary>
        ///   The artifact is an image.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Image")]
        Image,

        /// <summary>
        ///   The artifact is a portrait.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Portrait")]
        Portrait,

        /// <summary>
        ///   The artifact is a story.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Story")]
        Story,

        /// <summary>
        ///   The artifact is a video.
        /// </summary>
        [XmlEnum("http://familysearch.org/v1/Video")]
        Video,

        /// <summary>
        ///   Custom
        /// </summary>
        [XmlEnum("http://gedcomx.org/OTHER")]
        OTHER
    }
}
