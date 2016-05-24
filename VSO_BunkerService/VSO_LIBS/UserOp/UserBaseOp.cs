using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.UserOp
{
    public class UserBaseOp
    {
        /// <summary>
        /// 获取用户的GUID
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>Guid类型的实例</returns>
        public static Guid GetUserGuidIDByName(string userName)
        {
            string sqlCmmd = string.Format("SELECT [Id] FROM AspNetUsers] WHERE [Email] = '{0}'", userName);
            string gotGuid = DbOperation.DirectDbOperation.SqlQueryOne(sqlCmmd, "DefaultConnection").ToString();
            return Guid.Parse(gotGuid);
        }
        /// <summary>
        /// 获取用户的ID
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>string类型的用户ID</returns>
        public static string GetUserIDByName(string userName)
        {
            string sqlCmmd = string.Format("SELECT [Id] FROM [AspNetUsers] WHERE [Email] = '{0}'", userName);
            string gotGuid = DbOperation.DirectDbOperation.SqlQueryOne(sqlCmmd, "DefaultConnection").ToString();
            return gotGuid;
        }
        /// <summary>
        /// 将用户类型设置为“Traveller”
        /// </summary>
        /// <param name="userName">用户名</param>
        public static void RegUserAsTraveller(string userName)
        {
            string userId = GetUserIDByName(userName);
            DbOperation.DirectDbOperation.SqlModify(string.Format("INSERT INTO [AspNetUserRoles](UserId, RoleId) VALUES('{0}', '{1}')", userId, "100104"), "DefaultConnection");
        }
        public static void CreateUserDetail(string userName, object inputDb)
        {
            Guid userGuid = GetUserGuidIDByName(userName);
            DatasModels.OpDbContext db = new DatasModels.OpDbContext();
            var userInfo = db.UserInfos.Find(userGuid);
            userInfo.BeneficiaryAccount = inputDb.GetHashCode().ToString();
            userInfo.BeneficiaryBank = inputDb.ToString();
        }
        public static void EditUserDetail()
        {

        }
        public static void CreateFisher()
        {

        }
        public static void EditFisher()
        {

        }
        public static void DeleteFisher()
        {
        }

    }
}
