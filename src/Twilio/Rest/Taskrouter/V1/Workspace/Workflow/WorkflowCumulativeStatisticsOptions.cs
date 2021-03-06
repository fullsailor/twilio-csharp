/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Workflow 
{

    /// <summary>
    /// FetchWorkflowCumulativeStatisticsOptions
    /// </summary>
    public class FetchWorkflowCumulativeStatisticsOptions : IOptions<WorkflowCumulativeStatisticsResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The workflow_sid
        /// </summary>
        public string PathWorkflowSid { get; }
        /// <summary>
        /// The end_date
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The minutes
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// The start_date
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The task_channel
        /// </summary>
        public string TaskChannel { get; set; }
        /// <summary>
        /// The split_by_wait_time
        /// </summary>
        public string SplitByWaitTime { get; set; }

        /// <summary>
        /// Construct a new FetchWorkflowCumulativeStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathWorkflowSid"> The workflow_sid </param>
        public FetchWorkflowCumulativeStatisticsOptions(string pathWorkspaceSid, string pathWorkflowSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathWorkflowSid = pathWorkflowSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }

            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.Value.ToString()));
            }

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            if (SplitByWaitTime != null)
            {
                p.Add(new KeyValuePair<string, string>("SplitByWaitTime", SplitByWaitTime));
            }

            return p;
        }
    }

}