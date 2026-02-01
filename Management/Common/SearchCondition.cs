using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Common
{
    ///<summary>
    /// 検索条件まとめクラス
    ///</summary>
    internal class SearchCondition
    {
        // 開始日
        public DateTime StartDate { get; set; }
        // 終了日
        public DateTime EndDate { get; set; }
        // 商品分類
        public List<string> Categories { get; set; } = new();   
        // 商品番号
        public string ProductNumber { get; set; }
        // 商品名
        public string ProductName { get; set; }

        // SQL用プロパティ
        /// <summary>
        /// 開始年月（yyyyMM）
        /// </summary>
        public string StartDateString => StartDate.ToString("yyyyMM");
        /// <summary>
        /// 終了年月（yyyyMM）
        /// </summary>
        public string EndDateString => EndDate.ToString("yyyyMM");

        public bool HasCategory => Categories.Any();
        public bool HasProductNumber => !string.IsNullOrWhiteSpace(ProductNumber);
        public bool HasProductName => !string.IsNullOrWhiteSpace(ProductName);
    }
}
