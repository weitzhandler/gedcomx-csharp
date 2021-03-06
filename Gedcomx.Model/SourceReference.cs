using Gedcomx.Model.Rt;
using Gx.Common;
using Newtonsoft.Json;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Gx.Source
{

    /// <remarks>
    ///  An attributable reference to a description of a source.
    /// </remarks>
    /// <summary>
    ///  An attributable reference to a description of a source.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://gedcomx.org/v1/", TypeName = "SourceReference")]
    [XmlRoot(Namespace = "http://gedcomx.org/v1/", ElementName = "sourceReference")]
    public partial class SourceReference : Gx.Links.HypermediaEnabledData, IAttributable
    {

        private string _descriptionRef;
        private Gx.Common.Attribution _attribution;
        private List<Gx.Common.Qualifier> _qualifiers;
        private List<Gx.Source.Tag> _tags;
        /// <summary>
        ///  A reference to a description of the source being referenced.
        /// </summary>
        [XmlAttribute(AttributeName = "description")]
        [JsonProperty("description")]
        public string DescriptionRef
        {
            get
            {
                return this._descriptionRef;
            }
            set
            {
                this._descriptionRef = value;
            }
        }
        /// <summary>
        ///  The attribution metadata for this source reference.
        /// </summary>
        [XmlElement(ElementName = "attribution", Namespace = "http://gedcomx.org/v1/")]
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
        /// <summary>
        ///  The qualifiers associated with this source reference.
        /// </summary>
        [XmlElement(ElementName = "qualifier", Namespace = "http://gedcomx.org/v1/")]
        [JsonProperty("qualifiers")]
        public List<Gx.Common.Qualifier> Qualifiers
        {
            get
            {
                return this._qualifiers;
            }
            set
            {
                this._qualifiers = value;
            }
        }
        /// <summary>
        ///  The tags associated with this source reference.
        /// </summary>
        [XmlElement(ElementName = "tags", Namespace = "http://gedcomx.org/v1/")]
        [JsonProperty("tags")]
        public List<Gx.Source.Tag> Tags
        {
            get
            {
                return this._tags;
            }
            set
            {
                this._tags = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor.
         */
        public void Accept(IGedcomxModelVisitor visitor)
        {
            visitor.VisitSourceReference(this);
        }

        /**
         * Build up this source reference with a description reference.
         *
         * @param description The description.
         * @return this.
         */
        public SourceReference SetDescription(SourceDescription description)
        {
            if (description.Id == null)
            {
                throw new ArgumentException("Cannot reference description: no id.");
            }
            return SetDescriptionRef("#" + description.Id);
        }

        /**
         * Build up this source reference with attribution.
         *
         * @param attribution The attribution.
         * @return this.
         */
        public SourceReference SetAttribution(Attribution attribution)
        {
            Attribution = attribution;
            return this;
        }

        /**
         * Build up this source reference with a description reference.
         *
         * @param descriptionRef The description ref.
         * @return this.
         */
        public SourceReference SetDescriptionRef(String descriptionRef)
        {
            DescriptionRef = descriptionRef;
            return this;
        }

        /**
         * Build up this source reference with a qualifier.
         *
         * @param qualifier The qualifier.
         * @return this.
         */
        public SourceReference SetQualifier(Qualifier qualifier)
        {
            AddQualifier(qualifier);
            return this;
        }

        /**
         * Add a qualifier.
         *
         * @param qualifier The qualifier.
         */
        public void AddQualifier(Qualifier qualifier)
        {
            if (_qualifiers == null)
            {
                _qualifiers = new List<Qualifier>();
            }
            _qualifiers.Add(qualifier);
        }
    }
}
