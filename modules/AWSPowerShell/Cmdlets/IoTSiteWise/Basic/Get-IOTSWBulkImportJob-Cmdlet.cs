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
using Amazon.IoTSiteWise;
using Amazon.IoTSiteWise.Model;

namespace Amazon.PowerShell.Cmdlets.IOTSW
{
    /// <summary>
    /// <note><para>
    /// This API operation is in preview release for IoT SiteWise and is subject to change.
    /// We recommend that you use this operation only with test data, and not in production
    /// environments.
    /// </para></note><para>
    /// Retrieves information about a bulk import job request. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/DescribeBulkImportJob.html">Describe
    /// a bulk import job (CLI)</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "IOTSWBulkImportJob")]
    [OutputType("Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse")]
    [AWSCmdlet("Calls the AWS IoT SiteWise DescribeBulkImportJob API operation.", Operation = new[] {"DescribeBulkImportJob"}, SelectReturnType = typeof(Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse))]
    [AWSCmdletOutput("Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse",
        "This cmdlet returns an Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetIOTSWBulkImportJobCmdlet : AmazonIoTSiteWiseClientCmdlet, IExecutor
    {
        
        #region Parameter JobId
        /// <summary>
        /// <para>
        /// <para>The ID of the job.</para>
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
        public System.String JobId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse).
        /// Specifying the name of a property of type Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the JobId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^JobId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^JobId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse, GetIOTSWBulkImportJobCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.JobId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.JobId = this.JobId;
            #if MODULAR
            if (this.JobId == null && ParameterWasBound(nameof(this.JobId)))
            {
                WriteWarning("You are passing $null as a value for parameter JobId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.IoTSiteWise.Model.DescribeBulkImportJobRequest();
            
            if (cmdletContext.JobId != null)
            {
                request.JobId = cmdletContext.JobId;
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
        
        private Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse CallAWSServiceOperation(IAmazonIoTSiteWise client, Amazon.IoTSiteWise.Model.DescribeBulkImportJobRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IoT SiteWise", "DescribeBulkImportJob");
            try
            {
                #if DESKTOP
                return client.DescribeBulkImportJob(request);
                #elif CORECLR
                return client.DescribeBulkImportJobAsync(request).GetAwaiter().GetResult();
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
            public System.String JobId { get; set; }
            public System.Func<Amazon.IoTSiteWise.Model.DescribeBulkImportJobResponse, GetIOTSWBulkImportJobCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
