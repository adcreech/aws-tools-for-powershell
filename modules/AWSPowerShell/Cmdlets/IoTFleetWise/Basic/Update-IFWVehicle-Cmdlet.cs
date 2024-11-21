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
using Amazon.IoTFleetWise;
using Amazon.IoTFleetWise.Model;

namespace Amazon.PowerShell.Cmdlets.IFW
{
    /// <summary>
    /// Updates a vehicle.
    /// </summary>
    [Cmdlet("Update", "IFWVehicle", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.IoTFleetWise.Model.UpdateVehicleResponse")]
    [AWSCmdlet("Calls the AWS IoT FleetWise UpdateVehicle API operation.", Operation = new[] {"UpdateVehicle"}, SelectReturnType = typeof(Amazon.IoTFleetWise.Model.UpdateVehicleResponse))]
    [AWSCmdletOutput("Amazon.IoTFleetWise.Model.UpdateVehicleResponse",
        "This cmdlet returns an Amazon.IoTFleetWise.Model.UpdateVehicleResponse object containing multiple properties."
    )]
    public partial class UpdateIFWVehicleCmdlet : AmazonIoTFleetWiseClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter Attribute
        /// <summary>
        /// <para>
        /// <para>Static information about a vehicle in a key-value pair. For example:</para><para><c>"engineType"</c> : <c>"1.3 L R2"</c></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Attributes")]
        public System.Collections.Hashtable Attribute { get; set; }
        #endregion
        
        #region Parameter AttributeUpdateMode
        /// <summary>
        /// <para>
        /// <para>The method the specified attributes will update the existing attributes on the vehicle.
        /// Use<c>Overwite</c> to replace the vehicle attributes with the specified attributes.
        /// Or use <c>Merge</c> to combine all attributes.</para><para>This is required if attributes are present in the input.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.IoTFleetWise.UpdateMode")]
        public Amazon.IoTFleetWise.UpdateMode AttributeUpdateMode { get; set; }
        #endregion
        
        #region Parameter DecoderManifestArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the decoder manifest associated with this vehicle.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DecoderManifestArn { get; set; }
        #endregion
        
        #region Parameter ModelManifestArn
        /// <summary>
        /// <para>
        /// <para>The ARN of a vehicle model (model manifest) associated with the vehicle.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelManifestArn { get; set; }
        #endregion
        
        #region Parameter StateTemplatesToAdd
        /// <summary>
        /// <para>
        /// <para>Associate state templates with the vehicle.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.IoTFleetWise.Model.StateTemplateAssociation[] StateTemplatesToAdd { get; set; }
        #endregion
        
        #region Parameter StateTemplatesToRemove
        /// <summary>
        /// <para>
        /// <para>Remove state templates from the vehicle.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] StateTemplatesToRemove { get; set; }
        #endregion
        
        #region Parameter VehicleName
        /// <summary>
        /// <para>
        /// <para>The unique ID of the vehicle to update.</para>
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
        public System.String VehicleName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IoTFleetWise.Model.UpdateVehicleResponse).
        /// Specifying the name of a property of type Amazon.IoTFleetWise.Model.UpdateVehicleResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the VehicleName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^VehicleName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^VehicleName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.VehicleName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-IFWVehicle (UpdateVehicle)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IoTFleetWise.Model.UpdateVehicleResponse, UpdateIFWVehicleCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.VehicleName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.Attribute != null)
            {
                context.Attribute = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Attribute.Keys)
                {
                    context.Attribute.Add((String)hashKey, (System.String)(this.Attribute[hashKey]));
                }
            }
            context.AttributeUpdateMode = this.AttributeUpdateMode;
            context.DecoderManifestArn = this.DecoderManifestArn;
            context.ModelManifestArn = this.ModelManifestArn;
            if (this.StateTemplatesToAdd != null)
            {
                context.StateTemplatesToAdd = new List<Amazon.IoTFleetWise.Model.StateTemplateAssociation>(this.StateTemplatesToAdd);
            }
            if (this.StateTemplatesToRemove != null)
            {
                context.StateTemplatesToRemove = new List<System.String>(this.StateTemplatesToRemove);
            }
            context.VehicleName = this.VehicleName;
            #if MODULAR
            if (this.VehicleName == null && ParameterWasBound(nameof(this.VehicleName)))
            {
                WriteWarning("You are passing $null as a value for parameter VehicleName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.IoTFleetWise.Model.UpdateVehicleRequest();
            
            if (cmdletContext.Attribute != null)
            {
                request.Attributes = cmdletContext.Attribute;
            }
            if (cmdletContext.AttributeUpdateMode != null)
            {
                request.AttributeUpdateMode = cmdletContext.AttributeUpdateMode;
            }
            if (cmdletContext.DecoderManifestArn != null)
            {
                request.DecoderManifestArn = cmdletContext.DecoderManifestArn;
            }
            if (cmdletContext.ModelManifestArn != null)
            {
                request.ModelManifestArn = cmdletContext.ModelManifestArn;
            }
            if (cmdletContext.StateTemplatesToAdd != null)
            {
                request.StateTemplatesToAdd = cmdletContext.StateTemplatesToAdd;
            }
            if (cmdletContext.StateTemplatesToRemove != null)
            {
                request.StateTemplatesToRemove = cmdletContext.StateTemplatesToRemove;
            }
            if (cmdletContext.VehicleName != null)
            {
                request.VehicleName = cmdletContext.VehicleName;
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
        
        private Amazon.IoTFleetWise.Model.UpdateVehicleResponse CallAWSServiceOperation(IAmazonIoTFleetWise client, Amazon.IoTFleetWise.Model.UpdateVehicleRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IoT FleetWise", "UpdateVehicle");
            try
            {
                #if DESKTOP
                return client.UpdateVehicle(request);
                #elif CORECLR
                return client.UpdateVehicleAsync(request).GetAwaiter().GetResult();
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
            public Dictionary<System.String, System.String> Attribute { get; set; }
            public Amazon.IoTFleetWise.UpdateMode AttributeUpdateMode { get; set; }
            public System.String DecoderManifestArn { get; set; }
            public System.String ModelManifestArn { get; set; }
            public List<Amazon.IoTFleetWise.Model.StateTemplateAssociation> StateTemplatesToAdd { get; set; }
            public List<System.String> StateTemplatesToRemove { get; set; }
            public System.String VehicleName { get; set; }
            public System.Func<Amazon.IoTFleetWise.Model.UpdateVehicleResponse, UpdateIFWVehicleCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
