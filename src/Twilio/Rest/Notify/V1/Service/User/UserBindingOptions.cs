using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Notify.V1.Service.User 
{

    /// <summary>
    /// FetchUserBindingOptions
    /// </summary>
    public class FetchUserBindingOptions : IOptions<UserBindingResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The identity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchUserBindingOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="pathSid"> The sid </param>
        public FetchUserBindingOptions(string pathServiceSid, string pathIdentity, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// DeleteUserBindingOptions
    /// </summary>
    public class DeleteUserBindingOptions : IOptions<UserBindingResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The identity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteUserBindingOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteUserBindingOptions(string pathServiceSid, string pathIdentity, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateUserBindingOptions
    /// </summary>
    public class CreateUserBindingOptions : IOptions<UserBindingResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The identity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// The binding_type
        /// </summary>
        public UserBindingResource.BindingTypeEnum BindingType { get; }
        /// <summary>
        /// The address
        /// </summary>
        public string Address { get; }
        /// <summary>
        /// The tag
        /// </summary>
        public List<string> Tag { get; set; }
        /// <summary>
        /// The notification_protocol_version
        /// </summary>
        public string NotificationProtocolVersion { get; set; }
        /// <summary>
        /// The credential_sid
        /// </summary>
        public string CredentialSid { get; set; }
        /// <summary>
        /// The endpoint
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Construct a new CreateUserBindingOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="bindingType"> The binding_type </param>
        /// <param name="address"> The address </param>
        public CreateUserBindingOptions(string pathServiceSid, string pathIdentity, UserBindingResource.BindingTypeEnum bindingType, string address)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            BindingType = bindingType;
            Address = address;
            Tag = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (BindingType != null)
            {
                p.Add(new KeyValuePair<string, string>("BindingType", BindingType.ToString()));
            }

            if (Address != null)
            {
                p.Add(new KeyValuePair<string, string>("Address", Address));
            }

            if (Tag != null)
            {
                p.AddRange(Tag.Select(prop => new KeyValuePair<string, string>("Tag", prop)));
            }

            if (NotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationProtocolVersion", NotificationProtocolVersion));
            }

            if (CredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("CredentialSid", CredentialSid.ToString()));
            }

            if (Endpoint != null)
            {
                p.Add(new KeyValuePair<string, string>("Endpoint", Endpoint));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadUserBindingOptions
    /// </summary>
    public class ReadUserBindingOptions : ReadOptions<UserBindingResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The identity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// The start_date
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The end_date
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The tag
        /// </summary>
        public List<string> Tag { get; set; }

        /// <summary>
        /// Construct a new ReadUserBindingOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        public ReadUserBindingOptions(string pathServiceSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            Tag = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd")));
            }

            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd")));
            }

            if (Tag != null)
            {
                p.AddRange(Tag.Select(prop => new KeyValuePair<string, string>("Tag", prop)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}