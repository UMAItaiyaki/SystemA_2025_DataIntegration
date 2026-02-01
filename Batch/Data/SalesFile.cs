using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch.Data
{
    // 店舗売上データ（バイナリ）
    public class SalesFile
    {
        /// <summary>店舗コード</summary>
        public string ShopCode;         // 店舗を識別する8桁の番号

        /// <summary>集計年月</summary>
        public string SummaryTarget;    // 集計した年月

        /// <summary>商品コード</summary>
        public string ItemCode;         // 1～3桁:分類, 4～8桁:商品番号

        /// <summary>販売単価</summary>
        public int Price;            // 販売時の設定単価

        /// <summary>販売数量</summary>
        public int TotalQuantity;       // 集計月内の売上総数量

        /// <summary>割引適用総額</summary>
        public int TotalDiscount;       // 集計月内の割引適用総額

        /// <summary>予約領域</summary>
        public int Padding = 0;         // パディング(固定値0を埋める)
    
        /// <summary>
        /// SalesFile.csのコンストラクタ
        /// </summary>
        public SalesFile(string _ShopCode, string _SummaryTarget, string _ItemCode, int _Price, int _TotalQuantity, int _TotalDiscount)
        {
            try
            {
                ShopCode = _ShopCode;
                SummaryTarget = _SummaryTarget;
                ItemCode = _ItemCode;
                Price = _Price;
                TotalQuantity = _TotalQuantity;
                TotalDiscount = _TotalDiscount;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
