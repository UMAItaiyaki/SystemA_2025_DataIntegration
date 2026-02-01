using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch.Common
{
    /// <summary>
    /// ログクラス
    /// </summary>
    internal class Log
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        /// <summary>
        /// エラーログ出力
        /// </summary>
        /// <param name="argMsg"></param>
        public static void WriteLog(string argMsg)
        {
            logger.Error(argMsg);
        }
    }
}
