using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch.Data
{
    /// <summary>分類</summary>
    public enum Category
    {
        // 0: 送信, 1: 受信
        Send = 0,
        Receive = 1
    }

    /// <summary>ステータス</summary>
    public enum Status
    {
        // 0: 処理済み、1: 再送、 2: エラー
        Processed = 0,
        Retry = 1,
        Error = 2
    }

    /// <summary>
    /// 送受信テーブル
    /// </summary>
    internal class TransmissionTable
    {

        /// <summary>ID</summary>
        public string Id;

        /// <summary>処理日時</summary>
        public DateTime ProcessDatetime;

        /// <summary>分類</summary>
        public Category Category;

        /// <summary>ファイル名</summary>
        public string FileName;

        /// <summary>ステータス</summary>
        public Status Status;
       
        /// <summary>出力メッセージ</summary>
        public string OutputMessage;

        /// <summary>
        /// 送受信テーブルのコンストラクタ
        /// </summary>        
        public TransmissionTable(DateTime _ProcessDatetime, Category _Category, string _FileName, Status _Status, string _OutputMessage, string _Id = "0")
        {
            Id = _Id;
            ProcessDatetime = _ProcessDatetime;
            Category = _Category;
            FileName = _FileName;
            Status = _Status;
            OutputMessage = _OutputMessage;
        }
    }
}
