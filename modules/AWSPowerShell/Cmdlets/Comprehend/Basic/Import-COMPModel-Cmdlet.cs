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
using Amazon.Comprehend;
using Amazon.Comprehend.Model;

namespace Amazon.PowerShell.Cmdlets.COMP
{
    /// <summary>
    /// Creates a new custom model that replicates a source custom model that you import.
    /// The source model can be in your AWS account or another one.
    /// 
    ///  
    /// <para>
    /// If the source model is in another AWS account, then it must have a resource-based
    /// policy that authorizes you to import it.
    /// </para><para>
    /// The source model must be in the same AWS region that you're using when you import.
    /// You can't import a model that's in a different region.
    /// </para>
    /// </summary>
    [Cmdlet("Import", "COMPModel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Comprehend ImportModel API operation.", Operation = new[] {"ImportModel"}, SelectReturnType = typeof(Amazon.Comprehend.Model.ImportModelResponse))]
    [AWSCmdletOutput("System.String or Amazon.Comprehend.Model.ImportModelResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.Comprehend.Model.ImportModelResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class ImportCOMPModelCmdlet : AmazonComprehendClientCmdlet, IExecutor
    {
        
        #region Parameter DataAccessRoleArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that grants Amazon Comprehend permission to use Amazon Key Management Service (KMS)
        /// to encrypt or decrypt the custom model.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DataAccessRoleArn { get; set; }
        #endregion
        
        #region Parameter ModelKmsKeyId
        /// <summary>
        /// <para>
        /// <para>ID for the AWS Key Management Service (KMS) key that Amazon Comprehend uses to encrypt
        /// trained custom models. The ModelKmsKeyId can be either of the following formats:</para><ul><li><para>KMS Key ID: <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code></para></li><li><para>Amazon Resource Name (ARN) of a KMS Key: <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code></para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelKmsKeyId { get; set; }
        #endregion
        
        #region Parameter ModelName
        /// <summary>
        /// <para>
        /// <para>The name to assign to the custom model that is created in Amazon Comprehend by this
        /// import.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelName { get; set; }
        #endregion
        
        #region Parameter SourceModelArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the custom model to import.</para>
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
        public System.String SourceModelArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Tags to associate with the custom model that is created by this import. A tag is a
        /// key-value pair that adds as a metadata to a resource used by Amazon Comprehend. For
        /// example, a tag with "Sales" as the key might be added to a resource to indicate its
        /// use by the sales department.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.Comprehend.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter VersionName
        /// <summary>
        /// <para>
        /// <para>The version name given to the custom model that is created by this import. Version
        /// names can have a maximum of 256 characters. Alphanumeric characters, hyphens (-) and
        /// underscores (_) are allowed. The version name must be unique among all models with
        /// the same classifier name in the account/AWS Region.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String VersionName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ModelArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Comprehend.Model.ImportModelResponse).
        /// Specifying the name of a property of type Amazon.Comprehend.Model.ImportModelResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ModelArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the SourceModelArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^SourceModelArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^SourceModelArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.SourceModelArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Import-COMPModel (ImportModel)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Comprehend.Model.ImportModelResponse, ImportCOMPModelCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.SourceModelArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.DataAccessRoleArn = this.DataAccessRoleArn;
            context.ModelKmsKeyId = this.ModelKmsKeyId;
            context.ModelName = this.ModelName;
            context.SourceModelArn = this.SourceModelArn;
            #if MODULAR
            if (this.SourceModelArn == null && ParameterWasBound(nameof(this.SourceModelArn)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceModelArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.Comprehend.Model.Tag>(this.Tag);
            }
            context.VersionName = this.VersionName;
            
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
            var request = new Amazon.Comprehend.Model.ImportModelRequest();
            
            if (cmdletContext.DataAccessRoleArn != null)
            {
                request.DataAccessRoleArn = cmdletContext.DataAccessRoleArn;
            }
            if (cmdletContext.ModelKmsKeyId != null)
            {
                request.ModelKmsKeyId = cmdletContext.ModelKmsKeyId;
            }
            if (cmdletContext.ModelName != null)
            {
                request.ModelName = cmdletContext.ModelName;
            }
            if (cmdletContext.SourceModelArn != null)
            {
                request.SourceModelArn = cmdletContext.SourceModelArn;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.VersionName != null)
            {
                request.VersionName = cmdletContext.VersionName;
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
        
        private Amazon.Comprehend.Model.ImportModelResponse CallAWSServiceOperation(IAmazonComprehend client, Amazon.Comprehend.Model.ImportModelRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Comprehend", "ImportModel");
            try
            {
                #if DESKTOP
                return client.ImportModel(request);
                #elif CORECLR
                return client.ImportModelAsync(request).GetAwaiter().GetResult();
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
            public System.String DataAccessRoleArn { get; set; }
            public System.String ModelKmsKeyId { get; set; }
            public System.String ModelName { get; set; }
            public System.String SourceModelArn { get; set; }
            public List<Amazon.Comprehend.Model.Tag> Tag { get; set; }
            public System.String VersionName { get; set; }
            public System.Func<Amazon.Comprehend.Model.ImportModelResponse, ImportCOMPModelCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ModelArn;
        }
        
    }
}
