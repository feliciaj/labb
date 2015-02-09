using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HelloWorld.Models;

namespace HelloWorld
{
    public class MVContext : DbContext
    {

        public MVContext() : base("name = MVContext") { }
        public DbSet<Consultant> Consultants { get; set; }

    }
}