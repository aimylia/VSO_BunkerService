using System;
using System.Data;
using System.Data.SqlClient;

namespace VSO_LIBS.DbOperation
{
    public class DirectDbOperation
    {
        /// <summary>
        /// 单个结果的查询
        /// </summary>
        /// <param name="sqlCommandString">查询时使用的sql文</param>
        /// <param name="connectionName">配置文件中的数据库连接名称</param>
        /// <returns>object类型的一个结果，需要自行转换</returns>
        public static object SqlQueryOne(string sqlCommandString, string connectionName)
        {
            string connectionStringToSqlServer = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString();
            return new AdoDbConnection(connectionStringToSqlServer).SqlCommandQueryOne(sqlCommandString);
        }
        /// <summary>
        /// 多个结果的查询
        /// </summary>
        /// <param name="sqlCommandString">查询时使用的sql文</param>
        /// <param name="connectionName">配置文件中的数据库连接名称</param>
        /// <returns>一个dataset，需要自行解析</returns>
        public static System.Data.DataSet SqlQueryMany(string sqlCommandString, string connectionName)
        {
            string connectionStringToSqlServer = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString();
            return new AdoDbConnection(connectionStringToSqlServer).SqlCommandQueryGroup(sqlCommandString);
        }
        /// <summary>
        /// 数据库修改（增删改）
        /// </summary>
        /// <param name="sqlCommandString">修改时使用的sql文</param>
        /// <param name="connectionName">配置文件中的数据库连接名称</param>
        /// <returns>一个int数，表示数据库中受影响的行数</returns>
        public static int SqlModify(string sqlCommandString, string connectionName)
        {
            string connectionStringToSqlServer = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString();
            return new AdoDbConnection(connectionStringToSqlServer).SqlCommandModify(sqlCommandString);
        }
    }
    class AdoDbConnection
    {
        //sql连接
        private readonly SqlConnection sqlServerConnection;
        //构造函数
        public AdoDbConnection(string inputConnectionString)
        {
            this.sqlServerConnection = new SqlConnection(inputConnectionString);
        }
        //获取Sql命令
        private SqlCommand GetSqlServerCommand(string sqlCommandString)
        {
            return new SqlCommand(sqlCommandString, this.sqlServerConnection);
        }
        /// <summary>
        /// 单个结果的查询
        /// </summary>
        /// <param name="sqlCommandString">查询时使用的sql文</param>
        /// <returns>object类型的一个结果，需要自行转换</returns>
        public object SqlCommandQueryOne(string sqlCommandString)
        {
            using (this.sqlServerConnection)
            {
                try
                {
                    this.sqlServerConnection.Open();
                    object r = this.GetSqlServerCommand(sqlCommandString).ExecuteScalar();
                    return r;
                }
                catch(Exception ee)
                {
                    throw new Exception(string.Format("数据库连接出现问题:{0}", ee.Message));
                }
                finally
                {
                    this.sqlServerConnection.Close();
                }
            }
        }
        /// <summary>
        /// 多个结果的查询
        /// </summary>
        /// <param name="sqlCommandString">查询时使用的sql文</param>
        /// <returns>一个dataset，需要自行解析</returns>
        public DataSet SqlCommandQueryGroup(string sqlCommandString)
        {
            DataSet results = new DataSet();
            using (this.sqlServerConnection)
            {
                try
                {
                    this.sqlServerConnection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(this.GetSqlServerCommand(sqlCommandString));
                    sda.Fill(results);
                    return results;
                }
                catch(Exception ee)
                {
                    throw new Exception(string.Format("数据库连接出现问题:{0}", ee.Message));
                }
                finally
                {
                    this.sqlServerConnection.Close();
                }
            }
        }
        /// <summary>
        /// 数据库修改（增删改）
        /// </summary>
        /// <param name="sqlCommandString">修改时使用的sql文</param>
        /// <returns>一个int数，表示数据库中受影响的行数</returns>
        public int SqlCommandModify(string sqlCommandString)
        {
            using (this.sqlServerConnection)
            {
                try
                {
                    this.sqlServerConnection.Open();
                    return this.GetSqlServerCommand(sqlCommandString).ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    throw new Exception(string.Format("数据库连接出现问题:{0}", ee.Message));
                }
                finally
                {
                    this.sqlServerConnection.Close();
                }
            }
        }
    }
}
