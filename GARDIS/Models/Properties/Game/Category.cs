using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Norm;

namespace GARDIS.Models.Properties.Game
{
    public class Category : ICollectable
    {
		public ObjectId Id {get; internal set;}
        public string Name { get; set; }
    }
}