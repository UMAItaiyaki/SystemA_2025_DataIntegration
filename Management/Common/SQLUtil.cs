using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Common
{
    /// <summary>
    /// SQL作成ユーティリティクラス
    /// </summary>
    internal class SQLUtil
    {
        /// <summary>
        /// 検索SQL作成処理
        /// </summary>
        /// <returns></returns>
        public static string CreateSearchSql(SearchCondition condition)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(@"
            SELECT
                s.agg_date,
                SUBSTRING(s.item_code, 1, 3) AS category,
                SUBSTRING(s.item_code, 4, 5) AS item_no,
                i.item_name,
                s.quantity,
                s.discount,
                (s.price * s.quantity) - s.discount AS sales_amount
            FROM store_sales s
            INNER JOIN items i
                ON s.item_code = i.item_code
            WHERE 1 = 1
        ");

            // 期間
            sql.AppendFormat(
                " AND s.agg_date BETWEEN '{0}' AND '{1}' ",
                condition.StartDate,
                condition.EndDate);

            // 商品分類
            if (condition.HasCategory)
            {
                sql.Append(" AND SUBSTRING(s.item_code,1,3) IN (");
                sql.Append(string.Join(",", condition.Categories.Select(c => $"'{c}'")));
                sql.Append(") ");
            }

            // 商品番号
            if (condition.HasProductNumber)
            {
                sql.AppendFormat(
                    " AND SUBSTRING(s.item_code,4,5) = '{0}' ",
                    condition.ProductNumber);
            }

            // 商品名
            if (condition.HasProductName)
            {
                sql.AppendFormat(
                    " AND i.item_name LIKE '%{0}%' ",
                    condition.ProductName);
            }

            return sql.ToString();
        }
    }
}
