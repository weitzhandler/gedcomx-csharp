using Gedcomx.Model.Util;
using Gx.Common;
using Gx.Source;
using Newtonsoft.Json;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Gx.Conclusion
{

    /// <remarks>
    ///  The &lt;tt&gt;Subject&lt;/tt&gt; data type defines the abstract concept of a genealogical &lt;em&gt;subject&lt;/em&gt;. A &lt;em&gt;subject&lt;/em&gt; is something with a unique and
    ///  intrinsic identity, e.g., a person, a location on the surface of the earth. We identify that &lt;em&gt;subject&lt;/em&gt; in time and space using various supporting
    ///  &lt;em&gt;conclusions&lt;/em&gt;, e.g. for a person: things like name, birth date, age, address, etc. We aggregate these supporting &lt;em&gt;conclusions&lt;/em&gt; to form an
    ///  apparently-unique identity by which we can distinguish our &lt;em&gt;subject&lt;/em&gt; from all other possible &lt;em&gt;subjects&lt;/em&gt;.
    /// </remarks>
    /// <summary>
    ///  The &lt;tt&gt;Subject&lt;/tt&gt; data type defines the abstract concept of a genealogical &lt;em&gt;subject&lt;/em&gt;. A &lt;em&gt;subject&lt;/em&gt; is something with a unique and
    ///  intrinsic identity, e.g., a person, a location on the surface of the earth. We identify that &lt;em&gt;subject&lt;/em&gt; in time and space using various supporting
    ///  &lt;em&gt;conclusions&lt;/em&gt;, e.g. for a person: things like name, birth date, age, address, etc. We aggregate these supporting &lt;em&gt;conclusions&lt;/em&gt; to form an
    ///  apparently-unique identity by which we can distinguish our &lt;em&gt;subject&lt;/em&gt; from all other possible &lt;em&gt;subjects&lt;/em&gt;.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://gedcomx.org/v1/", TypeName = "Subject")]
    public abstract partial class Subject : Gx.Conclusion.Conclusion, IAttributable
    {

        private bool? _extracted;
        private bool _extractedSpecified;
        private List<Gx.Common.EvidenceReference> _evidence;
        private List<Gx.Source.SourceReference> _media;
        private List<Gx.Conclusion.Identifier> _identifiers;
        /// <summary>
        ///  Whether this subject has been identified as &quot;extracted&quot;.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "extracted")]
        [Newtonsoft.Json.JsonProperty("extracted")]
        public bool Extracted
        {
            get
            {
                return this._extracted.GetValueOrDefault();
            }
            set
            {
                this._extracted = value;
                this._extractedSpecified = true;
            }
        }

        /// <summary>
        ///  Property for the XML serializer indicating whether the "Extracted" property should be included in the output.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [Newtonsoft.Json.JsonIgnore]
        public bool ExtractedSpecified
        {
            get
            {
                return this._extractedSpecified;
            }
            set
            {
                this._extractedSpecified = value;
            }
        }

        /// <summary>
        ///  References to the evidence being referenced.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "evidence", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("evidence")]
        public List<Gx.Common.EvidenceReference> Evidence
        {
            get
            {
                return this._evidence;
            }
            set
            {
                this._evidence = value;
            }
        }
        /// <summary>
        ///  References to multimedia resources associated with this subject.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "media", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("media")]
        public List<Gx.Source.SourceReference> Media
        {
            get
            {
                return this._media;
            }
            set
            {
                this._media = value;
            }
        }
        /// <summary>
        ///  The list of identifiers for the subject.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "identifier", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("identifiers")]
        [JsonConverter(typeof(JsonIdentifiersConverter))]
        public List<Gx.Conclusion.Identifier> Identifiers
        {
            get
            {
                return this._identifiers;
            }
            set
            {
                this._identifiers = value;
            }
        }

        protected internal override void Embed(ExtensibleData subject)
        {
            var value = (Subject)subject;
            this._extracted = this._extracted == null ? value._extracted : this._extracted;

            if (value._identifiers != null)
            {
                this._identifiers = this._identifiers == null ? new List<Identifier>() : this._identifiers;
                this._identifiers.AddRange(value._identifiers);
            }
            if (value._media != null)
            {
                this._media = this._media == null ? new List<SourceReference>() : this._media;
                this._media.AddRange(value._media);
            }
            if (value._evidence != null)
            {
                this._evidence = this._evidence == null ? new List<EvidenceReference>() : this._evidence;
                this._evidence.AddRange(value._evidence);
            }

            base.Embed(subject);
        }

        /**
         * Add an evidence reference for this subject.
         *
         * @param evidenceRef The evidence to be added.
         */
        public void AddEvidence(EvidenceReference evidenceRef)
        {
            if (evidenceRef != null)
            {
                if (_evidence == null)
                {
                    _evidence = new List<EvidenceReference>();
                }
                _evidence.Add(evidenceRef);
            }
        }

        /**
         * Build up this subject with an extracted flag.
         *
         * @param extracted The extracted flag.
         * @return this.
         */
        public Subject SetExtracted(Boolean extracted)
        {
            Extracted = extracted;
            return this;
        }

        /**
         * Build up this subject with an identifier.
         *
         * @param identifier The identifier.
         * @return this.
         */
        public Subject SetIdentifier(Identifier identifier)
        {
            AddIdentifier(identifier);
            return this;
        }

        /**
         * Build up this subject with an evidence reference.
         *
         * @param evidence The evidence reference.
         * @return this.
         */
        public Subject SetEvidence(EvidenceReference evidence)
        {
            AddEvidence(evidence);
            return this;
        }

        /**
         * Build up this subject with a media reference.
         *
         * @param media The media reference.
         * @return this.
         */
        public Subject SetMedia(SourceReference media)
        {
            AddMedia(media);
            return this;
        }

        /**
         * Build up this subject with a media reference.
         *
         * @param media The media reference.
         * @return this.
         */
        public Subject SetMedia(SourceDescription media)
        {
            AddMedia(new SourceReference().SetDescription(media));
            return this;
        }

        /**
         * Add an identifier of the subject.
         *
         * @param identifier The identifier to be added.
         */
        public void AddIdentifier(Identifier identifier)
        {
            if (identifier != null)
            {
                if (_identifiers == null)
                {
                    _identifiers = new List<Identifier>();
                }
                _identifiers.Add(identifier);
            }
        }

        /**
         * Add an media reference associated with this subject.
         *
         * @param mediaRef The reference to the media to be added.
         */
        public void AddMedia(SourceReference mediaRef)
        {
            if (mediaRef != null)
            {
                if (_media == null)
                {
                    _media = new List<SourceReference>();
                }
                _media.Add(mediaRef);
            }
        }
    }
}
