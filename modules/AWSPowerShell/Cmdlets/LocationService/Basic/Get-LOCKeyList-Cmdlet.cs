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
using Amazon.LocationService;
using Amazon.LocationService.Model;

namespace Amazon.PowerShell.Cmdlets.LOC
{
    /// <summary>
    /// Lists API key resources in your Amazon Web Services account.
    /// 
    ///  <important><para>
    /// The API keys feature is in preview. We may add, change, or remove features before
    /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
    /// API keys</a>.
    /// </para></important>
    /// </summary>
    [Cmdlet("Get", "LOCKeyList")]
    [OutputType("Amazon.LocationService.Model.ListKeysResponseEntry")]
    [AWSCmdlet("Calls the Amazon Location Service ListKeys API operation.", Operation = new[] {"ListKeys"}, SelectReturnType = typeof(Amazon.LocationService.Model.ListKeysResponse))]
    [AWSCmdletOutput("Amazon.LocationService.Model.ListKeysResponseEntry or Amazon.LocationService.Model.ListKeysResponse",
        "This cmdlet returns a collection of Amazon.LocationService.Model.ListKeysResponseEntry objects.",
        "The service call response (type Amazon.LocationService.Model.ListKeysResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetLOCKeyListCmdlet : AmazonLocationServiceClientCmdlet, IExecutor
    {
        
        #region Parameter Filter_KeyStatus
        /// <summary>
        /// <para>
        /// <para>Filter on <code>Active</code> or <code>Expired</code> API keys.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        [AWSConstantClassSource("Amazon.LocationService.Status")]
        public Amazon.LocationService.Status Filter_KeyStatus { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>An optional limit for the number of resources returned in a single call. </para><para>Default value: <code>100</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page. </para><para>Default value: <code>null</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Entries'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.LocationService.Model.ListKeysResponse).
        /// Specifying the name of a property of type Amazon.LocationService.Model.ListKeysResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Entries";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Filter_KeyStatus parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Filter_KeyStatus' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Filter_KeyStatus' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.LocationService.Model.ListKeysResponse, GetLOCKeyListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Filter_KeyStatus;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Filter_KeyStatus = this.Filter_KeyStatus;
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            
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
            var request = new Amazon.LocationService.Model.ListKeysRequest();
            
            
             // populate Filter
            var requestFilterIsNull = true;
            request.Filter = new Amazon.LocationService.Model.ApiKeyFilter();
            Amazon.LocationService.Status requestFilter_filter_KeyStatus = null;
            if (cmdletContext.Filter_KeyStatus != null)
            {
                requestFilter_filter_KeyStatus = cmdletContext.Filter_KeyStatus;
            }
            if (requestFilter_filter_KeyStatus != null)
            {
                request.Filter.KeyStatus = requestFilter_filter_KeyStatus;
                requestFilterIsNull = false;
            }
             // determine if request.Filter should be set to null
            if (requestFilterIsNull)
            {
                request.Filter = null;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.NextToken != null)
            {
                request.NextToken = cmdletContext.NextToken;
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
        
        private Amazon.LocationService.Model.ListKeysResponse CallAWSServiceOperation(IAmazonLocationService client, Amazon.LocationService.Model.ListKeysRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Location Service", "ListKeys");
            try
            {
                #if DESKTOP
                return client.ListKeys(request);
                #elif CORECLR
                return client.ListKeysAsync(request).GetAwaiter().GetResult();
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
            public Amazon.LocationService.Status Filter_KeyStatus { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.LocationService.Model.ListKeysResponse, GetLOCKeyListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Entries;
        }
        
    }
}