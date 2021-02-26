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
using Amazon.S3;
using Amazon.S3.Model;

namespace Amazon.PowerShell.Cmdlets.S3
{
    /// <summary>
    /// Amazon.S3.IAmazonS3.PutBucketAnalyticsConfiguration
    /// </summary>
    [Cmdlet("Write", "S3BucketAnalyticsConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the Amazon Simple Storage Service (S3) PutBucketAnalyticsConfiguration API operation.", Operation = new[] {"PutBucketAnalyticsConfiguration"}, SelectReturnType = typeof(Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse))]
    [AWSCmdletOutput("None or Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class WriteS3BucketAnalyticsConfigurationCmdlet : AmazonS3ClientCmdlet, IExecutor
    {
        
        #region Parameter AnalyticsFilter_AnalyticsFilterPredicate
        /// <summary>
        /// <para>
        /// Filter Predicate setup for specific filter types.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AnalyticsConfiguration_AnalyticsFilter_AnalyticsFilterPredicate")]
        public Amazon.S3.Model.AnalyticsFilterPredicate AnalyticsFilter_AnalyticsFilterPredicate { get; set; }
        #endregion
        
        #region Parameter AnalyticsId
        /// <summary>
        /// <para>
        /// The identifier used to represent an analytics configuration.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AnalyticsId { get; set; }
        #endregion
        
        #region Parameter AnalyticsConfiguration_AnalyticsId
        /// <summary>
        /// <para>
        /// The identifier used to represent an analytics configuration.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AnalyticsConfiguration_AnalyticsId { get; set; }
        #endregion
        
        #region Parameter S3BucketDestination_BucketAccountId
        /// <summary>
        /// <para>
        /// The account ID that owns the destination bucket. If no account ID is provided, the owner will not be validated prior to exporting data.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AnalyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_BucketAccountId")]
        public System.String S3BucketDestination_BucketAccountId { get; set; }
        #endregion
        
        #region Parameter BucketName
        /// <summary>
        /// <para>
        /// The name of the bucket to which an analytics configuration is stored.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String BucketName { get; set; }
        #endregion
        
        #region Parameter S3BucketDestination_BucketName
        /// <summary>
        /// <para>
        /// The Amazon resource name (ARN) of the bucket to which data is exported.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AnalyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_BucketName")]
        public System.String S3BucketDestination_BucketName { get; set; }
        #endregion
        
        #region Parameter ExpectedBucketOwner
        /// <summary>
        /// <para>
        /// The account ID of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ExpectedBucketOwner { get; set; }
        #endregion
        
        #region Parameter S3BucketDestination_Format
        /// <summary>
        /// <para>
        /// The file format used when exporting data to Amazon S3.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AnalyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_Format")]
        public System.String S3BucketDestination_Format { get; set; }
        #endregion
        
        #region Parameter DataExport_OutputSchemaVersion
        /// <summary>
        /// <para>
        /// The version of the output schema to use when exporting data. Must be V_1.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AnalyticsConfiguration_StorageClassAnalysis_DataExport_OutputSchemaVersion")]
        [AWSConstantClassSource("Amazon.S3.StorageClassAnalysisSchemaVersion")]
        public Amazon.S3.StorageClassAnalysisSchemaVersion DataExport_OutputSchemaVersion { get; set; }
        #endregion
        
        #region Parameter S3BucketDestination_Prefix
        /// <summary>
        /// <para>
        /// The prefix to use when exporting data. The exported data begins with this prefix.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AnalyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_Prefix")]
        public System.String S3BucketDestination_Prefix { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the BucketName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^BucketName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^BucketName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.BucketName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Write-S3BucketAnalyticsConfiguration (PutBucketAnalyticsConfiguration)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse, WriteS3BucketAnalyticsConfigurationCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.BucketName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.BucketName = this.BucketName;
            context.AnalyticsId = this.AnalyticsId;
            context.AnalyticsConfiguration_AnalyticsId = this.AnalyticsConfiguration_AnalyticsId;
            context.AnalyticsFilter_AnalyticsFilterPredicate = this.AnalyticsFilter_AnalyticsFilterPredicate;
            context.DataExport_OutputSchemaVersion = this.DataExport_OutputSchemaVersion;
            context.S3BucketDestination_Format = this.S3BucketDestination_Format;
            context.S3BucketDestination_BucketAccountId = this.S3BucketDestination_BucketAccountId;
            context.S3BucketDestination_BucketName = this.S3BucketDestination_BucketName;
            context.S3BucketDestination_Prefix = this.S3BucketDestination_Prefix;
            context.ExpectedBucketOwner = this.ExpectedBucketOwner;
            
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
            var request = new Amazon.S3.Model.PutBucketAnalyticsConfigurationRequest();
            
            if (cmdletContext.BucketName != null)
            {
                request.BucketName = cmdletContext.BucketName;
            }
            if (cmdletContext.AnalyticsId != null)
            {
                request.AnalyticsId = cmdletContext.AnalyticsId;
            }
            
             // populate AnalyticsConfiguration
            var requestAnalyticsConfigurationIsNull = true;
            request.AnalyticsConfiguration = new Amazon.S3.Model.AnalyticsConfiguration();
            System.String requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsId = null;
            if (cmdletContext.AnalyticsConfiguration_AnalyticsId != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsId = cmdletContext.AnalyticsConfiguration_AnalyticsId;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsId != null)
            {
                request.AnalyticsConfiguration.AnalyticsId = requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsId;
                requestAnalyticsConfigurationIsNull = false;
            }
            Amazon.S3.Model.AnalyticsFilter requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter = null;
            
             // populate AnalyticsFilter
            var requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilterIsNull = true;
            requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter = new Amazon.S3.Model.AnalyticsFilter();
            Amazon.S3.Model.AnalyticsFilterPredicate requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter_analyticsFilter_AnalyticsFilterPredicate = null;
            if (cmdletContext.AnalyticsFilter_AnalyticsFilterPredicate != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter_analyticsFilter_AnalyticsFilterPredicate = cmdletContext.AnalyticsFilter_AnalyticsFilterPredicate;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter_analyticsFilter_AnalyticsFilterPredicate != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter.AnalyticsFilterPredicate = requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter_analyticsFilter_AnalyticsFilterPredicate;
                requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilterIsNull = false;
            }
             // determine if requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter should be set to null
            if (requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilterIsNull)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter = null;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter != null)
            {
                request.AnalyticsConfiguration.AnalyticsFilter = requestAnalyticsConfiguration_analyticsConfiguration_AnalyticsFilter;
                requestAnalyticsConfigurationIsNull = false;
            }
            Amazon.S3.Model.StorageClassAnalysis requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis = null;
            
             // populate StorageClassAnalysis
            var requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysisIsNull = true;
            requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis = new Amazon.S3.Model.StorageClassAnalysis();
            Amazon.S3.Model.StorageClassAnalysisDataExport requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport = null;
            
             // populate DataExport
            var requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExportIsNull = true;
            requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport = new Amazon.S3.Model.StorageClassAnalysisDataExport();
            Amazon.S3.StorageClassAnalysisSchemaVersion requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_dataExport_OutputSchemaVersion = null;
            if (cmdletContext.DataExport_OutputSchemaVersion != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_dataExport_OutputSchemaVersion = cmdletContext.DataExport_OutputSchemaVersion;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_dataExport_OutputSchemaVersion != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport.OutputSchemaVersion = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_dataExport_OutputSchemaVersion;
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExportIsNull = false;
            }
            Amazon.S3.Model.AnalyticsExportDestination requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination = null;
            
             // populate Destination
            var requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_DestinationIsNull = true;
            requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination = new Amazon.S3.Model.AnalyticsExportDestination();
            Amazon.S3.Model.AnalyticsS3BucketDestination requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination = null;
            
             // populate S3BucketDestination
            var requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestinationIsNull = true;
            requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination = new Amazon.S3.Model.AnalyticsS3BucketDestination();
            System.String requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_Format = null;
            if (cmdletContext.S3BucketDestination_Format != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_Format = cmdletContext.S3BucketDestination_Format;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_Format != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination.Format = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_Format;
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestinationIsNull = false;
            }
            System.String requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_BucketAccountId = null;
            if (cmdletContext.S3BucketDestination_BucketAccountId != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_BucketAccountId = cmdletContext.S3BucketDestination_BucketAccountId;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_BucketAccountId != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination.BucketAccountId = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_BucketAccountId;
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestinationIsNull = false;
            }
            System.String requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_BucketName = null;
            if (cmdletContext.S3BucketDestination_BucketName != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_BucketName = cmdletContext.S3BucketDestination_BucketName;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_BucketName != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination.BucketName = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_BucketName;
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestinationIsNull = false;
            }
            System.String requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_Prefix = null;
            if (cmdletContext.S3BucketDestination_Prefix != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_Prefix = cmdletContext.S3BucketDestination_Prefix;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_Prefix != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination.Prefix = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination_s3BucketDestination_Prefix;
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestinationIsNull = false;
            }
             // determine if requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination should be set to null
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestinationIsNull)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination = null;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination.S3BucketDestination = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination_S3BucketDestination;
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_DestinationIsNull = false;
            }
             // determine if requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination should be set to null
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_DestinationIsNull)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination = null;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport.Destination = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport_analyticsConfiguration_StorageClassAnalysis_DataExport_Destination;
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExportIsNull = false;
            }
             // determine if requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport should be set to null
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExportIsNull)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport = null;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis.DataExport = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis_analyticsConfiguration_StorageClassAnalysis_DataExport;
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysisIsNull = false;
            }
             // determine if requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis should be set to null
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysisIsNull)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis = null;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis != null)
            {
                request.AnalyticsConfiguration.StorageClassAnalysis = requestAnalyticsConfiguration_analyticsConfiguration_StorageClassAnalysis;
                requestAnalyticsConfigurationIsNull = false;
            }
             // determine if request.AnalyticsConfiguration should be set to null
            if (requestAnalyticsConfigurationIsNull)
            {
                request.AnalyticsConfiguration = null;
            }
            if (cmdletContext.ExpectedBucketOwner != null)
            {
                request.ExpectedBucketOwner = cmdletContext.ExpectedBucketOwner;
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
        
        private Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse CallAWSServiceOperation(IAmazonS3 client, Amazon.S3.Model.PutBucketAnalyticsConfigurationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Simple Storage Service (S3)", "PutBucketAnalyticsConfiguration");
            try
            {
                #if DESKTOP
                return client.PutBucketAnalyticsConfiguration(request);
                #elif CORECLR
                return client.PutBucketAnalyticsConfigurationAsync(request).GetAwaiter().GetResult();
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
            public System.String BucketName { get; set; }
            public System.String AnalyticsId { get; set; }
            public System.String AnalyticsConfiguration_AnalyticsId { get; set; }
            public Amazon.S3.Model.AnalyticsFilterPredicate AnalyticsFilter_AnalyticsFilterPredicate { get; set; }
            public Amazon.S3.StorageClassAnalysisSchemaVersion DataExport_OutputSchemaVersion { get; set; }
            public System.String S3BucketDestination_Format { get; set; }
            public System.String S3BucketDestination_BucketAccountId { get; set; }
            public System.String S3BucketDestination_BucketName { get; set; }
            public System.String S3BucketDestination_Prefix { get; set; }
            public System.String ExpectedBucketOwner { get; set; }
            public System.Func<Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse, WriteS3BucketAnalyticsConfigurationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
