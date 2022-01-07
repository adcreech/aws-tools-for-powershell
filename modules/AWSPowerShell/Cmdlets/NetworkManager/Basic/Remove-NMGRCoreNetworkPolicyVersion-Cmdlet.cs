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
using Amazon.NetworkManager;
using Amazon.NetworkManager.Model;

namespace Amazon.PowerShell.Cmdlets.NMGR
{
    /// <summary>
    /// Deletes a policy version from a core network. You can't delete the current LIVE policy.
    /// </summary>
    [Cmdlet("Remove", "NMGRCoreNetworkPolicyVersion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    [OutputType("Amazon.NetworkManager.Model.CoreNetworkPolicy")]
    [AWSCmdlet("Calls the AWS Network Manager DeleteCoreNetworkPolicyVersion API operation.", Operation = new[] {"DeleteCoreNetworkPolicyVersion"}, SelectReturnType = typeof(Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionResponse))]
    [AWSCmdletOutput("Amazon.NetworkManager.Model.CoreNetworkPolicy or Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionResponse",
        "This cmdlet returns an Amazon.NetworkManager.Model.CoreNetworkPolicy object.",
        "The service call response (type Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RemoveNMGRCoreNetworkPolicyVersionCmdlet : AmazonNetworkManagerClientCmdlet, IExecutor
    {
        
        #region Parameter CoreNetworkId
        /// <summary>
        /// <para>
        /// <para>The ID of a core network for the deleted policy.</para>
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
        public System.String CoreNetworkId { get; set; }
        #endregion
        
        #region Parameter PolicyVersionId
        /// <summary>
        /// <para>
        /// <para>The version ID of the deleted policy.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Int32? PolicyVersionId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'CoreNetworkPolicy'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionResponse).
        /// Specifying the name of a property of type Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "CoreNetworkPolicy";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the CoreNetworkId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^CoreNetworkId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^CoreNetworkId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.CoreNetworkId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Remove-NMGRCoreNetworkPolicyVersion (DeleteCoreNetworkPolicyVersion)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionResponse, RemoveNMGRCoreNetworkPolicyVersionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.CoreNetworkId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CoreNetworkId = this.CoreNetworkId;
            #if MODULAR
            if (this.CoreNetworkId == null && ParameterWasBound(nameof(this.CoreNetworkId)))
            {
                WriteWarning("You are passing $null as a value for parameter CoreNetworkId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.PolicyVersionId = this.PolicyVersionId;
            #if MODULAR
            if (this.PolicyVersionId == null && ParameterWasBound(nameof(this.PolicyVersionId)))
            {
                WriteWarning("You are passing $null as a value for parameter PolicyVersionId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionRequest();
            
            if (cmdletContext.CoreNetworkId != null)
            {
                request.CoreNetworkId = cmdletContext.CoreNetworkId;
            }
            if (cmdletContext.PolicyVersionId != null)
            {
                request.PolicyVersionId = cmdletContext.PolicyVersionId.Value;
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
        
        private Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionResponse CallAWSServiceOperation(IAmazonNetworkManager client, Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Network Manager", "DeleteCoreNetworkPolicyVersion");
            try
            {
                #if DESKTOP
                return client.DeleteCoreNetworkPolicyVersion(request);
                #elif CORECLR
                return client.DeleteCoreNetworkPolicyVersionAsync(request).GetAwaiter().GetResult();
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
            public System.String CoreNetworkId { get; set; }
            public System.Int32? PolicyVersionId { get; set; }
            public System.Func<Amazon.NetworkManager.Model.DeleteCoreNetworkPolicyVersionResponse, RemoveNMGRCoreNetworkPolicyVersionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.CoreNetworkPolicy;
        }
        
    }
}