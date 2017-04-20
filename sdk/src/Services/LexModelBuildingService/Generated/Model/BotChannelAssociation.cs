/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Represents an association between an Amazon Lex bot and an external messaging platform.
    /// </summary>
    public partial class BotChannelAssociation
    {
        private string _botAlias;
        private Dictionary<string, string> _botConfiguration = new Dictionary<string, string>();
        private string _botName;
        private DateTime? _createdDate;
        private string _description;
        private string _name;
        private ChannelType _type;

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// An alias pointing to the specific version of the Amazon Lex bot to which this association
        /// is being made. 
        /// </para>
        /// </summary>
        public string BotAlias
        {
            get { return this._botAlias; }
            set { this._botAlias = value; }
        }

        // Check to see if BotAlias property is set
        internal bool IsSetBotAlias()
        {
            return this._botAlias != null;
        }

        /// <summary>
        /// Gets and sets the property BotConfiguration. 
        /// <para>
        /// Provides information necessary to communicate with the messaging platform. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> BotConfiguration
        {
            get { return this._botConfiguration; }
            set { this._botConfiguration = value; }
        }

        // Check to see if BotConfiguration property is set
        internal bool IsSetBotConfiguration()
        {
            return this._botConfiguration != null && this._botConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the Amazon Lex bot to which this association is being made. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, Amazon Lex supports associations with Facebook and Slack, and Twilio.
        /// </para>
        ///  </note>
        /// </summary>
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the association between the Amazon Lex bot and the channel was created.
        /// 
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A text description of the association you are creating. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the association between the bot and the channel. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of association by indicating the type of channel being established
        /// between the Amazon Lex bot and the external messaging platform.
        /// </para>
        /// </summary>
        public ChannelType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}