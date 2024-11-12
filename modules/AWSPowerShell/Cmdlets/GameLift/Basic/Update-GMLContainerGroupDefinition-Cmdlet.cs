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
using Amazon.GameLift;
using Amazon.GameLift.Model;

namespace Amazon.PowerShell.Cmdlets.GML
{
    /// <summary>
    /// Updates properties in an existing container group definition. This operation doesn't
    /// replace the definition. Instead, it creates a new version of the definition and saves
    /// it separately. You can access all versions that you choose to retain.
    /// 
    ///  
    /// <para>
    /// The only property you can't update is the container group type.
    /// </para><para><b>Request options:</b></para><ul><li><para>
    /// Update based on the latest version of the container group definition. Specify the
    /// container group definition name only, or use an ARN value without a version number.
    /// Provide updated values for the properties that you want to change only. All other
    /// values remain the same as the latest version.
    /// </para></li><li><para>
    /// Update based on a specific version of the container group definition. Specify the
    /// container group definition name and a source version number, or use an ARN value with
    /// a version number. Provide updated values for the properties that you want to change
    /// only. All other values remain the same as the source version.
    /// </para></li><li><para>
    /// Change a game server container definition. Provide the updated container definition.
    /// </para></li><li><para>
    /// Add or change a support container definition. Provide a complete set of container
    /// definitions, including the updated definition.
    /// </para></li><li><para>
    /// Remove a support container definition. Provide a complete set of container definitions,
    /// excluding the definition to remove. If the container group has only one support container
    /// definition, provide an empty set.
    /// </para></li></ul><para><b>Results:</b></para><para>
    /// If successful, this operation returns the complete properties of the new container
    /// group definition version.
    /// </para><para>
    /// If the container group definition version is used in an active fleets, the update
    /// automatically initiates a new fleet deployment of the new version. You can track a
    /// fleet's deployments using <a>ListFleetDeployments</a>.
    /// </para>
    /// </summary>
    [Cmdlet("Update", "GMLContainerGroupDefinition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.GameLift.Model.ContainerGroupDefinition")]
    [AWSCmdlet("Calls the Amazon GameLift Service UpdateContainerGroupDefinition API operation.", Operation = new[] {"UpdateContainerGroupDefinition"}, SelectReturnType = typeof(Amazon.GameLift.Model.UpdateContainerGroupDefinitionResponse))]
    [AWSCmdletOutput("Amazon.GameLift.Model.ContainerGroupDefinition or Amazon.GameLift.Model.UpdateContainerGroupDefinitionResponse",
        "This cmdlet returns an Amazon.GameLift.Model.ContainerGroupDefinition object.",
        "The service call response (type Amazon.GameLift.Model.UpdateContainerGroupDefinitionResponse) can be returned by specifying '-Select *'."
    )]
    public partial class UpdateGMLContainerGroupDefinitionCmdlet : AmazonGameLiftClientCmdlet, IExecutor
    {
        
        protected override bool IsSensitiveRequest { get; set; } = true;
        
        protected override bool IsSensitiveResponse { get; set; } = true;
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter GameServerContainerDefinition_ContainerName
        /// <summary>
        /// <para>
        /// <para>A string that uniquely identifies the container definition within a container group.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String GameServerContainerDefinition_ContainerName { get; set; }
        #endregion
        
        #region Parameter PortConfiguration_ContainerPortRange
        /// <summary>
        /// <para>
        /// <para>A set of one or more container port number ranges. The ranges can't overlap. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("GameServerContainerDefinition_PortConfiguration_ContainerPortRanges")]
        public Amazon.GameLift.Model.ContainerPortRange[] PortConfiguration_ContainerPortRange { get; set; }
        #endregion
        
