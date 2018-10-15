using Ator.Entity.Sys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ator.Entity
{
    public class AeDbContext : DbContext
    {
        public AeDbContext(DbContextOptions<AeDbContext> options) : base(options) { }

        public AeDbContext() { }


        #region 表对象
        public virtual DbSet<SysUser> SysUsers { get; set; }
        public virtual DbSet<SysRole> SysRoles { get; set; }
        public virtual DbSet<SysUserRole> SysUserRoles { get; set; }
        public virtual DbSet<SysPage> SysPages { get; set; }
        public virtual DbSet<SysRolePage> SysRolePages { get; set; }
        public virtual DbSet<SysSetting> SysSettings { get; set; }
        public virtual DbSet<SysDictionary> SysDictionarys { get; set; }
        public virtual DbSet<SysDictionaryItem> SysDictionaryItems { get; set; }
        public virtual DbSet<SysLinkType> SysLinkTypes { get; set; }
        public virtual DbSet<SysLinkItem> SysLinkItem { get; set; } 
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                var configuration = builder.Build();

                string connectionString = configuration.GetConnectionString("MyConnection");

                optionsBuilder.UseMySql(connectionString);

                //optionsBuilder.UseMySql(@"Data Source=localhost;port=3306;Initial Catalog=dbae;uid=root;password=123456;Charset=utf8");
            }
            
        }
    }
}
