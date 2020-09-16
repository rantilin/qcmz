using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using qcmz.Model;

namespace qcmz.DataAccess
{
    public class DataContext : FrameworkContext
    {
        /// <summary>
        /// 订单主表
        /// </summary>
        public DbSet<T_OrderBasic> Q_OrderBasic { get; set; }
        /// <summary>
        /// 订单组表
        /// </summary>
        public DbSet<T_OrderGroup> Q_OrderGroup { get; set; }
        /// <summary>
        /// 产品订单项表
        /// </summary>
        public DbSet<T_OrderItemForSpecialty> Q_OrderItemForSpecialty { get; set; }
        /// <summary>
        /// 购物车表
        /// </summary>
        public DbSet<T_ShoppingCart> Q_ShoppingCart { get; set; }
        /// <summary>
        /// 购物车项表
        /// </summary>
        public DbSet<T_ShoppingCartItem> Q_ShoppingCartItem { get; set; }
        /// <summary>
        /// 退换货记录表
        /// </summary>
        public DbSet<T_RefundableRecord> Q_RefundableRecord { get; set; }
        /// <summary>
        /// 文件表
        /// </summary>
        public DbSet<T_File> Q_File { get; set; }
        /// <summary>
        /// 产品主表
        /// </summary>
        public DbSet<T_ProductBasic> Q_ProductBasic { get; set; }
        /// <summary>
        /// 产品价格表
        /// </summary>
        public DbSet<T_PriceInventory> Q_PriceInventory { get; set; }
        /// <summary>
        /// 产品分类表
        /// </summary>
        public DbSet<T_ProductCategories> Q_ProductCategories { get; set; }
        /// <summary>
        /// 文章表
        /// </summary>
        public DbSet<T_Article> Q_Article { get; set; }

        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<T_Users> Q_Users { get; set; }

        public DataContext(CS cs)
             : base(cs)
        {
        }

        public DataContext(string cs, DBTypeEnum dbtype, string version=null)
             : base(cs, dbtype, version)
        {
        }

    }

    /// <summary>
    /// DesignTimeFactory for EF Migration, use your full connection string,
    /// EF will find this class and use the connection defined here to run Add-Migration and Update-Database
    /// </summary>
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            return new DataContext("your full connection string", DBTypeEnum.SqlServer);
        }
    }

}
