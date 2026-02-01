using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch.Data
{
    /// <summary>
    /// 商品マスタファイル
    /// </summary>
    public class ItemsFile
    {
        /// <summary>店舗コード</summary>
        public string ShopCode;
        
        /// <summary>ファイルバージョン</summary>
        public string FileVersion;
        
        /// <summary>商品コード</summary>
        public string ItemCode;
        
        /// <summary>販売単価</summary>
        public string Price;
        
        /// <summary>仕入単価</summary>
        public string PurchasePrice;
        
        /// <summary>販売フラグ</summary>
        public string SaleFlag;

        /// <summary>
        /// ItemFiles.csのコンストラクタ
        /// </summary>        
        public ItemsFile(string _ShopCode, string _FileVersion, string _ItemCode, string _Price, string _PurchasePrice, string _SaleFlag)
        {
            try
            {
                ShopCode = _ShopCode;
                FileVersion = _FileVersion;
                ItemCode = _ItemCode;
                Price = _Price;
                PurchasePrice = _PurchasePrice;
                SaleFlag = _SaleFlag;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    
}
