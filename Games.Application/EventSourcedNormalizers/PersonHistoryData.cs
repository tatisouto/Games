using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Application.EventSourcedNormalizers
{
    public class PersonHistoryData
    {
        public string Action { get; set; }
        public string Name { get; set; }
        public string Phone { get;  set; }
        public string Email { get;  set; }       
        public string Timestamp { get; set; }
        public string Who { get; set; }
    }
}
