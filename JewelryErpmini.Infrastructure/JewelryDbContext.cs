using JewelryErpmini.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryErpmini.Infrastructure
{
    public class JewelryDbContext:DbContext
    {
        #region 构造函数
        public JewelryDbContext() : base("default") { }
        public JewelryDbContext(string NameOrConnectionString) : base(NameOrConnectionString) { }
        #endregion
        public IDbSet<BusinessMessage> BusinessMessages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