        #region Parameter GameServerContainerDefinition_DependsOn
        /// <summary>
        /// <para>
        /// <para>Establishes dependencies between this container and the status of other containers
        /// in the same container group. A container can have dependencies on multiple different
        /// containers. </para><para>You can use dependencies to establish a startup/shutdown sequence across the container
        /// group. For example, you might specify that <i>ContainerB</i> has a <c>START</c> dependency
        /// on <i>ContainerA</i>. This dependency means that <i>ContainerB</i> can't start until
        /// after <i>ContainerA</i> has started. This dependency is reversed on shutdown, which
        /// means that <i>ContainerB</i> must shut down before <i>ContainerA</i> can shut down.
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.GameLift.Model.ContainerDependency[] GameServerContainerDefinition_DependsOn { get; set; }
        #endregion
        
        #region Parameter GameServerContainerDefinition_EnvironmentOverride
        /// <summary>
        /// <para>
        /// <para>A set of environment variables to pass to the container on startup. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-environment">ContainerDefinition::environment</a>
        /// parameter in the <i>Amazon Elastic Container Service API Reference</i>. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.GameLift.Model.ContainerEnvironment[] GameServerContainerDefinition_EnvironmentOverride { get; set; }
        #endregion
        
        #region Parameter GameServerContainerDefinition_ImageUri
        /// <summary>
        /// <para>
        /// <para>The location of the container image to deploy to a container fleet. Provide an image
        /// in an Amazon Elastic Container Registry public or private repository. The repository
        /// must be in the same Amazon Web Services account and Amazon Web Services Region where
        /// you're creating the container group definition. For limits on image size, see <a href="https://docs.aws.amazon.com/general/latest/gr/gamelift.html">Amazon
        /// GameLift endpoints and quotas</a>. You can use any of the following image URI formats:
        /// </para><ul><li><para>Image ID only: <c>[AWS account].dkr.ecr.[AWS region].amazonaws.com/[repository ID]</c></para></li><li><para>Image ID and digest: <c>[AWS account].dkr.ecr.[AWS region].amazonaws.com/[repository
        /// ID]@[digest]</c></para></li><li><para>Image ID and tag: <c>[AWS account].dkr.ecr.[AWS region].amazonaws.com/[repository
        /// ID]:[tag]</c></para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String GameServerContainerDefinition_ImageUri { get; set; }
        #endregion
        
