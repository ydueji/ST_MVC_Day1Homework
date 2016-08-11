using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ST_MVC_Day1Homework.Models.dbModel
{
    public class AccountBookDAO
    {
        private string ConnectionString { get; set; }

        public AccountBookDAO()
        {
            this.ConnectionString = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        public List<HomeworkInputDataModel> GetAccountBookAllData()
        {
            var result = new List<HomeworkInputDataModel>();

            const string sqlStatement = "Select Id,Categoryyy,Amounttt,Dateee,Remarkkk From AccountBook";

            using (var conn = new SqlConnection(this.ConnectionString))
            using (var comm = new SqlCommand(sqlStatement, conn))
            {
               // comm.Parameters.Add(new SqlParameter("authorId", id));

                comm.CommandType = CommandType.Text;
                comm.CommandTimeout = 180;

                if (conn.State != ConnectionState.Open) conn.Open();

                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new HomeworkInputDataModel
                        {
                            ID = reader["Id"].ToString(),
                            Type = reader["Categoryyy"].ToString(),
                            Date = reader["Dateee"].ToString(),
                            Price = reader["Amounttt"].ToString(),
                            Remark = reader["Remarkkk"].ToString()
                        };
                        result.Add(item);
                    }
                }

            }
            return result;
        }
    }
}