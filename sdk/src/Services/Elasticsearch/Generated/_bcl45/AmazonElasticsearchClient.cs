/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Elasticsearch.Model;
using Amazon.Elasticsearch.Model.Internal.MarshallTransformations;
using Amazon.Elasticsearch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Elasticsearch
{
    /// <summary>
    /// Implementation for accessing Elasticsearch
    ///
    /// Amazon Elasticsearch Configuration Service 
    /// <para>
    /// Use the Amazon Elasticsearch Configuration API to create, configure, and manage Elasticsearch
    /// domains.
    /// </para>
    ///  
    /// <para>
    /// For sample code that uses the Configuration API, see the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-configuration-samples.html">Amazon
    /// Elasticsearch Service Developer Guide</a>. The guide also contains <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-request-signing.html">sample
    /// code for sending signed HTTP requests to the Elasticsearch APIs</a>.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: es.<i>region</i>.amazonaws.com.
    /// For example, es.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticsearch-service-regions"
    /// target="_blank">Regions and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial class AmazonElasticsearchClient : AmazonServiceClient, IAmazonElasticsearch
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticsearchMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonElasticsearchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticsearchConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticsearchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(AmazonElasticsearchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticsearchClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticsearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials and an
        /// AmazonElasticsearchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(AWSCredentials credentials, AmazonElasticsearchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticsearchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticsearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticsearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticsearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticsearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticsearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddTags


        /// <summary>
        /// Attaches tags to an existing Elasticsearch domain. Tags are a set of case-sensitive
        /// key value pairs. An Elasticsearch domain may have up to 10 tags. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-awsresorcetagging"
        /// target="_blank"> Tagging Amazon Elasticsearch Service Domains for more information.</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }


        /// <summary>
        /// Attaches tags to an existing Elasticsearch domain. Tags are a set of case-sensitive
        /// key value pairs. An Elasticsearch domain may have up to 10 tags. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-awsresorcetagging"
        /// target="_blank"> Tagging Amazon Elasticsearch Service Domains for more information.</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelElasticsearchServiceSoftwareUpdate


        /// <summary>
        /// Cancels a scheduled service software update for an Amazon ES domain. You can only
        /// perform this operation before the <code>AutomatedUpdateDate</code> and when the <code>UpdateStatus</code>
        /// is in the <code>PENDING_UPDATE</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the CancelElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual CancelElasticsearchServiceSoftwareUpdateResponse CancelElasticsearchServiceSoftwareUpdate(CancelElasticsearchServiceSoftwareUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<CancelElasticsearchServiceSoftwareUpdateResponse>(request, options);
        }


        /// <summary>
        /// Cancels a scheduled service software update for an Amazon ES domain. You can only
        /// perform this operation before the <code>AutomatedUpdateDate</code> and when the <code>UpdateStatus</code>
        /// is in the <code>PENDING_UPDATE</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<CancelElasticsearchServiceSoftwareUpdateResponse> CancelElasticsearchServiceSoftwareUpdateAsync(CancelElasticsearchServiceSoftwareUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelElasticsearchServiceSoftwareUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateElasticsearchDomain


        /// <summary>
        /// Creates a new Elasticsearch domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
        /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the CreateElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual CreateElasticsearchDomainResponse CreateElasticsearchDomain(CreateElasticsearchDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<CreateElasticsearchDomainResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Elasticsearch domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
        /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<CreateElasticsearchDomainResponse> CreateElasticsearchDomainAsync(CreateElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateElasticsearchDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteElasticsearchDomain


        /// <summary>
        /// Permanently deletes the specified Elasticsearch domain and all of its data. Once a
        /// domain is deleted, it cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DeleteElasticsearchDomainResponse DeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchDomainResponse>(request, options);
        }


        /// <summary>
        /// Permanently deletes the specified Elasticsearch domain and all of its data. Once a
        /// domain is deleted, it cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<DeleteElasticsearchDomainResponse> DeleteElasticsearchDomainAsync(DeleteElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteElasticsearchDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteElasticsearchServiceRole


        /// <summary>
        /// Deletes the service-linked role that Elasticsearch Service uses to manage and maintain
        /// VPC domains. Role deletion will fail if any existing VPC domains use the role. You
        /// must delete any such Elasticsearch domains before deleting the role. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html#es-enabling-slr"
        /// target="_blank">Deleting Elasticsearch Service Role</a> in <i>VPC Endpoints for Amazon
        /// Elasticsearch Service Domains</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole service method.</param>
        /// 
        /// <returns>The response from the DeleteElasticsearchServiceRole service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DeleteElasticsearchServiceRoleResponse DeleteElasticsearchServiceRole(DeleteElasticsearchServiceRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchServiceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchServiceRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchServiceRoleResponse>(request, options);
        }


        /// <summary>
        /// Deletes the service-linked role that Elasticsearch Service uses to manage and maintain
        /// VPC domains. Role deletion will fail if any existing VPC domains use the role. You
        /// must delete any such Elasticsearch domains before deleting the role. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html#es-enabling-slr"
        /// target="_blank">Deleting Elasticsearch Service Role</a> in <i>VPC Endpoints for Amazon
        /// Elasticsearch Service Domains</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteElasticsearchServiceRole service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<DeleteElasticsearchServiceRoleResponse> DeleteElasticsearchServiceRoleAsync(DeleteElasticsearchServiceRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchServiceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchServiceRoleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteElasticsearchServiceRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomain


        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domain,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeElasticsearchDomainResponse DescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainResponse>(request, options);
        }


        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domain,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<DescribeElasticsearchDomainResponse> DescribeElasticsearchDomainAsync(DescribeElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeElasticsearchDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomainConfig


        /// <summary>
        /// Provides cluster configuration information about the specified Elasticsearch domain,
        /// such as the state, creation date, update version, and update date for cluster options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeElasticsearchDomainConfigResponse DescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainConfigResponse>(request, options);
        }


        /// <summary>
        /// Provides cluster configuration information about the specified Elasticsearch domain,
        /// such as the state, creation date, update version, and update date for cluster options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<DescribeElasticsearchDomainConfigResponse> DescribeElasticsearchDomainConfigAsync(DescribeElasticsearchDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeElasticsearchDomainConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomains


        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domains,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomains service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeElasticsearchDomainsResponse DescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainsResponse>(request, options);
        }


        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domains,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomains service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<DescribeElasticsearchDomainsResponse> DescribeElasticsearchDomainsAsync(DescribeElasticsearchDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeElasticsearchDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchInstanceTypeLimits


        /// <summary>
        /// Describe Elasticsearch Limits for a given InstanceType and ElasticsearchVersion.
        /// When modifying existing Domain, specify the <code> <a>DomainName</a> </code> to know
        /// what Limits are supported for modifying.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchInstanceTypeLimits service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeElasticsearchInstanceTypeLimitsResponse DescribeElasticsearchInstanceTypeLimits(DescribeElasticsearchInstanceTypeLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchInstanceTypeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchInstanceTypeLimitsResponse>(request, options);
        }


        /// <summary>
        /// Describe Elasticsearch Limits for a given InstanceType and ElasticsearchVersion.
        /// When modifying existing Domain, specify the <code> <a>DomainName</a> </code> to know
        /// what Limits are supported for modifying.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeElasticsearchInstanceTypeLimits service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<DescribeElasticsearchInstanceTypeLimitsResponse> DescribeElasticsearchInstanceTypeLimitsAsync(DescribeElasticsearchInstanceTypeLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchInstanceTypeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeElasticsearchInstanceTypeLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedElasticsearchInstanceOfferings


        /// <summary>
        /// Lists available reserved Elasticsearch instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstanceOfferings service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeReservedElasticsearchInstanceOfferingsResponse DescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedElasticsearchInstanceOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Lists available reserved Elasticsearch instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstanceOfferings service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<DescribeReservedElasticsearchInstanceOfferingsResponse> DescribeReservedElasticsearchInstanceOfferingsAsync(DescribeReservedElasticsearchInstanceOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReservedElasticsearchInstanceOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedElasticsearchInstances


        /// <summary>
        /// Returns information about reserved Elasticsearch instances for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstances service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeReservedElasticsearchInstancesResponse DescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedElasticsearchInstancesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about reserved Elasticsearch instances for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstances service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<DescribeReservedElasticsearchInstancesResponse> DescribeReservedElasticsearchInstancesAsync(DescribeReservedElasticsearchInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReservedElasticsearchInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCompatibleElasticsearchVersions


        /// <summary>
        /// Returns a list of upgrade compatible Elastisearch versions. You can optionally pass
        /// a <code> <a>DomainName</a> </code> to get all upgrade compatible Elasticsearch versions
        /// for that specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions service method.</param>
        /// 
        /// <returns>The response from the GetCompatibleElasticsearchVersions service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual GetCompatibleElasticsearchVersionsResponse GetCompatibleElasticsearchVersions(GetCompatibleElasticsearchVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompatibleElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCompatibleElasticsearchVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of upgrade compatible Elastisearch versions. You can optionally pass
        /// a <code> <a>DomainName</a> </code> to get all upgrade compatible Elasticsearch versions
        /// for that specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCompatibleElasticsearchVersions service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<GetCompatibleElasticsearchVersionsResponse> GetCompatibleElasticsearchVersionsAsync(GetCompatibleElasticsearchVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompatibleElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCompatibleElasticsearchVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUpgradeHistory


        /// <summary>
        /// Retrieves the complete history of the last 10 upgrades that were performed on the
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeHistory service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual GetUpgradeHistoryResponse GetUpgradeHistory(GetUpgradeHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeHistoryResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the complete history of the last 10 upgrades that were performed on the
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUpgradeHistory service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<GetUpgradeHistoryResponse> GetUpgradeHistoryAsync(GetUpgradeHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUpgradeHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUpgradeStatus


        /// <summary>
        /// Retrieves the latest status of the last upgrade or upgrade eligibility check that
        /// was performed on the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeStatus service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual GetUpgradeStatusResponse GetUpgradeStatus(GetUpgradeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeStatusResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the latest status of the last upgrade or upgrade eligibility check that
        /// was performed on the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUpgradeStatus service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<GetUpgradeStatusResponse> GetUpgradeStatusAsync(GetUpgradeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUpgradeStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainNames


        /// <summary>
        /// Returns the name of all Elasticsearch domains owned by the current user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesResponse>(request, options);
        }


        /// <summary>
        /// Returns the name of all Elasticsearch domains owned by the current user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListElasticsearchInstanceTypes


        /// <summary>
        /// List all Elasticsearch instance types that are supported for given ElasticsearchVersion
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the ListElasticsearchInstanceTypes service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual ListElasticsearchInstanceTypesResponse ListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListElasticsearchInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<ListElasticsearchInstanceTypesResponse>(request, options);
        }


        /// <summary>
        /// List all Elasticsearch instance types that are supported for given ElasticsearchVersion
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListElasticsearchInstanceTypes service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<ListElasticsearchInstanceTypesResponse> ListElasticsearchInstanceTypesAsync(ListElasticsearchInstanceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListElasticsearchInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListElasticsearchInstanceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListElasticsearchVersions


        /// <summary>
        /// List all supported Elasticsearch versions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions service method.</param>
        /// 
        /// <returns>The response from the ListElasticsearchVersions service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual ListElasticsearchVersionsResponse ListElasticsearchVersions(ListElasticsearchVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;

            return Invoke<ListElasticsearchVersionsResponse>(request, options);
        }


        /// <summary>
        /// List all supported Elasticsearch versions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListElasticsearchVersions service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<ListElasticsearchVersionsResponse> ListElasticsearchVersionsAsync(ListElasticsearchVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListElasticsearchVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns all tags for the given Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Returns all tags for the given Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedElasticsearchInstanceOffering


        /// <summary>
        /// Allows you to purchase reserved Elasticsearch instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedElasticsearchInstanceOffering service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual PurchaseReservedElasticsearchInstanceOfferingResponse PurchaseReservedElasticsearchInstanceOffering(PurchaseReservedElasticsearchInstanceOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedElasticsearchInstanceOfferingResponse>(request, options);
        }


        /// <summary>
        /// Allows you to purchase reserved Elasticsearch instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedElasticsearchInstanceOffering service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<PurchaseReservedElasticsearchInstanceOfferingResponse> PurchaseReservedElasticsearchInstanceOfferingAsync(PurchaseReservedElasticsearchInstanceOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PurchaseReservedElasticsearchInstanceOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes the specified set of tags from the specified Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified set of tags from the specified Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartElasticsearchServiceSoftwareUpdate


        /// <summary>
        /// Schedules a service software update for an Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the StartElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual StartElasticsearchServiceSoftwareUpdateResponse StartElasticsearchServiceSoftwareUpdate(StartElasticsearchServiceSoftwareUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<StartElasticsearchServiceSoftwareUpdateResponse>(request, options);
        }


        /// <summary>
        /// Schedules a service software update for an Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<StartElasticsearchServiceSoftwareUpdateResponse> StartElasticsearchServiceSoftwareUpdateAsync(StartElasticsearchServiceSoftwareUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartElasticsearchServiceSoftwareUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateElasticsearchDomainConfig


        /// <summary>
        /// Modifies the cluster configuration of the specified Elasticsearch domain, setting
        /// as setting the instance type and the number of instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual UpdateElasticsearchDomainConfigResponse UpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateElasticsearchDomainConfigResponse>(request, options);
        }


        /// <summary>
        /// Modifies the cluster configuration of the specified Elasticsearch domain, setting
        /// as setting the instance type and the number of instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<UpdateElasticsearchDomainConfigResponse> UpdateElasticsearchDomainConfigAsync(UpdateElasticsearchDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateElasticsearchDomainConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpgradeElasticsearchDomain


        /// <summary>
        /// Allows you to either upgrade your domain or perform an Upgrade eligibility check to
        /// a compatible Elasticsearch version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the UpgradeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual UpgradeElasticsearchDomainResponse UpgradeElasticsearchDomain(UpgradeElasticsearchDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<UpgradeElasticsearchDomainResponse>(request, options);
        }


        /// <summary>
        /// Allows you to either upgrade your domain or perform an Upgrade eligibility check to
        /// a compatible Elasticsearch version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpgradeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual Task<UpgradeElasticsearchDomainResponse> UpgradeElasticsearchDomainAsync(UpgradeElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpgradeElasticsearchDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}