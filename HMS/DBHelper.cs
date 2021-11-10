using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    class DBHelper
    {
        // 连接字符串
        private static string connString = "Data Source=.;Initial Catalog=HMS;User ID=sa;Password=123";

        // 字段
        private SqlConnection conn;



        /// <summary>
        /// 获取 conn 对象
        /// </summary>
        public SqlConnection Conn
        {
            get
            {
                try
                {
                    conn = new SqlConnection(connString);
                }
                catch (Exception)
                {

                    throw;
                }
                return conn;

            }

        }


        /// <summary>
        /// 获取连接对象
        /// </summary>
        public void GetConn()
        {
            try
            {
                conn = new SqlConnection(connString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                conn = null;
            }
        }


        /// <summary>
        /// 关闭方法
        /// </summary>
        /// <param name="reader"></param>
        public void Close(SqlDataReader reader)
        {
            try
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                conn = null;
            }
        }


        /// <summary>
        /// 返回单个值方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public object ExecuteScalar(string sql)
        {
            try
            {
                // 获取连接对象
                GetConn();

                // 判断 SqlConnection 对象是否为空
                if (conn == null)
                {
                    return null;
                }

                // 打开数据库
                conn.Open();

                // 创建 SqlCommand 对象
                SqlCommand comm = new SqlCommand(sql, conn);

                return comm.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                // 关闭数据库连接
                Close(null);
            }
        }


        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                // 获取连接对象
                GetConn();

                // 判断 SqlConnection 对象是否为空
                if (conn == null)
                {
                    return null;
                }

                // 打开数据库
                conn.Open();

                // 创建 SqlCommand 对象
                SqlCommand comm = new SqlCommand(sql, conn);
                return comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        /// <summary>
        /// 增加、删除、修改方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                // 获取连接对象
                GetConn();

                // 判断 SqlConnection 对象是否为空
                if (conn == null)
                {
                    return -1;
                }

                // 打开数据库
                conn.Open();

                // 创建 SqlCommand 对象
                SqlCommand comm = new SqlCommand(sql, conn);
                return comm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            finally
            {
                Close(null);
            }
        }


    }
}
