using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSHP330Project02.Models
{
     public class User
     {
         [JsonProperty("Id")]
         public Guid Id { get; set; }

         [JsonProperty("Email")]
         public string UserEmail { get; set; }

         [JsonProperty("Password")]
         public string UserPassword { get; set; }

         [JsonProperty("DateCreated")]
         public DateTime DateCreated { get; set; }
     }
}
