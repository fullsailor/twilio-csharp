using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Notify.V1.Service.User 
{

    /// <summary>
    /// SegmentMembershipResource
    /// </summary>
    public class SegmentMembershipResource : Resource 
    {
        private static Request BuildCreateRequest(CreateSegmentMembershipOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathServiceSid + "/Users/" + options.PathIdentity + "/SegmentMemberships",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create SegmentMembership parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SegmentMembership </returns> 
        public static SegmentMembershipResource Create(CreateSegmentMembershipOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create SegmentMembership parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SegmentMembership </returns> 
        public static async System.Threading.Tasks.Task<SegmentMembershipResource> CreateAsync(CreateSegmentMembershipOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="segment"> The segment </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SegmentMembership </returns> 
        public static SegmentMembershipResource Create(string pathServiceSid, string pathIdentity, string segment, ITwilioRestClient client = null)
        {
            var options = new CreateSegmentMembershipOptions(pathServiceSid, pathIdentity, segment);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="segment"> The segment </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SegmentMembership </returns> 
        public static async System.Threading.Tasks.Task<SegmentMembershipResource> CreateAsync(string pathServiceSid, string pathIdentity, string segment, ITwilioRestClient client = null)
        {
            var options = new CreateSegmentMembershipOptions(pathServiceSid, pathIdentity, segment);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteSegmentMembershipOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathServiceSid + "/Users/" + options.PathIdentity + "/SegmentMemberships/" + options.PathSegment + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete SegmentMembership parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SegmentMembership </returns> 
        public static bool Delete(DeleteSegmentMembershipOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete SegmentMembership parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SegmentMembership </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSegmentMembershipOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="pathSegment"> The segment </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SegmentMembership </returns> 
        public static bool Delete(string pathServiceSid, string pathIdentity, string pathSegment, ITwilioRestClient client = null)
        {
            var options = new DeleteSegmentMembershipOptions(pathServiceSid, pathIdentity, pathSegment);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="pathSegment"> The segment </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SegmentMembership </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathIdentity, string pathSegment, ITwilioRestClient client = null)
        {
            var options = new DeleteSegmentMembershipOptions(pathServiceSid, pathIdentity, pathSegment);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchSegmentMembershipOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathServiceSid + "/Users/" + options.PathIdentity + "/SegmentMemberships/" + options.PathSegment + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch SegmentMembership parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SegmentMembership </returns> 
        public static SegmentMembershipResource Fetch(FetchSegmentMembershipOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch SegmentMembership parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SegmentMembership </returns> 
        public static async System.Threading.Tasks.Task<SegmentMembershipResource> FetchAsync(FetchSegmentMembershipOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="pathSegment"> The segment </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SegmentMembership </returns> 
        public static SegmentMembershipResource Fetch(string pathServiceSid, string pathIdentity, string pathSegment, ITwilioRestClient client = null)
        {
            var options = new FetchSegmentMembershipOptions(pathServiceSid, pathIdentity, pathSegment);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="pathSegment"> The segment </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SegmentMembership </returns> 
        public static async System.Threading.Tasks.Task<SegmentMembershipResource> FetchAsync(string pathServiceSid, string pathIdentity, string pathSegment, ITwilioRestClient client = null)
        {
            var options = new FetchSegmentMembershipOptions(pathServiceSid, pathIdentity, pathSegment);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SegmentMembershipResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SegmentMembershipResource object represented by the provided JSON </returns> 
        public static SegmentMembershipResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SegmentMembershipResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The identity
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// The segment
        /// </summary>
        [JsonProperty("segment")]
        public string Segment { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private SegmentMembershipResource()
        {

        }
    }

}