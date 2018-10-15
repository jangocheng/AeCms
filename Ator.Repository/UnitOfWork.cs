using Ator.Entity;
using Ator.Repository.Sys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ator.Repository
{
    public class UnitOfWork : IDisposable
    {
        private readonly AeDbContext _context = null;
        private SysUserRepository _SysUserRepository = null;
        private SysUserRoleRepository _SysUserRoleRepository = null;
        private SysRoleRepository _SysRoleRepository = null;

        public UnitOfWork(AeDbContext context)
        {
            _context = context;
        }

        #region 操作类
        public SysUserRepository SysUserRepository
        {
            get
            {
                return _SysUserRepository ?? (_SysUserRepository = new SysUserRepository(_context));
            }
        }
        public SysUserRoleRepository SysUserRoleRepository
        {
            get
            {
                return _SysUserRoleRepository ?? (_SysUserRoleRepository = new SysUserRoleRepository(_context));
            }
        }
        public SysRoleRepository SysRoleRepository
        {
            get
            {
                return _SysRoleRepository ?? (_SysRoleRepository = new SysRoleRepository(_context));
            }
        } 
        #endregion
        /// <summary>
        /// 保存
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
