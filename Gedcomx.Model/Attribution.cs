using Gedcomx.Model.Util;
using Newtonsoft.Json;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Gx.Common
{

    /// <remarks>
    ///  Attribution for genealogical information. Attribution is used to model &lt;strong&gt;who&lt;/strong&gt; is contributing/modifying
    ///  information, &lt;strong&gt;when&lt;/strong&gt; they contributed it, and &lt;strong&gt;why&lt;/strong&gt; they are making the
    ///  contribution/modification.
    /// </remarks>
    /// <summary>
    ///  Attribution for genealogical information. Attribution is used to model &lt;strong&gt;who&lt;/strong&gt; is contributing/modifying
    ///  information, &lt;strong&gt;when&lt;/strong&gt; they contributed it, and &lt;strong&gt;why&lt;/strong&gt; they are making the
    ///  contribution/modification.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://gedcomx.org/v1/", TypeName = "Attribution")]
    [XmlRoot(Namespace = "http://gedcomx.org/v1/", ElementName = "attribution")]
    public sealed partial class Attribution : Gx.Common.ExtensibleData
    {

        private Gx.Common.ResourceReference _contributor;
        private DateTime? _modified;
        private bool _modifiedSpecified;
        private string _changeMessage;
        /// <summary>
        ///  Reference to the contributor of the attributed data.
        /// </summary>
        [XmlElement(ElementName = "contributor", Namespace = "http://gedcomx.org/v1/")]
        [JsonProperty("contributor")]
        public Gx.Common.ResourceReference Contributor
        {
            get
            {
                return this._contributor;
            }
            set
            {
                this._contributor = value;
            }
        }
        /// <summary>
        ///  The modified timestamp for the attributed data.
        /// </summary>
        [XmlElement(ElementName = "modified", Namespace = "http://gedcomx.org/v1/")]
        [JsonProperty("modified")]
        [JsonConverter(typeof(JsonUnixTimestampConverter))]
        public DateTime Modified
        {
            get
            {
                return this._modified.GetValueOrDefault();
            }
            set
            {
                this._modified = value;
                this._modifiedSpecified = true;
            }
        }

        /// <summary>
        ///  Property for the XML serializer indicating whether the "Modified" property should be included in the output.
        /// </summary>
        [XmlIgnore]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonIgnore]
        public bool ModifiedSpecified
        {
            get
            {
                return this._modifiedSpecified;
            }
            set
            {
                this._modifiedSpecified = value;
            }
        }

        /// <summary>
        ///  The &quot;change message&quot; for the attributed data provided by the contributor.
        /// </summary>
        [XmlElement(ElementName = "changeMessage", Namespace = "http://gedcomx.org/v1/")]
        [JsonProperty("changeMessage")]
        public string ChangeMessage
        {
            get
            {
                return this._changeMessage;
            }
            set
            {
                this._changeMessage = value;
            }
        }

        /**
         * Build up this attribution with a contributor.
         *
         * @param agent The contributor.
         * @return this.
         */
        public Attribution SetContributor(Gx.Agent.Agent agent)
        {
            if (agent.Id == null)
            {
                throw new ArgumentException("Can't reference agent as a contributor: no id.");
            }
            return SetContributor(new ResourceReference("#" + agent.Id));
        }

        /**
         * Build up this attribution with a contributor.
         *
         * @param contributor The contributor.
         * @return this.
         */
        public Attribution SetContributor(ResourceReference contributor)
        {
            this.Contributor = contributor;
            return this;
        }

        /**
         * Build up this attribution with a modified date.
         *
         * @param modified The modified date.
         * @return this.
         */
        public Attribution SetModified(DateTime modified)
        {
            this.Modified = modified;
            return this;
        }

        public Attribution SetChangeMessage(String changeMessage)
        {
            this.ChangeMessage = changeMessage;
            return this;
        }
    }
}
