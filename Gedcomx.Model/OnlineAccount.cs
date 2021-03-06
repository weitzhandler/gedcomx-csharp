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

namespace Gx.Agent
{

    /// <remarks>
    ///  An online account for a web application.
    /// </remarks>
    /// <summary>
    ///  An online account for a web application.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://gedcomx.org/v1/", TypeName = "OnlineAccount")]
    public partial class OnlineAccount : Gx.Common.ExtensibleData
    {

        private string _accountName;
        private Gx.Common.ResourceReference _serviceHomepage;
        /// <summary>
        ///  The name associated the holder of this account with the account.
        /// </summary>
        [XmlElement(ElementName = "accountName", Namespace = "http://gedcomx.org/v1/")]
        [JsonProperty("accountName")]
        public string AccountName
        {
            get
            {
                return this._accountName;
            }
            set
            {
                this._accountName = value;
            }
        }
        /// <summary>
        ///  The homepage of the service that provides this account.
        /// </summary>
        [XmlElement(ElementName = "serviceHomepage", Namespace = "http://gedcomx.org/v1/")]
        [JsonProperty("serviceHomepage")]
        public Gx.Common.ResourceReference ServiceHomepage
        {
            get
            {
                return this._serviceHomepage;
            }
            set
            {
                this._serviceHomepage = value;
            }
        }

        /**
         * Build up this online account with a service homepage.
         *
         * @param serviceHomepage The service homepage.
         * @return this.
         */
        public OnlineAccount SetServiceHomepage(ResourceReference serviceHomepage)
        {
            this.ServiceHomepage = serviceHomepage;
            return this;
        }

        /**
         * Build up this online account with an account name.
         *
         * @param accountName The account name.
         */
        public OnlineAccount SetAccountName(String accountName)
        {
            this.AccountName = accountName;
            return this;
        }
    }
}
