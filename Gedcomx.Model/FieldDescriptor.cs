using Gx.Common;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Gx.Records
{

    /// <remarks>
    ///  A description of a field in a record.
    /// </remarks>
    /// <summary>
    ///  A description of a field in a record.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://gedcomx.org/v1/", TypeName = "FieldDescriptor")]
    public partial class FieldDescriptor : Gx.Links.HypermediaEnabledData
    {

        private string _originalLabel;
        private List<Gx.Common.TextValue> _descriptions;
        private List<Gx.Records.FieldValueDescriptor> _values;
        /// <summary>
        ///  The original label for the field, as stated on the original record.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "originalLabel", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("originalLabel")]
        public string OriginalLabel
        {
            get
            {
                return this._originalLabel;
            }
            set
            {
                this._originalLabel = value;
            }
        }
        /// <summary>
        ///  The description of the field.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "description", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("descriptions")]
        public List<Gx.Common.TextValue> Descriptions
        {
            get
            {
                return this._descriptions;
            }
            set
            {
                this._descriptions = value;
            }
        }
        /// <summary>
        ///  Descriptors of the values that are applicable to the field.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "value", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("values")]
        public List<Gx.Records.FieldValueDescriptor> Values
        {
            get
            {
                return this._values;
            }
            set
            {
                this._values = value;
            }
        }

        /**
         * Build out this field descriptor with an original label.
         *
         * @param originalLabel The original label.
         * @return this.
         */
        public FieldDescriptor SetOriginalLabel(String originalLabel)
        {
            OriginalLabel = originalLabel;
            return this;
        }

        /**
         * Build out this descriptor with a description.
         * @param description The description.
         * @return this.
         */
        public FieldDescriptor SetDescription(TextValue description)
        {
            AddDescription(description);
            return this;
        }

        /**
         * Build out this descriptor with a description.
         * @param description The description.
         * @return this.
         */
        public FieldDescriptor SetDescription(String description)
        {
            AddDescription(new TextValue(description));
            return this;
        }

        /**
         * Add a description.
         *
         * @param description The description to be added.
         */
        public void AddDescription(TextValue description)
        {
            if (description != null)
            {
                if (this._descriptions == null)
                {
                    this._descriptions = new List<TextValue>();
                }
                this._descriptions.Add(description);
            }
        }
    }
}
