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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListOfferings Request Marshaller
    /// </summary>       
    public class ListOfferingsRequestMarshaller : IMarshaller<IRequest, ListOfferingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListOfferingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListOfferingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.HttpMethod = "GET";

            string uriResourcePath = "/prod/offerings";
            
            if (publicRequest.IsSetChannelConfiguration())
                request.Parameters.Add("channelConfiguration", StringUtils.FromString(publicRequest.ChannelConfiguration));
            
            if (publicRequest.IsSetCodec())
                request.Parameters.Add("codec", StringUtils.FromString(publicRequest.Codec));
            
            if (publicRequest.IsSetMaximumBitrate())
                request.Parameters.Add("maximumBitrate", StringUtils.FromString(publicRequest.MaximumBitrate));
            
            if (publicRequest.IsSetMaximumFramerate())
                request.Parameters.Add("maximumFramerate", StringUtils.FromString(publicRequest.MaximumFramerate));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetResolution())
                request.Parameters.Add("resolution", StringUtils.FromString(publicRequest.Resolution));
            
            if (publicRequest.IsSetResourceType())
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ResourceType));
            
            if (publicRequest.IsSetSpecialFeature())
                request.Parameters.Add("specialFeature", StringUtils.FromString(publicRequest.SpecialFeature));
            
            if (publicRequest.IsSetVideoQuality())
                request.Parameters.Add("videoQuality", StringUtils.FromString(publicRequest.VideoQuality));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static ListOfferingsRequestMarshaller _instance = new ListOfferingsRequestMarshaller();        

        internal static ListOfferingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListOfferingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}