        #region Parameter GameServerContainerDefinition_MountPoint
        /// <summary>
        /// <para>
        /// <para>A mount point that binds a path inside the container to a file or directory on the
        /// host system and lets it access the file or directory.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("GameServerContainerDefinition_MountPoints")]
        public Amazon.GameLift.Model.ContainerMountPoint[] GameServerContainerDefinition_MountPoint { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>A descriptive identifier for the container group definition. The name value must be
        /// unique in an Amazon Web Services Region.</para>
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
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter OperatingSystem
        /// <summary>
        /// <para>
        /// <para>The platform that all containers in the group use. Containers in a group must run
        /// on the same operating system.</para><note><para>Amazon Linux 2 (AL2) will reach end of support on 6/30/2025. See more details in the
        /// <a href="https://aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2 FAQs</a>. For
        /// game servers that are hosted on AL2 and use Amazon GameLift server SDK 4.x, first
        /// update the game server build to server SDK 5.x, and then deploy to AL2023 instances.
        /// See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to Amazon GameLift server SDK version 5.</a></para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.GameLift.ContainerOperatingSystem")]
        public Amazon.GameLift.ContainerOperatingSystem OperatingSystem { get; set; }
        #endregion
        
        #region Parameter GameServerContainerDefinition_ServerSdkVersion
        /// <summary>
        /// <para>
        /// <para>The Amazon GameLift server SDK version that the game server is integrated with. Only
        /// game servers using 5.2.0 or higher are compatible with container fleets.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String GameServerContainerDefinition_ServerSdkVersion { get; set; }
        #endregion
        
        #region Parameter SourceVersionNumber
        /// <summary>
        /// <para>
        /// <para>The container group definition version to update. The new version starts with values
        /// from the source version, and then updates values included in this request. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? SourceVersionNumber { get; set; }
        #endregion
        
        #region Parameter SupportContainerDefinition
        /// <summary>
        /// <para>
        /// <para>One or more definitions for support containers in this group. You can define a support
        /// container in any type of container group. You can pass in your container definitions
        /// as a JSON file.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SupportContainerDefinitions")]
        public Amazon.GameLift.Model.SupportContainerDefinitionInput[] SupportContainerDefinition { get; set; }
        #endregion
        
        #region Parameter TotalMemoryLimitMebibyte
        /// <summary>
        /// <para>
        /// <para>The maximum amount of memory (in MiB) to allocate to the container group. All containers
        /// in the group share this memory. If you specify memory limits for an individual container,
        /// the total value must be greater than any individual container's memory limit.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TotalMemoryLimitMebibytes")]
        public System.Int32? TotalMemoryLimitMebibyte { get; set; }
        #endregion
        
        #region Parameter TotalVcpuLimit
        /// <summary>
        /// <para>
        /// <para>The maximum amount of vCPU units to allocate to the container group (1 vCPU is equal
        /// to 1024 CPU units). All containers in the group share this memory. If you specify
        /// vCPU limits for individual containers, the total value must be equal to or greater
        /// than the sum of the CPU limits for all containers in the group.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Double? TotalVcpuLimit { get; set; }
        #endregion
        
        #region Parameter VersionDescription
        /// <summary>
        /// <para>
        /// <para>A description for this update to the container group definition. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String VersionDescription { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ContainerGroupDefinition'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.GameLift.Model.UpdateContainerGroupDefinitionResponse).
        /// Specifying the name of a property of type Amazon.GameLift.Model.UpdateContainerGroupDefinitionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ContainerGroupDefinition";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-GMLContainerGroupDefinition (UpdateContainerGroupDefinition)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.GameLift.Model.UpdateContainerGroupDefinitionResponse, UpdateGMLContainerGroupDefinitionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.GameServerContainerDefinition_ContainerName = this.GameServerContainerDefinition_ContainerName;
            if (this.GameServerContainerDefinition_DependsOn != null)
            {
                context.GameServerContainerDefinition_DependsOn = new List<Amazon.GameLift.Model.ContainerDependency>(this.GameServerContainerDefinition_DependsOn);
            }
            if (this.GameServerContainerDefinition_EnvironmentOverride != null)
            {
                context.GameServerContainerDefinition_EnvironmentOverride = new List<Amazon.GameLift.Model.ContainerEnvironment>(this.GameServerContainerDefinition_EnvironmentOverride);
            }
            context.GameServerContainerDefinition_ImageUri = this.GameServerContainerDefinition_ImageUri;
            if (this.GameServerContainerDefinition_MountPoint != null)
            {
                context.GameServerContainerDefinition_MountPoint = new List<Amazon.GameLift.Model.ContainerMountPoint>(this.GameServerContainerDefinition_MountPoint);
            }
            if (this.PortConfiguration_ContainerPortRange != null)
            {
                context.PortConfiguration_ContainerPortRange = new List<Amazon.GameLift.Model.ContainerPortRange>(this.PortConfiguration_ContainerPortRange);
            }
            context.GameServerContainerDefinition_ServerSdkVersion = this.GameServerContainerDefinition_ServerSdkVersion;
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.OperatingSystem = this.OperatingSystem;
            context.SourceVersionNumber = this.SourceVersionNumber;
            if (this.SupportContainerDefinition != null)
            {
                context.SupportContainerDefinition = new List<Amazon.GameLift.Model.SupportContainerDefinitionInput>(this.SupportContainerDefinition);
            }
            context.TotalMemoryLimitMebibyte = this.TotalMemoryLimitMebibyte;
            context.TotalVcpuLimit = this.TotalVcpuLimit;
            context.VersionDescription = this.VersionDescription;
            
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
            var request = new Amazon.GameLift.Model.UpdateContainerGroupDefinitionRequest();
            
            
             // populate GameServerContainerDefinition
            var requestGameServerContainerDefinitionIsNull = true;
            request.GameServerContainerDefinition = new Amazon.GameLift.Model.GameServerContainerDefinitionInput();
            System.String requestGameServerContainerDefinition_gameServerContainerDefinition_ContainerName = null;
            if (cmdletContext.GameServerContainerDefinition_ContainerName != null)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_ContainerName = cmdletContext.GameServerContainerDefinition_ContainerName;
            }
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_ContainerName != null)
            {
                request.GameServerContainerDefinition.ContainerName = requestGameServerContainerDefinition_gameServerContainerDefinition_ContainerName;
                requestGameServerContainerDefinitionIsNull = false;
            }
            List<Amazon.GameLift.Model.ContainerDependency> requestGameServerContainerDefinition_gameServerContainerDefinition_DependsOn = null;
            if (cmdletContext.GameServerContainerDefinition_DependsOn != null)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_DependsOn = cmdletContext.GameServerContainerDefinition_DependsOn;
            }
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_DependsOn != null)
            {
                request.GameServerContainerDefinition.DependsOn = requestGameServerContainerDefinition_gameServerContainerDefinition_DependsOn;
                requestGameServerContainerDefinitionIsNull = false;
            }
            List<Amazon.GameLift.Model.ContainerEnvironment> requestGameServerContainerDefinition_gameServerContainerDefinition_EnvironmentOverride = null;
            if (cmdletContext.GameServerContainerDefinition_EnvironmentOverride != null)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_EnvironmentOverride = cmdletContext.GameServerContainerDefinition_EnvironmentOverride;
            }
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_EnvironmentOverride != null)
            {
                request.GameServerContainerDefinition.EnvironmentOverride = requestGameServerContainerDefinition_gameServerContainerDefinition_EnvironmentOverride;
                requestGameServerContainerDefinitionIsNull = false;
            }
            System.String requestGameServerContainerDefinition_gameServerContainerDefinition_ImageUri = null;
            if (cmdletContext.GameServerContainerDefinition_ImageUri != null)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_ImageUri = cmdletContext.GameServerContainerDefinition_ImageUri;
            }
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_ImageUri != null)
            {
                request.GameServerContainerDefinition.ImageUri = requestGameServerContainerDefinition_gameServerContainerDefinition_ImageUri;
                requestGameServerContainerDefinitionIsNull = false;
            }
            List<Amazon.GameLift.Model.ContainerMountPoint> requestGameServerContainerDefinition_gameServerContainerDefinition_MountPoint = null;
            if (cmdletContext.GameServerContainerDefinition_MountPoint != null)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_MountPoint = cmdletContext.GameServerContainerDefinition_MountPoint;
            }
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_MountPoint != null)
            {
                request.GameServerContainerDefinition.MountPoints = requestGameServerContainerDefinition_gameServerContainerDefinition_MountPoint;
                requestGameServerContainerDefinitionIsNull = false;
            }
            System.String requestGameServerContainerDefinition_gameServerContainerDefinition_ServerSdkVersion = null;
            if (cmdletContext.GameServerContainerDefinition_ServerSdkVersion != null)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_ServerSdkVersion = cmdletContext.GameServerContainerDefinition_ServerSdkVersion;
            }
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_ServerSdkVersion != null)
            {
                request.GameServerContainerDefinition.ServerSdkVersion = requestGameServerContainerDefinition_gameServerContainerDefinition_ServerSdkVersion;
                requestGameServerContainerDefinitionIsNull = false;
            }
            Amazon.GameLift.Model.ContainerPortConfiguration requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration = null;
            
             // populate PortConfiguration
            var requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfigurationIsNull = true;
            requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration = new Amazon.GameLift.Model.ContainerPortConfiguration();
            List<Amazon.GameLift.Model.ContainerPortRange> requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration_portConfiguration_ContainerPortRange = null;
            if (cmdletContext.PortConfiguration_ContainerPortRange != null)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration_portConfiguration_ContainerPortRange = cmdletContext.PortConfiguration_ContainerPortRange;
            }
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration_portConfiguration_ContainerPortRange != null)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration.ContainerPortRanges = requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration_portConfiguration_ContainerPortRange;
                requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfigurationIsNull = false;
            }
             // determine if requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration should be set to null
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfigurationIsNull)
            {
                requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration = null;
            }
            if (requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration != null)
            {
                request.GameServerContainerDefinition.PortConfiguration = requestGameServerContainerDefinition_gameServerContainerDefinition_PortConfiguration;
                requestGameServerContainerDefinitionIsNull = false;
            }
             // determine if request.GameServerContainerDefinition should be set to null
            if (requestGameServerContainerDefinitionIsNull)
            {
                request.GameServerContainerDefinition = null;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.OperatingSystem != null)
            {
                request.OperatingSystem = cmdletContext.OperatingSystem;
            }
            if (cmdletContext.SourceVersionNumber != null)
            {
                request.SourceVersionNumber = cmdletContext.SourceVersionNumber.Value;
            }
            if (cmdletContext.SupportContainerDefinition != null)
            {
                request.SupportContainerDefinitions = cmdletContext.SupportContainerDefinition;
            }
            if (cmdletContext.TotalMemoryLimitMebibyte != null)
            {
                request.TotalMemoryLimitMebibytes = cmdletContext.TotalMemoryLimitMebibyte.Value;
            }
            if (cmdletContext.TotalVcpuLimit != null)
            {
                request.TotalVcpuLimit = cmdletContext.TotalVcpuLimit.Value;
            }
            if (cmdletContext.VersionDescription != null)
            {
                request.VersionDescription = cmdletContext.VersionDescription;
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
        
        private Amazon.GameLift.Model.UpdateContainerGroupDefinitionResponse CallAWSServiceOperation(IAmazonGameLift client, Amazon.GameLift.Model.UpdateContainerGroupDefinitionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon GameLift Service", "UpdateContainerGroupDefinition");
            try
            {
                #if DESKTOP
                return client.UpdateContainerGroupDefinition(request);
                #elif CORECLR
                return client.UpdateContainerGroupDefinitionAsync(request).GetAwaiter().GetResult();
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
            public System.String GameServerContainerDefinition_ContainerName { get; set; }
            public List<Amazon.GameLift.Model.ContainerDependency> GameServerContainerDefinition_DependsOn { get; set; }
            public List<Amazon.GameLift.Model.ContainerEnvironment> GameServerContainerDefinition_EnvironmentOverride { get; set; }
            public System.String GameServerContainerDefinition_ImageUri { get; set; }
            public List<Amazon.GameLift.Model.ContainerMountPoint> GameServerContainerDefinition_MountPoint { get; set; }
            public List<Amazon.GameLift.Model.ContainerPortRange> PortConfiguration_ContainerPortRange { get; set; }
            public System.String GameServerContainerDefinition_ServerSdkVersion { get; set; }
            public System.String Name { get; set; }
            public Amazon.GameLift.ContainerOperatingSystem OperatingSystem { get; set; }
            public System.Int32? SourceVersionNumber { get; set; }
            public List<Amazon.GameLift.Model.SupportContainerDefinitionInput> SupportContainerDefinition { get; set; }
            public System.Int32? TotalMemoryLimitMebibyte { get; set; }
            public System.Double? TotalVcpuLimit { get; set; }
            public System.String VersionDescription { get; set; }
            public System.Func<Amazon.GameLift.Model.UpdateContainerGroupDefinitionResponse, UpdateGMLContainerGroupDefinitionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ContainerGroupDefinition;
        }
        
    }
}
