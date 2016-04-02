using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoKo.Models
{
    public class Pokemon : Entity
    {
        public string Name { get; set; }

        public int Number { get; set; }

        public string Type { get; set; }

        public List<string> Moves { get; set; }
    }
}