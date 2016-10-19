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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigRule operation.
    /// Adds or updates an AWS Config rule for evaluating whether your AWS resources comply
    /// with your desired configurations.
    /// 
    ///  
    /// <para>
    /// You can use this action for custom Config rules and AWS managed Config rules. A custom
    /// Config rule is a rule that you develop and maintain. An AWS managed Config rule is
    /// a customizable, predefined rule that AWS Config provides.
    /// </para>
    ///  
    /// <para>
    /// If you are adding a new custom Config rule, you must first create the AWS Lambda function
    /// that the rule invokes to evaluate your resources. When you use the <code>PutConfigRule</code>
    /// action to add the rule to AWS Config, you must specify the Amazon Resource Name (ARN)
    /// that AWS Lambda assigns to the function. Specify the ARN for the <code>SourceIdentifier</code>
    /// key. This key is part of the <code>Source</code> object, which is part of the <code>ConfigRule</code>
    /// object. 
    /// </para>
    ///  
    /// <para>
    /// If you are adding a new AWS managed Config rule, specify the rule's identifier for
    /// the <code>SourceIdentifier</code> key. To reference AWS managed Config rule identifiers,
    /// see <a href="http://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">Using
    /// AWS Managed Config Rules</a>.
    /// </para>
    ///  
    /// <para>
    /// For any new rule that you add, specify the <code>ConfigRuleName</code> in the <code>ConfigRule</code>
    /// object. Do not specify the <code>ConfigRuleArn</code> or the <code>ConfigRuleId</code>.
    /// These values are generated by AWS Config for new rules.
    /// </para>
    ///  
    /// <para>
    /// If you are updating a rule that you added previously, you can specify the rule by
    /// <code>ConfigRuleName</code>, <code>ConfigRuleId</code>, or <code>ConfigRuleArn</code>
    /// in the <code>ConfigRule</code> data type that you use in this request.
    /// </para>
    ///  
    /// <para>
    /// The maximum number of rules that AWS Config supports is 25.
    /// </para>
    ///  
    /// <para>
    /// For more information about developing and using AWS Config rules, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/evaluate-config.html">Evaluating
    /// AWS Resource Configurations with AWS Config</a> in the <i>AWS Config Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutConfigRuleRequest : AmazonConfigServiceRequest
    {
        private ConfigRule _configRule;

        /// <summary>
        /// Gets and sets the property ConfigRule.
        /// </summary>
        public ConfigRule ConfigRule
        {
            get { return this._configRule; }
            set { this._configRule = value; }
        }

        // Check to see if ConfigRule property is set
        internal bool IsSetConfigRule()
        {
            return this._configRule != null;
        }

    }
}