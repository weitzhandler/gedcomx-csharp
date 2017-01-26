using Gx.Common;
using Gx.Fs.Discussions;
using Gx.Fs.Tree;
using Gx.Fs.Users;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Gx.Fs
{

    /// <remarks>
    ///  &lt;p&gt;The FamilySearch data types define serialization formats that are specific the FamilySearch developer platform. These
    ///  data formats are extensions of the &lt;a href=&quot;http://gedcomx.org&quot;&gt;GEDCOM X&lt;/a&gt; media types and provide concepts and data types
    ///  that are specific to FamilySearch and therefore haven't been adopted into a formal, more general specification.&lt;/p&gt;
    /// </remarks>
    /// <summary>
    ///  &lt;p&gt;The FamilySearch data types define serialization formats that are specific the FamilySearch developer platform. These
    ///  data formats are extensions of the &lt;a href=&quot;http://gedcomx.org&quot;&gt;GEDCOM X&lt;/a&gt; media types and provide concepts and data types
    ///  that are specific to FamilySearch and therefore haven't been adopted into a formal, more general specification.&lt;/p&gt;
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://familysearch.org/v1/", TypeName = "FamilySearch")]
    [XmlRoot(Namespace = "http://familysearch.org/v1/", ElementName = "familysearch")]
    public partial class FamilySearchPlatform : Gx.Gedcomx
    {
        public static readonly String PROJECT_ID = "fs-platform";
        public static readonly String NAMESPACE = "http://familysearch.org/v1/";
        public static readonly String XML_MEDIA_TYPE = "application/x-fs-v1+xml";
        public static readonly String JSON_MEDIA_TYPE = "application/x-fs-v1+json";

        private List<Gx.Fs.Tree.ChildAndParentsRelationship> _childAndParentsRelationships;
        private List<Gx.Fs.Discussions.Discussion> _discussions;
        private List<Gx.Fs.Users.User> _users;
        private List<Gx.Fs.Tree.Merge> _merges;
        private List<Gx.Fs.Tree.MergeAnalysis> _mergeAnalyses;
        private List<Gx.Fs.Feature> _features;
        /// <summary>
        ///  The child-and-parents relationships for this data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "childAndParentsRelationship", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("childAndParentsRelationships")]
        public List<Gx.Fs.Tree.ChildAndParentsRelationship> ChildAndParentsRelationships
        {
            get
            {
                return this._childAndParentsRelationships;
            }
            set
            {
                this._childAndParentsRelationships = value;
            }
        }
        /// <summary>
        ///  The discussions included in this data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discussion", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("discussions")]
        public List<Gx.Fs.Discussions.Discussion> Discussions
        {
            get
            {
                return this._discussions;
            }
            set
            {
                this._discussions = value;
            }
        }
        /// <summary>
        ///  The users included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "user", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("users")]
        public List<Gx.Fs.Users.User> Users
        {
            get
            {
                return this._users;
            }
            set
            {
                this._users = value;
            }
        }
        /// <summary>
        ///  The merges for this data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "merge", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("merges")]
        public List<Gx.Fs.Tree.Merge> Merges
        {
            get
            {
                return this._merges;
            }
            set
            {
                this._merges = value;
            }
        }
        /// <summary>
        ///  The merge analysis results for this data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mergeAnalysis", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("mergeAnalyses")]
        public List<Gx.Fs.Tree.MergeAnalysis> MergeAnalyses
        {
            get
            {
                return this._mergeAnalyses;
            }
            set
            {
                this._mergeAnalyses = value;
            }
        }
        /// <summary>
        ///  The set of features defined in the platform API.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "feature", Namespace = "http://familysearch.org/v1/")]
        [Newtonsoft.Json.JsonProperty("features")]
        public List<Gx.Fs.Feature> Features
        {
            get
            {
                return this._features;
            }
            set
            {
                this._features = value;
            }
        }

        /**
         * Add a discussion to the data set.
         *
         * @param discussion The discussion to be added.
         */
        public void AddDiscussion(Discussion discussion)
        {
            if (discussion != null)
            {
                if (_discussions == null)
                    _discussions = new List<Discussion>();
                _discussions.Add(discussion);
            }
        }

        /**
         * Add a merge to the data set.
         *
         * @param merge The merge to be added.
         */
        public void AddMerge(Merge merge)
        {
            if (merge != null)
            {
                if (_merges == null)
                    _merges = new List<Merge>();
                _merges.Add(merge);
            }
        }

        /**
         * Add a childAndParentsRelationship to the data set.
         *
         * @param childAndParentsRelationship The childAndParentsRelationship to be added.
         */
        public void AddChildAndParentsRelationship(ChildAndParentsRelationship childAndParentsRelationship)
        {
            if (childAndParentsRelationship != null)
            {
                if (_childAndParentsRelationships == null)
                    _childAndParentsRelationships = new List<ChildAndParentsRelationship>();
                _childAndParentsRelationships.Add(childAndParentsRelationship);
            }
        }

        public override void Embed(Gedcomx gedcomx)
        {
            FamilySearchPlatform value = gedcomx as FamilySearchPlatform;
            base.Embed(gedcomx);

            if (value != null)
            {
                List<ChildAndParentsRelationship> relationships = value.ChildAndParentsRelationships;
                if (relationships != null)
                {
                    foreach (ChildAndParentsRelationship relationship in relationships)
                    {
                        bool found = false;
                        if (relationship.Id != null)
                        {
                            if (ChildAndParentsRelationships != null)
                            {
                                foreach (ChildAndParentsRelationship target in ChildAndParentsRelationships)
                                {
                                    if (relationship.Id.Equals(target.Id))
                                    {
                                        target.EmbedInt(relationship);
                                        found = true;
                                        break;
                                    }
                                }
                            }
                        }

                        if (!found)
                        {
                            AddChildAndParentsRelationship(relationship);
                        }
                    }
                }

                List<Discussion> discussions = value.Discussions;
                if (discussions != null)
                {
                    foreach (Discussion discussion in discussions)
                    {
                        bool found = false;
                        if (discussion.Id != null)
                        {
                            if (Discussions != null)
                            {
                                foreach (Discussion target in Discussions)
                                {
                                    if (discussion.Id.Equals(target.Id))
                                    {
                                        target.EmbedInt(discussion);
                                        found = true;
                                        break;
                                    }
                                }
                            }
                        }

                        if (!found)
                        {
                            AddDiscussion(discussion);
                        }
                    }
                }
            }
        }

        /**
         * Build out this document with a child-and-parents relationship.
         *
         * @param chap The child-and-parents relationship
         */
        public FamilySearchPlatform SetChildAndParentsRelationship(ChildAndParentsRelationship chap)
        {
            AddChildAndParentsRelationship(chap);
            return this;
        }

        /**
         * Build out this document with a discussion.
         *
         * @param discussion The discussion to be added.
         * @return this.
         */
        public FamilySearchPlatform SetDiscussion(Discussion discussion)
        {
            AddDiscussion(discussion);
            return this;
        }

        /**
         * Build out this document with a user.
         * @param user The user to be added.
         * @return this.
         */
        public FamilySearchPlatform SetUser(User user)
        {
            AddUser(user);
            return this;
        }

        /**
         * Add a user to the data set.
         *
         * @param user The user to be added.
         */
        public void AddUser(User user)
        {
            if (user != null)
            {
                if (_users == null)
                    _users = new List<User>();
                _users.Add(user);
            }
        }
    }
}
