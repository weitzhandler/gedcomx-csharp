using Gedcomx.Model.Util;
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
    ///  Information about a match.
    /// </remarks>
    /// <summary>
    ///  Information about a match.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://familysearch.org/v1/", TypeName = "MatchInfo")]
    [XmlRoot(Namespace = "http://familysearch.org/v1/", ElementName = "matchInfo")]
    public partial class MatchInfo
    {

        private string _status;
        private string _collection;
        /// <summary>
        ///  The way this match has been resolved.
        /// </summary>
        [XmlAttribute(AttributeName = "status")]
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }

        /// <summary>
        ///  Convenience property for treating Status as an enum. See Gx.Fs.Tree.MatchStatusQNameUtil for details on getter/setter functionality.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Gx.Fs.Tree.MatchStatus KnownStatus
        {
            get
            {
                return XmlQNameEnumUtil.GetEnumValue<MatchStatus>(this._status);
            }
            set
            {
                this._status = XmlQNameEnumUtil.GetNameValue(value);
            }
        }
        /// <summary>
        ///  The collection in which this match was found.
        /// </summary>
        [XmlAttribute(AttributeName = "collection")]
        [JsonProperty("collection")]
        public string Collection
        {
            get
            {
                return this._collection;
            }
            set
            {
                this._collection = value;
            }
        }
    }
}
