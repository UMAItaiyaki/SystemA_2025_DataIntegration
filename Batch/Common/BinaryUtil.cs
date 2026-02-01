using Batch.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Batch.Common
{
    /// <summary>
    /// バイナリファイル操作クラス
    /// </summary>
    internal class BinaryUtil
    {

        /// <summary>
        /// 商品マスタ読み込み
        /// </summary>
        /// <param name="_FilePath">読み込み対象のファイルパス</param>
        /// <returns>商品マスタリスト</returns>
        public List<ItemsFile> ReadItemsMaster(string _FilePath)
        {

            // 戻り値用リスト
            List<ItemsFile> rtnData = new List<ItemsFile>();

            // 受信folder
            string rcvFolder = @"D:\SystemA\rcv";

            try
            {
                using (FileStream stream = new FileStream(_FilePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        // 1レコード(20バイト)
                        byte[] record = new byte[20];

                        // 20バイトずつ読み込み
                        while (reader.Read(record, 0, 20) > 0)
                        {
                            // 店舗コード(BCD:4バイト)
                            string shopCode = BcdToString(record.AsSpan(0, 4).ToArray());

                            // ファイルバージョン(BCD:2バイト)
                            string fileVersion = BcdToString(record.AsSpan(4, 2).ToArray());

                            // 商品コード(BCD:4バイト)
                            string itemCode = BcdToString(record.AsSpan(6, 4).ToArray());

                            // 販売単価(BCD:4バイト)
                            string price = BinToString(record.AsSpan(10, 4).ToArray());

                            // 仕入単価(BCD:4バイト)
                            string purchasePrice = BinToString(record.AsSpan(14, 4).ToArray());

                            // 販売フラグ(2バイト)
                            string saleFlag = BinToString(record.AsSpan(18, 2).ToArray());

                            // レコード追加
                            rtnData.Add(
                                new ItemsFile(
                                    shopCode,
                                    fileVersion,
                                    itemCode,
                                    price,
                                    purchasePrice,
                                    saleFlag
                                )
                            );
                        }
                    }
                }

                return rtnData;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        /// <summary>
        /// 売上データ作成
        /// </summary>        
        public void MakeSales(List<SalesFile> _Data, string _FilePath)
        {
            try
            {
                using (FileStream stream = new FileStream(_FilePath, FileMode.Append, FileAccess.Write))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        foreach (SalesFile data in _Data)
                        {
                            // レコードを構成するバイト配列のリスト
                            List<byte[]> record = new List<byte[]>
                            {
                                StringToBcd(data.ShopCode),                     // 店舗コード(BCD:4バイト)
                                StringToBcd(data.SummaryTarget),                // 集計年月(BCD:3バイト)
                                StringToBcd(data.ItemCode),                     // 商品コード(BCD:4バイト)
                                IntToBin(data.Price),                        // 販売単価(BCD:4バイト)
                                IntToBin(data.TotalQuantity),                // 売上総数量(BCD:4バイト)
                                IntToBin(data.TotalDiscount),                // 割引適用総額(BCD:4バイト)
                                new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00 }     // 予約領域(BCD:5バイト)
                            };

                            // 各項目を順番に書き込み
                            foreach (byte[] value in record)
                            {
                                writer.Write(value.ToArray());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// BCD形式→文字列変換
        /// </summary>
        private string BcdToString(byte[] _Value)
        {
            try
            {
                return BitConverter.ToString(_Value).Replace("-", "");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// BIN形式→文字列変換
        /// </summary>
        private string BinToString(byte[] _Value)
        {
            try
            {
                string temp = BitConverter.ToString(_Value).Replace("-", "");
                return Convert.ToInt32(temp, 16).ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 文字列→BCD形式変換
        /// </summary>
        private byte[] StringToBcd(string _Value)
        {
            List<byte> rtnData = new List<byte>();

            try
            {
                for (int j = 0; j < _Value.Length; j += 2)
                {
                    rtnData.Add(Convert.ToByte(_Value.Substring(j, 2), 16));
                }

                return rtnData.ToArray();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        /// <summary>
        /// 数値(int)型→BIN形式変換
        /// </summary>
        /// <param name="_Value"></param>
        /// <returns></returns>
        private byte[] IntToBin(int _Value)
        {
            List<byte> rtnValue = new List<byte>();

            try
            {
                byte[] temp = BitConverter.GetBytes(_Value);
                foreach (byte value in temp.Reverse())
                {
                    rtnValue.Add(value);
                }
                return rtnValue.ToArray();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
