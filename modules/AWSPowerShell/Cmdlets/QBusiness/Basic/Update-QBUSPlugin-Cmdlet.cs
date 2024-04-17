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
using Amazon.QBusiness;
using Amazon.QBusiness.Model;

namespace Amazon.PowerShell.Cmdlets.QBUS
{
    /// <summary>
    /// Updates an Amazon Q Business plugin.
    /// </summary>
    [Cmdlet("Update", "QBUSPlugin", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the Amazon QBusiness UpdatePlugin API operation.", Operation = new[] {"UpdatePlugin"}, SelectReturnType = typeof(Amazon.QBusiness.Model.UpdatePluginResponse))]
    [AWSCmdletOutput("None or Amazon.QBusiness.Model.UpdatePluginResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.QBusiness.Model.UpdatePluginResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateQBUSPluginCmdlet : AmazonQBusinessClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter ApplicationId
        /// <summary>
        /// <para>
        /// <para>The identifier of the application the plugin is attached to.</para>
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
        public System.String ApplicationId { get; set; }
        #endregion
        
        #region Parameter DisplayName
        /// <summary>
        /// <para>
        /// <para>The name of the plugin.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DisplayName { get; set; }
        #endregion
        
        #region Parameter PluginId
        /// <summary>
        /// <para>
        /// <para>The identifier of the plugin.</para>
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
        public System.String PluginId { get; set; }
        #endregion
        
        #region Parameter BasicAuthConfiguration_RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of an IAM role used by Amazon Q Business to access the basic authentication
        /// credentials stored in a Secrets Manager secret.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AuthConfiguration_BasicAuthConfiguration_RoleArn")]
        public System.String BasicAuthConfiguration_RoleArn { get; set; }
        #endregion
        
        #region Parameter OAuth2ClientCredentialConfiguration_RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of an IAM role used by Amazon Q Business to access the OAuth 2.0 authentication
        /// credentials stored in a Secrets Manager secret.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AuthConfiguration_OAuth2ClientCredentialConfiguration_RoleArn")]
        public System.String OAuth2ClientCredentialConfiguration_RoleArn { get; set; }
        #endregion
        
        #region Parameter BasicAuthConfiguration_SecretArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the Secrets Manager secret that stores the basic authentication credentials
        /// used for plugin configuration..</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AuthConfiguration_BasicAuthConfiguration_SecretArn")]
        public System.String BasicAuthConfiguration_SecretArn { get; set; }
        #endregion
        
        #region Parameter OAuth2ClientCredentialConfiguration_SecretArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the Secrets Manager secret that stores the OAuth 2.0 credentials/token
        /// used for plugin configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AuthConfiguration_OAuth2ClientCredentialConfiguration_SecretArn")]
        public System.String OAuth2ClientCredentialConfiguration_SecretArn { get; set; }
        #endregion
        
        #region Parameter ServerUrl
        /// <summary>
        /// <para>
        /// <para>The source URL used for plugin configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ServerUrl { get; set; }
        #endregion
        
        #region Parameter State
        /// <summary>
        /// <para>
        /// <para>The status of the plugin. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.QBusiness.PluginState")]
        public Amazon.QBusiness.PluginState State { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.QBusiness.Model.UpdatePluginResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the PluginId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^PluginId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^PluginId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.PluginId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-QBUSPlugin (UpdatePlugin)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.QBusiness.Model.UpdatePluginResponse, UpdateQBUSPluginCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.PluginId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ApplicationId = this.ApplicationId;
            #if MODULAR
            if (this.ApplicationId == null && ParameterWasBound(nameof(this.ApplicationId)))
            {
                WriteWarning("You are passing $null as a value for parameter ApplicationId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.BasicAuthConfiguration_RoleArn = this.BasicAuthConfiguration_RoleArn;
            context.BasicAuthConfiguration_SecretArn = this.BasicAuthConfiguration_SecretArn;
            context.OAuth2ClientCredentialConfiguration_RoleArn = this.OAuth2ClientCredentialConfiguration_RoleArn;
            context.OAuth2ClientCredentialConfiguration_SecretArn = this.OAuth2ClientCredentialConfiguration_SecretArn;
            context.DisplayName = this.DisplayName;
            context.PluginId = this.PluginId;
            #if MODULAR
            if (this.PluginId == null && ParameterWasBound(nameof(this.PluginId)))
            {
                WriteWarning("You are passing $null as a value for parameter PluginId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ServerUrl = this.ServerUrl;
            context.State = this.State;
            
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
            var request = new Amazon.QBusiness.Model.UpdatePluginRequest();
            
            if (cmdletContext.ApplicationId != null)
            {
                request.ApplicationId = cmdletContext.ApplicationId;
            }
            
             // populate AuthConfiguration
            var requestAuthConfigurationIsNull = true;
            request.AuthConfiguration = new Amazon.QBusiness.Model.PluginAuthConfiguration();
            Amazon.QBusiness.Model.BasicAuthConfiguration requestAuthConfiguration_authConfiguration_BasicAuthConfiguration = null;
            
             // populate BasicAuthConfiguration
            var requestAuthConfiguration_authConfiguration_BasicAuthConfigurationIsNull = true;
            requestAuthConfiguration_authConfiguration_BasicAuthConfiguration = new Amazon.QBusiness.Model.BasicAuthConfiguration();
            System.String requestAuthConfiguration_authConfiguration_BasicAuthConfiguration_basicAuthConfiguration_RoleArn = null;
            if (cmdletContext.BasicAuthConfiguration_RoleArn != null)
            {
                requestAuthConfiguration_authConfiguration_BasicAuthConfiguration_basicAuthConfiguration_RoleArn = cmdletContext.BasicAuthConfiguration_RoleArn;
            }
            if (requestAuthConfiguration_authConfiguration_BasicAuthConfiguration_basicAuthConfiguration_RoleArn != null)
            {
                requestAuthConfiguration_authConfiguration_BasicAuthConfiguration.RoleArn = requestAuthConfiguration_authConfiguration_BasicAuthConfiguration_basicAuthConfiguration_RoleArn;
                requestAuthConfiguration_authConfiguration_BasicAuthConfigurationIsNull = false;
            }
            System.String requestAuthConfiguration_authConfiguration_BasicAuthConfiguration_basicAuthConfiguration_SecretArn = null;
            if (cmdletContext.BasicAuthConfiguration_SecretArn != null)
            {
                requestAuthConfiguration_authConfiguration_BasicAuthConfiguration_basicAuthConfiguration_SecretArn = cmdletContext.BasicAuthConfiguration_SecretArn;
            }
            if (requestAuthConfiguration_authConfiguration_BasicAuthConfiguration_basicAuthConfiguration_SecretArn != null)
            {
                requestAuthConfiguration_authConfiguration_BasicAuthConfiguration.SecretArn = requestAuthConfiguration_authConfiguration_BasicAuthConfiguration_basicAuthConfiguration_SecretArn;
                requestAuthConfiguration_authConfiguration_BasicAuthConfigurationIsNull = false;
            }
             // determine if requestAuthConfiguration_authConfiguration_BasicAuthConfiguration should be set to null
            if (requestAuthConfiguration_authConfiguration_BasicAuthConfigurationIsNull)
            {
                requestAuthConfiguration_authConfiguration_BasicAuthConfiguration = null;
            }
            if (requestAuthConfiguration_authConfiguration_BasicAuthConfiguration != null)
            {
                request.AuthConfiguration.BasicAuthConfiguration = requestAuthConfiguration_authConfiguration_BasicAuthConfiguration;
                requestAuthConfigurationIsNull = false;
            }
            Amazon.QBusiness.Model.OAuth2ClientCredentialConfiguration requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration = null;
            
             // populate OAuth2ClientCredentialConfiguration
            var requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfigurationIsNull = true;
            requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration = new Amazon.QBusiness.Model.OAuth2ClientCredentialConfiguration();
            System.String requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration_oAuth2ClientCredentialConfiguration_RoleArn = null;
            if (cmdletContext.OAuth2ClientCredentialConfiguration_RoleArn != null)
            {
                requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration_oAuth2ClientCredentialConfiguration_RoleArn = cmdletContext.OAuth2ClientCredentialConfiguration_RoleArn;
            }
            if (requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration_oAuth2ClientCredentialConfiguration_RoleArn != null)
            {
                requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration.RoleArn = requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration_oAuth2ClientCredentialConfiguration_RoleArn;
                requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfigurationIsNull = false;
            }
            System.String requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration_oAuth2ClientCredentialConfiguration_SecretArn = null;
            if (cmdletContext.OAuth2ClientCredentialConfiguration_SecretArn != null)
            {
                requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration_oAuth2ClientCredentialConfiguration_SecretArn = cmdletContext.OAuth2ClientCredentialConfiguration_SecretArn;
            }
            if (requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration_oAuth2ClientCredentialConfiguration_SecretArn != null)
            {
                requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration.SecretArn = requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration_oAuth2ClientCredentialConfiguration_SecretArn;
                requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfigurationIsNull = false;
            }
             // determine if requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration should be set to null
            if (requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfigurationIsNull)
            {
                requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration = null;
            }
            if (requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration != null)
            {
                request.AuthConfiguration.OAuth2ClientCredentialConfiguration = requestAuthConfiguration_authConfiguration_OAuth2ClientCredentialConfiguration;
                requestAuthConfigurationIsNull = false;
            }
             // determine if request.AuthConfiguration should be set to null
            if (requestAuthConfigurationIsNull)
            {
                request.AuthConfiguration = null;
            }
            if (cmdletContext.DisplayName != null)
            {
                request.DisplayName = cmdletContext.DisplayName;
            }
            if (cmdletContext.PluginId != null)
            {
                request.PluginId = cmdletContext.PluginId;
            }
            if (cmdletContext.ServerUrl != null)
            {
                request.ServerUrl = cmdletContext.ServerUrl;
            }
            if (cmdletContext.State != null)
            {
                request.State = cmdletContext.State;
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
        
        private Amazon.QBusiness.Model.UpdatePluginResponse CallAWSServiceOperation(IAmazonQBusiness client, Amazon.QBusiness.Model.UpdatePluginRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon QBusiness", "UpdatePlugin");
            try
            {
                #if DESKTOP
                return client.UpdatePlugin(request);
                #elif CORECLR
                return client.UpdatePluginAsync(request).GetAwaiter().GetResult();
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
            public System.String ApplicationId { get; set; }
            public System.String BasicAuthConfiguration_RoleArn { get; set; }
            public System.String BasicAuthConfiguration_SecretArn { get; set; }
            public System.String OAuth2ClientCredentialConfiguration_RoleArn { get; set; }
            public System.String OAuth2ClientCredentialConfiguration_SecretArn { get; set; }
            public System.String DisplayName { get; set; }
            public System.String PluginId { get; set; }
            public System.String ServerUrl { get; set; }
            public Amazon.QBusiness.PluginState State { get; set; }
            public System.Func<Amazon.QBusiness.Model.UpdatePluginResponse, UpdateQBUSPluginCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
