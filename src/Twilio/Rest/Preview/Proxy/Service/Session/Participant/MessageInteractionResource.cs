using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Preview.Proxy.Service.Session.Participant 
{

    /// <summary>
    /// MessageInteractionResource
    /// </summary>
    public class MessageInteractionResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}

            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }

        public sealed class ResourceStatusEnum : StringEnum 
        {
            private ResourceStatusEnum(string value) : base(value) {}
            public ResourceStatusEnum() {}

            public static readonly ResourceStatusEnum Queued = new ResourceStatusEnum("queued");
            public static readonly ResourceStatusEnum Sending = new ResourceStatusEnum("sending");
            public static readonly ResourceStatusEnum Sent = new ResourceStatusEnum("sent");
            public static readonly ResourceStatusEnum Failed = new ResourceStatusEnum("failed");
            public static readonly ResourceStatusEnum Delivered = new ResourceStatusEnum("delivered");
            public static readonly ResourceStatusEnum Undelivered = new ResourceStatusEnum("undelivered");
        }

        private static Request BuildCreateRequest(CreateMessageInteractionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/Proxy/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathParticipantSid + "/MessageInteractions",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific Interaction.
        /// </summary>
        ///
        /// <param name="options"> Create MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static MessageInteractionResource Create(CreateMessageInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Interaction.
        /// </summary>
        ///
        /// <param name="options"> Create MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<MessageInteractionResource> CreateAsync(CreateMessageInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Interaction.
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="body"> The body of the message. Up to 1600 characters long. </param>
        /// <param name="mediaUrl"> The url of an image or video. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static MessageInteractionResource Create(string pathServiceSid, string pathSessionSid, string pathParticipantSid, string body = null, List<Uri> mediaUrl = null, ITwilioRestClient client = null)
        {
            var options = new CreateMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid){Body = body, MediaUrl = mediaUrl};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Interaction.
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="body"> The body of the message. Up to 1600 characters long. </param>
        /// <param name="mediaUrl"> The url of an image or video. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<MessageInteractionResource> CreateAsync(string pathServiceSid, string pathSessionSid, string pathParticipantSid, string body = null, List<Uri> mediaUrl = null, ITwilioRestClient client = null)
        {
            var options = new CreateMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid){Body = body, MediaUrl = mediaUrl};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchMessageInteractionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/Proxy/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathParticipantSid + "/MessageInteractions/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific Message Interaction.
        /// </summary>
        ///
        /// <param name="options"> Fetch MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static MessageInteractionResource Fetch(FetchMessageInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Message Interaction.
        /// </summary>
        ///
        /// <param name="options"> Fetch MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<MessageInteractionResource> FetchAsync(FetchMessageInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Message Interaction.
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Interaction. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static MessageInteractionResource Fetch(string pathServiceSid, string pathSessionSid, string pathParticipantSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Message Interaction.
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Interaction. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<MessageInteractionResource> FetchAsync(string pathServiceSid, string pathSessionSid, string pathParticipantSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadMessageInteractionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/Proxy/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathParticipantSid + "/MessageInteractions",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Message Interactions for a Participant.
        /// </summary>
        ///
        /// <param name="options"> Read MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static ResourceSet<MessageInteractionResource> Read(ReadMessageInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<MessageInteractionResource>.FromJson("interactions", response.Content);
            return new ResourceSet<MessageInteractionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Message Interactions for a Participant.
        /// </summary>
        ///
        /// <param name="options"> Read MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MessageInteractionResource>> ReadAsync(ReadMessageInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MessageInteractionResource>.FromJson("interactions", response.Content);
            return new ResourceSet<MessageInteractionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Message Interactions for a Participant.
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static ResourceSet<MessageInteractionResource> Read(string pathServiceSid, string pathSessionSid, string pathParticipantSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Message Interactions for a Participant.
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MessageInteractionResource>> ReadAsync(string pathServiceSid, string pathSessionSid, string pathParticipantSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<MessageInteractionResource> NextPage(Page<MessageInteractionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MessageInteractionResource>.FromJson("interactions", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a MessageInteractionResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MessageInteractionResource object represented by the provided JSON </returns> 
        public static MessageInteractionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MessageInteractionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Interaction.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        [JsonProperty("session_sid")]
        public string SessionSid { get; private set; }
        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// What happened in this Interaction.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; private set; }
        /// <summary>
        /// The Status of this Interaction
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageInteractionResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The participant_sid
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// The inbound_participant_sid
        /// </summary>
        [JsonProperty("inbound_participant_sid")]
        public string InboundParticipantSid { get; private set; }
        /// <summary>
        /// The SID of the inbound resource.
        /// </summary>
        [JsonProperty("inbound_resource_sid")]
        public string InboundResourceSid { get; private set; }
        /// <summary>
        /// The Inbound Resource Status of this Interaction
        /// </summary>
        [JsonProperty("inbound_resource_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageInteractionResource.ResourceStatusEnum InboundResourceStatus { get; private set; }
        /// <summary>
        /// The Twilio object type of the inbound resource.
        /// </summary>
        [JsonProperty("inbound_resource_type")]
        public string InboundResourceType { get; private set; }
        /// <summary>
        /// The URL of the inbound resource.
        /// </summary>
        [JsonProperty("inbound_resource_url")]
        public Uri InboundResourceUrl { get; private set; }
        /// <summary>
        /// The outbound_participant_sid
        /// </summary>
        [JsonProperty("outbound_participant_sid")]
        public string OutboundParticipantSid { get; private set; }
        /// <summary>
        /// The SID of the outbound resource.
        /// </summary>
        [JsonProperty("outbound_resource_sid")]
        public string OutboundResourceSid { get; private set; }
        /// <summary>
        /// The Outbound Resource Status of this Interaction
        /// </summary>
        [JsonProperty("outbound_resource_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageInteractionResource.ResourceStatusEnum OutboundResourceStatus { get; private set; }
        /// <summary>
        /// The Twilio object type of the outbound resource.
        /// </summary>
        [JsonProperty("outbound_resource_type")]
        public string OutboundResourceType { get; private set; }
        /// <summary>
        /// The URL of the outbound resource.
        /// </summary>
        [JsonProperty("outbound_resource_url")]
        public Uri OutboundResourceUrl { get; private set; }
        /// <summary>
        /// The date this Interaction was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Interaction was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this Interaction.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private MessageInteractionResource()
        {

        }
    }

}