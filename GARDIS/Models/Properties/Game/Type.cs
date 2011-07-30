using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Norm;

namespace GARDIS.Models.Properties.Game
{
    public class Type : ICollectable
    {
		public ObjectId Id {get; internal set;}
        public string Name { get; set; }
    }
}