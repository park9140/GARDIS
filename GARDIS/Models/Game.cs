using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Norm;
using System.ComponentModel.DataAnnotations;

namespace GARDIS.Models
{
    public class Game : ICollectable
    {
		public ObjectId Id {get; internal set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        
        public Properties.Game.Type Type { get; set; }
       
        public Properties.Game.Category Category { get; set; }
        
        public Properties.Game.Players Players { get; set; }
    }
}