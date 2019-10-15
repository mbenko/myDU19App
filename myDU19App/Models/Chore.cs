using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myDU19App.Models
{
    public class Chore
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public bool IsDone { get; set; }
        public int Effort { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompleteAt { get; set; }

        public Chore()
        {
            Effort = 1;
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.UtcNow;
            IsDone = false;
        }    }
}
