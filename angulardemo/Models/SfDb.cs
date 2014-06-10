using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using angulardemo.domain.DomainModels;

namespace angulardemo.Models
{
    public class SfDb: DbContext
    {
        public DbSet<Character> Chars { get; set; }
        public DbSet<Stage> Stages{get;set;}
    }
}