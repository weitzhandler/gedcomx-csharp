// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gx.Common
{

    /// <remarks>
    ///  A generic reference to a resource.
    /// </remarks>
    /// <summary>
    ///  A generic reference to a resource.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://gedcomx.org/v1/", TypeName = "ResourceReference")]
    [XmlRoot(Namespace = "http://gedcomx.org/v1/", ElementName = "resourceReference")]
    public sealed partial class ResourceReference
    {
        public ResourceReference()
        {
        }

        public ResourceReference(string resource)
            : this()
        {
            Resource = resource;
        }

        private string _resourceId;
        private string _resource;
        /// <summary>
        ///  The resource id of the resource being referenced.
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

        /**
         * Build up this resource reference with a resource id.
         *
         * @param resourceId The resource id.
         * @return this.
         */
        public ResourceReference SetResourceId(String resourceId)
        {
            ResourceId = resourceId;
            return this;
        }

        /**
         * Build up this resource reference with a resource.
         *
         * @param resource The resource.
         * @return this.
         */
        public ResourceReference SetResource(String resource)
        {
            Resource = resource;
            return this;
        }
    }
}
