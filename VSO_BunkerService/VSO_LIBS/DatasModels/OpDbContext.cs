using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace VSO_LIBS.DatasModels
{
    public class OpDbContext : DbContext
    {
        public OpDbContext()
        {
        }
        public OpDbContext(string connectionName) : base(string.Format("name = {0}", connectionName))
        {
        }
        #region User
        public DbSet<User.UserDetail> UserInfos { get; set; }
        public DbSet<User.SupplierInformation> SupplierInfos { get; set; }
        #endregion
        #region Business_Bunker
        public DbSet<Business.Bunker.BunkerInquiry> Inquiries { get; set; }
        public DbSet<Business.Bunker.BunkerOrder> Orders { get; set; }
        public DbSet<Business.Bunker.BunkerQuotation> Quotations { get; set; }
        #endregion
        #region Vessel
        public DbSet<Vessel.FisherInformation> Fishers { get; set; }
        public DbSet<Vessel.TankerInformation> Tankers { get; set; }
        public DbSet<Vessel.ReeferInformation> Reefers { get; set; }
        #endregion
        #region VanPoint
        public DbSet<VanPoint.VanPointInformation> VanPoints { get; set; }
        public DbSet<Log.VanPointInformationLog> VanPointLogs { get; set; }
        #endregion
        #region Sys
        public DbSet<Systema.BroadcastInformation> Broadcastings { get; set; }
        #endregion
        #region Log
        public DbSet<Log.Bunker.BunkerInquiryLog> BunkerInquiryLogs { get; set; }
        public DbSet<Log.Bunker.BunkerOrderLog> BunkerOrderLogs { get; set; }

        #endregion
    }
}
