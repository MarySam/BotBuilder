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
    using Newtonsoft.Json.Linq;
    /// <summary>
    /// </summary>
    public class Mention : Entity
    {
        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        public Mention() : base("mention") { }

        public ChannelAccount Mentioned { get; set; }

        public string Text { get; set; }
    }
}
