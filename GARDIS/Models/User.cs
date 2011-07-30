using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Norm;

namespace GARDIS.Models
{
    public class User : ICollectable
    {
		public ObjectId Id {get; internal set;}
        public string OpenID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}