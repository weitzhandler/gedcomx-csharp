// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Gx.Atom
{

    /// <remarks>
    ///  
    /// </remarks>
    /// <summary>
    ///  
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2005/Atom", TypeName = "Content")]
    public sealed partial class Content
    {

        private string _type;
        private Gx.Gedcomx _gedcomx;
        /// <summary>
        ///  The type of the content.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "type")]
        [Newtonsoft.Json.JsonProperty("type")]
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
        ///  The genealogical data associated with this entry.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "gedcomx", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("gedcomx")]
        public Gx.Gedcomx Gedcomx
        {
            get
            {
                return this._gedcomx;
            }
            set
            {
                this._gedcomx = value;
            }
        }
    }
}
