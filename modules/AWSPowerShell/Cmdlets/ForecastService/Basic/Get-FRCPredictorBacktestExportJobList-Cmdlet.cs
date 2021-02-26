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
using Amazon.ForecastService;
using Amazon.ForecastService.Model;

namespace Amazon.PowerShell.Cmdlets.FRC
{
    /// <summary>
    /// Returns a list of predictor backtest export jobs created using the <a>CreatePredictorBacktestExportJob</a>
    /// operation. This operation returns a summary for each backtest export job. You can
    /// filter the list using an array of <a>Filter</a> objects.
    /// 
    ///  
    /// <para>
    /// To retrieve the complete set of properties for a particular backtest export job, use
    /// the ARN with the <a>DescribePredictorBacktestExportJob</a> operation.
    /// </para><br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "FRCPredictorBacktestExportJobList")]
    [OutputType("Amazon.ForecastService.Model.PredictorBacktestExportJobSummary")]
    [AWSCmdlet("Calls the Amazon Forecast Service ListPredictorBacktestExportJobs API operation.", Operation = new[] {"ListPredictorBacktestExportJobs"}, SelectReturnType = typeof(Amazon.ForecastService.Model.ListPredictorBacktestExportJobsResponse))]
    [AWSCmdletOutput("Amazon.ForecastService.Model.PredictorBacktestExportJobSummary or Amazon.ForecastService.Model.ListPredictorBacktestExportJobsResponse",
        "This cmdlet returns a collection of Amazon.ForecastService.Model.PredictorBacktestExportJobSummary objects.",
        "The service call response (type Amazon.ForecastService.Model.ListPredictorBacktestExportJobsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetFRCPredictorBacktestExportJobListCmdlet : AmazonForecastServiceClientCmdlet, IExecutor
    {
        
        #region Parameter Filter
        /// <summary>
        /// <para>
        /// <para>An array of filters. For each filter, provide a condition and a match statement. The
        /// condition is either <code>IS</code> or <code>IS_NOT</code>, which specifies whether
        /// to include or exclude the predictor backtest export jobs that match the statement
        /// from the list. The match statement consists of a key and a value.</para><para><b>Filter properties</b></para><ul><li><para><code>Condition</code> - The condition to apply. Valid values are <code>IS</code>
        /// and <code>IS_NOT</code>. To include the predictor backtest export jobs that match
        /// the statement, specify <code>IS</code>. To exclude matching predictor backtest export
        /// jobs, specify <code>IS_NOT</code>.</para></li><li><para><code>Key</code> - The name of the parameter to filter on. Valid values are <code>PredictorArn</code>
        /// and <code>Status</code>.</para></li><li><para><code>Value</code> - The value to match.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filters")]
        public Amazon.ForecastService.Model.Filter[] Filter { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The number of items to return in the response.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>If the result of the previous request was truncated, the response includes a NextToken.
        /// To retrieve the next set of results, use the token in the next request. Tokens expire
        /// after 24 hours.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> This parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-NextToken $null' for the first call and '-NextToken $AWSHistory.LastServiceResponse.NextToken' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'PredictorBacktestExportJobs'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ForecastService.Model.ListPredictorBacktestExportJobsResponse).
        /// Specifying the name of a property of type Amazon.ForecastService.Model.ListPredictorBacktestExportJobsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "PredictorBacktestExportJobs";
        #endregion
        
        #region Parameter NoAutoIteration
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ForecastService.Model.ListPredictorBacktestExportJobsResponse, GetFRCPredictorBacktestExportJobListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.Filter != null)
            {
                context.Filter = new List<Amazon.ForecastService.Model.Filter>(this.Filter);
            }
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
            var useParameterSelect = this.Select.StartsWith("^");
            
            // create request and set iteration invariants
            var request = new Amazon.ForecastService.Model.ListPredictorBacktestExportJobsRequest();
            
            if (cmdletContext.Filter != null)
            {
                request.Filters = cmdletContext.Filter;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.NextToken;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    
                    _nextToken = response.NextToken;
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                ProcessOutput(output);
                
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken));
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.ForecastService.Model.ListPredictorBacktestExportJobsResponse CallAWSServiceOperation(IAmazonForecastService client, Amazon.ForecastService.Model.ListPredictorBacktestExportJobsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Forecast Service", "ListPredictorBacktestExportJobs");
            try
            {
                #if DESKTOP
                return client.ListPredictorBacktestExportJobs(request);
                #elif CORECLR
                return client.ListPredictorBacktestExportJobsAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.ForecastService.Model.Filter> Filter { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.ForecastService.Model.ListPredictorBacktestExportJobsResponse, GetFRCPredictorBacktestExportJobListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.PredictorBacktestExportJobs;
        }
        
    }
}
