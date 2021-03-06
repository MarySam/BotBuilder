// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Metdata for an attachment
    /// </summary>
    public partial class AttachmentInfo
    {
        /// <summary>
        /// Initializes a new instance of the AttachmentInfo class.
        /// </summary>
        public AttachmentInfo() { }

        /// <summary>
        /// Initializes a new instance of the AttachmentInfo class.
        /// </summary>
        public AttachmentInfo(string name = default(string), string type = default(string), IList<AttachmentView> views = default(IList<AttachmentView>))
        {
            Name = name;
            Type = type;
            Views = views;
        }

        /// <summary>
        /// Name of the attachment
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// ContentType of the attachment
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// attachment views
        /// </summary>
        [JsonProperty(PropertyName = "views")]
        public IList<AttachmentView> Views { get; set; }

    }
}
