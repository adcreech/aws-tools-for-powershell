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
using Amazon.ElasticLoadBalancingV2;
using Amazon.ElasticLoadBalancingV2.Model;

namespace Amazon.PowerShell.Cmdlets.ELB2
{
    /// <summary>
    /// Update the ca certificate bundle for the specified trust store.
    /// </summary>
    [Cmdlet("Edit", "ELB2TrustStore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.ElasticLoadBalancingV2.Model.TrustStore")]
    [AWSCmdlet("Calls the Elastic Load Balancing V2 ModifyTrustStore API operation.", Operation = new[] {"ModifyTrustStore"}, SelectReturnType = typeof(Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreResponse))]
    [AWSCmdletOutput("Amazon.ElasticLoadBalancingV2.Model.TrustStore or Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreResponse",
        "This cmdlet returns a collection of Amazon.ElasticLoadBalancingV2.Model.TrustStore objects.",
        "The service call response (type Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class EditELB2TrustStoreCmdlet : AmazonElasticLoadBalancingV2ClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter CaCertificatesBundleS3Bucket
        /// <summary>
        /// <para>
        /// <para>The Amazon S3 bucket for the ca certificates bundle.</para>
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
        public System.String CaCertificatesBundleS3Bucket { get; set; }
        #endregion
        
        #region Parameter CaCertificatesBundleS3Key
        /// <summary>
        /// <para>
        /// <para>The Amazon S3 path for the ca certificates bundle.</para>
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
        public System.String CaCertificatesBundleS3Key { get; set; }
        #endregion
        
        #region Parameter CaCertificatesBundleS3ObjectVersion
        /// <summary>
        /// <para>
        /// <para>The Amazon S3 object version for the ca certificates bundle. If undefined the current
        /// version is used.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CaCertificatesBundleS3ObjectVersion { get; set; }
        #endregion
        
        #region Parameter TrustStoreArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the trust store.</para>
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
        public System.String TrustStoreArn { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'TrustStores'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreResponse).
        /// Specifying the name of a property of type Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "TrustStores";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the TrustStoreArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^TrustStoreArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^TrustStoreArn' instead. This parameter will be removed in a future version.")]
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
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.TrustStoreArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Edit-ELB2TrustStore (ModifyTrustStore)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreResponse, EditELB2TrustStoreCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.TrustStoreArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CaCertificatesBundleS3Bucket = this.CaCertificatesBundleS3Bucket;
            #if MODULAR
            if (this.CaCertificatesBundleS3Bucket == null && ParameterWasBound(nameof(this.CaCertificatesBundleS3Bucket)))
            {
                WriteWarning("You are passing $null as a value for parameter CaCertificatesBundleS3Bucket which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.CaCertificatesBundleS3Key = this.CaCertificatesBundleS3Key;
            #if MODULAR
            if (this.CaCertificatesBundleS3Key == null && ParameterWasBound(nameof(this.CaCertificatesBundleS3Key)))
            {
                WriteWarning("You are passing $null as a value for parameter CaCertificatesBundleS3Key which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.CaCertificatesBundleS3ObjectVersion = this.CaCertificatesBundleS3ObjectVersion;
            context.TrustStoreArn = this.TrustStoreArn;
            #if MODULAR
            if (this.TrustStoreArn == null && ParameterWasBound(nameof(this.TrustStoreArn)))
            {
                WriteWarning("You are passing $null as a value for parameter TrustStoreArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreRequest();
            
            if (cmdletContext.CaCertificatesBundleS3Bucket != null)
            {
                request.CaCertificatesBundleS3Bucket = cmdletContext.CaCertificatesBundleS3Bucket;
            }
            if (cmdletContext.CaCertificatesBundleS3Key != null)
            {
                request.CaCertificatesBundleS3Key = cmdletContext.CaCertificatesBundleS3Key;
            }
            if (cmdletContext.CaCertificatesBundleS3ObjectVersion != null)
            {
                request.CaCertificatesBundleS3ObjectVersion = cmdletContext.CaCertificatesBundleS3ObjectVersion;
            }
            if (cmdletContext.TrustStoreArn != null)
            {
                request.TrustStoreArn = cmdletContext.TrustStoreArn;
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
        
        private Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreResponse CallAWSServiceOperation(IAmazonElasticLoadBalancingV2 client, Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Elastic Load Balancing V2", "ModifyTrustStore");
            try
            {
                #if DESKTOP
                return client.ModifyTrustStore(request);
                #elif CORECLR
                return client.ModifyTrustStoreAsync(request).GetAwaiter().GetResult();
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
            public System.String CaCertificatesBundleS3Bucket { get; set; }
            public System.String CaCertificatesBundleS3Key { get; set; }
            public System.String CaCertificatesBundleS3ObjectVersion { get; set; }
            public System.String TrustStoreArn { get; set; }
            public System.Func<Amazon.ElasticLoadBalancingV2.Model.ModifyTrustStoreResponse, EditELB2TrustStoreCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.TrustStores;
        }
        
    }
}
