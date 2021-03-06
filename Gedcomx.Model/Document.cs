using Gedcomx.Model.Rt;
using Gedcomx.Model.Util;
using Gx.Common;
using Gx.Types;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gx.Conclusion
{

    /// <remarks>
    ///  An abstract document that contains derived (conclusionary) text -- for example, a transcription or researcher analysis.
    /// </remarks>
    /// <summary>
    ///  An abstract document that contains derived (conclusionary) text -- for example, a transcription or researcher analysis.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://gedcomx.org/v1/", TypeName = "Document")]
    [XmlRoot(Namespace = "http://gedcomx.org/v1/", ElementName = "document")]
    [JsonObject("documents")]
    public partial class Document : Gx.Conclusion.Conclusion, IAttributable
    {

        private string _textType;
        private bool? _extracted;
        private bool _extractedSpecified;
        private string _type;
        private string _text;
        /// <summary>
        ///  The text type of the document.
        /// </summary>
        [XmlAttribute(AttributeName = "textType")]
        [JsonProperty("textType")]
        public string TextType
        {
            get
            {
                return this._textType;
            }
            set
            {
                this._textType = value;
            }
        }
        /// <summary>
        ///  Whether this document has been identified as &quot;extracted&quot;.
        /// </summary>
        [XmlAttribute(AttributeName = "extracted")]
        [JsonProperty("extracted")]
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
        [XmlIgnore]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonIgnore]
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
        ///  The type of the document.
        /// </summary>
        [XmlAttribute(AttributeName = "type")]
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        /// <summary>
        ///  Convenience property for treating Type as an enum. See Gx.Types.DocumentTypeQNameUtil for details on getter/setter functionality.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Gx.Types.DocumentType KnownType
        {
            get
            {
                return XmlQNameEnumUtil.GetEnumValue<DocumentType>(this._type);
            }
            set
            {
                this._type = XmlQNameEnumUtil.GetNameValue(value);
            }
        }
        /// <summary>
        ///  The document text.
        /// </summary>
        [XmlElement(ElementName = "text", Namespace = "http://gedcomx.org/v1/")]
        [JsonProperty("text")]
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor.
         */
        public void Accept(IGedcomxModelVisitor visitor)
        {
            visitor.VisitDocument(this);
        }

        /**
         * Build up this document with an extracted flag.
         * @param extracted The extracted flag.
         * @return this.
         */
        public Document SetExtracted(Boolean extracted)
        {
            Extracted = extracted;
            return this;
        }

        /**
         * Build up this document with a type.
         *
         * @param type The type.
         * @return this.
         */
        public Document SetType(String type)
        {
            Type = type;
            return this;
        }

        /**
         * Build up this document with a type.
         *
         * @param type The type.
         * @return this.
         */
        public Document SetType(DocumentType type)
        {
            KnownType = type;
            return this;
        }

        /**
         * Build up this document with a text type.
         *
         * @param textType The text type.
         * @return this.
         */
        public Document SetTextType(String textType)
        {
            TextType = textType;
            return this;
        }

        /**
         * Build up this document with some text.
         *
         * @param text The text.
         * @return this.
         */
        public Document SetText(String text)
        {
            Text = text;
            return this;
        }
    }
}
