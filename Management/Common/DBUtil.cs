using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Common
{
    internal class DBUtil
    {
        private string DBServer;
        private string DBUser;
        private string DBPass;
        private string DBName;
        private string DBSchema;

        // コンストラクタ
        public DBUtil()
        {
            // configファイルからDB接続情報を読み込む
            DBServer = ConfigurationManager.AppSettings["DB_SERVER"];
            DBUser = ConfigurationManager.AppSettings["DB_USER"];
            DBPass = ConfigurationManager.AppSettings["DB_PASS"];
            DBName = ConfigurationManager.AppSettings["DB_NAME"];
            DBSchema = ConfigurationManager.AppSettings["DB_SCHEMA"];
        }
    }
}
