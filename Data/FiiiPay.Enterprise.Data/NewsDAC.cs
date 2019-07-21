using Dapper;
using FiiiPay.Enterprise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiiiPay.Enterprise.Data
{
    public class NewsDAC : BaseDataAccess
    {
        public List<News> GetPagedList(string title, byte? status, ref Tuple<string, string, int, int, int, int> pager)
        {
            string sql = @"SELECT * FROM  [dbo].[News]";
            string countSql = "SELECT COUNT(1) FROM [dbo].[News]";
            string conditionSql = " WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(title))
            {
                conditionSql += "AND (CNTitle LIKE @Title OR ENTitle like @Title )";

            }
            else if (status.HasValue)
            {
                conditionSql += "AND Status = @Status";
            }

            string sql_statement = sql + conditionSql + $" ORDER BY CreateTime ASC";
            sql_statement += $" OFFSET {(pager.Item3 - 1) * pager.Item4} ROW FETCH NEXT {pager.Item4} ROWS ONLY";

            using (var con = ReadConnection())
            {
                var sqlParam = new { Title = $"%{title}%", Status = status };
                var totalCount = con.ExecuteScalar<int>(countSql + conditionSql, sqlParam);
                int totalPage = totalCount == 0 ? 0 : ((int)Math.Ceiling((double)totalCount / (double)pager.Item4));
                pager = Tuple.Create(pager.Item1, pager.Item2, pager.Item3, pager.Item4, totalCount, totalPage);

                var result = con.Query<News>(sql_statement, sqlParam);
                return result.ToList();
            }

        }
    }
}
