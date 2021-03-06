using Gx.Common;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gx.Source
{

    /// <remarks>
    ///  
    /// </remarks>
    /// <summary>
    ///  
    /// </summary>
    // TODO: Create attribute equivalent to JsonWrapper (for each call to FindExtensionsOfType<T>() and FindExtensionOfType<T>())
    [Serializable]
    [XmlType(Namespace = "http://familysearch.org/v1/", TypeName = "DiscussionReference")]
    [XmlRoot(Namespace = "http://familysearch.org/v1/", ElementName = "discussion-reference")]
    public sealed partial class DiscussionReference : Gx.Links.HypermediaEnabledData
    {

        private string _resourceId;
        private string _resource;
        private Gx.Common.Attribution _attribution;
        /// <summary>
        ///  The id of the discussion being referenced.
        /// </summary>
        [XmlAttribute(AttributeName = "resourceId")]
        [JsonProperty("resourceId")]
        public string ResourceId
        {
            get
            {
                return this._resourceId;
            }
            set
            {
                this._resourceId = value;
            }
        }
        /// <summary>
        ///  The URI to the resource.
        /// </summary>
        [XmlAttribute(AttributeName = "resource")]
        [JsonProperty("resource")]
        public string Resource
        {
            get
            {
                return this._resource;
            }
            set
            {
                this._resource = value;
            }
        }
        /// <summary>
        ///  The attribution metadata for this discussion reference.
        /// </summary>
        [XmlElement(ElementName = "attribution", Namespace = "http://familysearch.org/v1/")]
        [JsonProperty("attribution")]
        public Gx.Common.Attribution Attribution
        {
            get
            {
                return this._attribution;
            }
            set
            {
                this._attribution = value;
            }
        }

        /**
         * Build up this discussion reference with a resource id.
         *
         * @param resourceId The resource id.
         * @return this.
         */
        public DiscussionReference SetResourceId(String resourceId)
        {
            ResourceId = resourceId;
            return this;
        }

        /**
         * Build up this discussion reference with attribution.
         *
         * @param attribution The attribution.
         * @return this.
         */
        public DiscussionReference SetAttribution(Attribution attribution)
        {
            Attribution = attribution;
            return this;
        }
    }
}
