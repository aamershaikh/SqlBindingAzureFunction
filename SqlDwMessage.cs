using System;
using Newtonsoft.Json;

namespace SqlDwBinding
{
    public class SqlDwMessage
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }
    }
}