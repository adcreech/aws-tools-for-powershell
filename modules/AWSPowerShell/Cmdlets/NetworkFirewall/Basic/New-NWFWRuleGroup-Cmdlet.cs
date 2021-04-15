/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.NetworkFirewall;
using Amazon.NetworkFirewall.Model;

namespace Amazon.PowerShell.Cmdlets.NWFW
{
    /// <summary>
    /// Creates the specified stateless or stateful rule group, which includes the rules for
    /// network traffic inspection, a capacity setting, and tags. 
    /// 
    ///  
    /// <para>
    /// You provide your rule group specification in your request using either <code>RuleGroup</code>
    /// or <code>Rules</code>.
    /// </para>
    /// </summary>
    [Cmdlet("New", "NWFWRuleGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.NetworkFirewall.Model.CreateRuleGroupResponse")]
    [AWSCmdlet("Calls the AWS Network Firewall CreateRuleGroup API operation.", Operation = new[] {"CreateRuleGroup"}, SelectReturnType = typeof(Amazon.NetworkFirewall.Model.CreateRuleGroupResponse))]
    [AWSCmdletOutput("Amazon.NetworkFirewall.Model.CreateRuleGroupResponse",
        "This cmdlet returns an Amazon.NetworkFirewall.Model.CreateRuleGroupResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewNWFWRuleGroupCmdlet : AmazonNetworkFirewallClientCmdlet, IExecutor
    {
        
        #region Parameter Capacity
        /// <summary>
        /// <para>
        /// <para>The maximum operating resources that this rule group can use. Rule group capacity
        /// is fixed at creation. When you update a rule group, you are limited to this capacity.
        /// When you reference a rule group from a firewall policy, Network Firewall reserves
        /// this capacity for the rule group. </para><para>You can retrieve the capacity that would be required for a rule group before you create
        /// the rule group by calling <a>CreateRuleGroup</a> with <code>DryRun</code> set to <code>TRUE</code>.
        /// </para><note><para>You can't change or exceed this capacity when you update the rule group, so leave
        /// room for your rule group to grow. </para></note><para><b>Capacity for a stateless rule group</b></para><para>For a stateless rule group, the capacity required is the sum of the capacity requirements
        /// of the individual rules that you expect to have in the rule group. </para><para>To calculate the capacity requirement of a single rule, multiply the capacity requirement
        /// values of each of the rule's match settings:</para><ul><li><para>A match setting with no criteria specified has a value of 1. </para></li><li><para>A match setting with <code>Any</code> specified has a value of 1. </para></li><li><para>All other match settings have a value equal to the number of elements provided in
        /// the setting. For example, a protocol setting ["UDP"] and a source setting ["10.0.0.0/24"]
        /// each have a value of 1. A protocol setting ["UDP","TCP"] has a value of 2. A source
        /// setting ["10.0.0.0/24","10.0.0.1/24","10.0.0.2/24"] has a value of 3. </para></li></ul><para>A rule with no criteria specified in any of its match settings has a capacity requirement
        /// of 1. A rule with protocol setting ["UDP","TCP"], source setting ["10.0.0.0/24","10.0.0.1/24","10.0.0.2/24"],
        /// and a single specification or no specification for each of the other match settings
        /// has a capacity requirement of 6. </para><para><b>Capacity for a stateful rule group</b></para><para>For a stateful rule group, the minimum capacity required is the number of individual
        /// rules that you expect to have in the rule group. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Int32? Capacity { get; set; }
        #endregion
        
        #region Parameter StatelessRulesAndCustomActions_CustomAction
        /// <summary>
        /// <para>
        /// <para>Defines an array of individual custom action definitions that are available for use
        /// by the stateless rules in this <code>StatelessRulesAndCustomActions</code> specification.
        /// You name each custom action that you define, and then you can use it by name in your
        /// <a>StatelessRule</a><a>RuleDefinition</a><code>Actions</code> specification.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RulesSource_StatelessRulesAndCustomActions_CustomActions")]
        public Amazon.NetworkFirewall.Model.CustomAction[] StatelessRulesAndCustomActions_CustomAction { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>A description of the rule group. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter DryRun
        /// <summary>
        /// <para>
        /// <para>Indicates whether you want Network Firewall to just check the validity of the request,
        /// rather than run the request. </para><para>If set to <code>TRUE</code>, Network Firewall checks whether the request can run successfully,
        /// but doesn't actually make the requested changes. The call returns the value that the
        /// request would return if you ran it with dry run set to <code>FALSE</code>, but doesn't
        /// make additions or changes to your resources. This option allows you to make sure that
        /// you have the required permissions to run the request and that your request parameters
        /// are valid. </para><para>If set to <code>FALSE</code>, Network Firewall makes the requested changes to your
        /// resources. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? DryRun { get; set; }
        #endregion
        
        #region Parameter RulesSourceList_GeneratedRulesType
        /// <summary>
        /// <para>
        /// <para>Whether you want to allow or deny access to the domains in your target list.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RulesSource_RulesSourceList_GeneratedRulesType")]
        [AWSConstantClassSource("Amazon.NetworkFirewall.GeneratedRulesType")]
        public Amazon.NetworkFirewall.GeneratedRulesType RulesSourceList_GeneratedRulesType { get; set; }
        #endregion
        
        #region Parameter RuleVariables_IPSet
        /// <summary>
        /// <para>
        /// <para>A list of IP addresses and address ranges, in CIDR notation. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RuleVariables_IPSets")]
        public System.Collections.Hashtable RuleVariables_IPSet { get; set; }
        #endregion
        
        #region Parameter RuleVariables_PortSet
        /// <summary>
        /// <para>
        /// <para>A list of port ranges. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RuleVariables_PortSets")]
        public System.Collections.Hashtable RuleVariables_PortSet { get; set; }
        #endregion
        
        #region Parameter RuleGroupName
        /// <summary>
        /// <para>
        /// <para>The descriptive name of the rule group. You can't change the name of a rule group
        /// after you create it.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String RuleGroupName { get; set; }
        #endregion
        
        #region Parameter Rule
        /// <summary>
        /// <para>
        /// <para>A string containing stateful rule group rules specifications in Suricata flat format,
        /// with one rule per line. Use this to import your existing Suricata compatible rule
        /// groups. </para><note><para>You must provide either this rules setting or a populated <code>RuleGroup</code> setting,
        /// but not both. </para></note><para>You can provide your rule group specification in Suricata flat format through this
        /// setting when you create or update your rule group. The call response returns a <a>RuleGroup</a>
        /// object that Network Firewall has populated from your string. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Rules")]
        public System.String Rule { get; set; }
        #endregion
        
        #region Parameter RulesSource_RulesString
        /// <summary>
        /// <para>
        /// <para>Stateful inspection criteria, provided in Suricata compatible intrusion prevention
        /// system (IPS) rules. Suricata is an open-source network IPS that includes a standard
        /// rule-based language for network traffic inspection.</para><para>These rules contain the inspection criteria and the action to take for traffic that
        /// matches the criteria, so this type of rule group doesn't have a separate action setting.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RulesSource_RulesString")]
        public System.String RulesSource_RulesString { get; set; }
        #endregion
        
        #region Parameter RulesSource_StatefulRule
        /// <summary>
        /// <para>
        /// <para>The 5-tuple stateful inspection criteria. This contains an array of individual 5-tuple
        /// stateful rules to be used together in a stateful rule group. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RulesSource_StatefulRules")]
        public Amazon.NetworkFirewall.Model.StatefulRule[] RulesSource_StatefulRule { get; set; }
        #endregion
        
        #region Parameter StatelessRulesAndCustomActions_StatelessRule
        /// <summary>
        /// <para>
        /// <para>Defines the set of stateless rules for use in a stateless rule group. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RulesSource_StatelessRulesAndCustomActions_StatelessRules")]
        public Amazon.NetworkFirewall.Model.StatelessRule[] StatelessRulesAndCustomActions_StatelessRule { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The key:value pairs to associate with the resource.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.NetworkFirewall.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter RulesSourceList_Target
        /// <summary>
        /// <para>
        /// <para>The domains that you want to inspect for in your traffic flows. To provide multiple
        /// domains, separate them with commas. Valid domain specifications are the following:</para><ul><li><para>Explicit names. For example, <code>abc.example.com</code> matches only the domain
        /// <code>abc.example.com</code>.</para></li><li><para>Names that use a domain wildcard, which you indicate with an initial '<code>.</code>'.
        /// For example,<code>.example.com</code> matches <code>example.com</code> and matches
        /// all subdomains of <code>example.com</code>, such as <code>abc.example.com</code> and
        /// <code>www.example.com</code>. </para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RulesSource_RulesSourceList_Targets")]
        public System.String[] RulesSourceList_Target { get; set; }
        #endregion
        
        #region Parameter RulesSourceList_TargetType
        /// <summary>
        /// <para>
        /// <para>The protocols you want to inspect. Specify <code>TLS_SNI</code> for <code>HTTPS</code>.
        /// Specity <code>HTTP_HOST</code> for <code>HTTP</code>. You can specify either or both.
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RuleGroup_RulesSource_RulesSourceList_TargetTypes")]
        public System.String[] RulesSourceList_TargetType { get; set; }
        #endregion
        
        #region Parameter Type
        /// <summary>
        /// <para>
        /// <para>Indicates whether the rule group is stateless or stateful. If the rule group is stateless,
        /// it contains stateless rules. If it is stateful, it contains stateful rules. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.NetworkFirewall.RuleGroupType")]
        public Amazon.NetworkFirewall.RuleGroupType Type { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.NetworkFirewall.Model.CreateRuleGroupResponse).
        /// Specifying the name of a property of type Amazon.NetworkFirewall.Model.CreateRuleGroupResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the RuleGroupName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^RuleGroupName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^RuleGroupName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.RuleGroupName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-NWFWRuleGroup (CreateRuleGroup)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.NetworkFirewall.Model.CreateRuleGroupResponse, NewNWFWRuleGroupCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.RuleGroupName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Capacity = this.Capacity;
            #if MODULAR
            if (this.Capacity == null && ParameterWasBound(nameof(this.Capacity)))
            {
                WriteWarning("You are passing $null as a value for parameter Capacity which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Description = this.Description;
            context.DryRun = this.DryRun;
            context.RulesSourceList_GeneratedRulesType = this.RulesSourceList_GeneratedRulesType;
            if (this.RulesSourceList_Target != null)
            {
                context.RulesSourceList_Target = new List<System.String>(this.RulesSourceList_Target);
            }
            if (this.RulesSourceList_TargetType != null)
            {
                context.RulesSourceList_TargetType = new List<System.String>(this.RulesSourceList_TargetType);
            }
            context.RulesSource_RulesString = this.RulesSource_RulesString;
            if (this.RulesSource_StatefulRule != null)
            {
                context.RulesSource_StatefulRule = new List<Amazon.NetworkFirewall.Model.StatefulRule>(this.RulesSource_StatefulRule);
            }
            if (this.StatelessRulesAndCustomActions_CustomAction != null)
            {
                context.StatelessRulesAndCustomActions_CustomAction = new List<Amazon.NetworkFirewall.Model.CustomAction>(this.StatelessRulesAndCustomActions_CustomAction);
            }
            if (this.StatelessRulesAndCustomActions_StatelessRule != null)
            {
                context.StatelessRulesAndCustomActions_StatelessRule = new List<Amazon.NetworkFirewall.Model.StatelessRule>(this.StatelessRulesAndCustomActions_StatelessRule);
            }
            if (this.RuleVariables_IPSet != null)
            {
                context.RuleVariables_IPSet = new Dictionary<System.String, Amazon.NetworkFirewall.Model.IPSet>(StringComparer.Ordinal);
                foreach (var hashKey in this.RuleVariables_IPSet.Keys)
                {
                    context.RuleVariables_IPSet.Add((String)hashKey, (IPSet)(this.RuleVariables_IPSet[hashKey]));
                }
            }
            if (this.RuleVariables_PortSet != null)
            {
                context.RuleVariables_PortSet = new Dictionary<System.String, Amazon.NetworkFirewall.Model.PortSet>(StringComparer.Ordinal);
                foreach (var hashKey in this.RuleVariables_PortSet.Keys)
                {
                    context.RuleVariables_PortSet.Add((String)hashKey, (PortSet)(this.RuleVariables_PortSet[hashKey]));
                }
            }
            context.RuleGroupName = this.RuleGroupName;
            #if MODULAR
            if (this.RuleGroupName == null && ParameterWasBound(nameof(this.RuleGroupName)))
            {
                WriteWarning("You are passing $null as a value for parameter RuleGroupName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Rule = this.Rule;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.NetworkFirewall.Model.Tag>(this.Tag);
            }
            context.Type = this.Type;
            #if MODULAR
            if (this.Type == null && ParameterWasBound(nameof(this.Type)))
            {
                WriteWarning("You are passing $null as a value for parameter Type which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.NetworkFirewall.Model.CreateRuleGroupRequest();
            
            if (cmdletContext.Capacity != null)
            {
                request.Capacity = cmdletContext.Capacity.Value;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.DryRun != null)
            {
                request.DryRun = cmdletContext.DryRun.Value;
            }
            
             // populate RuleGroup
            var requestRuleGroupIsNull = true;
            request.RuleGroup = new Amazon.NetworkFirewall.Model.RuleGroup();
            Amazon.NetworkFirewall.Model.RuleVariables requestRuleGroup_ruleGroup_RuleVariables = null;
            
             // populate RuleVariables
            var requestRuleGroup_ruleGroup_RuleVariablesIsNull = true;
            requestRuleGroup_ruleGroup_RuleVariables = new Amazon.NetworkFirewall.Model.RuleVariables();
            Dictionary<System.String, Amazon.NetworkFirewall.Model.IPSet> requestRuleGroup_ruleGroup_RuleVariables_ruleVariables_IPSet = null;
            if (cmdletContext.RuleVariables_IPSet != null)
            {
                requestRuleGroup_ruleGroup_RuleVariables_ruleVariables_IPSet = cmdletContext.RuleVariables_IPSet;
            }
            if (requestRuleGroup_ruleGroup_RuleVariables_ruleVariables_IPSet != null)
            {
                requestRuleGroup_ruleGroup_RuleVariables.IPSets = requestRuleGroup_ruleGroup_RuleVariables_ruleVariables_IPSet;
                requestRuleGroup_ruleGroup_RuleVariablesIsNull = false;
            }
            Dictionary<System.String, Amazon.NetworkFirewall.Model.PortSet> requestRuleGroup_ruleGroup_RuleVariables_ruleVariables_PortSet = null;
            if (cmdletContext.RuleVariables_PortSet != null)
            {
                requestRuleGroup_ruleGroup_RuleVariables_ruleVariables_PortSet = cmdletContext.RuleVariables_PortSet;
            }
            if (requestRuleGroup_ruleGroup_RuleVariables_ruleVariables_PortSet != null)
            {
                requestRuleGroup_ruleGroup_RuleVariables.PortSets = requestRuleGroup_ruleGroup_RuleVariables_ruleVariables_PortSet;
                requestRuleGroup_ruleGroup_RuleVariablesIsNull = false;
            }
             // determine if requestRuleGroup_ruleGroup_RuleVariables should be set to null
            if (requestRuleGroup_ruleGroup_RuleVariablesIsNull)
            {
                requestRuleGroup_ruleGroup_RuleVariables = null;
            }
            if (requestRuleGroup_ruleGroup_RuleVariables != null)
            {
                request.RuleGroup.RuleVariables = requestRuleGroup_ruleGroup_RuleVariables;
                requestRuleGroupIsNull = false;
            }
            Amazon.NetworkFirewall.Model.RulesSource requestRuleGroup_ruleGroup_RulesSource = null;
            
             // populate RulesSource
            var requestRuleGroup_ruleGroup_RulesSourceIsNull = true;
            requestRuleGroup_ruleGroup_RulesSource = new Amazon.NetworkFirewall.Model.RulesSource();
            System.String requestRuleGroup_ruleGroup_RulesSource_rulesSource_RulesString = null;
            if (cmdletContext.RulesSource_RulesString != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_rulesSource_RulesString = cmdletContext.RulesSource_RulesString;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_rulesSource_RulesString != null)
            {
                requestRuleGroup_ruleGroup_RulesSource.RulesString = requestRuleGroup_ruleGroup_RulesSource_rulesSource_RulesString;
                requestRuleGroup_ruleGroup_RulesSourceIsNull = false;
            }
            List<Amazon.NetworkFirewall.Model.StatefulRule> requestRuleGroup_ruleGroup_RulesSource_rulesSource_StatefulRule = null;
            if (cmdletContext.RulesSource_StatefulRule != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_rulesSource_StatefulRule = cmdletContext.RulesSource_StatefulRule;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_rulesSource_StatefulRule != null)
            {
                requestRuleGroup_ruleGroup_RulesSource.StatefulRules = requestRuleGroup_ruleGroup_RulesSource_rulesSource_StatefulRule;
                requestRuleGroup_ruleGroup_RulesSourceIsNull = false;
            }
            Amazon.NetworkFirewall.Model.StatelessRulesAndCustomActions requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions = null;
            
             // populate StatelessRulesAndCustomActions
            var requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActionsIsNull = true;
            requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions = new Amazon.NetworkFirewall.Model.StatelessRulesAndCustomActions();
            List<Amazon.NetworkFirewall.Model.CustomAction> requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions_statelessRulesAndCustomActions_CustomAction = null;
            if (cmdletContext.StatelessRulesAndCustomActions_CustomAction != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions_statelessRulesAndCustomActions_CustomAction = cmdletContext.StatelessRulesAndCustomActions_CustomAction;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions_statelessRulesAndCustomActions_CustomAction != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions.CustomActions = requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions_statelessRulesAndCustomActions_CustomAction;
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActionsIsNull = false;
            }
            List<Amazon.NetworkFirewall.Model.StatelessRule> requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions_statelessRulesAndCustomActions_StatelessRule = null;
            if (cmdletContext.StatelessRulesAndCustomActions_StatelessRule != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions_statelessRulesAndCustomActions_StatelessRule = cmdletContext.StatelessRulesAndCustomActions_StatelessRule;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions_statelessRulesAndCustomActions_StatelessRule != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions.StatelessRules = requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions_statelessRulesAndCustomActions_StatelessRule;
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActionsIsNull = false;
            }
             // determine if requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions should be set to null
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActionsIsNull)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions = null;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions != null)
            {
                requestRuleGroup_ruleGroup_RulesSource.StatelessRulesAndCustomActions = requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_StatelessRulesAndCustomActions;
                requestRuleGroup_ruleGroup_RulesSourceIsNull = false;
            }
            Amazon.NetworkFirewall.Model.RulesSourceList requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList = null;
            
             // populate RulesSourceList
            var requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceListIsNull = true;
            requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList = new Amazon.NetworkFirewall.Model.RulesSourceList();
            Amazon.NetworkFirewall.GeneratedRulesType requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_GeneratedRulesType = null;
            if (cmdletContext.RulesSourceList_GeneratedRulesType != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_GeneratedRulesType = cmdletContext.RulesSourceList_GeneratedRulesType;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_GeneratedRulesType != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList.GeneratedRulesType = requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_GeneratedRulesType;
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceListIsNull = false;
            }
            List<System.String> requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_Target = null;
            if (cmdletContext.RulesSourceList_Target != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_Target = cmdletContext.RulesSourceList_Target;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_Target != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList.Targets = requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_Target;
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceListIsNull = false;
            }
            List<System.String> requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_TargetType = null;
            if (cmdletContext.RulesSourceList_TargetType != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_TargetType = cmdletContext.RulesSourceList_TargetType;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_TargetType != null)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList.TargetTypes = requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList_rulesSourceList_TargetType;
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceListIsNull = false;
            }
             // determine if requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList should be set to null
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceListIsNull)
            {
                requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList = null;
            }
            if (requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList != null)
            {
                requestRuleGroup_ruleGroup_RulesSource.RulesSourceList = requestRuleGroup_ruleGroup_RulesSource_ruleGroup_RulesSource_RulesSourceList;
                requestRuleGroup_ruleGroup_RulesSourceIsNull = false;
            }
             // determine if requestRuleGroup_ruleGroup_RulesSource should be set to null
            if (requestRuleGroup_ruleGroup_RulesSourceIsNull)
            {
                requestRuleGroup_ruleGroup_RulesSource = null;
            }
            if (requestRuleGroup_ruleGroup_RulesSource != null)
            {
                request.RuleGroup.RulesSource = requestRuleGroup_ruleGroup_RulesSource;
                requestRuleGroupIsNull = false;
            }
             // determine if request.RuleGroup should be set to null
            if (requestRuleGroupIsNull)
            {
                request.RuleGroup = null;
            }
            if (cmdletContext.RuleGroupName != null)
            {
                request.RuleGroupName = cmdletContext.RuleGroupName;
            }
            if (cmdletContext.Rule != null)
            {
                request.Rules = cmdletContext.Rule;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.Type != null)
            {
                request.Type = cmdletContext.Type;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.NetworkFirewall.Model.CreateRuleGroupResponse CallAWSServiceOperation(IAmazonNetworkFirewall client, Amazon.NetworkFirewall.Model.CreateRuleGroupRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Network Firewall", "CreateRuleGroup");
            try
            {
                #if DESKTOP
                return client.CreateRuleGroup(request);
                #elif CORECLR
                return client.CreateRuleGroupAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.Int32? Capacity { get; set; }
            public System.String Description { get; set; }
            public System.Boolean? DryRun { get; set; }
            public Amazon.NetworkFirewall.GeneratedRulesType RulesSourceList_GeneratedRulesType { get; set; }
            public List<System.String> RulesSourceList_Target { get; set; }
            public List<System.String> RulesSourceList_TargetType { get; set; }
            public System.String RulesSource_RulesString { get; set; }
            public List<Amazon.NetworkFirewall.Model.StatefulRule> RulesSource_StatefulRule { get; set; }
            public List<Amazon.NetworkFirewall.Model.CustomAction> StatelessRulesAndCustomActions_CustomAction { get; set; }
            public List<Amazon.NetworkFirewall.Model.StatelessRule> StatelessRulesAndCustomActions_StatelessRule { get; set; }
            public Dictionary<System.String, Amazon.NetworkFirewall.Model.IPSet> RuleVariables_IPSet { get; set; }
            public Dictionary<System.String, Amazon.NetworkFirewall.Model.PortSet> RuleVariables_PortSet { get; set; }
            public System.String RuleGroupName { get; set; }
            public System.String Rule { get; set; }
            public List<Amazon.NetworkFirewall.Model.Tag> Tag { get; set; }
            public Amazon.NetworkFirewall.RuleGroupType Type { get; set; }
            public System.Func<Amazon.NetworkFirewall.Model.CreateRuleGroupResponse, NewNWFWRuleGroupCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}