﻿/*******************************************************************************
* Copyright (C) JuCheap.Com
* 
* Author: dj.wong
* Create Date: 2015/8/21
* Description: Automated building by service@jucheap.com 
* 
* Revision History:
* Date         Author               Description
*
*********************************************************************************/

using JuCheap.Core.Data.Configurations;
using JuCheap.Core.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace JuCheap.Core.Data
{
    /// <summary>
    /// JuCheapContext
    /// </summary>
    public class JuCheapContext : DbContext
    {

        /// <summary>
        /// JuCheapContext
        /// </summary>
        public JuCheapContext(DbContextOptions<JuCheapContext> options):
            base(options)
        {
            
        }

        /// <summary>
        /// OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SystemConfigConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RoleMenuConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new LoginLogConfiguration());
            modelBuilder.ApplyConfiguration(new PageViewConfiguration());
            modelBuilder.ApplyConfiguration(new AreaConfiguration());
            modelBuilder.ApplyConfiguration(new PathCodeConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        #region DbSets

        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<UserEntity> Users { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public DbSet<RoleEntity> Roles { get; set; }

        /// <summary>
        /// 菜单
        /// </summary>
        public DbSet<MenuEntity> Menus { get; set; }

        /// <summary>
        /// 用户角色关系
        /// </summary>
        public DbSet<UserRoleEntity> UserRoles { get; set; }

        /// <summary>
        /// 角色菜单关系
        /// </summary>
        public DbSet<RoleMenuEntity> RoleMenus { get; set; }

        /// <summary>
        /// 路径码
        /// </summary>
        public DbSet<PathCodeEntity> PathCodes { get; set; }

        /// <summary>
        /// 页面访问记录
        /// </summary>
        public DbSet<PageViewEntity> PageViews { get; set; }

        /// <summary>
        /// 登录日志
        /// </summary>
        public DbSet<LoginLogEntity> LoginLogs { get; set; }

        /// <summary>
        /// 系统配置
        /// </summary>
        public DbSet<SystemConfigEntity> SystemConfigs { get; set; } 

        /// <summary>
        /// 区域
        /// </summary>
        public DbSet<AreaEntity> Areas { get; set; }

        #endregion
    }
}
