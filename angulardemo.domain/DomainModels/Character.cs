using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angulardemo.domain.DomainModels
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Skill { get; set; }
    }
}