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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ServiceCatalog.Model;
using Amazon.ServiceCatalog.Model.Internal.MarshallTransformations;
using Amazon.ServiceCatalog.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServiceCatalog
{
    /// <summary>
    /// Implementation for accessing ServiceCatalog
    ///
    /// AWS Service Catalog 
    /// <para>
    ///  <a href="https://aws.amazon.com/servicecatalog/">AWS Service Catalog</a> enables
    /// organizations to create and manage catalogs of IT services that are approved for use
    /// on AWS. To get the most out of this documentation, you should be familiar with the
    /// terminology discussed in <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/what-is_concepts.html">AWS
    /// Service Catalog Concepts</a>.
    /// </para>
    /// </summary>
    public partial class AmazonServiceCatalogClient : AmazonServiceClient, IAmazonServiceCatalog
    {
        private static IServiceMetadata serviceMetadata = new AmazonServiceCatalogMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with the credentials loaded from the application's
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
        public AmazonServiceCatalogClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceCatalogConfig()) { }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with the credentials loaded from the application's
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
        public AmazonServiceCatalogClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceCatalogConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonServiceCatalogClient Configuration Object</param>
        public AmazonServiceCatalogClient(AmazonServiceCatalogConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServiceCatalogClient(AWSCredentials credentials)
            : this(credentials, new AmazonServiceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceCatalogClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServiceCatalogConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Credentials and an
        /// AmazonServiceCatalogClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServiceCatalogClient Configuration Object</param>
        public AmazonServiceCatalogClient(AWSCredentials credentials, AmazonServiceCatalogConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceCatalogConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceCatalogClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServiceCatalogClient Configuration Object</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServiceCatalogConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceCatalogConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceCatalogClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServiceCatalogClient Configuration Object</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServiceCatalogConfig clientConfig)
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


        #region  AcceptPortfolioShare


        /// <summary>
        /// Accepts an offer to share the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the AcceptPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        public virtual AcceptPortfolioShareResponse AcceptPortfolioShare(AcceptPortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<AcceptPortfolioShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        public virtual Task<AcceptPortfolioShareResponse> AcceptPortfolioShareAsync(AcceptPortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptPortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociatePrincipalWithPortfolio


        /// <summary>
        /// Associates the specified principal ARN with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociatePrincipalWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        public virtual AssociatePrincipalWithPortfolioResponse AssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociatePrincipalWithPortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePrincipalWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        public virtual Task<AssociatePrincipalWithPortfolioResponse> AssociatePrincipalWithPortfolioAsync(AssociatePrincipalWithPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociatePrincipalWithPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateProductWithPortfolio


        /// <summary>
        /// Associates the specified product with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociateProductWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        public virtual AssociateProductWithPortfolioResponse AssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociateProductWithPortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateProductWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        public virtual Task<AssociateProductWithPortfolioResponse> AssociateProductWithPortfolioAsync(AssociateProductWithPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateProductWithPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateServiceActionWithProvisioningArtifact


        /// <summary>
        /// Associates a self-service action with a provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceActionWithProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the AssociateServiceActionWithProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateServiceActionWithProvisioningArtifact">REST API Reference for AssociateServiceActionWithProvisioningArtifact Operation</seealso>
        public virtual AssociateServiceActionWithProvisioningArtifactResponse AssociateServiceActionWithProvisioningArtifact(AssociateServiceActionWithProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceActionWithProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateServiceActionWithProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceActionWithProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateServiceActionWithProvisioningArtifact">REST API Reference for AssociateServiceActionWithProvisioningArtifact Operation</seealso>
        public virtual Task<AssociateServiceActionWithProvisioningArtifactResponse> AssociateServiceActionWithProvisioningArtifactAsync(AssociateServiceActionWithProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateServiceActionWithProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateTagOptionWithResource


        /// <summary>
        /// Associate the specified TagOption with the specified portfolio or product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource service method.</param>
        /// 
        /// <returns>The response from the AssociateTagOptionWithResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        public virtual AssociateTagOptionWithResourceResponse AssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateTagOptionWithResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTagOptionWithResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        public virtual Task<AssociateTagOptionWithResourceResponse> AssociateTagOptionWithResourceAsync(AssociateTagOptionWithResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateTagOptionWithResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchAssociateServiceActionWithProvisioningArtifact


        /// <summary>
        /// Associates multiple self-service actions with provisioning artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateServiceActionWithProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateServiceActionWithProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchAssociateServiceActionWithProvisioningArtifact">REST API Reference for BatchAssociateServiceActionWithProvisioningArtifact Operation</seealso>
        public virtual BatchAssociateServiceActionWithProvisioningArtifactResponse BatchAssociateServiceActionWithProvisioningArtifact(BatchAssociateServiceActionWithProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateServiceActionWithProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateServiceActionWithProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateServiceActionWithProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchAssociateServiceActionWithProvisioningArtifact">REST API Reference for BatchAssociateServiceActionWithProvisioningArtifact Operation</seealso>
        public virtual Task<BatchAssociateServiceActionWithProvisioningArtifactResponse> BatchAssociateServiceActionWithProvisioningArtifactAsync(BatchAssociateServiceActionWithProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchAssociateServiceActionWithProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisassociateServiceActionFromProvisioningArtifact


        /// <summary>
        /// Disassociates a batch of self-service actions from the specified provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateServiceActionFromProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateServiceActionFromProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchDisassociateServiceActionFromProvisioningArtifact">REST API Reference for BatchDisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        public virtual BatchDisassociateServiceActionFromProvisioningArtifactResponse BatchDisassociateServiceActionFromProvisioningArtifact(BatchDisassociateServiceActionFromProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateServiceActionFromProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateServiceActionFromProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateServiceActionFromProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchDisassociateServiceActionFromProvisioningArtifact">REST API Reference for BatchDisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        public virtual Task<BatchDisassociateServiceActionFromProvisioningArtifactResponse> BatchDisassociateServiceActionFromProvisioningArtifactAsync(BatchDisassociateServiceActionFromProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisassociateServiceActionFromProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyProduct


        /// <summary>
        /// Copies the specified source product to the specified target product or a new product.
        /// 
        ///  
        /// <para>
        /// You can copy a product to the same account or another account. You can copy a product
        /// to the same region or another region.
        /// </para>
        ///  
        /// <para>
        /// This operation is performed asynchronously. To track the progress of the operation,
        /// use <a>DescribeCopyProductStatus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyProduct service method.</param>
        /// 
        /// <returns>The response from the CopyProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        public virtual CopyProductResponse CopyProduct(CopyProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyProductResponseUnmarshaller.Instance;

            return Invoke<CopyProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        public virtual Task<CopyProductResponse> CopyProductAsync(CopyProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConstraint


        /// <summary>
        /// Creates a constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint service method.</param>
        /// 
        /// <returns>The response from the CreateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        public virtual CreateConstraintResponse CreateConstraint(CreateConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConstraintResponseUnmarshaller.Instance;

            return Invoke<CreateConstraintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        public virtual Task<CreateConstraintResponse> CreateConstraintAsync(CreateConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConstraintResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePortfolio


        /// <summary>
        /// Creates a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public virtual CreatePortfolioResponse CreatePortfolio(CreatePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public virtual Task<CreatePortfolioResponse> CreatePortfolioAsync(CreatePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePortfolioShare


        /// <summary>
        /// Shares the specified portfolio with the specified account or organization node. Shares
        /// to an organization node can only be created by the master account of an Organization.
        /// AWSOrganizationsAccess must be enabled in order to create a portfolio share to an
        /// organization node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public virtual CreatePortfolioShareResponse CreatePortfolioShare(CreatePortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public virtual Task<CreatePortfolioShareResponse> CreatePortfolioShareAsync(CreatePortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProduct


        /// <summary>
        /// Creates a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// 
        /// <returns>The response from the CreateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;

            return Invoke<CreateProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisionedProductPlan


        /// <summary>
        /// Creates a plan. A plan includes the list of resources to be created (when provisioning
        /// a new product) or modified (when updating a provisioned product) when the plan is
        /// executed.
        /// 
        ///  
        /// <para>
        /// You can create one plan per provisioned product. To create a plan for an existing
        /// provisioned product, the product status must be AVAILBLE or TAINTED.
        /// </para>
        ///  
        /// <para>
        /// To view the resource changes in the change set, use <a>DescribeProvisionedProductPlan</a>.
        /// To create or modify the provisioned product, use <a>ExecuteProvisionedProductPlan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the CreateProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        public virtual CreateProvisionedProductPlanResponse CreateProvisionedProductPlan(CreateProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<CreateProvisionedProductPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedProductPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        public virtual Task<CreateProvisionedProductPlanResponse> CreateProvisionedProductPlanAsync(CreateProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisioningArtifact


        /// <summary>
        /// Creates a provisioning artifact (also known as a version) for the specified product.
        /// 
        ///  
        /// <para>
        /// You cannot create a provisioning artifact for a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        public virtual CreateProvisioningArtifactResponse CreateProvisioningArtifact(CreateProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        public virtual Task<CreateProvisioningArtifactResponse> CreateProvisioningArtifactAsync(CreateProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceAction


        /// <summary>
        /// Creates a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceAction service method.</param>
        /// 
        /// <returns>The response from the CreateServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateServiceAction">REST API Reference for CreateServiceAction Operation</seealso>
        public virtual CreateServiceActionResponse CreateServiceAction(CreateServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceActionResponseUnmarshaller.Instance;

            return Invoke<CreateServiceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateServiceAction">REST API Reference for CreateServiceAction Operation</seealso>
        public virtual Task<CreateServiceActionResponse> CreateServiceActionAsync(CreateServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTagOption


        /// <summary>
        /// Creates a TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption service method.</param>
        /// 
        /// <returns>The response from the CreateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public virtual CreateTagOptionResponse CreateTagOption(CreateTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagOptionResponseUnmarshaller.Instance;

            return Invoke<CreateTagOptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public virtual Task<CreateTagOptionResponse> CreateTagOptionAsync(CreateTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConstraint


        /// <summary>
        /// Deletes the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint service method.</param>
        /// 
        /// <returns>The response from the DeleteConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        public virtual DeleteConstraintResponse DeleteConstraint(DeleteConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConstraintResponseUnmarshaller.Instance;

            return Invoke<DeleteConstraintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        public virtual Task<DeleteConstraintResponse> DeleteConstraintAsync(DeleteConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConstraintResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePortfolio


        /// <summary>
        /// Deletes the specified portfolio.
        /// 
        ///  
        /// <para>
        /// You cannot delete a portfolio if it was shared with you or if it has associated products,
        /// users, constraints, or shared accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        public virtual DeletePortfolioResponse DeletePortfolio(DeletePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        public virtual Task<DeletePortfolioResponse> DeletePortfolioAsync(DeletePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePortfolioShare


        /// <summary>
        /// Stops sharing the specified portfolio with the specified account or organization node.
        /// Shares to an organization node can only be deleted by the master account of an Organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public virtual DeletePortfolioShareResponse DeletePortfolioShare(DeletePortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public virtual Task<DeletePortfolioShareResponse> DeletePortfolioShareAsync(DeletePortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProduct


        /// <summary>
        /// Deletes the specified product.
        /// 
        ///  
        /// <para>
        /// You cannot delete a product if it was shared with you or is associated with a portfolio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// 
        /// <returns>The response from the DeleteProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return Invoke<DeleteProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisionedProductPlan


        /// <summary>
        /// Deletes the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        public virtual DeleteProvisionedProductPlanResponse DeleteProvisionedProductPlan(DeleteProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisionedProductPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedProductPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        public virtual Task<DeleteProvisionedProductPlanResponse> DeleteProvisionedProductPlanAsync(DeleteProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisioningArtifact


        /// <summary>
        /// Deletes the specified provisioning artifact (also known as a version) for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// You cannot delete a provisioning artifact associated with a product that was shared
        /// with you. You cannot delete the last provisioning artifact for a product, because
        /// a product must have at least one provisioning artifact.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        public virtual DeleteProvisioningArtifactResponse DeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        public virtual Task<DeleteProvisioningArtifactResponse> DeleteProvisioningArtifactAsync(DeleteProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceAction


        /// <summary>
        /// Deletes a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceAction service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteServiceAction">REST API Reference for DeleteServiceAction Operation</seealso>
        public virtual DeleteServiceActionResponse DeleteServiceAction(DeleteServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceActionResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteServiceAction">REST API Reference for DeleteServiceAction Operation</seealso>
        public virtual Task<DeleteServiceActionResponse> DeleteServiceActionAsync(DeleteServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTagOption


        /// <summary>
        /// Deletes the specified TagOption.
        /// 
        ///  
        /// <para>
        /// You cannot delete a TagOption if it is associated with a product or portfolio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagOption service method.</param>
        /// 
        /// <returns>The response from the DeleteTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        public virtual DeleteTagOptionResponse DeleteTagOption(DeleteTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteTagOptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        public virtual Task<DeleteTagOptionResponse> DeleteTagOptionAsync(DeleteTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConstraint


        /// <summary>
        /// Gets information about the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint service method.</param>
        /// 
        /// <returns>The response from the DescribeConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        public virtual DescribeConstraintResponse DescribeConstraint(DescribeConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConstraintResponseUnmarshaller.Instance;

            return Invoke<DescribeConstraintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        public virtual Task<DescribeConstraintResponse> DescribeConstraintAsync(DescribeConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConstraintResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCopyProductStatus


        /// <summary>
        /// Gets the status of the specified copy product operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyProductStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeCopyProductStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        public virtual DescribeCopyProductStatusResponse DescribeCopyProductStatus(DescribeCopyProductStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeCopyProductStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCopyProductStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyProductStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        public virtual Task<DescribeCopyProductStatusResponse> DescribeCopyProductStatusAsync(DescribeCopyProductStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCopyProductStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePortfolio


        /// <summary>
        /// Gets information about the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        public virtual DescribePortfolioResponse DescribePortfolio(DescribePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        public virtual Task<DescribePortfolioResponse> DescribePortfolioAsync(DescribePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePortfolioShareStatus


        /// <summary>
        /// Gets the status of the specified portfolio share operation. This API can only be called
        /// by the master account in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShareStatus service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolioShareStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShareStatus">REST API Reference for DescribePortfolioShareStatus Operation</seealso>
        public virtual DescribePortfolioShareStatusResponse DescribePortfolioShareStatus(DescribePortfolioShareStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioShareStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioShareStatusResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioShareStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortfolioShareStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShareStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShareStatus">REST API Reference for DescribePortfolioShareStatus Operation</seealso>
        public virtual Task<DescribePortfolioShareStatusResponse> DescribePortfolioShareStatusAsync(DescribePortfolioShareStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioShareStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioShareStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePortfolioShareStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProduct


        /// <summary>
        /// Gets information about the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        public virtual DescribeProductResponse DescribeProduct(DescribeProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        public virtual Task<DescribeProductResponse> DescribeProductAsync(DescribeProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProductAsAdmin


        /// <summary>
        /// Gets information about the specified product. This operation is run with administrator
        /// access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin service method.</param>
        /// 
        /// <returns>The response from the DescribeProductAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public virtual DescribeProductAsAdminResponse DescribeProductAsAdmin(DescribeProductAsAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;

            return Invoke<DescribeProductAsAdminResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProductAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public virtual Task<DescribeProductAsAdminResponse> DescribeProductAsAdminAsync(DescribeProductAsAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProductAsAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProductView


        /// <summary>
        /// Gets information about the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView service method.</param>
        /// 
        /// <returns>The response from the DescribeProductView service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        public virtual DescribeProductViewResponse DescribeProductView(DescribeProductViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductViewResponseUnmarshaller.Instance;

            return Invoke<DescribeProductViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProductView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        public virtual Task<DescribeProductViewResponse> DescribeProductViewAsync(DescribeProductViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductViewResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProductViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisionedProduct


        /// <summary>
        /// Gets information about the specified provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public virtual DescribeProvisionedProductResponse DescribeProvisionedProduct(DescribeProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public virtual Task<DescribeProvisionedProductResponse> DescribeProvisionedProductAsync(DescribeProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisionedProductPlan


        /// <summary>
        /// Gets information about the resource changes for the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        public virtual DescribeProvisionedProductPlanResponse DescribeProvisionedProductPlan(DescribeProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProductPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        public virtual Task<DescribeProvisionedProductPlanResponse> DescribeProvisionedProductPlanAsync(DescribeProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningArtifact


        /// <summary>
        /// Gets information about the specified provisioning artifact (also known as a version)
        /// for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public virtual DescribeProvisioningArtifactResponse DescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public virtual Task<DescribeProvisioningArtifactResponse> DescribeProvisioningArtifactAsync(DescribeProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningParameters


        /// <summary>
        /// Gets information about the configuration required to provision the specified product
        /// using the specified provisioning artifact.
        /// 
        ///  
        /// <para>
        /// If the output contains a TagOption key with an empty list of values, there is a TagOption
        /// conflict for that key. The end user cannot take action to fix the conflict, and launch
        /// is not blocked. In subsequent calls to <a>ProvisionProduct</a>, do not include conflicted
        /// TagOption keys as tags, or this causes the error "Parameter validation failed: Missing
        /// required parameter in Tags[<i>N</i>]:<i>Value</i>". Tag the provisioned product with
        /// the value <code>sc-tagoption-conflict-portfolioId-productId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        public virtual DescribeProvisioningParametersResponse DescribeProvisioningParameters(DescribeProvisioningParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        public virtual Task<DescribeProvisioningParametersResponse> DescribeProvisioningParametersAsync(DescribeProvisioningParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProvisioningParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRecord


        /// <summary>
        /// Gets information about the specified request operation.
        /// 
        ///  
        /// <para>
        /// Use this operation after calling a request operation (for example, <a>ProvisionProduct</a>,
        /// <a>TerminateProvisionedProduct</a>, or <a>UpdateProvisionedProduct</a>). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord service method.</param>
        /// 
        /// <returns>The response from the DescribeRecord service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        public virtual DescribeRecordResponse DescribeRecord(DescribeRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecordResponseUnmarshaller.Instance;

            return Invoke<DescribeRecordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        public virtual Task<DescribeRecordResponse> DescribeRecordAsync(DescribeRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecordResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceAction


        /// <summary>
        /// Describes a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAction service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceAction">REST API Reference for DescribeServiceAction Operation</seealso>
        public virtual DescribeServiceActionResponse DescribeServiceAction(DescribeServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceActionResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceAction">REST API Reference for DescribeServiceAction Operation</seealso>
        public virtual Task<DescribeServiceActionResponse> DescribeServiceActionAsync(DescribeServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTagOption


        /// <summary>
        /// Gets information about the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTagOption service method.</param>
        /// 
        /// <returns>The response from the DescribeTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        public virtual DescribeTagOptionResponse DescribeTagOption(DescribeTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;

            return Invoke<DescribeTagOptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        public virtual Task<DescribeTagOptionResponse> DescribeTagOptionAsync(DescribeTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableAWSOrganizationsAccess


        /// <summary>
        /// Disable portfolio sharing through AWS Organizations feature. This feature will not
        /// delete your current shares but it will prevent you from creating new shares throughout
        /// your organization. Current shares will not be in sync with your organization structure
        /// if it changes after calling this API. This API can only be called by the master account
        /// in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the DisableAWSOrganizationsAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisableAWSOrganizationsAccess">REST API Reference for DisableAWSOrganizationsAccess Operation</seealso>
        public virtual DisableAWSOrganizationsAccessResponse DisableAWSOrganizationsAccess(DisableAWSOrganizationsAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAWSOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<DisableAWSOrganizationsAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAWSOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSOrganizationsAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisableAWSOrganizationsAccess">REST API Reference for DisableAWSOrganizationsAccess Operation</seealso>
        public virtual Task<DisableAWSOrganizationsAccessResponse> DisableAWSOrganizationsAccessAsync(DisableAWSOrganizationsAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAWSOrganizationsAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableAWSOrganizationsAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociatePrincipalFromPortfolio


        /// <summary>
        /// Disassociates a previously associated principal ARN from a specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisassociatePrincipalFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        public virtual DisassociatePrincipalFromPortfolioResponse DisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociatePrincipalFromPortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePrincipalFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        public virtual Task<DisassociatePrincipalFromPortfolioResponse> DisassociatePrincipalFromPortfolioAsync(DisassociatePrincipalFromPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociatePrincipalFromPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateProductFromPortfolio


        /// <summary>
        /// Disassociates the specified product from the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisassociateProductFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        public virtual DisassociateProductFromPortfolioResponse DisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociateProductFromPortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateProductFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        public virtual Task<DisassociateProductFromPortfolioResponse> DisassociateProductFromPortfolioAsync(DisassociateProductFromPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateProductFromPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateServiceActionFromProvisioningArtifact


        /// <summary>
        /// Disassociates the specified self-service action association from the specified provisioning
        /// artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceActionFromProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DisassociateServiceActionFromProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateServiceActionFromProvisioningArtifact">REST API Reference for DisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        public virtual DisassociateServiceActionFromProvisioningArtifactResponse DisassociateServiceActionFromProvisioningArtifact(DisassociateServiceActionFromProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceActionFromProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateServiceActionFromProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceActionFromProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateServiceActionFromProvisioningArtifact">REST API Reference for DisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        public virtual Task<DisassociateServiceActionFromProvisioningArtifactResponse> DisassociateServiceActionFromProvisioningArtifactAsync(DisassociateServiceActionFromProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateServiceActionFromProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTagOptionFromResource


        /// <summary>
        /// Disassociates the specified TagOption from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTagOptionFromResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateTagOptionFromResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        public virtual DisassociateTagOptionFromResourceResponse DisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateTagOptionFromResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTagOptionFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTagOptionFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        public virtual Task<DisassociateTagOptionFromResourceResponse> DisassociateTagOptionFromResourceAsync(DisassociateTagOptionFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateTagOptionFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableAWSOrganizationsAccess


        /// <summary>
        /// Enable portfolio sharing feature through AWS Organizations. This API will allow Service
        /// Catalog to receive updates on your organization in order to sync your shares with
        /// the current structure. This API can only be called by the master account in the organization.
        /// 
        ///  
        /// <para>
        /// By calling this API Service Catalog will make a call to organizations:EnableAWSServiceAccess
        /// on your behalf so that your shares can be in sync with any changes in your AWS Organizations
        /// structure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the EnableAWSOrganizationsAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/EnableAWSOrganizationsAccess">REST API Reference for EnableAWSOrganizationsAccess Operation</seealso>
        public virtual EnableAWSOrganizationsAccessResponse EnableAWSOrganizationsAccess(EnableAWSOrganizationsAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAWSOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<EnableAWSOrganizationsAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAWSOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSOrganizationsAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/EnableAWSOrganizationsAccess">REST API Reference for EnableAWSOrganizationsAccess Operation</seealso>
        public virtual Task<EnableAWSOrganizationsAccessResponse> EnableAWSOrganizationsAccessAsync(EnableAWSOrganizationsAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAWSOrganizationsAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableAWSOrganizationsAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteProvisionedProductPlan


        /// <summary>
        /// Provisions or modifies a product based on the resource changes for the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the ExecuteProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        public virtual ExecuteProvisionedProductPlanResponse ExecuteProvisionedProductPlan(ExecuteProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<ExecuteProvisionedProductPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        public virtual Task<ExecuteProvisionedProductPlanResponse> ExecuteProvisionedProductPlanAsync(ExecuteProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteProvisionedProductServiceAction


        /// <summary>
        /// Executes a self-service action against a provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductServiceAction service method.</param>
        /// 
        /// <returns>The response from the ExecuteProvisionedProductServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductServiceAction">REST API Reference for ExecuteProvisionedProductServiceAction Operation</seealso>
        public virtual ExecuteProvisionedProductServiceActionResponse ExecuteProvisionedProductServiceAction(ExecuteProvisionedProductServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductServiceActionResponseUnmarshaller.Instance;

            return Invoke<ExecuteProvisionedProductServiceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteProvisionedProductServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductServiceAction">REST API Reference for ExecuteProvisionedProductServiceAction Operation</seealso>
        public virtual Task<ExecuteProvisionedProductServiceActionResponse> ExecuteProvisionedProductServiceActionAsync(ExecuteProvisionedProductServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteProvisionedProductServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAWSOrganizationsAccessStatus


        /// <summary>
        /// Get the Access Status for AWS Organization portfolio share feature. This API can only
        /// be called by the master account in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSOrganizationsAccessStatus service method.</param>
        /// 
        /// <returns>The response from the GetAWSOrganizationsAccessStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetAWSOrganizationsAccessStatus">REST API Reference for GetAWSOrganizationsAccessStatus Operation</seealso>
        public virtual GetAWSOrganizationsAccessStatusResponse GetAWSOrganizationsAccessStatus(GetAWSOrganizationsAccessStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAWSOrganizationsAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSOrganizationsAccessStatusResponseUnmarshaller.Instance;

            return Invoke<GetAWSOrganizationsAccessStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAWSOrganizationsAccessStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAWSOrganizationsAccessStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetAWSOrganizationsAccessStatus">REST API Reference for GetAWSOrganizationsAccessStatus Operation</seealso>
        public virtual Task<GetAWSOrganizationsAccessStatusResponse> GetAWSOrganizationsAccessStatusAsync(GetAWSOrganizationsAccessStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAWSOrganizationsAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSOrganizationsAccessStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAWSOrganizationsAccessStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAcceptedPortfolioShares


        /// <summary>
        /// Lists all portfolios for which sharing was accepted by this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares service method.</param>
        /// 
        /// <returns>The response from the ListAcceptedPortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public virtual ListAcceptedPortfolioSharesResponse ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;

            return Invoke<ListAcceptedPortfolioSharesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAcceptedPortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public virtual Task<ListAcceptedPortfolioSharesResponse> ListAcceptedPortfolioSharesAsync(ListAcceptedPortfolioSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAcceptedPortfolioSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConstraintsForPortfolio


        /// <summary>
        /// Lists the constraints for the specified portfolio and product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListConstraintsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        public virtual ListConstraintsForPortfolioResponse ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListConstraintsForPortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConstraintsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        public virtual Task<ListConstraintsForPortfolioResponse> ListConstraintsForPortfolioAsync(ListConstraintsForPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConstraintsForPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLaunchPaths


        /// <summary>
        /// Lists the paths to the specified product. A path is how the user has access to a specified
        /// product, and is necessary when provisioning a product. A path also determines the
        /// constraints put on the product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths service method.</param>
        /// 
        /// <returns>The response from the ListLaunchPaths service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        public virtual ListLaunchPathsResponse ListLaunchPaths(ListLaunchPathsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLaunchPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;

            return Invoke<ListLaunchPathsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLaunchPaths operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        public virtual Task<ListLaunchPathsResponse> ListLaunchPathsAsync(ListLaunchPathsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLaunchPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLaunchPathsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationPortfolioAccess


        /// <summary>
        /// Lists the organization nodes that have access to the specified portfolio. This API
        /// can only be called by the master account in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListOrganizationPortfolioAccess">REST API Reference for ListOrganizationPortfolioAccess Operation</seealso>
        public virtual ListOrganizationPortfolioAccessResponse ListOrganizationPortfolioAccess(ListOrganizationPortfolioAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationPortfolioAccessResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationPortfolioAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationPortfolioAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListOrganizationPortfolioAccess">REST API Reference for ListOrganizationPortfolioAccess Operation</seealso>
        public virtual Task<ListOrganizationPortfolioAccessResponse> ListOrganizationPortfolioAccessAsync(ListOrganizationPortfolioAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationPortfolioAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOrganizationPortfolioAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPortfolioAccess


        /// <summary>
        /// Lists the account IDs that have access to the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public virtual ListPortfolioAccessResponse ListPortfolioAccess(ListPortfolioAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;

            return Invoke<ListPortfolioAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public virtual Task<ListPortfolioAccessResponse> ListPortfolioAccessAsync(ListPortfolioAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPortfolioAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPortfolios


        /// <summary>
        /// Lists all portfolios in the catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolios service method.</param>
        /// 
        /// <returns>The response from the ListPortfolios service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        public virtual ListPortfoliosResponse ListPortfolios(ListPortfoliosRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfolios operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolios operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        public virtual Task<ListPortfoliosResponse> ListPortfoliosAsync(ListPortfoliosRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPortfoliosResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPortfoliosForProduct


        /// <summary>
        /// Lists all portfolios that the specified product is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfoliosForProduct service method.</param>
        /// 
        /// <returns>The response from the ListPortfoliosForProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        public virtual ListPortfoliosForProductResponse ListPortfoliosForProduct(ListPortfoliosForProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosForProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfoliosForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfoliosForProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        public virtual Task<ListPortfoliosForProductResponse> ListPortfoliosForProductAsync(ListPortfoliosForProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPortfoliosForProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipalsForPortfolio


        /// <summary>
        /// Lists all principal ARNs associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListPrincipalsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        public virtual ListPrincipalsForPortfolioResponse ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalsForPortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipalsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        public virtual Task<ListPrincipalsForPortfolioResponse> ListPrincipalsForPortfolioAsync(ListPrincipalsForPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPrincipalsForPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisionedProductPlans


        /// <summary>
        /// Lists the plans for the specified provisioned product or all plans to which the user
        /// has access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedProductPlans service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedProductPlans service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        public virtual ListProvisionedProductPlansResponse ListProvisionedProductPlans(ListProvisionedProductPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedProductPlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisionedProductPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedProductPlans operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        public virtual Task<ListProvisionedProductPlansResponse> ListProvisionedProductPlansAsync(ListProvisionedProductPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisionedProductPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningArtifacts


        /// <summary>
        /// Lists all provisioning artifacts (also known as versions) for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningArtifacts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        public virtual ListProvisioningArtifactsResponse ListProvisioningArtifacts(ListProvisioningArtifactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningArtifactsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        public virtual Task<ListProvisioningArtifactsResponse> ListProvisioningArtifactsAsync(ListProvisioningArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisioningArtifactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningArtifactsForServiceAction


        /// <summary>
        /// Lists all provisioning artifacts (also known as versions) for the specified self-service
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifactsForServiceAction service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningArtifactsForServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifactsForServiceAction">REST API Reference for ListProvisioningArtifactsForServiceAction Operation</seealso>
        public virtual ListProvisioningArtifactsForServiceActionResponse ListProvisioningArtifactsForServiceAction(ListProvisioningArtifactsForServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsForServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsForServiceActionResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningArtifactsForServiceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningArtifactsForServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifactsForServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifactsForServiceAction">REST API Reference for ListProvisioningArtifactsForServiceAction Operation</seealso>
        public virtual Task<ListProvisioningArtifactsForServiceActionResponse> ListProvisioningArtifactsForServiceActionAsync(ListProvisioningArtifactsForServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsForServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsForServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisioningArtifactsForServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecordHistory


        /// <summary>
        /// Lists the specified requests or all performed requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory service method.</param>
        /// 
        /// <returns>The response from the ListRecordHistory service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        public virtual ListRecordHistoryResponse ListRecordHistory(ListRecordHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecordHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;

            return Invoke<ListRecordHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecordHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        public virtual Task<ListRecordHistoryResponse> ListRecordHistoryAsync(ListRecordHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecordHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecordHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourcesForTagOption


        /// <summary>
        /// Lists the resources associated with the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        public virtual ListResourcesForTagOptionResponse ListResourcesForTagOption(ListResourcesForTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForTagOptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcesForTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        public virtual Task<ListResourcesForTagOptionResponse> ListResourcesForTagOptionAsync(ListResourcesForTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourcesForTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceActions


        /// <summary>
        /// Lists all self-service actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActions service method.</param>
        /// 
        /// <returns>The response from the ListServiceActions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActions">REST API Reference for ListServiceActions Operation</seealso>
        public virtual ListServiceActionsResponse ListServiceActions(ListServiceActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsResponseUnmarshaller.Instance;

            return Invoke<ListServiceActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActions">REST API Reference for ListServiceActions Operation</seealso>
        public virtual Task<ListServiceActionsResponse> ListServiceActionsAsync(ListServiceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceActionsForProvisioningArtifact


        /// <summary>
        /// Returns a paginated list of self-service actions associated with the specified Product
        /// ID and Provisioning Artifact ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActionsForProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the ListServiceActionsForProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActionsForProvisioningArtifact">REST API Reference for ListServiceActionsForProvisioningArtifact Operation</seealso>
        public virtual ListServiceActionsForProvisioningArtifactResponse ListServiceActionsForProvisioningArtifact(ListServiceActionsForProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsForProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsForProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<ListServiceActionsForProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceActionsForProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActionsForProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActionsForProvisioningArtifact">REST API Reference for ListServiceActionsForProvisioningArtifact Operation</seealso>
        public virtual Task<ListServiceActionsForProvisioningArtifactResponse> ListServiceActionsForProvisioningArtifactAsync(ListServiceActionsForProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsForProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsForProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceActionsForProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagOptions


        /// <summary>
        /// Lists the specified TagOptions or all TagOptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions service method.</param>
        /// 
        /// <returns>The response from the ListTagOptions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public virtual ListTagOptionsResponse ListTagOptions(ListTagOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagOptionsResponseUnmarshaller.Instance;

            return Invoke<ListTagOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public virtual Task<ListTagOptionsResponse> ListTagOptionsAsync(ListTagOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ProvisionProduct


        /// <summary>
        /// Provisions the specified product.
        /// 
        ///  
        /// <para>
        /// A provisioned product is a resourced instance of a product. For example, provisioning
        /// a product based on a CloudFormation template launches a CloudFormation stack and its
        /// underlying resources. You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        ///  
        /// <para>
        /// If the request contains a tag key with an empty list of values, there is a tag conflict
        /// for that key. Do not include conflicted keys as tags, or this causes the error "Parameter
        /// validation failed: Missing required parameter in Tags[<i>N</i>]:<i>Value</i>".
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct service method.</param>
        /// 
        /// <returns>The response from the ProvisionProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        public virtual ProvisionProductResponse ProvisionProduct(ProvisionProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionProductResponseUnmarshaller.Instance;

            return Invoke<ProvisionProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        public virtual Task<ProvisionProductResponse> ProvisionProductAsync(ProvisionProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<ProvisionProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectPortfolioShare


        /// <summary>
        /// Rejects an offer to share the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the RejectPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        public virtual RejectPortfolioShareResponse RejectPortfolioShare(RejectPortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<RejectPortfolioShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        public virtual Task<RejectPortfolioShareResponse> RejectPortfolioShareAsync(RejectPortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectPortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ScanProvisionedProducts


        /// <summary>
        /// Lists the provisioned products that are available (not terminated).
        /// 
        ///  
        /// <para>
        /// To use additional filtering, see <a>SearchProvisionedProducts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts service method.</param>
        /// 
        /// <returns>The response from the ScanProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        public virtual ScanProvisionedProductsResponse ScanProvisionedProducts(ScanProvisionedProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<ScanProvisionedProductsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ScanProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        public virtual Task<ScanProvisionedProductsResponse> ScanProvisionedProductsAsync(ScanProvisionedProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ScanProvisionedProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProducts


        /// <summary>
        /// Gets information about the products to which the caller has access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts service method.</param>
        /// 
        /// <returns>The response from the SearchProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        public virtual SearchProductsResponse SearchProducts(SearchProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProductsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        public virtual Task<SearchProductsResponse> SearchProductsAsync(SearchProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProductsAsAdmin


        /// <summary>
        /// Gets information about the products for the specified portfolio or all products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin service method.</param>
        /// 
        /// <returns>The response from the SearchProductsAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        public virtual SearchProductsAsAdminResponse SearchProductsAsAdmin(SearchProductsAsAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;

            return Invoke<SearchProductsAsAdminResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProductsAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        public virtual Task<SearchProductsAsAdminResponse> SearchProductsAsAdminAsync(SearchProductsAsAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchProductsAsAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProvisionedProducts


        /// <summary>
        /// Gets information about the provisioned products that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProvisionedProducts service method.</param>
        /// 
        /// <returns>The response from the SearchProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        public virtual SearchProvisionedProductsResponse SearchProvisionedProducts(SearchProvisionedProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProvisionedProductsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProvisionedProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        public virtual Task<SearchProvisionedProductsResponse> SearchProvisionedProductsAsync(SearchProvisionedProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchProvisionedProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateProvisionedProduct


        /// <summary>
        /// Terminates the specified provisioned product.
        /// 
        ///  
        /// <para>
        /// This operation does not delete any records associated with the provisioned product.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the TerminateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        public virtual TerminateProvisionedProductResponse TerminateProvisionedProduct(TerminateProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<TerminateProvisionedProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        public virtual Task<TerminateProvisionedProductResponse> TerminateProvisionedProductAsync(TerminateProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<TerminateProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConstraint


        /// <summary>
        /// Updates the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint service method.</param>
        /// 
        /// <returns>The response from the UpdateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        public virtual UpdateConstraintResponse UpdateConstraint(UpdateConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConstraintResponseUnmarshaller.Instance;

            return Invoke<UpdateConstraintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        public virtual Task<UpdateConstraintResponse> UpdateConstraintAsync(UpdateConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConstraintResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePortfolio


        /// <summary>
        /// Updates the specified portfolio.
        /// 
        ///  
        /// <para>
        /// You cannot update a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio service method.</param>
        /// 
        /// <returns>The response from the UpdatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        public virtual UpdatePortfolioResponse UpdatePortfolio(UpdatePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;

            return Invoke<UpdatePortfolioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        public virtual Task<UpdatePortfolioResponse> UpdatePortfolioAsync(UpdatePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProduct


        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisionedProduct


        /// <summary>
        /// Requests updates to the configuration of the specified provisioned product.
        /// 
        ///  
        /// <para>
        /// If there are tags associated with the object, they cannot be updated or added. Depending
        /// on the specific updates requested, this operation can update with no interruption,
        /// with some interruption, or replace the provisioned product entirely.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        public virtual UpdateProvisionedProductResponse UpdateProvisionedProduct(UpdateProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisionedProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        public virtual Task<UpdateProvisionedProductResponse> UpdateProvisionedProductAsync(UpdateProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisioningArtifact


        /// <summary>
        /// Updates the specified provisioning artifact (also known as a version) for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// You cannot update a provisioning artifact for a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        public virtual UpdateProvisioningArtifactResponse UpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisioningArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        public virtual Task<UpdateProvisioningArtifactResponse> UpdateProvisioningArtifactAsync(UpdateProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceAction


        /// <summary>
        /// Updates a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAction service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateServiceAction">REST API Reference for UpdateServiceAction Operation</seealso>
        public virtual UpdateServiceActionResponse UpdateServiceAction(UpdateServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceActionResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateServiceAction">REST API Reference for UpdateServiceAction Operation</seealso>
        public virtual Task<UpdateServiceActionResponse> UpdateServiceActionAsync(UpdateServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTagOption


        /// <summary>
        /// Updates the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption service method.</param>
        /// 
        /// <returns>The response from the UpdateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        public virtual UpdateTagOptionResponse UpdateTagOption(UpdateTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;

            return Invoke<UpdateTagOptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        public virtual Task<UpdateTagOptionResponse> UpdateTagOptionAsync(UpdateTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}