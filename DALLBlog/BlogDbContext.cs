using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLBlog
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("name = Blog")
        {

        }
        public DbSet<AdminInfo> AdminInfo { get; set; }
        public DbSet<EmpInfo> EmpInfo { get; set; }
        public DbSet<BlogInfo> BlogInfo { get; set; }
    }
}

