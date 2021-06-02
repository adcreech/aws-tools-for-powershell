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
using Amazon.Connect;
using Amazon.Connect.Model;

namespace Amazon.PowerShell.Cmdlets.CONN
{
    /// <summary>
    /// Create an AppIntegration association with an Amazon Connect instance.
    /// </summary>
    [Cmdlet("New", "CONNIntegrationAssociation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Connect.Model.CreateIntegrationAssociationResponse")]
    [AWSCmdlet("Calls the Amazon Connect Service CreateIntegrationAssociation API operation.", Operation = new[] {"CreateIntegrationAssociation"}, SelectReturnType = typeof(Amazon.Connect.Model.CreateIntegrationAssociationResponse))]
    [AWSCmdletOutput("Amazon.Connect.Model.CreateIntegrationAssociationResponse",
        "This cmdlet returns an Amazon.Connect.Model.CreateIntegrationAssociationResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewCONNIntegrationAssociationCmdlet : AmazonConnectClientCmdlet, IExecutor
    {
        
        #region Parameter InstanceId
        /// <summary>
        /// <para>
        /// <para>The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.</para>
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
        public System.String InstanceId { get; set; }
        #endregion
        
        #region Parameter IntegrationArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the integration.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String IntegrationArn { get; set; }
        #endregion
        
        #region Parameter IntegrationType
        /// <summary>
        /// <para>
        /// <para>The type of information to be ingested.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Connect.IntegrationType")]
        public Amazon.Connect.IntegrationType IntegrationType { get; set; }
        #endregion
        
        #region Parameter SourceApplicationName
        /// <summary>
        /// <para>
        /// <para>The name of the external application.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String SourceApplicationName { get; set; }
        #endregion
        
        #region Parameter SourceApplicationUrl
        /// <summary>
        /// <para>
        /// <para>The URL for the external application.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String SourceApplicationUrl { get; set; }
        #endregion
        
        #region Parameter SourceType
        /// <summary>
        /// <para>
        /// <para>The type of the data source.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Connect.SourceType")]
        public Amazon.Connect.SourceType SourceType { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>One or more tags.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Connect.Model.CreateIntegrationAssociationResponse).
        /// Specifying the name of a property of type Amazon.Connect.Model.CreateIntegrationAssociationResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the InstanceId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^InstanceId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^InstanceId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.SourceApplicationName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-CONNIntegrationAssociation (CreateIntegrationAssociation)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Connect.Model.CreateIntegrationAssociationResponse, NewCONNIntegrationAssociationCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.InstanceId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.InstanceId = this.InstanceId;
            #if MODULAR
            if (this.InstanceId == null && ParameterWasBound(nameof(this.InstanceId)))
            {
                WriteWarning("You are passing $null as a value for parameter InstanceId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.IntegrationArn = this.IntegrationArn;
            #if MODULAR
            if (this.IntegrationArn == null && ParameterWasBound(nameof(this.IntegrationArn)))
            {
                WriteWarning("You are passing $null as a value for parameter IntegrationArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.IntegrationType = this.IntegrationType;
            #if MODULAR
            if (this.IntegrationType == null && ParameterWasBound(nameof(this.IntegrationType)))
            {
                WriteWarning("You are passing $null as a value for parameter IntegrationType which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SourceApplicationName = this.SourceApplicationName;
            #if MODULAR
            if (this.SourceApplicationName == null && ParameterWasBound(nameof(this.SourceApplicationName)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceApplicationName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SourceApplicationUrl = this.SourceApplicationUrl;
            #if MODULAR
            if (this.SourceApplicationUrl == null && ParameterWasBound(nameof(this.SourceApplicationUrl)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceApplicationUrl which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SourceType = this.SourceType;
            #if MODULAR
            if (this.SourceType == null && ParameterWasBound(nameof(this.SourceType)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceType which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            
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
            var request = new Amazon.Connect.Model.CreateIntegrationAssociationRequest();
            
            if (cmdletContext.InstanceId != null)
            {
                request.InstanceId = cmdletContext.InstanceId;
            }
            if (cmdletContext.IntegrationArn != null)
            {
                request.IntegrationArn = cmdletContext.IntegrationArn;
            }
            if (cmdletContext.IntegrationType != null)
            {
                request.IntegrationType = cmdletContext.IntegrationType;
            }
            if (cmdletContext.SourceApplicationName != null)
            {
                request.SourceApplicationName = cmdletContext.SourceApplicationName;
            }
            if (cmdletContext.SourceApplicationUrl != null)
            {
                request.SourceApplicationUrl = cmdletContext.SourceApplicationUrl;
            }
            if (cmdletContext.SourceType != null)
            {
                request.SourceType = cmdletContext.SourceType;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.Connect.Model.CreateIntegrationAssociationResponse CallAWSServiceOperation(IAmazonConnect client, Amazon.Connect.Model.CreateIntegrationAssociationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Connect Service", "CreateIntegrationAssociation");
            try
            {
                #if DESKTOP
                return client.CreateIntegrationAssociation(request);
                #elif CORECLR
                return client.CreateIntegrationAssociationAsync(request).GetAwaiter().GetResult();
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
            public System.String InstanceId { get; set; }
            public System.String IntegrationArn { get; set; }
            public Amazon.Connect.IntegrationType IntegrationType { get; set; }
            public System.String SourceApplicationName { get; set; }
            public System.String SourceApplicationUrl { get; set; }
            public Amazon.Connect.SourceType SourceType { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public System.Func<Amazon.Connect.Model.CreateIntegrationAssociationResponse, NewCONNIntegrationAssociationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
