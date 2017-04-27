using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Notify.V1.Service.User;

namespace Twilio.Tests.Rest.Notify.V1.Service.User 
{

    [TestFixture]
    public class SegmentMembershipTest : TwilioTest 
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Notify,
                "/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Users/NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SegmentMemberships",
                ""
            );
            request.AddPostParam("Segment", Serialize("Segment"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SegmentMembershipResource.Create("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Segment", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"identity\",\"segment\": \"segment\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://notify.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Users/identity/SegmentMemberships/segment\"}"
                                     ));

            var response = SegmentMembershipResource.Create("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Segment", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Notify,
                "/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Users/NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SegmentMemberships/PathSegment",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SegmentMembershipResource.Delete("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "PathSegment", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = SegmentMembershipResource.Delete("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "PathSegment", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Notify,
                "/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Users/NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SegmentMemberships/PathSegment",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SegmentMembershipResource.Fetch("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "PathSegment", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"identity\",\"segment\": \"segment\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://notify.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Users/identity/SegmentMemberships/segment\"}"
                                     ));

            var response = SegmentMembershipResource.Fetch("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "NUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "PathSegment", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}