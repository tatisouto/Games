using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Application.EventSourcedNormalizers
{
    public class GameHistoryData
    {
        public string Action { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string Active { get; set; }      
        public string Timestamp { get; set; }
        public string Who { get; set; }
    }
}
