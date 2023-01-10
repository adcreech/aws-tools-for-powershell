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
using Amazon.RDS;
using Amazon.RDS.Model;

namespace Amazon.PowerShell.Cmdlets.RDS
{
    /// <summary>
    /// Creates a new DB instance that acts as a read replica for an existing source DB instance.
    /// You can create a read replica for a DB instance running MySQL, MariaDB, Oracle, PostgreSQL,
    /// or SQL Server. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReadRepl.html">Working
    /// with Read Replicas</a> in the <i>Amazon RDS User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Amazon Aurora doesn't support this operation. Call the <code>CreateDBInstance</code>
    /// operation to create a DB instance for an Aurora DB cluster.
    /// </para><para>
    /// All read replica DB instances are created with backups disabled. All other DB instance
    /// attributes (including DB security groups and DB parameter groups) are inherited from
    /// the source DB instance, except as specified.
    /// </para><important><para>
    /// Your source DB instance must have backup retention enabled.
    /// </para></important>
    /// </summary>
    [Cmdlet("New", "RDSDBInstanceReadReplica", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.RDS.Model.DBInstance")]
    [AWSCmdlet("Calls the Amazon Relational Database Service CreateDBInstanceReadReplica API operation.", Operation = new[] {"CreateDBInstanceReadReplica"}, SelectReturnType = typeof(Amazon.RDS.Model.CreateDBInstanceReadReplicaResponse))]
    [AWSCmdletOutput("Amazon.RDS.Model.DBInstance or Amazon.RDS.Model.CreateDBInstanceReadReplicaResponse",
        "This cmdlet returns an Amazon.RDS.Model.DBInstance object.",
        "The service call response (type Amazon.RDS.Model.CreateDBInstanceReadReplicaResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewRDSDBInstanceReadReplicaCmdlet : AmazonRDSClientCmdlet, IExecutor
    {
        
        #region Parameter AllocatedStorage
        /// <summary>
        /// <para>
        /// <para>The amount of storage (in gibibytes) to allocate initially for the read replica. Follow
        /// the allocation rules specified in <code>CreateDBInstance</code>.</para><note><para>Be sure to allocate enough memory for your read replica so that the create operation
        /// can succeed. You can also allocate additional memory for future growth.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? AllocatedStorage { get; set; }
        #endregion
        
        #region Parameter AutoMinorVersionUpgrade
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether minor engine upgrades are applied automatically to
        /// the read replica during the maintenance window.</para><para>This setting doesn't apply to RDS Custom.</para><para>Default: Inherits from the source DB instance</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AutoMinorVersionUpgrade { get; set; }
        #endregion
        
        #region Parameter AvailabilityZone
        /// <summary>
        /// <para>
        /// <para>The Availability Zone (AZ) where the read replica will be created.</para><para>Default: A random, system-chosen Availability Zone in the endpoint's Amazon Web Services
        /// Region.</para><para>Example: <code>us-east-1d</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AvailabilityZone { get; set; }
        #endregion
        
        #region Parameter CopyTagsToSnapshot
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether to copy all tags from the read replica to snapshots
        /// of the read replica. By default, tags are not copied.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? CopyTagsToSnapshot { get; set; }
        #endregion
        
        #region Parameter CustomIamInstanceProfile
        /// <summary>
        /// <para>
        /// <para>The instance profile associated with the underlying Amazon EC2 instance of an RDS
        /// Custom DB instance. The instance profile must meet the following requirements:</para><ul><li><para>The profile must exist in your account.</para></li><li><para>The profile must have an IAM role that Amazon EC2 has permissions to assume.</para></li><li><para>The instance profile name and the associated IAM role name must start with the prefix
        /// <code>AWSRDSCustom</code>.</para></li></ul><para>For the list of permissions required for the IAM role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-setup-orcl.html#custom-setup-orcl.iam-vpc">
        /// Configure IAM and your VPC</a> in the <i>Amazon RDS User Guide</i>.</para><para>This setting is required for RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CustomIamInstanceProfile { get; set; }
        #endregion
        
        #region Parameter DBInstanceClass
        /// <summary>
        /// <para>
        /// <para>The compute and memory capacity of the read replica, for example db.m4.large. Not
        /// all DB instance classes are available in all Amazon Web Services Regions, or for all
        /// database engines. For the full list of DB instance classes, and availability for your
        /// engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// Instance Class</a> in the <i>Amazon RDS User Guide</i>.</para><para>Default: Inherits from the source DB instance.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DBInstanceClass { get; set; }
        #endregion
        
        #region Parameter DBInstanceIdentifier
        /// <summary>
        /// <para>
        /// <para>The DB instance identifier of the read replica. This identifier is the unique key
        /// that identifies a DB instance. This parameter is stored as a lowercase string.</para>
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
        public System.String DBInstanceIdentifier { get; set; }
        #endregion
        
        #region Parameter DBParameterGroupName
        /// <summary>
        /// <para>
        /// <para>The name of the DB parameter group to associate with this DB instance.</para><para>If you do not specify a value for <code>DBParameterGroupName</code>, then Amazon RDS
        /// uses the <code>DBParameterGroup</code> of source DB instance for a same Region read
        /// replica, or the default <code>DBParameterGroup</code> for the specified DB engine
        /// for a cross-Region read replica.</para><para>Specifying a parameter group for this operation is only supported for MySQL and Oracle
        /// DB instances. It isn't supported for RDS Custom.</para><para>Constraints:</para><ul><li><para>Must be 1 to 255 letters, numbers, or hyphens.</para></li><li><para>First character must be a letter</para></li><li><para>Can't end with a hyphen or contain two consecutive hyphens</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DBParameterGroupName { get; set; }
        #endregion
        
        #region Parameter DBSubnetGroupName
        /// <summary>
        /// <para>
        /// <para>Specifies a DB subnet group for the DB instance. The new DB instance is created in
        /// the VPC associated with the DB subnet group. If no DB subnet group is specified, then
        /// the new DB instance isn't created in a VPC.</para><para>Constraints:</para><ul><li><para>Can only be specified if the source DB instance identifier specifies a DB instance
        /// in another Amazon Web Services Region.</para></li><li><para>If supplied, must match the name of an existing DBSubnetGroup.</para></li><li><para>The specified DB subnet group must be in the same Amazon Web Services Region in which
        /// the operation is running.</para></li><li><para>All read replicas in one Amazon Web Services Region that are created from the same
        /// source DB instance must either:&gt;</para><ul><li><para>Specify DB subnet groups from the same VPC. All these read replicas are created in
        /// the same VPC.</para></li><li><para>Not specify a DB subnet group. All these read replicas are created outside of any
        /// VPC.</para></li></ul></li></ul><para>Example: <code>mydbsubnetgroup</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DBSubnetGroupName { get; set; }
        #endregion
        
        #region Parameter DeletionProtection
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether the DB instance has deletion protection enabled. The
        /// database can't be deleted when deletion protection is enabled. By default, deletion
        /// protection isn't enabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? DeletionProtection { get; set; }
        #endregion
        
        #region Parameter Domain
        /// <summary>
        /// <para>
        /// <para>The Active Directory directory ID to create the DB instance in. Currently, only MySQL,
        /// Microsoft SQL Server, Oracle, and PostgreSQL DB instances can be created in an Active
        /// Directory Domain.</para><para>For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/kerberos-authentication.html">
        /// Kerberos Authentication</a> in the <i>Amazon RDS User Guide</i>.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Domain { get; set; }
        #endregion
        
        #region Parameter DomainIAMRoleName
        /// <summary>
        /// <para>
        /// <para>Specify the name of the IAM role to be used when making API calls to the Directory
        /// Service.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DomainIAMRoleName { get; set; }
        #endregion
        
        #region Parameter EnableCloudwatchLogsExport
        /// <summary>
        /// <para>
        /// <para>The list of logs that the new DB instance is to export to CloudWatch Logs. The values
        /// in the list depend on the DB engine being used. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs </a> in the <i>Amazon RDS User Guide</i>.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("EnableCloudwatchLogsExports")]
        public System.String[] EnableCloudwatchLogsExport { get; set; }
        #endregion
        
        #region Parameter EnableCustomerOwnedIp
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether to enable a customer-owned IP address (CoIP) for an
        /// RDS on Outposts read replica.</para><para>A <i>CoIP</i> provides local or external connectivity to resources in your Outpost
        /// subnets through your on-premises network. For some use cases, a CoIP can provide lower
        /// latency for connections to the read replica from outside of its virtual private cloud
        /// (VPC) on your local network.</para><para>For more information about RDS on Outposts, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html">Working
        /// with Amazon RDS on Amazon Web Services Outposts</a> in the <i>Amazon RDS User Guide</i>.</para><para>For more information about CoIPs, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/routing.html#ip-addressing">Customer-owned
        /// IP addresses</a> in the <i>Amazon Web Services Outposts User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EnableCustomerOwnedIp { get; set; }
        #endregion
        
        #region Parameter EnableIAMDatabaseAuthentication
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether to enable mapping of Amazon Web Services Identity and
        /// Access Management (IAM) accounts to database accounts. By default, mapping isn't enabled.</para><para>For more information about IAM database authentication, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide</i>.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EnableIAMDatabaseAuthentication { get; set; }
        #endregion
        
        #region Parameter EnablePerformanceInsight
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether to enable Performance Insights for the read replica.</para><para>For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
        /// Amazon Performance Insights</a> in the <i>Amazon RDS User Guide</i>.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("EnablePerformanceInsights")]
        public System.Boolean? EnablePerformanceInsight { get; set; }
        #endregion
        
        #region Parameter Iops
        /// <summary>
        /// <para>
        /// <para>The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for the DB instance.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Iops { get; set; }
        #endregion
        
        #region Parameter KmsKeyId
        /// <summary>
        /// <para>
        /// <para>The Amazon Web Services KMS key identifier for an encrypted read replica.</para><para>The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.</para><para>If you create an encrypted read replica in the same Amazon Web Services Region as
        /// the source DB instance, then do not specify a value for this parameter. A read replica
        /// in the same Amazon Web Services Region is always encrypted with the same KMS key as
        /// the source DB instance.</para><para>If you create an encrypted read replica in a different Amazon Web Services Region,
        /// then you must specify a KMS key identifier for the destination Amazon Web Services
        /// Region. KMS keys are specific to the Amazon Web Services Region that they are created
        /// in, and you can't use KMS keys from one Amazon Web Services Region in another Amazon
        /// Web Services Region.</para><para>You can't create an encrypted read replica from an unencrypted DB instance.</para><para>This setting doesn't apply to RDS Custom, which uses the same KMS key as the primary
        /// replica.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String KmsKeyId { get; set; }
        #endregion
        
        #region Parameter MaxAllocatedStorage
        /// <summary>
        /// <para>
        /// <para>The upper limit in gibibytes (GiB) to which Amazon RDS can automatically scale the
        /// storage of the DB instance.</para><para>For more information about this setting, including limitations that apply to it, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIOPS.StorageTypes.html#USER_PIOPS.Autoscaling">
        /// Managing capacity automatically with Amazon RDS storage autoscaling</a> in the <i>Amazon
        /// RDS User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? MaxAllocatedStorage { get; set; }
        #endregion
        
        #region Parameter MonitoringInterval
        /// <summary>
        /// <para>
        /// <para>The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the read replica. To disable collecting Enhanced Monitoring metrics, specify 0.
        /// The default is 0.</para><para>If <code>MonitoringRoleArn</code> is specified, then you must also set <code>MonitoringInterval</code>
        /// to a value other than 0.</para><para>This setting doesn't apply to RDS Custom.</para><para>Valid Values: <code>0, 1, 5, 10, 15, 30, 60</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? MonitoringInterval { get; set; }
        #endregion
        
        #region Parameter MonitoringRoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN for the IAM role that permits RDS to send enhanced monitoring metrics to Amazon
        /// CloudWatch Logs. For example, <code>arn:aws:iam:123456789012:role/emaccess</code>.
        /// For information on creating a monitoring role, go to <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
        /// create an IAM role for Amazon RDS Enhanced Monitoring</a> in the <i>Amazon RDS User
        /// Guide</i>.</para><para>If <code>MonitoringInterval</code> is set to a value other than 0, then you must supply
        /// a <code>MonitoringRoleArn</code> value.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MonitoringRoleArn { get; set; }
        #endregion
        
        #region Parameter MultiAZ
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether the read replica is in a Multi-AZ deployment.</para><para>You can create a read replica as a Multi-AZ DB instance. RDS creates a standby of
        /// your replica in another Availability Zone for failover support for the replica. Creating
        /// your read replica as a Multi-AZ DB instance is independent of whether the source database
        /// is a Multi-AZ DB instance.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? MultiAZ { get; set; }
        #endregion
        
        #region Parameter NetworkType
        /// <summary>
        /// <para>
        /// <para>The network type of the DB instance.</para><para>Valid values:</para><ul><li><para><code>IPV4</code></para></li><li><para><code>DUAL</code></para></li></ul><para>The network type is determined by the <code>DBSubnetGroup</code> specified for read
        /// replica. A <code>DBSubnetGroup</code> can support only the IPv4 protocol or the IPv4
        /// and the IPv6 protocols (<code>DUAL</code>).</para><para>For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide.</i></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NetworkType { get; set; }
        #endregion
        
        #region Parameter OptionGroupName
        /// <summary>
        /// <para>
        /// <para>The option group the DB instance is associated with. If omitted, the option group
        /// associated with the source instance is used.</para><note><para>For SQL Server, you must use the option group associated with the source instance.</para></note><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OptionGroupName { get; set; }
        #endregion
        
        #region Parameter PerformanceInsightsKMSKeyId
        /// <summary>
        /// <para>
        /// <para>The Amazon Web Services KMS key identifier for encryption of Performance Insights
        /// data.</para><para>The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.</para><para>If you do not specify a value for <code>PerformanceInsightsKMSKeyId</code>, then Amazon
        /// RDS uses your default KMS key. There is a default KMS key for your Amazon Web Services
        /// account. Your Amazon Web Services account has a different default KMS key for each
        /// Amazon Web Services Region.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PerformanceInsightsKMSKeyId { get; set; }
        #endregion
        
        #region Parameter PerformanceInsightsRetentionPeriod
        /// <summary>
        /// <para>
        /// <para>The number of days to retain Performance Insights data. The default is 7 days. The
        /// following values are valid:</para><ul><li><para>7</para></li><li><para><i>month</i> * 31, where <i>month</i> is a number of months from 1-23</para></li><li><para>731</para></li></ul><para>For example, the following values are valid:</para><ul><li><para>93 (3 months * 31)</para></li><li><para>341 (11 months * 31)</para></li><li><para>589 (19 months * 31)</para></li><li><para>731</para></li></ul><para>If you specify a retention period such as 94, which isn't a valid value, RDS issues
        /// an error.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? PerformanceInsightsRetentionPeriod { get; set; }
        #endregion
        
        #region Parameter Port
        /// <summary>
        /// <para>
        /// <para>The port number that the DB instance uses for connections.</para><para>Default: Inherits from the source DB instance</para><para>Valid Values: <code>1150-65535</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Port { get; set; }
        #endregion
        
        #region Parameter PreSignedUrl
        /// <summary>
        /// <para>
        /// <para>When you are creating a read replica from one Amazon Web Services GovCloud (US) Region
        /// to another or from one China Amazon Web Services Region to another, the URL that contains
        /// a Signature Version 4 signed request for the <code>CreateDBInstanceReadReplica</code>
        /// API operation in the source Amazon Web Services Region that contains the source DB
        /// instance.</para><para>This setting applies only to Amazon Web Services GovCloud (US) Regions and China Amazon
        /// Web Services Regions. It's ignored in other Amazon Web Services Regions.</para><para>You must specify this parameter when you create an encrypted read replica from another
        /// Amazon Web Services Region by using the Amazon RDS API. Don't specify <code>PreSignedUrl</code>
        /// when you are creating an encrypted read replica in the same Amazon Web Services Region.</para><para>The presigned URL must be a valid request for the <code>CreateDBInstanceReadReplica</code>
        /// API operation that can run in the source Amazon Web Services Region that contains
        /// the encrypted source DB instance. The presigned URL request must contain the following
        /// parameter values:</para><ul><li><para><code>DestinationRegion</code> - The Amazon Web Services Region that the encrypted
        /// read replica is created in. This Amazon Web Services Region is the same one where
        /// the <code>CreateDBInstanceReadReplica</code> operation is called that contains this
        /// presigned URL.</para><para>For example, if you create an encrypted DB instance in the us-west-1 Amazon Web Services
        /// Region, from a source DB instance in the us-east-2 Amazon Web Services Region, then
        /// you call the <code>CreateDBInstanceReadReplica</code> operation in the us-east-1 Amazon
        /// Web Services Region and provide a presigned URL that contains a call to the <code>CreateDBInstanceReadReplica</code>
        /// operation in the us-west-2 Amazon Web Services Region. For this example, the <code>DestinationRegion</code>
        /// in the presigned URL must be set to the us-east-1 Amazon Web Services Region.</para></li><li><para><code>KmsKeyId</code> - The KMS key identifier for the key to use to encrypt the
        /// read replica in the destination Amazon Web Services Region. This is the same identifier
        /// for both the <code>CreateDBInstanceReadReplica</code> operation that is called in
        /// the destination Amazon Web Services Region, and the operation contained in the presigned
        /// URL.</para></li><li><para><code>SourceDBInstanceIdentifier</code> - The DB instance identifier for the encrypted
        /// DB instance to be replicated. This identifier must be in the Amazon Resource Name
        /// (ARN) format for the source Amazon Web Services Region. For example, if you are creating
        /// an encrypted read replica from a DB instance in the us-west-2 Amazon Web Services
        /// Region, then your <code>SourceDBInstanceIdentifier</code> looks like the following
        /// example: <code>arn:aws:rds:us-west-2:123456789012:instance:mysql-instance1-20161115</code>.</para></li></ul><para>To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">Authenticating
        /// Requests: Using Query Parameters (Amazon Web Services Signature Version 4)</a> and
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 Signing Process</a>.</para><note><para>If you are using an Amazon Web Services SDK tool or the CLI, you can specify <code>SourceRegion</code>
        /// (or <code>--source-region</code> for the CLI) instead of specifying <code>PreSignedUrl</code>
        /// manually. Specifying <code>SourceRegion</code> autogenerates a presigned URL that
        /// is a valid request for the operation that can run in the source Amazon Web Services
        /// Region.</para><para><code>SourceRegion</code> isn't supported for SQL Server, because Amazon RDS for
        /// SQL Server doesn't support cross-Region read replicas.</para></note><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PreSignedUrl { get; set; }
        #endregion
        
        #region Parameter ProcessorFeature
        /// <summary>
        /// <para>
        /// <para>The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ProcessorFeatures")]
        public Amazon.RDS.Model.ProcessorFeature[] ProcessorFeature { get; set; }
        #endregion
        
        #region Parameter PubliclyAccessible
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether the DB instance is publicly accessible.</para><para>When the DB cluster is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB cluster's virtual private cloud
        /// (VPC). It resolves to the public IP address from outside of the DB cluster's VPC.
        /// Access to the DB cluster is ultimately controlled by the security group it uses. That
        /// public access isn't permitted if the security group assigned to the DB cluster doesn't
        /// permit it.</para><para>When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.</para><para>For more information, see <a>CreateDBInstance</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? PubliclyAccessible { get; set; }
        #endregion
        
        #region Parameter ReplicaMode
        /// <summary>
        /// <para>
        /// <para>The open mode of the replica database: mounted or read-only.</para><note><para>This parameter is only supported for Oracle DB instances.</para></note><para>Mounted DB replicas are included in Oracle Database Enterprise Edition. The main use
        /// case for mounted replicas is cross-Region disaster recovery. The primary database
        /// doesn't use Active Data Guard to transmit information to the mounted replica. Because
        /// it doesn't accept user connections, a mounted replica can't serve a read-only workload.</para><para>You can create a combination of mounted and read-only DB replicas for the same primary
        /// DB instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Working
        /// with Oracle Read Replicas for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.</para><para>For RDS Custom, you must specify this parameter and set it to <code>mounted</code>.
        /// The value won't be set by default. After replica creation, you can manage the open
        /// mode manually.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.RDS.ReplicaMode")]
        public Amazon.RDS.ReplicaMode ReplicaMode { get; set; }
        #endregion
        
        #region Parameter SourceDBInstanceIdentifier
        /// <summary>
        /// <para>
        /// <para>The identifier of the DB instance that will act as the source for the read replica.
        /// Each DB instance can have up to five read replicas.</para><para>Constraints:</para><ul><li><para>Must be the identifier of an existing MySQL, MariaDB, Oracle, PostgreSQL, or SQL Server
        /// DB instance.</para></li><li><para>Can specify a DB instance that is a MySQL read replica only if the source is running
        /// MySQL 5.6 or later.</para></li><li><para>For the limitations of Oracle read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Read
        /// Replica Limitations with Oracle</a> in the <i>Amazon RDS User Guide</i>.</para></li><li><para>For the limitations of SQL Server read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/SQLServer.ReadReplicas.Limitations.html">Read
        /// Replica Limitations with Microsoft SQL Server</a> in the <i>Amazon RDS User Guide</i>.</para></li><li><para>Can specify a PostgreSQL DB instance only if the source is running PostgreSQL 9.3.5
        /// or later (9.4.7 and higher for cross-Region replication).</para></li><li><para>The specified DB instance must have automatic backups enabled, that is, its backup
        /// retention period must be greater than 0.</para></li><li><para>If the source DB instance is in the same Amazon Web Services Region as the read replica,
        /// specify a valid DB instance identifier.</para></li><li><para>If the source DB instance is in a different Amazon Web Services Region from the read
        /// replica, specify a valid DB instance ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">Constructing
        /// an ARN for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>. This doesn't apply
        /// to SQL Server or RDS Custom, which don't support cross-Region replicas.</para></li></ul>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String SourceDBInstanceIdentifier { get; set; }
        #endregion
        
        #region Parameter SourceRegion
        /// <summary>
        /// <para>
        ///  The SourceRegion for generating the PreSignedUrl property.
        /// 
        ///  If SourceRegion is set and the PreSignedUrl property is not,
        ///  then PreSignedUrl will be automatically generated by the client.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SourceRegion { get; set; }
        #endregion
        
        #region Parameter StorageThroughput
        /// <summary>
        /// <para>
        /// <para>Specifies the storage throughput value for the read replica.</para><para>This setting doesn't apply to RDS Custom or Amazon Aurora.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? StorageThroughput { get; set; }
        #endregion
        
        #region Parameter StorageType
        /// <summary>
        /// <para>
        /// <para>Specifies the storage type to be associated with the read replica.</para><para>Valid values: <code>gp2 | gp3 | io1 | standard</code></para><para>If you specify <code>io1</code> or <code>gp3</code>, you must also include a value
        /// for the <code>Iops</code> parameter.</para><para>Default: <code>io1</code> if the <code>Iops</code> parameter is specified, otherwise
        /// <code>gp2</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String StorageType { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.RDS.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter UseDefaultProcessorFeature
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether the DB instance class of the DB instance uses its default
        /// processor features.</para><para>This setting doesn't apply to RDS Custom.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("UseDefaultProcessorFeatures")]
        public System.Boolean? UseDefaultProcessorFeature { get; set; }
        #endregion
        
        #region Parameter VpcSecurityGroupId
        /// <summary>
        /// <para>
        /// <para>A list of Amazon EC2 VPC security groups to associate with the read replica.</para><para>This setting doesn't apply to RDS Custom.</para><para>Default: The default EC2 VPC security group for the DB subnet group's VPC.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("VpcSecurityGroupIds")]
        public System.String[] VpcSecurityGroupId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'DBInstance'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.RDS.Model.CreateDBInstanceReadReplicaResponse).
        /// Specifying the name of a property of type Amazon.RDS.Model.CreateDBInstanceReadReplicaResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "DBInstance";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the DBInstanceIdentifier parameter.
        /// The -PassThru parameter is deprecated, use -Select '^DBInstanceIdentifier' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^DBInstanceIdentifier' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DBInstanceIdentifier), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-RDSDBInstanceReadReplica (CreateDBInstanceReadReplica)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.RDS.Model.CreateDBInstanceReadReplicaResponse, NewRDSDBInstanceReadReplicaCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.DBInstanceIdentifier;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.SourceRegion = this.SourceRegion;
            context.AllocatedStorage = this.AllocatedStorage;
            context.AutoMinorVersionUpgrade = this.AutoMinorVersionUpgrade;
            context.AvailabilityZone = this.AvailabilityZone;
            context.CopyTagsToSnapshot = this.CopyTagsToSnapshot;
            context.CustomIamInstanceProfile = this.CustomIamInstanceProfile;
            context.DBInstanceClass = this.DBInstanceClass;
            context.DBInstanceIdentifier = this.DBInstanceIdentifier;
            #if MODULAR
            if (this.DBInstanceIdentifier == null && ParameterWasBound(nameof(this.DBInstanceIdentifier)))
            {
                WriteWarning("You are passing $null as a value for parameter DBInstanceIdentifier which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.DBParameterGroupName = this.DBParameterGroupName;
            context.DBSubnetGroupName = this.DBSubnetGroupName;
            context.DeletionProtection = this.DeletionProtection;
            context.Domain = this.Domain;
            context.DomainIAMRoleName = this.DomainIAMRoleName;
            if (this.EnableCloudwatchLogsExport != null)
            {
                context.EnableCloudwatchLogsExport = new List<System.String>(this.EnableCloudwatchLogsExport);
            }
            context.EnableCustomerOwnedIp = this.EnableCustomerOwnedIp;
            context.EnableIAMDatabaseAuthentication = this.EnableIAMDatabaseAuthentication;
            context.EnablePerformanceInsight = this.EnablePerformanceInsight;
            context.Iops = this.Iops;
            context.KmsKeyId = this.KmsKeyId;
            context.MaxAllocatedStorage = this.MaxAllocatedStorage;
            context.MonitoringInterval = this.MonitoringInterval;
            context.MonitoringRoleArn = this.MonitoringRoleArn;
            context.MultiAZ = this.MultiAZ;
            context.NetworkType = this.NetworkType;
            context.OptionGroupName = this.OptionGroupName;
            context.PerformanceInsightsKMSKeyId = this.PerformanceInsightsKMSKeyId;
            context.PerformanceInsightsRetentionPeriod = this.PerformanceInsightsRetentionPeriod;
            context.Port = this.Port;
            context.PreSignedUrl = this.PreSignedUrl;
            if (this.ProcessorFeature != null)
            {
                context.ProcessorFeature = new List<Amazon.RDS.Model.ProcessorFeature>(this.ProcessorFeature);
            }
            context.PubliclyAccessible = this.PubliclyAccessible;
            context.ReplicaMode = this.ReplicaMode;
            context.SourceDBInstanceIdentifier = this.SourceDBInstanceIdentifier;
            #if MODULAR
            if (this.SourceDBInstanceIdentifier == null && ParameterWasBound(nameof(this.SourceDBInstanceIdentifier)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceDBInstanceIdentifier which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.StorageThroughput = this.StorageThroughput;
            context.StorageType = this.StorageType;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.RDS.Model.Tag>(this.Tag);
            }
            context.UseDefaultProcessorFeature = this.UseDefaultProcessorFeature;
            if (this.VpcSecurityGroupId != null)
            {
                context.VpcSecurityGroupId = new List<System.String>(this.VpcSecurityGroupId);
            }
            
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
            var request = new Amazon.RDS.Model.CreateDBInstanceReadReplicaRequest();
            
            if (cmdletContext.SourceRegion != null)
            {
                request.SourceRegion = cmdletContext.SourceRegion;
            }
            if (cmdletContext.AllocatedStorage != null)
            {
                request.AllocatedStorage = cmdletContext.AllocatedStorage.Value;
            }
            if (cmdletContext.AutoMinorVersionUpgrade != null)
            {
                request.AutoMinorVersionUpgrade = cmdletContext.AutoMinorVersionUpgrade.Value;
            }
            if (cmdletContext.AvailabilityZone != null)
            {
                request.AvailabilityZone = cmdletContext.AvailabilityZone;
            }
            if (cmdletContext.CopyTagsToSnapshot != null)
            {
                request.CopyTagsToSnapshot = cmdletContext.CopyTagsToSnapshot.Value;
            }
            if (cmdletContext.CustomIamInstanceProfile != null)
            {
                request.CustomIamInstanceProfile = cmdletContext.CustomIamInstanceProfile;
            }
            if (cmdletContext.DBInstanceClass != null)
            {
                request.DBInstanceClass = cmdletContext.DBInstanceClass;
            }
            if (cmdletContext.DBInstanceIdentifier != null)
            {
                request.DBInstanceIdentifier = cmdletContext.DBInstanceIdentifier;
            }
            if (cmdletContext.DBParameterGroupName != null)
            {
                request.DBParameterGroupName = cmdletContext.DBParameterGroupName;
            }
            if (cmdletContext.DBSubnetGroupName != null)
            {
                request.DBSubnetGroupName = cmdletContext.DBSubnetGroupName;
            }
            if (cmdletContext.DeletionProtection != null)
            {
                request.DeletionProtection = cmdletContext.DeletionProtection.Value;
            }
            if (cmdletContext.Domain != null)
            {
                request.Domain = cmdletContext.Domain;
            }
            if (cmdletContext.DomainIAMRoleName != null)
            {
                request.DomainIAMRoleName = cmdletContext.DomainIAMRoleName;
            }
            if (cmdletContext.EnableCloudwatchLogsExport != null)
            {
                request.EnableCloudwatchLogsExports = cmdletContext.EnableCloudwatchLogsExport;
            }
            if (cmdletContext.EnableCustomerOwnedIp != null)
            {
                request.EnableCustomerOwnedIp = cmdletContext.EnableCustomerOwnedIp.Value;
            }
            if (cmdletContext.EnableIAMDatabaseAuthentication != null)
            {
                request.EnableIAMDatabaseAuthentication = cmdletContext.EnableIAMDatabaseAuthentication.Value;
            }
            if (cmdletContext.EnablePerformanceInsight != null)
            {
                request.EnablePerformanceInsights = cmdletContext.EnablePerformanceInsight.Value;
            }
            if (cmdletContext.Iops != null)
            {
                request.Iops = cmdletContext.Iops.Value;
            }
            if (cmdletContext.KmsKeyId != null)
            {
                request.KmsKeyId = cmdletContext.KmsKeyId;
            }
            if (cmdletContext.MaxAllocatedStorage != null)
            {
                request.MaxAllocatedStorage = cmdletContext.MaxAllocatedStorage.Value;
            }
            if (cmdletContext.MonitoringInterval != null)
            {
                request.MonitoringInterval = cmdletContext.MonitoringInterval.Value;
            }
            if (cmdletContext.MonitoringRoleArn != null)
            {
                request.MonitoringRoleArn = cmdletContext.MonitoringRoleArn;
            }
            if (cmdletContext.MultiAZ != null)
            {
                request.MultiAZ = cmdletContext.MultiAZ.Value;
            }
            if (cmdletContext.NetworkType != null)
            {
                request.NetworkType = cmdletContext.NetworkType;
            }
            if (cmdletContext.OptionGroupName != null)
            {
                request.OptionGroupName = cmdletContext.OptionGroupName;
            }
            if (cmdletContext.PerformanceInsightsKMSKeyId != null)
            {
                request.PerformanceInsightsKMSKeyId = cmdletContext.PerformanceInsightsKMSKeyId;
            }
            if (cmdletContext.PerformanceInsightsRetentionPeriod != null)
            {
                request.PerformanceInsightsRetentionPeriod = cmdletContext.PerformanceInsightsRetentionPeriod.Value;
            }
            if (cmdletContext.Port != null)
            {
                request.Port = cmdletContext.Port.Value;
            }
            if (cmdletContext.PreSignedUrl != null)
            {
                request.PreSignedUrl = cmdletContext.PreSignedUrl;
            }
            if (cmdletContext.ProcessorFeature != null)
            {
                request.ProcessorFeatures = cmdletContext.ProcessorFeature;
            }
            if (cmdletContext.PubliclyAccessible != null)
            {
                request.PubliclyAccessible = cmdletContext.PubliclyAccessible.Value;
            }
            if (cmdletContext.ReplicaMode != null)
            {
                request.ReplicaMode = cmdletContext.ReplicaMode;
            }
            if (cmdletContext.SourceDBInstanceIdentifier != null)
            {
                request.SourceDBInstanceIdentifier = cmdletContext.SourceDBInstanceIdentifier;
            }
            if (cmdletContext.StorageThroughput != null)
            {
                request.StorageThroughput = cmdletContext.StorageThroughput.Value;
            }
            if (cmdletContext.StorageType != null)
            {
                request.StorageType = cmdletContext.StorageType;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.UseDefaultProcessorFeature != null)
            {
                request.UseDefaultProcessorFeatures = cmdletContext.UseDefaultProcessorFeature.Value;
            }
            if (cmdletContext.VpcSecurityGroupId != null)
            {
                request.VpcSecurityGroupIds = cmdletContext.VpcSecurityGroupId;
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
        
        private Amazon.RDS.Model.CreateDBInstanceReadReplicaResponse CallAWSServiceOperation(IAmazonRDS client, Amazon.RDS.Model.CreateDBInstanceReadReplicaRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Relational Database Service", "CreateDBInstanceReadReplica");
            try
            {
                #if DESKTOP
                return client.CreateDBInstanceReadReplica(request);
                #elif CORECLR
                return client.CreateDBInstanceReadReplicaAsync(request).GetAwaiter().GetResult();
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
            public System.String SourceRegion { get; set; }
            public System.Int32? AllocatedStorage { get; set; }
            public System.Boolean? AutoMinorVersionUpgrade { get; set; }
            public System.String AvailabilityZone { get; set; }
            public System.Boolean? CopyTagsToSnapshot { get; set; }
            public System.String CustomIamInstanceProfile { get; set; }
            public System.String DBInstanceClass { get; set; }
            public System.String DBInstanceIdentifier { get; set; }
            public System.String DBParameterGroupName { get; set; }
            public System.String DBSubnetGroupName { get; set; }
            public System.Boolean? DeletionProtection { get; set; }
            public System.String Domain { get; set; }
            public System.String DomainIAMRoleName { get; set; }
            public List<System.String> EnableCloudwatchLogsExport { get; set; }
            public System.Boolean? EnableCustomerOwnedIp { get; set; }
            public System.Boolean? EnableIAMDatabaseAuthentication { get; set; }
            public System.Boolean? EnablePerformanceInsight { get; set; }
            public System.Int32? Iops { get; set; }
            public System.String KmsKeyId { get; set; }
            public System.Int32? MaxAllocatedStorage { get; set; }
            public System.Int32? MonitoringInterval { get; set; }
            public System.String MonitoringRoleArn { get; set; }
            public System.Boolean? MultiAZ { get; set; }
            public System.String NetworkType { get; set; }
            public System.String OptionGroupName { get; set; }
            public System.String PerformanceInsightsKMSKeyId { get; set; }
            public System.Int32? PerformanceInsightsRetentionPeriod { get; set; }
            public System.Int32? Port { get; set; }
            public System.String PreSignedUrl { get; set; }
            public List<Amazon.RDS.Model.ProcessorFeature> ProcessorFeature { get; set; }
            public System.Boolean? PubliclyAccessible { get; set; }
            public Amazon.RDS.ReplicaMode ReplicaMode { get; set; }
            public System.String SourceDBInstanceIdentifier { get; set; }
            public System.Int32? StorageThroughput { get; set; }
            public System.String StorageType { get; set; }
            public List<Amazon.RDS.Model.Tag> Tag { get; set; }
            public System.Boolean? UseDefaultProcessorFeature { get; set; }
            public List<System.String> VpcSecurityGroupId { get; set; }
            public System.Func<Amazon.RDS.Model.CreateDBInstanceReadReplicaResponse, NewRDSDBInstanceReadReplicaCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.DBInstance;
        }
        
    }
}
